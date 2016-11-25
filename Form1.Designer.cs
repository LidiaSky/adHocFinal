namespace adHoc
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.numericUpDownVerticesStep = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownVerticesMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVerticesMin = new System.Windows.Forms.NumericUpDown();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIterationsCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxTotalTime = new System.Windows.Forms.TextBox();
            this.textBoxAvgRadius = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTipTestWarning = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationsCount)).BeginInit();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInput);
            this.tabControl1.Controls.Add(this.tabResults);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInput
            // 
            this.tabInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabInput.Controls.Add(this.numericUpDownVerticesStep);
            this.tabInput.Controls.Add(this.label5);
            this.tabInput.Controls.Add(this.label2);
            this.tabInput.Controls.Add(this.label6);
            this.tabInput.Controls.Add(this.numericUpDownVerticesMax);
            this.tabInput.Controls.Add(this.numericUpDownRadius);
            this.tabInput.Controls.Add(this.numericUpDownVerticesMin);
            this.tabInput.Controls.Add(this.buttonLaunch);
            this.tabInput.Controls.Add(this.label4);
            this.tabInput.Controls.Add(this.label3);
            this.tabInput.Controls.Add(this.label1);
            this.tabInput.Controls.Add(this.numericUpDownIterationsCount);
            this.tabInput.Controls.Add(this.label7);
            this.tabInput.Location = new System.Drawing.Point(4, 29);
            this.tabInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInput.Size = new System.Drawing.Size(574, 303);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Исходные данные";
            // 
            // numericUpDownVerticesStep
            // 
            this.numericUpDownVerticesStep.Location = new System.Drawing.Point(435, 128);
            this.numericUpDownVerticesStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVerticesStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVerticesStep.Name = "numericUpDownVerticesStep";
            this.numericUpDownVerticesStep.Size = new System.Drawing.Size(131, 27);
            this.numericUpDownVerticesStep.TabIndex = 6;
            this.numericUpDownVerticesStep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип области - окружность";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(383, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шаг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Радиус связности = 1";
            // 
            // numericUpDownVerticesMax
            // 
            this.numericUpDownVerticesMax.Location = new System.Drawing.Point(435, 83);
            this.numericUpDownVerticesMax.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownVerticesMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVerticesMax.Name = "numericUpDownVerticesMax";
            this.numericUpDownVerticesMax.Size = new System.Drawing.Size(131, 27);
            this.numericUpDownVerticesMax.TabIndex = 4;
            this.numericUpDownVerticesMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Location = new System.Drawing.Point(139, 83);
            this.numericUpDownRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(111, 27);
            this.numericUpDownRadius.TabIndex = 1;
            this.numericUpDownRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownVerticesMin
            // 
            this.numericUpDownVerticesMin.Location = new System.Drawing.Point(435, 40);
            this.numericUpDownVerticesMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVerticesMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVerticesMin.Name = "numericUpDownVerticesMin";
            this.numericUpDownVerticesMin.Size = new System.Drawing.Size(131, 27);
            this.numericUpDownVerticesMin.TabIndex = 3;
            this.numericUpDownVerticesMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLaunch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLaunch.Location = new System.Drawing.Point(171, 247);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(225, 48);
            this.buttonLaunch.TabIndex = 10;
            this.buttonLaunch.Text = "Начать тестирование";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(286, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Число вершин min";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(286, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Число вершин max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус области:";
            // 
            // numericUpDownIterationsCount
            // 
            this.numericUpDownIterationsCount.Location = new System.Drawing.Point(431, 207);
            this.numericUpDownIterationsCount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownIterationsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIterationsCount.Name = "numericUpDownIterationsCount";
            this.numericUpDownIterationsCount.Size = new System.Drawing.Size(131, 27);
            this.numericUpDownIterationsCount.TabIndex = 7;
            this.numericUpDownIterationsCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(417, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Количество итераций для каждого количества вершин:";
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.chart);
            this.tabResults.Controls.Add(this.textBoxTotalTime);
            this.tabResults.Controls.Add(this.textBoxAvgRadius);
            this.tabResults.Controls.Add(this.label11);
            this.tabResults.Controls.Add(this.label10);
            this.tabResults.Location = new System.Drawing.Point(4, 29);
            this.tabResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Size = new System.Drawing.Size(574, 303);
            this.tabResults.TabIndex = 1;
            this.tabResults.Text = "Результаты";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(7, 41);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(567, 405);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // textBoxTotalTime
            // 
            this.textBoxTotalTime.Location = new System.Drawing.Point(471, 8);
            this.textBoxTotalTime.Name = "textBoxTotalTime";
            this.textBoxTotalTime.ReadOnly = true;
            this.textBoxTotalTime.Size = new System.Drawing.Size(100, 27);
            this.textBoxTotalTime.TabIndex = 3;
            // 
            // textBoxAvgRadius
            // 
            this.textBoxAvgRadius.Location = new System.Drawing.Point(471, 8);
            this.textBoxAvgRadius.Name = "textBoxAvgRadius";
            this.textBoxAvgRadius.ReadOnly = true;
            this.textBoxAvgRadius.Size = new System.Drawing.Size(100, 27);
            this.textBoxAvgRadius.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Время работы:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = " ";
            // 
            // toolTipTestWarning
            // 
            this.toolTipTestWarning.ToolTipTitle = "Перед началом тестирования убедитесь, что у вас введены значения минимума и макси" +
    "мума радиуса покрытия вершин.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(582, 336);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationsCount)).EndInit();
            this.tabResults.ResumeLayout(false);
            this.tabResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.NumericUpDown numericUpDownVerticesStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownVerticesMax;
        private System.Windows.Forms.NumericUpDown numericUpDownVerticesMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownIterationsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTipTestWarning;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTotalTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox textBoxAvgRadius;
        private System.Windows.Forms.Label label10;
    }
}

