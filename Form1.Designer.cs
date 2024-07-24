namespace Rabanut
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
            label1 = new Label();
            DayInWeekComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            DayInMonthComboBox = new ComboBox();
            label4 = new Label();
            MonthComboBox = new ComboBox();
            label5 = new Label();
            YearComboBox = new ComboBox();
            GetDateButten = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 45);
            label1.Name = "label1";
            label1.Size = new Size(221, 45);
            label1.TabIndex = 0;
            label1.Text = "כתיבת תאריך";
            // 
            // DayInWeekComboBox
            // 
            DayInWeekComboBox.FormattingEnabled = true;
            DayInWeekComboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            DayInWeekComboBox.Location = new Point(616, 159);
            DayInWeekComboBox.Name = "DayInWeekComboBox";
            DayInWeekComboBox.Size = new Size(182, 33);
            DayInWeekComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(662, 131);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "היום בשבוע";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 131);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "היום בחודש";
            // 
            // DayInMonthComboBox
            // 
            DayInMonthComboBox.FormattingEnabled = true;
            DayInMonthComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DayInMonthComboBox.Location = new Point(422, 159);
            DayInMonthComboBox.Name = "DayInMonthComboBox";
            DayInMonthComboBox.Size = new Size(182, 33);
            DayInMonthComboBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 131);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 6;
            label4.Text = "חודש";
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthComboBox.Location = new Point(234, 159);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(182, 33);
            MonthComboBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 131);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 8;
            label5.Text = "שנה";
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            YearComboBox.Location = new Point(39, 159);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(182, 33);
            YearComboBox.TabIndex = 7;
            // 
            // GetDateButten
            // 
            GetDateButten.Location = new Point(353, 274);
            GetDateButten.Name = "GetDateButten";
            GetDateButten.Size = new Size(112, 34);
            GetDateButten.TabIndex = 9;
            GetDateButten.Text = "אישור";
            GetDateButten.UseVisualStyleBackColor = true;
            GetDateButten.Click += OnGetDateButten;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 450);
            Controls.Add(GetDateButten);
            Controls.Add(label5);
            Controls.Add(YearComboBox);
            Controls.Add(label4);
            Controls.Add(MonthComboBox);
            Controls.Add(label3);
            Controls.Add(DayInMonthComboBox);
            Controls.Add(label2);
            Controls.Add(DayInWeekComboBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "כתיבת תאריך";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox DayInWeekComboBox;
        private Label label2;
        private Label label3;
        private ComboBox DayInMonthComboBox;
        private Label label4;
        private ComboBox MonthComboBox;
        private Label label5;
        private ComboBox YearComboBox;
        private Button GetDateButten;
    }
}
