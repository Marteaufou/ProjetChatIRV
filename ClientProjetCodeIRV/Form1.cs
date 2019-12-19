using System;
using System.Threading;
using System.Windows.Forms;

namespace ClientProjetCodeIRV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WriteChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            String sendText = "";
            if ((Keys)e.KeyChar == Keys.Enter && !sendText.Equals(""))
            {
                sendText = WriteChat.Text + "\n<EOF>";
                WriteChat.Text = "";
                //ReadChat.Text += sendText;
                AsynchronousClient.sendData(sendText);
                
                
            }
        }

        private void WriteChat_KeyDown(object sender, KeyEventArgs e)
        {
            /*String sendText = "";
            if (e.KeyCode == Keys.Enter)
            {
                sendText = WriteChat.Text + "\n<EOF>";
                WriteChat.Text = "";
                //ReadChat.Text += sendText;
                AsynchronousClient.sendData(sendText);


            }*/
        }

        public void stateMessage(String message)
        {
            if (message.EndsWith("<EOF>"))
            {
                message = message.Substring(0, message.LastIndexOf("<EOF>"));
            }
            ReadChat.Text += "Server: " + message + "\r\n";
        }

        public void receivedMessage(String message)
        {
            if (message.EndsWith("<EOF>"))
            {
                message = message.Substring(0, message.LastIndexOf("<EOF>"));
            }
            ReadChat.Text += message + "\r\n";
        }

        private void WriteChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AsynchronousClient.shutDownClient();
            Program.endProgram();
        }
    }
}
