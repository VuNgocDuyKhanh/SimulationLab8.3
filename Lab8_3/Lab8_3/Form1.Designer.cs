namespace Lab8_3
{
    partial class Form1
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
            this.Prob1Label = new System.Windows.Forms.Label();
            this.Prob2Label = new System.Windows.Forms.Label();
            this.Prob1 = new System.Windows.Forms.NumericUpDown();
            this.Prob2 = new System.Windows.Forms.NumericUpDown();
            this.Prob3 = new System.Windows.Forms.NumericUpDown();
            this.Prob4 = new System.Windows.Forms.NumericUpDown();
            this.NumTrials = new System.Windows.Forms.NumericUpDown();
            this.Prob3Label = new System.Windows.Forms.Label();
            this.Prob4Label = new System.Windows.Forms.Label();
            this.Prob5Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prob1Label
            // 
            this.Prob1Label.AutoSize = true;
            this.Prob1Label.Location = new System.Drawing.Point(12, 14);
            this.Prob1Label.Name = "Prob1Label";
            this.Prob1Label.Size = new System.Drawing.Size(46, 16);
            this.Prob1Label.TabIndex = 0;
            this.Prob1Label.Text = "Prob 1";
            // 
            // Prob2Label
            // 
            this.Prob2Label.AutoSize = true;
            this.Prob2Label.Location = new System.Drawing.Point(12, 42);
            this.Prob2Label.Name = "Prob2Label";
            this.Prob2Label.Size = new System.Drawing.Size(46, 16);
            this.Prob2Label.TabIndex = 1;
            this.Prob2Label.Text = "Prob 2";
            // 
            // Prob1
            // 
            this.Prob1.Location = new System.Drawing.Point(64, 12);
            this.Prob1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Prob1.Name = "Prob1";
            this.Prob1.Size = new System.Drawing.Size(120, 22);
            this.Prob1.TabIndex = 2;
            // 
            // Prob2
            // 
            this.Prob2.Location = new System.Drawing.Point(64, 40);
            this.Prob2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Prob2.Name = "Prob2";
            this.Prob2.Size = new System.Drawing.Size(120, 22);
            this.Prob2.TabIndex = 3;
            // 
            // Prob3
            // 
            this.Prob3.Location = new System.Drawing.Point(64, 68);
            this.Prob3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Prob3.Name = "Prob3";
            this.Prob3.Size = new System.Drawing.Size(120, 22);
            this.Prob3.TabIndex = 4;
            // 
            // Prob4
            // 
            this.Prob4.Location = new System.Drawing.Point(64, 96);
            this.Prob4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Prob4.Name = "Prob4";
            this.Prob4.Size = new System.Drawing.Size(120, 22);
            this.Prob4.TabIndex = 5;
            // 
            // NumTrials
            // 
            this.NumTrials.Location = new System.Drawing.Point(118, 152);
            this.NumTrials.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumTrials.Name = "NumTrials";
            this.NumTrials.Size = new System.Drawing.Size(120, 22);
            this.NumTrials.TabIndex = 7;
            // 
            // Prob3Label
            // 
            this.Prob3Label.AutoSize = true;
            this.Prob3Label.Location = new System.Drawing.Point(12, 70);
            this.Prob3Label.Name = "Prob3Label";
            this.Prob3Label.Size = new System.Drawing.Size(46, 16);
            this.Prob3Label.TabIndex = 8;
            this.Prob3Label.Text = "Prob 3";
            // 
            // Prob4Label
            // 
            this.Prob4Label.AutoSize = true;
            this.Prob4Label.Location = new System.Drawing.Point(12, 98);
            this.Prob4Label.Name = "Prob4Label";
            this.Prob4Label.Size = new System.Drawing.Size(46, 16);
            this.Prob4Label.TabIndex = 9;
            this.Prob4Label.Text = "Prob 4";
            // 
            // Prob5Label
            // 
            this.Prob5Label.AutoSize = true;
            this.Prob5Label.Location = new System.Drawing.Point(12, 126);
            this.Prob5Label.Name = "Prob5Label";
            this.Prob5Label.Size = new System.Drawing.Size(46, 16);
            this.Prob5Label.TabIndex = 10;
            this.Prob5Label.Text = "Prob 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of trials";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 173);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 12;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(244, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Freq";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(544, 426);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Auto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Prob5Label);
            this.Controls.Add(this.Prob4Label);
            this.Controls.Add(this.Prob3Label);
            this.Controls.Add(this.NumTrials);
            this.Controls.Add(this.Prob4);
            this.Controls.Add(this.Prob3);
            this.Controls.Add(this.Prob2);
            this.Controls.Add(this.Prob1);
            this.Controls.Add(this.Prob2Label);
            this.Controls.Add(this.Prob1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prob1Label;
        private System.Windows.Forms.Label Prob2Label;
        private System.Windows.Forms.NumericUpDown Prob1;
        private System.Windows.Forms.NumericUpDown Prob2;
        private System.Windows.Forms.NumericUpDown Prob3;
        private System.Windows.Forms.NumericUpDown Prob4;
        private System.Windows.Forms.NumericUpDown NumTrials;
        private System.Windows.Forms.Label Prob3Label;
        private System.Windows.Forms.Label Prob4Label;
        private System.Windows.Forms.Label Prob5Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

