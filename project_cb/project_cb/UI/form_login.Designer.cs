namespace project_cb
{
    partial class form_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.btn_batal = new MetroFramework.Controls.MetroButton();
            this.linkGantiPassword = new MetroFramework.Controls.MetroLink();
            this.txt_username = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(130, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 99;
            this.metroLabel1.Text = "Username";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_password
            // 
            this.txt_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_password.Location = new System.Drawing.Point(211, 94);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(156, 23);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(130, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 99;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(211, 174);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.Location = new System.Drawing.Point(292, 174);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(75, 23);
            this.btn_batal.TabIndex = 3;
            this.btn_batal.Text = "Batal";
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // linkGantiPassword
            // 
            this.linkGantiPassword.Location = new System.Drawing.Point(244, 123);
            this.linkGantiPassword.Name = "linkGantiPassword";
            this.linkGantiPassword.Size = new System.Drawing.Size(123, 23);
            this.linkGantiPassword.TabIndex = 100;
            this.linkGantiPassword.Text = "Ganti Password";
            this.linkGantiPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkGantiPassword.Click += new System.EventHandler(this.linkGantiPassword_Click);
            // 
            // txt_username
            // 
            this.txt_username.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_username.Location = new System.Drawing.Point(211, 61);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(156, 23);
            this.txt_username.TabIndex = 101;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.linkGantiPassword);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form_login";
            this.Padding = new System.Windows.Forms.Padding(30, 80, 30, 30);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroButton btn_batal;
        private MetroFramework.Controls.MetroLink linkGantiPassword;
        private MetroFramework.Controls.MetroTextBox txt_username;
    }
}

