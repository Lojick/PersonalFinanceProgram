namespace PersonalFinanceGUI
{
    partial class RegisterForm
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtRegisterUsername = new TextBox();
            txtRegisterPassword = new TextBox();
            txtInitialAmount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegister = new Button();
            btnClose = new Button();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 58);
            label1.Name = "label1";
            label1.Size = new Size(227, 29);
            label1.TabIndex = 0;
            label1.Text = "Registrera användare";
            label1.Click += label1_Click;
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(316, 153);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(169, 23);
            txtRegisterUsername.TabIndex = 1;
            txtRegisterUsername.TextChanged += txtRegisterUsername_TextChanged;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(316, 233);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(169, 23);
            txtRegisterPassword.TabIndex = 2;
            txtRegisterPassword.UseSystemPasswordChar = true;
            txtRegisterPassword.TextChanged += txtRegisterPassword_TextChanged;
            // 
            // txtInitialAmount
            // 
            txtInitialAmount.Location = new Point(316, 309);
            txtInitialAmount.Name = "txtInitialAmount";
            txtInitialAmount.Size = new Size(169, 23);
            txtInitialAmount.TabIndex = 3;
            txtInitialAmount.TextChanged += txtInitialAmount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 153);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 4;
            label2.Text = "Användarnamn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 233);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 5;
            label3.Text = "Lösenord:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 309);
            label4.Name = "label4";
            label4.Size = new Size(212, 23);
            label4.TabIndex = 6;
            label4.Text = "Startbelopp på ditt konto:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ScrollBar;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(336, 362);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(133, 64);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Slutför";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ScrollBar;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(588, 362);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(133, 64);
            btnClose.TabIndex = 8;
            btnClose.Text = "Stäng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(328, 262);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(119, 23);
            chkShowPassword.TabIndex = 9;
            chkShowPassword.Text = "Visa lösenord";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(chkShowPassword);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtInitialAmount);
            Controls.Add(txtRegisterPassword);
            Controls.Add(txtRegisterUsername);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "Registrera Användare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRegisterUsername;
        private TextBox txtRegisterPassword;
        private TextBox txtInitialAmount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegister;
        private Button btnClose;
        private CheckBox chkShowPassword;
    }
}
