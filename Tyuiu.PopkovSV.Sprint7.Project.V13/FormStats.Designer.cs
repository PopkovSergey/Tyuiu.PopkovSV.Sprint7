
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
            this.buttonViewStats_PSV = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_PSV)).BeginInit();
            this.groupBoxStats_PSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStats_PSV
            // 
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
            this.buttonDevelop_PSV.Location = new System.Drawing.Point(12, 12);
            this.buttonDevelop_PSV.Name = "buttonDevelop_PSV";
            this.buttonDevelop_PSV.Size = new System.Drawing.Size(238, 162);
            this.buttonDevelop_PSV.TabIndex = 1;
            this.buttonDevelop_PSV.Text = "График \r\n\"Кол-во стран/является ли страна развитой\"";
            this.buttonDevelop_PSV.UseVisualStyleBackColor = true;
            // 
            // buttonNational_PSV
            // 
            this.buttonNational_PSV.Location = new System.Drawing.Point(12, 179);
            this.buttonNational_PSV.Name = "buttonNational_PSV";
            this.buttonNational_PSV.Size = new System.Drawing.Size(238, 162);
            this.buttonNational_PSV.TabIndex = 2;
            this.buttonNational_PSV.Text = "График \r\n\"Кол-во стран/преобладающая национальность\"";
            this.buttonNational_PSV.UseVisualStyleBackColor = true;
            // 
            // groupBoxStats_PSV
            // 
            this.groupBoxStats_PSV.Controls.Add(this.label5);
            this.groupBoxStats_PSV.Controls.Add(this.textBox5);
            this.groupBoxStats_PSV.Controls.Add(this.label6);
            this.groupBoxStats_PSV.Controls.Add(this.textBox6);
            this.groupBoxStats_PSV.Controls.Add(this.label3);
            this.groupBoxStats_PSV.Controls.Add(this.textBox3);
            this.groupBoxStats_PSV.Controls.Add(this.label4);
            this.groupBoxStats_PSV.Controls.Add(this.textBox4);
            this.groupBoxStats_PSV.Controls.Add(this.label2);
            this.groupBoxStats_PSV.Controls.Add(this.textBox2);
            this.groupBoxStats_PSV.Controls.Add(this.label1);
            this.groupBoxStats_PSV.Controls.Add(this.textBox1);
            this.groupBoxStats_PSV.Controls.Add(this.buttonViewStats_PSV);
            this.groupBoxStats_PSV.Location = new System.Drawing.Point(12, 347);
            this.groupBoxStats_PSV.Name = "groupBoxStats_PSV";
            this.groupBoxStats_PSV.Size = new System.Drawing.Size(776, 136);
            this.groupBoxStats_PSV.TabIndex = 3;
            this.groupBoxStats_PSV.TabStop = false;
            this.groupBoxStats_PSV.Text = "Статистика";
            // 
            // buttonViewStats_PSV
            // 
            this.buttonViewStats_PSV.Location = new System.Drawing.Point(3, 18);
            this.buttonViewStats_PSV.Name = "buttonViewStats_PSV";
            this.buttonViewStats_PSV.Size = new System.Drawing.Size(102, 112);
            this.buttonViewStats_PSV.TabIndex = 0;
            this.buttonViewStats_PSV.Text = "Отобразить статистику";
            this.buttonViewStats_PSV.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(340, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(340, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(577, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(577, 102);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 9;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonViewStats_PSV;
    }
}