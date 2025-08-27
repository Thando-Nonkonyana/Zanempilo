namespace ZnForms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            btnSignUpPage = new Button();
            txtSignUpEmail = new TextBox();
            txtSignUpPassword = new TextBox();
            txtSignUpConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblConfirmPassword = new Label();
            checkBoxPrivacy = new CheckBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignUpPage
            // 
            btnSignUpPage.BackColor = Color.DarkOliveGreen;
            btnSignUpPage.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUpPage.Location = new Point(75, 518);
            btnSignUpPage.Name = "btnSignUpPage";
            btnSignUpPage.Size = new Size(278, 57);
            btnSignUpPage.TabIndex = 0;
            btnSignUpPage.Text = "SIGN UP";
            btnSignUpPage.UseVisualStyleBackColor = false;
            // 
            // txtSignUpEmail
            // 
            txtSignUpEmail.Location = new Point(60, 319);
            txtSignUpEmail.Name = "txtSignUpEmail";
            txtSignUpEmail.Size = new Size(308, 27);
            txtSignUpEmail.TabIndex = 1;
            // 
            // txtSignUpPassword
            // 
            txtSignUpPassword.Location = new Point(92, 362);
            txtSignUpPassword.Name = "txtSignUpPassword";
            txtSignUpPassword.Size = new Size(276, 27);
            txtSignUpPassword.TabIndex = 2;
            // 
            // txtSignUpConfirmPassword
            // 
            txtSignUpConfirmPassword.Location = new Point(142, 406);
            txtSignUpConfirmPassword.Name = "txtSignUpConfirmPassword";
            txtSignUpConfirmPassword.Size = new Size(226, 27);
            txtSignUpConfirmPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 322);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 365);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(3, 405);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(133, 24);
            lblConfirmPassword.TabIndex = 6;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // checkBoxPrivacy
            // 
            checkBoxPrivacy.AutoSize = true;
            checkBoxPrivacy.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxPrivacy.Location = new Point(12, 454);
            checkBoxPrivacy.Name = "checkBoxPrivacy";
            checkBoxPrivacy.Size = new Size(209, 28);
            checkBoxPrivacy.TabIndex = 7;
            checkBoxPrivacy.Text = "I agree with privacy policy";
            checkBoxPrivacy.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(3, 170);
            label3.Name = "label3";
            label3.Size = new Size(236, 72);
            label3.TabIndex = 9;
            label3.Text = "Sign Up";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(21, 242);
            label4.Name = "label4";
            label4.Size = new Size(139, 18);
            label4.TabIndex = 10;
            label4.Text = "Hello! let's join with us";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(432, 745);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(checkBoxPrivacy);
            Controls.Add(lblConfirmPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSignUpConfirmPassword);
            Controls.Add(txtSignUpPassword);
            Controls.Add(txtSignUpEmail);
            Controls.Add(btnSignUpPage);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUpPage;
        private TextBox txtSignUpEmail;
        private TextBox txtSignUpPassword;
        private TextBox txtSignUpConfirmPassword;
        private Label label1;
        private Label label2;
        private Label lblConfirmPassword;
        private CheckBox checkBoxPrivacy;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}