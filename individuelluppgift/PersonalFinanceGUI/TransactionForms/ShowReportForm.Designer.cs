namespace PersonalFinanceGUI
{
    partial class ShowReportForm
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
            lblYearIncome = new Label();
            lblMonthIncome = new Label();
            lblWeekIncome = new Label();
            lblDayIncome = new Label();
            lblYearExpense = new Label();
            lblMonthExpense = new Label();
            lblWeekExpense = new Label();
            lblDayExpense = new Label();
            label1 = new Label();
            btnReturnFromReport = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblYearIncome
            // 
            lblYearIncome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblYearIncome.AutoSize = true;
            lblYearIncome.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearIncome.Location = new Point(100, 105);
            lblYearIncome.Name = "lblYearIncome";
            lblYearIncome.Size = new Size(143, 26);
            lblYearIncome.TabIndex = 0;
            lblYearIncome.Text = "Årsvis Inkomst:";
            lblYearIncome.Click += lblYearIncome_Click;
            // 
            // lblMonthIncome
            // 
            lblMonthIncome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMonthIncome.AutoSize = true;
            lblMonthIncome.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthIncome.Location = new Point(100, 142);
            lblMonthIncome.Name = "lblMonthIncome";
            lblMonthIncome.Size = new Size(183, 26);
            lblMonthIncome.TabIndex = 1;
            lblMonthIncome.Text = "Månadsvis Inkomst:";
            lblMonthIncome.Click += lblMonthIncome_Click;
            // 
            // lblWeekIncome
            // 
            lblWeekIncome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWeekIncome.AutoSize = true;
            lblWeekIncome.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeekIncome.Location = new Point(100, 183);
            lblWeekIncome.Name = "lblWeekIncome";
            lblWeekIncome.Size = new Size(166, 26);
            lblWeekIncome.TabIndex = 2;
            lblWeekIncome.Text = "Veckovis Inkomst:";
            lblWeekIncome.Click += lblWeekIncome_Click;
            // 
            // lblDayIncome
            // 
            lblDayIncome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDayIncome.AutoSize = true;
            lblDayIncome.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDayIncome.Location = new Point(100, 225);
            lblDayIncome.Name = "lblDayIncome";
            lblDayIncome.Size = new Size(148, 26);
            lblDayIncome.TabIndex = 3;
            lblDayIncome.Text = "Dagvis Inkomst:";
            lblDayIncome.Click += lblDayIncome_Click;
            // 
            // lblYearExpense
            // 
            lblYearExpense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblYearExpense.AutoSize = true;
            lblYearExpense.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearExpense.Location = new Point(481, 103);
            lblYearExpense.Name = "lblYearExpense";
            lblYearExpense.Size = new Size(115, 26);
            lblYearExpense.TabIndex = 4;
            lblYearExpense.Text = "Årvis Utgift:";
            lblYearExpense.Click += lblYearExpense_Click;
            // 
            // lblMonthExpense
            // 
            lblMonthExpense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMonthExpense.AutoSize = true;
            lblMonthExpense.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthExpense.Location = new Point(484, 142);
            lblMonthExpense.Name = "lblMonthExpense";
            lblMonthExpense.Size = new Size(163, 26);
            lblMonthExpense.TabIndex = 5;
            lblMonthExpense.Text = "Månadsvis Utgift:";
            lblMonthExpense.Click += lblMonthExpense_Click;
            // 
            // lblWeekExpense
            // 
            lblWeekExpense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWeekExpense.AutoSize = true;
            lblWeekExpense.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeekExpense.Location = new Point(487, 181);
            lblWeekExpense.Name = "lblWeekExpense";
            lblWeekExpense.Size = new Size(146, 26);
            lblWeekExpense.TabIndex = 6;
            lblWeekExpense.Text = "Veckovis Utgift:";
            lblWeekExpense.Click += lblWeekExpense_Click;
            // 
            // lblDayExpense
            // 
            lblDayExpense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDayExpense.AutoSize = true;
            lblDayExpense.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDayExpense.Location = new Point(495, 220);
            lblDayExpense.Name = "lblDayExpense";
            lblDayExpense.Size = new Size(128, 26);
            lblDayExpense.TabIndex = 7;
            lblDayExpense.Text = "Dagvis Utgift:\r\n";
            lblDayExpense.Click += lblDayExpense_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 18);
            label1.Name = "label1";
            label1.Size = new Size(238, 29);
            label1.TabIndex = 8;
            label1.Text = "Inkomster och Utgifter";
            // 
            // btnReturnFromReport
            // 
            btnReturnFromReport.Anchor = AnchorStyles.Bottom;
            btnReturnFromReport.BackColor = SystemColors.ScrollBar;
            btnReturnFromReport.FlatStyle = FlatStyle.Flat;
            btnReturnFromReport.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnFromReport.Location = new Point(339, 308);
            btnReturnFromReport.Name = "btnReturnFromReport";
            btnReturnFromReport.Size = new Size(128, 58);
            btnReturnFromReport.TabIndex = 9;
            btnReturnFromReport.Text = "Tillbaka";
            btnReturnFromReport.UseVisualStyleBackColor = false;
            btnReturnFromReport.Click += btnReturnFromReport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 103);
            label2.Name = "label2";
            label2.Size = new Size(143, 26);
            label2.TabIndex = 0;
            label2.Text = "Årsvis Inkomst:";
            label2.Click += lblYearIncome_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 140);
            label3.Name = "label3";
            label3.Size = new Size(183, 26);
            label3.TabIndex = 1;
            label3.Text = "Månadsvis Inkomst:";
            label3.Click += lblMonthIncome_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(100, 181);
            label4.Name = "label4";
            label4.Size = new Size(166, 26);
            label4.TabIndex = 2;
            label4.Text = "Veckovis Inkomst:";
            label4.Click += lblWeekIncome_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(100, 223);
            label5.Name = "label5";
            label5.Size = new Size(148, 26);
            label5.TabIndex = 3;
            label5.Text = "Dagvis Inkomst:";
            label5.Click += lblDayIncome_Click;
            // 
            // ShowReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturnFromReport);
            Controls.Add(label1);
            Controls.Add(lblDayExpense);
            Controls.Add(lblWeekExpense);
            Controls.Add(lblMonthExpense);
            Controls.Add(lblYearExpense);
            Controls.Add(label5);
            Controls.Add(lblDayIncome);
            Controls.Add(label4);
            Controls.Add(lblWeekIncome);
            Controls.Add(label3);
            Controls.Add(lblMonthIncome);
            Controls.Add(label2);
            Controls.Add(lblYearIncome);
            Name = "ShowReportForm";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYearIncome;
        private Label lblMonthIncome;
        private Label lblWeekIncome;
        private Label lblDayIncome;
        private Label lblYearExpense;
        private Label lblMonthExpense;
        private Label lblWeekExpense;
        private Label lblDayExpense;
        private Label label1;
        private Button btnReturnFromReport;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}