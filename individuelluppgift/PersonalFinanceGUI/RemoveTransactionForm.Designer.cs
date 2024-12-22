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
            ReturnFromRemoveTransactionForm = new Button();
            listboxTransactions = new ListBox();
            SuspendLayout();
            // 
            // lblRemoveTransaction
            // 
            lblRemoveTransaction.AutoSize = true;
            lblRemoveTransaction.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemoveTransaction.Location = new Point(158, 35);
            lblRemoveTransaction.Name = "lblRemoveTransaction";
            lblRemoveTransaction.Size = new Size(412, 26);
            lblRemoveTransaction.TabIndex = 0;
            lblRemoveTransaction.Text = "Välj vilken transaktion du vill ta bort från listan";
            lblRemoveTransaction.Click += lblRemoveTransaction_Click;
            // 
            // btnRemoveTransaction
            // 
            btnRemoveTransaction.BackColor = Color.IndianRed;
            btnRemoveTransaction.FlatStyle = FlatStyle.Flat;
            btnRemoveTransaction.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveTransaction.Location = new Point(46, 167);
            btnRemoveTransaction.Name = "btnRemoveTransaction";
            btnRemoveTransaction.Size = new Size(109, 41);
            btnRemoveTransaction.TabIndex = 1;
            btnRemoveTransaction.Text = "Ta bort";
            btnRemoveTransaction.UseVisualStyleBackColor = false;
            btnRemoveTransaction.Click += btnRemoveTransaction_Click;
            // 
            // ReturnFromRemoveTransactionForm
            // 
            ReturnFromRemoveTransactionForm.BackColor = SystemColors.ControlDark;
            ReturnFromRemoveTransactionForm.FlatStyle = FlatStyle.Flat;
            ReturnFromRemoveTransactionForm.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReturnFromRemoveTransactionForm.Location = new Point(584, 415);
            ReturnFromRemoveTransactionForm.Name = "ReturnFromRemoveTransactionForm";
            ReturnFromRemoveTransactionForm.Size = new Size(109, 41);
            ReturnFromRemoveTransactionForm.TabIndex = 2;
            ReturnFromRemoveTransactionForm.Text = "Tillbaka";
            ReturnFromRemoveTransactionForm.UseVisualStyleBackColor = false;
            ReturnFromRemoveTransactionForm.Click += btnReturnFromRemoveTransactionForm_Click;
            // 
            // listboxTransactions
            // 
            listboxTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listboxTransactions.FormattingEnabled = true;
            listboxTransactions.ItemHeight = 21;
            listboxTransactions.Location = new Point(181, 81);
            listboxTransactions.Name = "listboxTransactions";
            listboxTransactions.Size = new Size(366, 319);
            listboxTransactions.TabIndex = 3;
            listboxTransactions.SelectedIndexChanged += listBoxTransactions_SelectedIndexChanged;
            // 
            // RemoveTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(729, 492);
            Controls.Add(listboxTransactions);
            Controls.Add(ReturnFromRemoveTransactionForm);
            Controls.Add(btnRemoveTransaction);
            Controls.Add(lblRemoveTransaction);
            Name = "RemoveTransactionForm";
            Text = "Form2";
            Load += RemoveTransactionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRemoveTransaction;
        private Button btnRemoveTransaction;
        private Button ReturnFromRemoveTransactionForm;
        private ListBox listboxTransactions;
    }
}