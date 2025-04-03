namespace TelefonskiImenik
{
    partial class AddContactForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblStevilka;
        private System.Windows.Forms.TextBox txtStevilka;
        private System.Windows.Forms.Button btnShrani;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblStevilka = new System.Windows.Forms.Label();
            this.txtStevilka = new System.Windows.Forms.TextBox();
            this.btnShrani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(20, 20);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(85, 15);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Ime in Priimek:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(120, 17);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 23);
            this.txtNaziv.TabIndex = 1;
            // 
            // lblStevilka
            // 
            this.lblStevilka.AutoSize = true;
            this.lblStevilka.Location = new System.Drawing.Point(20, 60);
            this.lblStevilka.Name = "lblStevilka";
            this.lblStevilka.Size = new System.Drawing.Size(70, 15);
            this.lblStevilka.TabIndex = 2;
            this.lblStevilka.Text = "Tel. Številka:";
            // 
            // txtStevilka
            // 
            this.txtStevilka.Location = new System.Drawing.Point(120, 57);
            this.txtStevilka.Name = "txtStevilka";
            this.txtStevilka.Size = new System.Drawing.Size(250, 23);
            this.txtStevilka.TabIndex = 3;
            // 
            // btnShrani
            // 
            this.btnShrani.Location = new System.Drawing.Point(170, 100);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(75, 30);
            this.btnShrani.TabIndex = 4;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = true;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // AddContactForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblStevilka);
            this.Controls.Add(this.txtStevilka);
            this.Controls.Add(this.btnShrani);
            this.Name = "AddContactForm";
            this.Text = "Dodaj Kontakt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
