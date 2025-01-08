namespace PersonalFinanceGUI
{
    partial class RemoveTransactionForm
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
            lblRemoveTransaction = new Label();
            btnRemoveTransaction = new Button();
            btnReturnFromRemoveTransactionForm = new Button();
            listboxTransactions = new ListBox();
            SuspendLayout();
            // 
            // lblRemoveTransaction
            // 
            lblRemoveTransaction.AutoSize = true;
            lblRemoveTransaction.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemoveTransaction.Location = new Point(231, 29);
            lblRemoveTransaction.Name = "lblRemoveTransaction";
            lblRemoveTransaction.Size = new Size(412, 26);
            lblRemoveTransaction.TabIndex = 0;
            lblRemoveTransaction.Text = "Välj vilken transaktion du vill ta bort från listan";
            // 
            // btnRemoveTransaction
            // 
            btnRemoveTransaction.BackColor = Color.IndianRed;
            btnRemoveTransaction.FlatStyle = FlatStyle.Flat;
            btnRemoveTransaction.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveTransaction.Location = new Point(381, 418);
            btnRemoveTransaction.Name = "btnRemoveTransaction";
            btnRemoveTransaction.Size = new Size(112, 62);
            btnRemoveTransaction.TabIndex = 1;
            btnRemoveTransaction.Text = "Ta bort";
            btnRemoveTransaction.UseVisualStyleBackColor = false;
            btnRemoveTransaction.Click += btnRemoveTransaction_Click;
            // 
            // btnReturnFromRemoveTransactionForm
            // 
            btnReturnFromRemoveTransactionForm.BackColor = SystemColors.ScrollBar;
            btnReturnFromRemoveTransactionForm.FlatStyle = FlatStyle.Flat;
            btnReturnFromRemoveTransactionForm.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnFromRemoveTransactionForm.Location = new Point(693, 418);
            btnReturnFromRemoveTransactionForm.Name = "btnReturnFromRemoveTransactionForm";
            btnReturnFromRemoveTransactionForm.Size = new Size(112, 62);
            btnReturnFromRemoveTransactionForm.TabIndex = 2;
            btnReturnFromRemoveTransactionForm.Text = "Tillbaka";
            btnReturnFromRemoveTransactionForm.UseVisualStyleBackColor = false;
            btnReturnFromRemoveTransactionForm.Click += btnReturnFromRemoveTransactionForm_Click;
            // 
            // listboxTransactions
            // 
            listboxTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listboxTransactions.FormattingEnabled = true;
            listboxTransactions.ItemHeight = 21;
            listboxTransactions.Location = new Point(56, 73);
            listboxTransactions.Name = "listboxTransactions";
            listboxTransactions.Size = new Size(749, 319);
            listboxTransactions.TabIndex = 3;
            listboxTransactions.SelectedIndexChanged += listboxTransactions_SelectedIndexChanged_1;
            // 
            // RemoveTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(874, 492);
            Controls.Add(listboxTransactions);
            Controls.Add(btnReturnFromRemoveTransactionForm);
            Controls.Add(btnRemoveTransaction);
            Controls.Add(lblRemoveTransaction);
            Name = "RemoveTransactionForm";
            Text = "RemoveTransactionForm";
            Load += RemoveTransactionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblRemoveTransaction;
        private System.Windows.Forms.Button btnRemoveTransaction;
        private System.Windows.Forms.Button btnReturnFromRemoveTransactionForm;
        private System.Windows.Forms.ListBox listboxTransactions;
    }
}
