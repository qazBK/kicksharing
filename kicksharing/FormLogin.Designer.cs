using System.Windows.Forms;

namespace kicksharing
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbLogo = new PictureBox();
            panelMain = new Panel();
            tbPassword = new TextBox();
            textBoxLogin = new TextBox();
            btnGuest = new Button();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.BackgroundImage = (Image)resources.GetObject("pbLogo.BackgroundImage");
            pbLogo.Location = new Point(142, 42);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(tbPassword);
            panelMain.Controls.Add(textBoxLogin);
            panelMain.Controls.Add(btnGuest);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Location = new Point(37, 148);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(315, 201);
            panelMain.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(236, 234, 205);
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Location = new Point(32, 94);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(250, 22);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(236, 234, 205);
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Location = new Point(32, 35);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 22);
            textBoxLogin.TabIndex = 4;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(249, 172, 102);
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.ForeColor = Color.Black;
            btnGuest.Location = new Point(82, 160);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 25);
            btnGuest.TabIndex = 3;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BtnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(249, 172, 102);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(82, 129);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 25);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 67);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 11);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(panelMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel panelMain;
        private TextBox tbPassword;
        private TextBox textBoxLogin;
        private Button btnGuest;
        private Button btnLogin;
        private Label label2;
        private Label label1;
    }
}
