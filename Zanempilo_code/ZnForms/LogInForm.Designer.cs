namespace ZnForms
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            txtEmail = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            checkBoxPrivacy = new CheckBox();
            btnSignUpPage = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 363);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(308, 27);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 362);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 5;
            label1.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(114, 404);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(276, 27);
            txtPassword.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 404);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // checkBoxPrivacy
            // 
            checkBoxPrivacy.AutoSize = true;
            checkBoxPrivacy.Font = new Font("Bahnschrift Condensed", 10.2F);
            checkBoxPrivacy.Location = new Point(12, 449);
            checkBoxPrivacy.Name = "checkBoxPrivacy";
            checkBoxPrivacy.Size = new Size(116, 25);
            checkBoxPrivacy.TabIndex = 8;
            checkBoxPrivacy.Text = "Remember me";
            checkBoxPrivacy.UseVisualStyleBackColor = true;
            // 
            // btnSignUpPage
            // 
            btnSignUpPage.BackColor = Color.DarkOliveGreen;
            btnSignUpPage.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnSignUpPage.Location = new Point(69, 505);
            btnSignUpPage.Name = "btnSignUpPage";
            btnSignUpPage.Size = new Size(278, 57);
            btnSignUpPage.TabIndex = 9;
            btnSignUpPage.Text = "SIGN UP";
            btnSignUpPage.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(311, 53);
            label3.TabIndex = 11;
            label3.Text = "Welcome Back";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(25, 259);
            label4.Name = "label4";
            label4.Size = new Size(164, 18);
            label4.TabIndex = 12;
            label4.Text = "Hey! Good to see you again";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(283, 450);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 13;
            label5.Text = "Forgot Password?";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(432, 745);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignUpPage);
            Controls.Add(checkBoxPrivacy);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Name = "LogInForm";
            Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private CheckBox checkBoxPrivacy;
        private Button btnSignUpPage;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}