using System;
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
            if (e.KeyChar == '\n')
            {
                ReadChat.Text = "GGs";
            }
        }

    }
}
