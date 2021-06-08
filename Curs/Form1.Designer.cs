
namespace Curs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addMoney = new System.Windows.Forms.Button();
            this.redCount = new System.Windows.Forms.NumericUpDown();
            this.Sell = new System.Windows.Forms.Button();
            this.Buy = new System.Windows.Forms.Button();
            this.redDoll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.redScore = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.redCurs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCurs)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea7.AxisX.Interval = 1D;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.MediumSpringGreen;
            chartArea7.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea7.AxisX.ScrollBar.LineColor = System.Drawing.Color.Orange;
            chartArea7.AxisY.IsStartedFromZero = false;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            legend7.Title = "Валюта";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(2, 149);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.IsValueShownAsLabel = true;
            series7.LabelFormat = "F2";
            series7.Legend = "Legend1";
            series7.Name = "$";
            series7.SmartLabelStyle.Enabled = false;
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(1026, 387);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addMoney);
            this.panel1.Controls.Add(this.redCount);
            this.panel1.Controls.Add(this.Sell);
            this.panel1.Controls.Add(this.Buy);
            this.panel1.Controls.Add(this.redDoll);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.redScore);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.redCurs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 143);
            this.panel1.TabIndex = 1;
            // 
            // addMoney
            // 
            this.addMoney.BackColor = System.Drawing.Color.Salmon;
            this.addMoney.ForeColor = System.Drawing.Color.Navy;
            this.addMoney.Location = new System.Drawing.Point(616, 9);
            this.addMoney.Name = "addMoney";
            this.addMoney.Size = new System.Drawing.Size(225, 104);
            this.addMoney.TabIndex = 11;
            this.addMoney.Text = "Пополнить счёт на 1000₽";
            this.addMoney.UseVisualStyleBackColor = false;
            this.addMoney.Click += new System.EventHandler(this.addMoney_Click);
            // 
            // redCount
            // 
            this.redCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.redCount.Location = new System.Drawing.Point(338, 80);
            this.redCount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.redCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.redCount.Name = "redCount";
            this.redCount.Size = new System.Drawing.Size(230, 18);
            this.redCount.TabIndex = 10;
            this.redCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.redCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(470, 6);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(98, 55);
            this.Sell.TabIndex = 9;
            this.Sell.Text = "Продать";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(338, 6);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(98, 55);
            this.Buy.TabIndex = 8;
            this.Buy.Text = "Купить";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // redDoll
            // 
            this.redDoll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redDoll.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redDoll.Location = new System.Drawing.Point(181, 96);
            this.redDoll.Name = "redDoll";
            this.redDoll.ReadOnly = true;
            this.redDoll.Size = new System.Drawing.Size(157, 20);
            this.redDoll.TabIndex = 7;
            this.redDoll.Text = "0$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество $ на счету:";
            // 
            // redScore
            // 
            this.redScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redScore.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redScore.Location = new System.Drawing.Point(210, 66);
            this.redScore.Name = "redScore";
            this.redScore.ReadOnly = true;
            this.redScore.ShortcutsEnabled = false;
            this.redScore.Size = new System.Drawing.Size(157, 20);
            this.redScore.TabIndex = 5;
            this.redScore.Text = "1000₽";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(871, 3);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(149, 58);
            this.start.TabIndex = 4;
            this.start.Text = "Start!!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество денег на счету:";
            // 
            // redCurs
            // 
            this.redCurs.DecimalPlaces = 2;
            this.redCurs.Location = new System.Drawing.Point(117, 9);
            this.redCurs.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.redCurs.Name = "redCurs";
            this.redCurs.Size = new System.Drawing.Size(120, 22);
            this.redCurs.TabIndex = 1;
            this.redCurs.Value = new decimal(new int[] {
            7433,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown redCurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox redScore;
        private System.Windows.Forms.TextBox redDoll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.NumericUpDown redCount;
        private System.Windows.Forms.Button addMoney;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

