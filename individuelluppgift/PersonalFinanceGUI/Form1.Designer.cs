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
            // btnCloseProgram
            // 
            btnCloseProgram.FlatStyle = FlatStyle.Flat;
            btnCloseProgram.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseProgram.Location = new Point(354, 331);
            btnCloseProgram.Name = "btnCloseProgram";
            btnCloseProgram.Size = new Size(170, 65);
            btnCloseProgram.TabIndex = 10;
            btnCloseProgram.Text = "Stäng programmet";
            btnCloseProgram.UseVisualStyleBackColor = true;
            btnCloseProgram.Click += btnCloseProgram_Click;
            // 
            // btnShowReport
            // 
            btnShowReport.FlatStyle = FlatStyle.Flat;
            btnShowReport.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnShowReport.Location = new Point(241, 211);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(186, 88);
            btnShowReport.TabIndex = 13;
            btnShowReport.Text = "Visa utgifter och inkomster";
            btnShowReport.UseVisualStyleBackColor = true;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // btnShowBalance
            // 
            btnShowBalance.FlatStyle = FlatStyle.Flat;
            btnShowBalance.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowBalance.Location = new Point(32, 211);
            btnShowBalance.Name = "btnShowBalance";
            btnShowBalance.Size = new Size(186, 88);
            btnShowBalance.TabIndex = 12;
            btnShowBalance.Text = "Visa kontobalans";
            btnShowBalance.UseVisualStyleBackColor = true;
            btnShowBalance.Click += btnShowBalance_Click;
            // 
            // lblMainMeny
            // 
            lblMainMeny.AutoSize = true;
            lblMainMeny.BackColor = SystemColors.ButtonFace;
            lblMainMeny.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainMeny.Location = new Point(109, 62);
            lblMainMeny.Name = "lblMainMeny";
            lblMainMeny.Size = new Size(661, 30);
            lblMainMeny.TabIndex = 11;
            lblMainMeny.Text = "Välkommen till Personal Finance Program! Välj följande alternativ.";
            // 
            // btnRemoveTransaction
            // 
            btnRemoveTransaction.FlatStyle = FlatStyle.Flat;
            btnRemoveTransaction.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnRemoveTransaction.Location = new Point(659, 209);
            btnRemoveTransaction.Name = "btnRemoveTransaction";
            btnRemoveTransaction.Size = new Size(186, 88);
            btnRemoveTransaction.TabIndex = 9;
            btnRemoveTransaction.Text = "Ta bort transaktioner\r\n";
            btnRemoveTransaction.UseVisualStyleBackColor = true;
            btnRemoveTransaction.Click += btnRemoveTransaction_Click;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.FlatStyle = FlatStyle.Flat;
            btnAddTransaction.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnAddTransaction.Location = new Point(450, 209);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(186, 88);
            btnAddTransaction.TabIndex = 8;
            btnAddTransaction.Text = "Lägg till transaktioner\r\n";
            btnAddTransaction.UseVisualStyleBackColor = true;
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
    }
}
