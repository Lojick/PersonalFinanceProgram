namespace PersonalFinanceGUI
{
    partial class Form1
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainPanel = new Panel();
            updateFormbtn = new Button();
            button1 = new Button();
            btnLogout = new Button();
            btnCloseProgram = new Button();
            btnShowReport = new Button();
            btnShowBalance = new Button();
            lblMainMeny = new Label();
            btnRemoveTransaction = new Button();
            btnAddTransaction = new Button();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            fileSystemWatcher1 = new FileSystemWatcher();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImage = Properties.Resources.Pengar_bakgrund_till_GUI;
            mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            mainPanel.Controls.Add(updateFormbtn);
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(btnLogout);
            mainPanel.Controls.Add(btnCloseProgram);
            mainPanel.Controls.Add(btnShowReport);
            mainPanel.Controls.Add(btnShowBalance);
            mainPanel.Controls.Add(lblMainMeny);
            mainPanel.Controls.Add(btnRemoveTransaction);
            mainPanel.Controls.Add(btnAddTransaction);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(878, 575);
            mainPanel.TabIndex = 8;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // updateFormbtn
            // 
            updateFormbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            updateFormbtn.BackColor = Color.Gainsboro;
            updateFormbtn.BackgroundImageLayout = ImageLayout.None;
            updateFormbtn.FlatStyle = FlatStyle.Flat;
            updateFormbtn.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateFormbtn.Location = new Point(48, 347);
            updateFormbtn.Name = "updateFormbtn";
            updateFormbtn.Size = new Size(170, 65);
            updateFormbtn.TabIndex = 16;
            updateFormbtn.Text = "Ändra användaruppgifter";
            updateFormbtn.UseVisualStyleBackColor = false;
            updateFormbtn.Click += updateFormbtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(692, 358);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 15;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom;
            btnLogout.BackColor = Color.Gainsboro;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(354, 345);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(170, 65);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Logga ut";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCloseProgram
            // 
            btnCloseProgram.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCloseProgram.BackColor = Color.Gainsboro;
            btnCloseProgram.FlatStyle = FlatStyle.Flat;
            btnCloseProgram.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseProgram.Location = new Point(659, 347);
            btnCloseProgram.Name = "btnCloseProgram";
            btnCloseProgram.Size = new Size(170, 65);
            btnCloseProgram.TabIndex = 10;
            btnCloseProgram.Text = "Avsluta";
            btnCloseProgram.UseVisualStyleBackColor = false;
            btnCloseProgram.Click += btnCloseProgram_Click;
            // 
            // btnShowReport
            // 
            btnShowReport.Anchor = AnchorStyles.Top;
            btnShowReport.BackColor = Color.Gainsboro;
            btnShowReport.FlatStyle = FlatStyle.Flat;
            btnShowReport.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnShowReport.Location = new Point(241, 211);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(170, 65);
            btnShowReport.TabIndex = 13;
            btnShowReport.Text = "Visa utgifter och inkomster";
            btnShowReport.UseVisualStyleBackColor = false;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // btnShowBalance
            // 
            btnShowBalance.BackColor = Color.Gainsboro;
            btnShowBalance.FlatStyle = FlatStyle.Flat;
            btnShowBalance.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowBalance.Location = new Point(32, 211);
            btnShowBalance.Name = "btnShowBalance";
            btnShowBalance.Size = new Size(170, 65);
            btnShowBalance.TabIndex = 12;
            btnShowBalance.Text = "Visa kontobalans";
            btnShowBalance.UseVisualStyleBackColor = false;
            btnShowBalance.Click += btnShowBalance_Click;
            // 
            // lblMainMeny
            // 
            lblMainMeny.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMainMeny.AutoSize = true;
            lblMainMeny.BackColor = Color.White;
            lblMainMeny.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainMeny.ForeColor = SystemColors.ActiveCaptionText;
            lblMainMeny.Location = new Point(319, 52);
            lblMainMeny.Name = "lblMainMeny";
            lblMainMeny.Size = new Size(241, 37);
            lblMainMeny.TabIndex = 11;
            lblMainMeny.Text = "Justera något här";
            lblMainMeny.Click += lblMainMeny_Click;
            // 
            // btnRemoveTransaction
            // 
            btnRemoveTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoveTransaction.BackColor = Color.Gainsboro;
            btnRemoveTransaction.FlatStyle = FlatStyle.Flat;
            btnRemoveTransaction.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnRemoveTransaction.Location = new Point(659, 211);
            btnRemoveTransaction.Name = "btnRemoveTransaction";
            btnRemoveTransaction.Size = new Size(170, 65);
            btnRemoveTransaction.TabIndex = 9;
            btnRemoveTransaction.Text = "Ta bort transaktioner\r\n";
            btnRemoveTransaction.UseVisualStyleBackColor = false;
            btnRemoveTransaction.Click += btnRemoveTransaction_Click;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Anchor = AnchorStyles.Top;
            btnAddTransaction.BackColor = Color.Gainsboro;
            btnAddTransaction.FlatStyle = FlatStyle.Flat;
            btnAddTransaction.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnAddTransaction.Location = new Point(451, 211);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(170, 65);
            btnAddTransaction.TabIndex = 8;
            btnAddTransaction.Text = "Lägg till transaktioner\r\n";
            btnAddTransaction.UseVisualStyleBackColor = false;
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(878, 575);
            Controls.Add(mainPanel);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel mainPanel;
        private Button btnShowReport;
        private Button btnShowBalance;
        private Label lblMainMeny;
        private Button btnCloseProgram;
        private Button btnRemoveTransaction;
        private Button btnAddTransaction;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnLogout;
        private Button button1;
        private Button updateFormbtn;
    }
}
