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
            dataGridView1 = new DataGridView();
            TransactionID = new DataGridViewTextBoxColumn();
            userColumn = new DataGridViewTextBoxColumn();
            transactionColumn = new DataGridViewTextBoxColumn();
            amountColumn = new DataGridViewTextBoxColumn();
            datetimeColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnRemoveTransaction.Location = new Point(16, 154);
            btnRemoveTransaction.Name = "btnRemoveTransaction";
            btnRemoveTransaction.Size = new Size(113, 43);
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
            btnReturnFromRemoveTransactionForm.Location = new Point(381, 418);
            btnReturnFromRemoveTransactionForm.Name = "btnReturnFromRemoveTransactionForm";
            btnReturnFromRemoveTransactionForm.Size = new Size(112, 62);
            btnReturnFromRemoveTransactionForm.TabIndex = 2;
            btnReturnFromRemoveTransactionForm.Text = "Tillbaka";
            btnReturnFromRemoveTransactionForm.UseVisualStyleBackColor = false;
            btnReturnFromRemoveTransactionForm.Click += btnReturnFromRemoveTransactionForm_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TransactionID, userColumn, transactionColumn, amountColumn, datetimeColumn });
            dataGridView1.Location = new Point(135, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(604, 330);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Enter += dataGridView1_Enter;
            // 
            // TransactionID
            // 
            TransactionID.HeaderText = "TransactionID";
            TransactionID.Name = "TransactionID";
            TransactionID.ReadOnly = true;
            // 
            // userColumn
            // 
            userColumn.HeaderText = "Username";
            userColumn.Name = "userColumn";
            userColumn.ReadOnly = true;
            // 
            // transactionColumn
            // 
            transactionColumn.HeaderText = "Type";
            transactionColumn.Name = "transactionColumn";
            transactionColumn.ReadOnly = true;
            // 
            // amountColumn
            // 
            amountColumn.HeaderText = "Amount";
            amountColumn.Name = "amountColumn";
            amountColumn.ReadOnly = true;
            // 
            // datetimeColumn
            // 
            datetimeColumn.HeaderText = "Date";
            datetimeColumn.Name = "datetimeColumn";
            datetimeColumn.ReadOnly = true;
            // 
            // RemoveTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(874, 492);
            Controls.Add(dataGridView1);
            Controls.Add(btnReturnFromRemoveTransactionForm);
            Controls.Add(btnRemoveTransaction);
            Controls.Add(lblRemoveTransaction);
            Name = "RemoveTransactionForm";
            Text = "RemoveTransactionForm";
            Load += RemoveTransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblRemoveTransaction;
        private System.Windows.Forms.Button btnRemoveTransaction;
        private System.Windows.Forms.Button btnReturnFromRemoveTransactionForm;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn userColumn;
        private DataGridViewTextBoxColumn transactionColumn;
        private DataGridViewTextBoxColumn amountColumn;
        private DataGridViewTextBoxColumn datetimeColumn;
    }
}
