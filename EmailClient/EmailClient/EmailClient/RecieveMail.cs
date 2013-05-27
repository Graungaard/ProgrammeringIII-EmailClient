using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Common.Logging;
using OpenPop.Mime;
using OpenPop.Mime.Decode;
using OpenPop.Mime.Header;
using OpenPop.Pop3;
using System.IO;

namespace EmailClient
{
    public partial class RecieveMail : Form
    {
        List<OpenPop.Mime.Message> list;

        private BackgroundWorker worker;
        
        public RecieveMail()
        {
            InitializeComponent();

            list = new List<OpenPop.Mime.Message>();

            worker = new BackgroundWorker();

            worker.WorkerReportsProgress = true;

            worker.DoWork += new DoWorkEventHandler(fetchAllMessages);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        private void ReciveMailbtn_Click(object sender, EventArgs e)
        {   
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private static void fetchAllMessages(object sender, DoWorkEventArgs e)
        {
            int percentComplete;

            // The client disconnects from the server when being disposed
            using (Pop3Client client = new Pop3Client())
            {
                // Connect to the server
                //client.Connect("pop.gmail.com", 995, true);
                client.Connect("mail.server", 110, false);

                // Authenticate ourselves towards the server
                client.Authenticate("user_id", "password");

                // Get the number of messages in the inbox
                int messageCount = client.GetMessageCount();

                // We want to download all messages
                List<OpenPop.Mime.Message> allMessages = new List<OpenPop.Mime.Message>(messageCount);

                // Messages are numbered in the interval: [1, messageCount]
                // Ergo: message numbers are 1-based.
                // Most servers give the latest message the highest number

                for (int i = messageCount; i > 0; i--)
                {
                    allMessages.Add(client.GetMessage(i));
                    percentComplete = Convert.ToInt16((Convert.ToDouble(allMessages.Count) / Convert.ToDouble(messageCount)) * 100);
                    (sender as BackgroundWorker).ReportProgress(percentComplete);
                }

                // Now return the fetched messages
                e.Result = allMessages;
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgBarMailFetched.Value = e.ProgressPercentage;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            list = (List<OpenPop.Mime.Message>)e.Result;

            msgcounglb.Text = Convert.ToString(list.Count);

            Subjectlsbx.Items.Clear();
            foreach (OpenPop.Mime.Message message in list)
            {
                Subjectlsbx.Items.Add(message.Headers.Subject.ToString());
            }
        }

        private void Subjectlsbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = Subjectlsbx.SelectedIndex;
            if (!list[selectedItem].MessagePart.IsMultiPart)
            {
                msgBodytbx.Text = list[selectedItem].MessagePart.GetBodyAsText();
            }
            else
            {
                OpenPop.Mime.MessagePart plainText = list[selectedItem].FindFirstPlainTextVersion();
                msgBodytbx.Text = plainText.GetBodyAsText();
            }
        }
    }
}
