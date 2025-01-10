namespace PersonalFinanceGUI
{
    partial class UpdateUserForm
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
            label1 = new Label();
            updateName = new TextBox();
            updatePassword = new TextBox();
            updateBtn = new Button();
            returnBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 66);
            label1.Name = "label1";
            label1.Size = new Size(312, 29);
            label1.TabIndex = 0;
            label1.Text = "Uppdatera användaruppgifter";
            // 
            // updateName
            // 
            updateName.Location = new Point(259, 157);
            updateName.Name = "updateName";
            updateName.Size = new Size(199, 23);
            updateName.TabIndex = 1;
            updateName.TextChanged += updateName_TextChanged;
            // 
            // updatePassword
            // 
            updatePassword.Location = new Point(259, 243);
            updatePassword.Name = "updatePassword";
            updatePassword.Size = new Size(199, 23);
            updatePassword.TabIndex = 2;
            updatePassword.UseSystemPasswordChar = true;
            updatePassword.TextChanged += updatePassword_TextChanged;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = SystemColors.ScrollBar;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            updateBtn.Location = new Point(314, 317);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(106, 61);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Uppdatera";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = SystemColors.ScrollBar;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            returnBtn.Location = new Point(471, 317);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(106, 61);
            returnBtn.TabIndex = 4;
            returnBtn.Text = "Tillbaka";
            returnBtn.UseVisualStyleBackColor = false;
            returnBtn.Click += returnBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label2.Location = new Point(70, 157);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 5;
            label2.Text = "Nytt användarnamn:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label3.Location = new Point(117, 240);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 6;
            label3.Text = "Nytt lösenord:";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(308, 272);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(119, 23);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Visa lösenord";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(734, 403);
            Controls.Add(chkShowPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(returnBtn);
            Controls.Add(updateBtn);
            Controls.Add(updatePassword);
            Controls.Add(updateName);
            Controls.Add(label1);
            Name = "UpdateUserForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox updateName;
        private TextBox updatePassword;
        private Button updateBtn;
        private Button returnBtn;
        private Label label2;
        private Label label3;
        private CheckBox chkShowPassword;
    }
}