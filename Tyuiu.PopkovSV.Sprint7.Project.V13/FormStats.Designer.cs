
namespace Tyuiu.PopkovSV.Sprint7.Project.V13
{
    partial class FormStats
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
            this.chartStats_PSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDevelop_PSV = new System.Windows.Forms.Button();
            this.buttonNational_PSV = new System.Windows.Forms.Button();
            this.groupBoxStats_PSV = new System.Windows.Forms.GroupBox();
            this.labelAverageArea_PSV = new System.Windows.Forms.Label();
            this.textBoxAverageArea_PSV = new System.Windows.Forms.TextBox();
            this.labelAveragePopulation_PSV = new System.Windows.Forms.Label();
            this.textBoxAveragePopulation_PSV = new System.Windows.Forms.TextBox();
            this.buttonViewStats_PSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_PSV)).BeginInit();
            this.groupBoxStats_PSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStats_PSV
            // 
            this.chartStats_PSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartStats_PSV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartStats_PSV.Legends.Add(legend1);
            this.chartStats_PSV.Location = new System.Drawing.Point(256, 12);
            this.chartStats_PSV.Name = "chartStats_PSV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStats_PSV.Series.Add(series1);
            this.chartStats_PSV.Size = new System.Drawing.Size(532, 329);
            this.chartStats_PSV.TabIndex = 0;
            this.chartStats_PSV.Text = "chart1";
            // 
            // buttonDevelop_PSV
            // 
            this.buttonDevelop_PSV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDevelop_PSV.Location = new System.Drawing.Point(12, 12);
            this.buttonDevelop_PSV.Name = "buttonDevelop_PSV";
            this.buttonDevelop_PSV.Size = new System.Drawing.Size(238, 162);
            this.buttonDevelop_PSV.TabIndex = 1;
            this.buttonDevelop_PSV.Text = "График \r\n\"Кол-во стран/является ли страна развитой\"";
            this.buttonDevelop_PSV.UseVisualStyleBackColor = true;
            this.buttonDevelop_PSV.Click += new System.EventHandler(this.buttonDevelop_PSV_Click);
            // 
            // buttonNational_PSV
            // 
            this.buttonNational_PSV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNational_PSV.Location = new System.Drawing.Point(12, 179);
            this.buttonNational_PSV.Name = "buttonNational_PSV";
            this.buttonNational_PSV.Size = new System.Drawing.Size(238, 162);
            this.buttonNational_PSV.TabIndex = 2;
            this.buttonNational_PSV.Text = "График \r\n\"Кол-во стран/преобладающая национальность\"";
            this.buttonNational_PSV.UseVisualStyleBackColor = true;
            this.buttonNational_PSV.Click += new System.EventHandler(this.buttonNational_PSV_Click);
            // 
            // groupBoxStats_PSV
            // 
            this.groupBoxStats_PSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStats_PSV.Controls.Add(this.labelAverageArea_PSV);
            this.groupBoxStats_PSV.Controls.Add(this.textBoxAverageArea_PSV);
            this.groupBoxStats_PSV.Controls.Add(this.labelAveragePopulation_PSV);
            this.groupBoxStats_PSV.Controls.Add(this.textBoxAveragePopulation_PSV);
            this.groupBoxStats_PSV.Controls.Add(this.buttonViewStats_PSV);
            this.groupBoxStats_PSV.Location = new System.Drawing.Point(12, 347);
            this.groupBoxStats_PSV.Name = "groupBoxStats_PSV";
            this.groupBoxStats_PSV.Size = new System.Drawing.Size(776, 136);
            this.groupBoxStats_PSV.TabIndex = 3;
            this.groupBoxStats_PSV.TabStop = false;
            this.groupBoxStats_PSV.Text = "Статистика";
            // 
            // labelAverageArea_PSV
            // 
            this.labelAverageArea_PSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAverageArea_PSV.AutoSize = true;
            this.labelAverageArea_PSV.Location = new System.Drawing.Point(293, 18);
            this.labelAverageArea_PSV.Name = "labelAverageArea_PSV";
            this.labelAverageArea_PSV.Size = new System.Drawing.Size(280, 17);
            this.labelAverageArea_PSV.TabIndex = 4;
            this.labelAverageArea_PSV.Text = "Ср. значение площади территории, км^2";
            // 
            // textBoxAverageArea_PSV
            // 
            this.textBoxAverageArea_PSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAverageArea_PSV.Location = new System.Drawing.Point(296, 38);
            this.textBoxAverageArea_PSV.Name = "textBoxAverageArea_PSV";
            this.textBoxAverageArea_PSV.ReadOnly = true;
            this.textBoxAverageArea_PSV.Size = new System.Drawing.Size(277, 22);
            this.textBoxAverageArea_PSV.TabIndex = 3;
            // 
            // labelAveragePopulation_PSV
            // 
            this.labelAveragePopulation_PSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAveragePopulation_PSV.AutoSize = true;
            this.labelAveragePopulation_PSV.Location = new System.Drawing.Point(293, 63);
            this.labelAveragePopulation_PSV.Name = "labelAveragePopulation_PSV";
            this.labelAveragePopulation_PSV.Size = new System.Drawing.Size(252, 17);
            this.labelAveragePopulation_PSV.TabIndex = 2;
            this.labelAveragePopulation_PSV.Text = "Ср. Значение кол-ва населения, чел\r\n";
            // 
            // textBoxAveragePopulation_PSV
            // 
            this.textBoxAveragePopulation_PSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAveragePopulation_PSV.Location = new System.Drawing.Point(296, 83);
            this.textBoxAveragePopulation_PSV.Name = "textBoxAveragePopulation_PSV";
            this.textBoxAveragePopulation_PSV.ReadOnly = true;
            this.textBoxAveragePopulation_PSV.Size = new System.Drawing.Size(277, 22);
            this.textBoxAveragePopulation_PSV.TabIndex = 1;
            // 
            // buttonViewStats_PSV
            // 
            this.buttonViewStats_PSV.Location = new System.Drawing.Point(3, 18);
            this.buttonViewStats_PSV.Name = "buttonViewStats_PSV";
            this.buttonViewStats_PSV.Size = new System.Drawing.Size(102, 112);
            this.buttonViewStats_PSV.TabIndex = 0;
            this.buttonViewStats_PSV.Text = "Отобразить статистику";
            this.buttonViewStats_PSV.UseVisualStyleBackColor = true;
            this.buttonViewStats_PSV.Click += new System.EventHandler(this.buttonViewStats_PSV_Click);
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.groupBoxStats_PSV);
            this.Controls.Add(this.buttonNational_PSV);
            this.Controls.Add(this.buttonDevelop_PSV);
            this.Controls.Add(this.chartStats_PSV);
            this.Name = "FormStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистические данные";
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_PSV)).EndInit();
            this.groupBoxStats_PSV.ResumeLayout(false);
            this.groupBoxStats_PSV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_PSV;
        private System.Windows.Forms.Button buttonDevelop_PSV;
        private System.Windows.Forms.Button buttonNational_PSV;
        private System.Windows.Forms.GroupBox groupBoxStats_PSV;
        private System.Windows.Forms.Label labelAverageArea_PSV;
        private System.Windows.Forms.TextBox textBoxAverageArea_PSV;
        private System.Windows.Forms.Label labelAveragePopulation_PSV;
        private System.Windows.Forms.TextBox textBoxAveragePopulation_PSV;
        private System.Windows.Forms.Button buttonViewStats_PSV;
    }
}