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
            SuspendLayout();
            // 
            // lblYearIncome
            // 
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
            Controls.Add(lblDayIncome);
            Controls.Add(lblWeekIncome);
            Controls.Add(lblMonthIncome);
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
    }
}