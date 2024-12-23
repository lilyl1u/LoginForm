namespace LoginForm
{
    partial class frmLogin
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
        private void InitializeComponent()
        {
            pswTxtBox = new TextBox();
            userNameTxtBox = new TextBox();
            loginBtn = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // pswTxtBox
            // 
            pswTxtBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pswTxtBox.Location = new Point(317, 198);
            pswTxtBox.Multiline = true;
            pswTxtBox.Name = "pswTxtBox";
            pswTxtBox.PasswordChar = '*';
            pswTxtBox.Size = new Size(294, 55);
            pswTxtBox.TabIndex = 0;
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTxtBox.Location = new Point(317, 120);
            userNameTxtBox.Multiline = true;
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Size = new Size(294, 55);
            userNameTxtBox.TabIndex = 6;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.LightSteelBlue;
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.ControlDarkDark;
            loginBtn.Location = new Point(474, 286);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(137, 40);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(317, 286);
            button2.Name = "button2";
            button2.Size = new Size(151, 40);
            button2.TabIndex = 3;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(82, 119);
            label1.Name = "label1";
            label1.Size = new Size(210, 56);
            label1.TabIndex = 4;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(82, 201);
            label2.Name = "label2";
            label2.Size = new Size(210, 52);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(loginBtn);
            Controls.Add(userNameTxtBox);
            Controls.Add(pswTxtBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pswTxtBox;
        private TextBox userNameTxtBox;
        private Button loginBtn;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}
