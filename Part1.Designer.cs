namespace OlegTielushkoProject1
{
    partial class Part1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.roll_count_text = new System.Windows.Forms.Label();
            this.rollCount = new System.Windows.Forms.TextBox();
            this.ClearInput = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.seed_text = new System.Windows.Forms.Label();
            this.seed = new System.Windows.Forms.TextBox();
            this.roll_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.error_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roll_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(598, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jump to Part 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeMessage.Location = new System.Drawing.Point(142, 64);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(519, 38);
            this.WelcomeMessage.TabIndex = 1;
            this.WelcomeMessage.Text = "Welcome to the Random Dice Roller!!!";
            this.WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeMessage.Click += new System.EventHandler(this.WelcomeMessage_Click);
            // 
            // roll_count_text
            // 
            this.roll_count_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roll_count_text.AutoSize = true;
            this.roll_count_text.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roll_count_text.Location = new System.Drawing.Point(24, 123);
            this.roll_count_text.Name = "roll_count_text";
            this.roll_count_text.Size = new System.Drawing.Size(195, 32);
            this.roll_count_text.TabIndex = 2;
            this.roll_count_text.Text = "How many rolls?";
            this.roll_count_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roll_count_text.Click += new System.EventHandler(this.label2_Click);
            // 
            // rollCount
            // 
            this.rollCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rollCount.Location = new System.Drawing.Point(49, 179);
            this.rollCount.Name = "rollCount";
            this.rollCount.Size = new System.Drawing.Size(126, 25);
            this.rollCount.TabIndex = 3;
            this.rollCount.Text = "6000";
            this.rollCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClearInput
            // 
            this.ClearInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ClearInput.AutoSize = true;
            this.ClearInput.Location = new System.Drawing.Point(33, 361);
            this.ClearInput.Name = "ClearInput";
            this.ClearInput.Size = new System.Drawing.Size(152, 33);
            this.ClearInput.TabIndex = 6;
            this.ClearInput.Text = "Clear Input and Chart";
            this.ClearInput.UseVisualStyleBackColor = true;
            this.ClearInput.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(49, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Build Histogram";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // seed_text
            // 
            this.seed_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.seed_text.AutoSize = true;
            this.seed_text.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seed_text.Location = new System.Drawing.Point(24, 207);
            this.seed_text.Name = "seed_text";
            this.seed_text.Size = new System.Drawing.Size(178, 32);
            this.seed_text.TabIndex = 4;
            this.seed_text.Text = "Enter the seed:";
            this.seed_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seed_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // seed
            // 
            this.seed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.seed.Location = new System.Drawing.Point(49, 253);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(126, 25);
            this.seed.TabIndex = 5;
            this.seed.Text = "123";
            // 
            // roll_chart
            // 
            this.roll_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.roll_chart.ChartAreas.Add(chartArea1);
            this.roll_chart.ImeMode = System.Windows.Forms.ImeMode.On;
            legend1.Name = "Legend1";
            this.roll_chart.Legends.Add(legend1);
            this.roll_chart.Location = new System.Drawing.Point(228, 123);
            this.roll_chart.Name = "roll_chart";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "rolls";
            series1.XValueMember = "1";
            this.roll_chart.Series.Add(series1);
            this.roll_chart.Size = new System.Drawing.Size(508, 395);
            this.roll_chart.TabIndex = 8;
            this.roll_chart.Text = "roll_chart";
            this.roll_chart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // error_label
            // 
            this.error_label.ForeColor = System.Drawing.Color.DarkRed;
            this.error_label.Location = new System.Drawing.Point(12, 292);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(207, 54);
            this.error_label.TabIndex = 9;
            // 
            // Part1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 530);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.roll_chart);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.seed_text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClearInput);
            this.Controls.Add(this.rollCount);
            this.Controls.Add(this.roll_count_text);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Part1";
            this.Text = "Project 1: Part 1";
            this.Load += new System.EventHandler(this.Part1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roll_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Label roll_count_text;
        private System.Windows.Forms.TextBox rollCount;
        private System.Windows.Forms.Button ClearInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label seed_text;
        private System.Windows.Forms.TextBox seed;
        private System.Windows.Forms.DataVisualization.Charting.Chart roll_chart;
        private System.Windows.Forms.Label error_label;
    }
}

