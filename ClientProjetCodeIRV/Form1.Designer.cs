namespace ClientProjetCodeIRV
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadChat = new System.Windows.Forms.TextBox();
            this.WriteChat = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ReadChat
            // 
            this.ReadChat.Location = new System.Drawing.Point(218, 12);
            this.ReadChat.Multiline = true;
            this.ReadChat.Name = "ReadChat";
            this.ReadChat.ReadOnly = true;
            this.ReadChat.Size = new System.Drawing.Size(705, 483);
            this.ReadChat.TabIndex = 0;
            // 
            // WriteChat
            // 
            this.WriteChat.Location = new System.Drawing.Point(218, 513);
            this.WriteChat.Multiline = true;
            this.WriteChat.Name = "WriteChat";
            this.WriteChat.Size = new System.Drawing.Size(705, 44);
            this.WriteChat.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 342);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 360);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 199);
            this.listBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(935, 569);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.WriteChat);
            this.Controls.Add(this.ReadChat);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReadChat;
        private System.Windows.Forms.TextBox WriteChat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

