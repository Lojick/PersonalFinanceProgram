namespace PersonalFinanceGUI
{
    partial class ShowBalanceForm
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
            lblBalance = new Label();
            btnReturnFromBalance = new Button();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(91, 101);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(253, 26);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Din nuvarande kontobalans:";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            lblBalance.Click += lblBalance_Click;
            // 
            // btnReturnFromBalance
            // 
            btnReturnFromBalance.BackColor = Color.LightGray;
            btnReturnFromBalance.FlatStyle = FlatStyle.Flat;
            btnReturnFromBalance.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnFromBalance.Location = new Point(122, 267);
            btnReturnFromBalance.Name = "btnReturnFromBalance";
            btnReturnFromBalance.Size = new Size(174, 79);
            btnReturnFromBalance.TabIndex = 1;
            btnReturnFromBalance.Text = "Tillbaka\r\n";
            btnReturnFromBalance.UseVisualStyleBackColor = false;
            btnReturnFromBalance.Click += btnReturnFromBalance_Click;
            // 
            // ShowBalanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(439, 435);
            Controls.Add(btnReturnFromBalance);
            Controls.Add(lblBalance);
            Name = "ShowBalanceForm";
            Text = "Form2";
            Load += ShowBalanceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private Button btnReturnFromBalance;
    }
}