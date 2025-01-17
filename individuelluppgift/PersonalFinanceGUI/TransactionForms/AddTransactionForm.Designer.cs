namespace PersonalFinanceGUI
{
    partial class AddTransactionForm
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
            lblAddTransaction = new Label();
            radioSättIn = new RadioButton();
            radioTaUt = new RadioButton();
            btnReturnFromAddTransaction = new Button();
            btnSaveTransaction = new Button();
            txtAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblAddTransaction
            // 
            lblAddTransaction.AutoSize = true;
            lblAddTransaction.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTransaction.Location = new Point(192, 25);
            lblAddTransaction.Name = "lblAddTransaction";
            lblAddTransaction.Size = new Size(234, 29);
            lblAddTransaction.TabIndex = 0;
            lblAddTransaction.Text = "Hantera transaktioner";
            lblAddTransaction.Click += lblAddTransaction_Click;
            // 
            // radioSättIn
            // 
            radioSättIn.AutoSize = true;
            radioSättIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioSättIn.Location = new Point(92, 134);
            radioSättIn.Name = "radioSättIn";
            radioSättIn.Size = new Size(156, 29);
            radioSättIn.TabIndex = 1;
            radioSättIn.TabStop = true;
            radioSättIn.Text = "Sätt in pengar";
            radioSättIn.UseVisualStyleBackColor = true;
            radioSättIn.CheckedChanged += radioSättIn_CheckedChanged;
            // 
            // radioTaUt
            // 
            radioTaUt.AutoSize = true;
            radioTaUt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioTaUt.Location = new Point(92, 191);
            radioTaUt.Name = "radioTaUt";
            radioTaUt.Size = new Size(142, 29);
            radioTaUt.TabIndex = 2;
            radioTaUt.TabStop = true;
            radioTaUt.Text = "Ta ut pengar";
            radioTaUt.UseVisualStyleBackColor = true;
            radioTaUt.CheckedChanged += radioTaUt_CheckedChanged;
            // 
            // btnReturnFromAddTransaction
            // 
            btnReturnFromAddTransaction.BackColor = Color.LightGray;
            btnReturnFromAddTransaction.FlatStyle = FlatStyle.Flat;
            btnReturnFromAddTransaction.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnFromAddTransaction.Location = new Point(404, 300);
            btnReturnFromAddTransaction.Name = "btnReturnFromAddTransaction";
            btnReturnFromAddTransaction.Size = new Size(131, 64);
            btnReturnFromAddTransaction.TabIndex = 3;
            btnReturnFromAddTransaction.Text = "Tillbaka";
            btnReturnFromAddTransaction.UseVisualStyleBackColor = false;
            btnReturnFromAddTransaction.Click += btnReturnFromAddTransaction_Click;
            // 
            // btnSaveTransaction
            // 
            btnSaveTransaction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveTransaction.BackColor = Color.FromArgb(192, 255, 192);
            btnSaveTransaction.FlatStyle = FlatStyle.Flat;
            btnSaveTransaction.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveTransaction.Location = new Point(92, 301);
            btnSaveTransaction.Name = "btnSaveTransaction";
            btnSaveTransaction.Size = new Size(131, 64);
            btnSaveTransaction.TabIndex = 4;
            btnSaveTransaction.Text = "Spara";
            btnSaveTransaction.UseVisualStyleBackColor = false;
            btnSaveTransaction.Click += btnSaveTransaction_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(233, 248);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(161, 23);
            txtAmount.TabIndex = 5;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 224);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 6;
            label1.Text = "Ange belopp";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(192, 25);
            label2.Name = "label2";
            label2.Size = new Size(234, 29);
            label2.TabIndex = 0;
            label2.Text = "Hantera transaktioner";
            label2.Click += lblAddTransaction_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = SystemColors.ScrollBar;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(404, 300);
            button1.Name = "button1";
            button1.Size = new Size(131, 64);
            button1.TabIndex = 3;
            button1.Text = "Tillbaka";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnReturnFromAddTransaction_Click;
            // 
            // AddTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(626, 456);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Controls.Add(btnSaveTransaction);
            Controls.Add(button1);
            Controls.Add(btnReturnFromAddTransaction);
            Controls.Add(radioTaUt);
            Controls.Add(radioSättIn);
            Controls.Add(label2);
            Controls.Add(lblAddTransaction);
            Name = "AddTransactionForm";
            Text = "Form2";
            Load += AddTransactionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddTransaction;
        private RadioButton radioSättIn;
        private RadioButton radioTaUt;
        private Button btnReturnFromAddTransaction;
        private Button btnSaveTransaction;
        private TextBox txtAmount;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}