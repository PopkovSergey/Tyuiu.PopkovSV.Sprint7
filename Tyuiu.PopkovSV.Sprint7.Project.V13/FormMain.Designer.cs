
namespace Tyuiu.PopkovSV.Sprint7.Project.V13
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelLeft_PSV = new System.Windows.Forms.Panel();
            this.groupBoxInPut_PSV = new System.Windows.Forms.GroupBox();
            this.buttonReturn_PSV = new System.Windows.Forms.Button();
            this.buttonDelete_PSV = new System.Windows.Forms.Button();
            this.buttonAdd_PSV = new System.Windows.Forms.Button();
            this.buttonSave_PSV = new System.Windows.Forms.Button();
            this.buttonOpen_PSV = new System.Windows.Forms.Button();
            this.panelFill_PSV = new System.Windows.Forms.Panel();
            this.dataGridViewMain_PSV = new System.Windows.Forms.DataGridView();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Страна = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Столица = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Площадь = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Экономика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Население = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Национальность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitterPanel_PSV = new System.Windows.Forms.Splitter();
            this.labelName_PSV = new System.Windows.Forms.Label();
            this.panelTop_PSV = new System.Windows.Forms.Panel();
            this.buttonHelp_PSV = new System.Windows.Forms.Button();
            this.buttonInfo_PSV = new System.Windows.Forms.Button();
            this.openFileDialogMain_PSV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain_PSV = new System.Windows.Forms.SaveFileDialog();
            this.labelSearch_PSV = new System.Windows.Forms.Label();
            this.textBoxSearch_PSV = new System.Windows.Forms.TextBox();
            this.groupBoxFilt_PSV = new System.Windows.Forms.GroupBox();
            this.comboBoxFilt_PSV = new System.Windows.Forms.ComboBox();
            this.panelLeft_PSV.SuspendLayout();
            this.groupBoxInPut_PSV.SuspendLayout();
            this.panelFill_PSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_PSV)).BeginInit();
            this.panelTop_PSV.SuspendLayout();
            this.groupBoxFilt_PSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft_PSV
            // 
            this.panelLeft_PSV.Controls.Add(this.groupBoxInPut_PSV);
            this.panelLeft_PSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PSV.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_PSV.Name = "panelLeft_PSV";
            this.panelLeft_PSV.Size = new System.Drawing.Size(510, 461);
            this.panelLeft_PSV.TabIndex = 1;
            // 
            // groupBoxInPut_PSV
            // 
            this.groupBoxInPut_PSV.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxInPut_PSV.Controls.Add(this.groupBoxFilt_PSV);
            this.groupBoxInPut_PSV.Controls.Add(this.textBoxSearch_PSV);
            this.groupBoxInPut_PSV.Controls.Add(this.labelSearch_PSV);
            this.groupBoxInPut_PSV.Controls.Add(this.buttonReturn_PSV);
            this.groupBoxInPut_PSV.Controls.Add(this.buttonDelete_PSV);
            this.groupBoxInPut_PSV.Controls.Add(this.buttonAdd_PSV);
            this.groupBoxInPut_PSV.Controls.Add(this.buttonSave_PSV);
            this.groupBoxInPut_PSV.Controls.Add(this.buttonOpen_PSV);
            this.groupBoxInPut_PSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_PSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_PSV.Name = "groupBoxInPut_PSV";
            this.groupBoxInPut_PSV.Size = new System.Drawing.Size(510, 461);
            this.groupBoxInPut_PSV.TabIndex = 0;
            this.groupBoxInPut_PSV.TabStop = false;
            this.groupBoxInPut_PSV.Text = "Ввод данных:";
            // 
            // buttonReturn_PSV
            // 
            this.buttonReturn_PSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn_PSV.Image")));
            this.buttonReturn_PSV.Location = new System.Drawing.Point(330, 405);
            this.buttonReturn_PSV.Name = "buttonReturn_PSV";
            this.buttonReturn_PSV.Size = new System.Drawing.Size(75, 50);
            this.buttonReturn_PSV.TabIndex = 16;
            this.buttonReturn_PSV.UseVisualStyleBackColor = true;
            this.buttonReturn_PSV.Click += new System.EventHandler(this.buttonReturn_PSV_Click);
            // 
            // buttonDelete_PSV
            // 
            this.buttonDelete_PSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete_PSV.Image")));
            this.buttonDelete_PSV.Location = new System.Drawing.Point(249, 405);
            this.buttonDelete_PSV.Name = "buttonDelete_PSV";
            this.buttonDelete_PSV.Size = new System.Drawing.Size(75, 50);
            this.buttonDelete_PSV.TabIndex = 15;
            this.buttonDelete_PSV.UseVisualStyleBackColor = true;
            this.buttonDelete_PSV.Click += new System.EventHandler(this.buttonDelete_PSV_Click);
            // 
            // buttonAdd_PSV
            // 
            this.buttonAdd_PSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_PSV.Image")));
            this.buttonAdd_PSV.Location = new System.Drawing.Point(168, 405);
            this.buttonAdd_PSV.Name = "buttonAdd_PSV";
            this.buttonAdd_PSV.Size = new System.Drawing.Size(75, 50);
            this.buttonAdd_PSV.TabIndex = 14;
            this.buttonAdd_PSV.UseVisualStyleBackColor = true;
            this.buttonAdd_PSV.Click += new System.EventHandler(this.buttonAdd_PSV_Click);
            // 
            // buttonSave_PSV
            // 
            this.buttonSave_PSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_PSV.Image")));
            this.buttonSave_PSV.Location = new System.Drawing.Point(87, 405);
            this.buttonSave_PSV.Name = "buttonSave_PSV";
            this.buttonSave_PSV.Size = new System.Drawing.Size(75, 50);
            this.buttonSave_PSV.TabIndex = 13;
            this.buttonSave_PSV.UseVisualStyleBackColor = true;
            this.buttonSave_PSV.Click += new System.EventHandler(this.buttonSave_PSV_Click);
            // 
            // buttonOpen_PSV
            // 
            this.buttonOpen_PSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_PSV.Image")));
            this.buttonOpen_PSV.Location = new System.Drawing.Point(6, 405);
            this.buttonOpen_PSV.Name = "buttonOpen_PSV";
            this.buttonOpen_PSV.Size = new System.Drawing.Size(75, 50);
            this.buttonOpen_PSV.TabIndex = 12;
            this.buttonOpen_PSV.UseVisualStyleBackColor = true;
            this.buttonOpen_PSV.Click += new System.EventHandler(this.buttonOpen_PSV_Click);
            // 
            // panelFill_PSV
            // 
            this.panelFill_PSV.Controls.Add(this.dataGridViewMain_PSV);
            this.panelFill_PSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PSV.Location = new System.Drawing.Point(510, 100);
            this.panelFill_PSV.Name = "panelFill_PSV";
            this.panelFill_PSV.Size = new System.Drawing.Size(604, 461);
            this.panelFill_PSV.TabIndex = 2;
            // 
            // dataGridViewMain_PSV
            // 
            this.dataGridViewMain_PSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain_PSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер,
            this.Страна,
            this.Столица,
            this.Площадь,
            this.Экономика,
            this.Население,
            this.Национальность});
            this.dataGridViewMain_PSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain_PSV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMain_PSV.Name = "dataGridViewMain_PSV";
            this.dataGridViewMain_PSV.RowHeadersVisible = false;
            this.dataGridViewMain_PSV.Size = new System.Drawing.Size(604, 461);
            this.dataGridViewMain_PSV.TabIndex = 0;
            this.dataGridViewMain_PSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Номер
            // 
            this.Номер.HeaderText = "Номер";
            this.Номер.Name = "Номер";
            this.Номер.ReadOnly = true;
            // 
            // Страна
            // 
            this.Страна.HeaderText = "Название страны";
            this.Страна.Name = "Страна";
            this.Страна.ReadOnly = true;
            // 
            // Столица
            // 
            this.Столица.HeaderText = "Столица";
            this.Столица.Name = "Столица";
            this.Столица.ReadOnly = true;
            // 
            // Площадь
            // 
            this.Площадь.HeaderText = "Площадь территории";
            this.Площадь.Name = "Площадь";
            this.Площадь.ReadOnly = true;
            // 
            // Экономика
            // 
            this.Экономика.HeaderText = "Является ли страна развитой в экономическом отношении";
            this.Экономика.Name = "Экономика";
            this.Экономика.ReadOnly = true;
            // 
            // Население
            // 
            this.Население.HeaderText = "Количество населения";
            this.Население.Name = "Население";
            this.Население.ReadOnly = true;
            // 
            // Национальность
            // 
            this.Национальность.HeaderText = "Преобладающая национальность";
            this.Национальность.Name = "Национальность";
            this.Национальность.ReadOnly = true;
            // 
            // splitterPanel_PSV
            // 
            this.splitterPanel_PSV.Location = new System.Drawing.Point(510, 100);
            this.splitterPanel_PSV.Name = "splitterPanel_PSV";
            this.splitterPanel_PSV.Size = new System.Drawing.Size(3, 461);
            this.splitterPanel_PSV.TabIndex = 3;
            this.splitterPanel_PSV.TabStop = false;
            // 
            // labelName_PSV
            // 
            this.labelName_PSV.AutoSize = true;
            this.labelName_PSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_PSV.ForeColor = System.Drawing.Color.White;
            this.labelName_PSV.Location = new System.Drawing.Point(3, 9);
            this.labelName_PSV.Name = "labelName_PSV";
            this.labelName_PSV.Size = new System.Drawing.Size(438, 73);
            this.labelName_PSV.TabIndex = 0;
            this.labelName_PSV.Text = "ГЕОГРАФИЯ";
            // 
            // panelTop_PSV
            // 
            this.panelTop_PSV.BackColor = System.Drawing.Color.Turquoise;
            this.panelTop_PSV.Controls.Add(this.buttonHelp_PSV);
            this.panelTop_PSV.Controls.Add(this.buttonInfo_PSV);
            this.panelTop_PSV.Controls.Add(this.labelName_PSV);
            this.panelTop_PSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PSV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PSV.Name = "panelTop_PSV";
            this.panelTop_PSV.Size = new System.Drawing.Size(1114, 100);
            this.panelTop_PSV.TabIndex = 0;
            // 
            // buttonHelp_PSV
            // 
            this.buttonHelp_PSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_PSV.Image")));
            this.buttonHelp_PSV.Location = new System.Drawing.Point(945, 12);
            this.buttonHelp_PSV.Name = "buttonHelp_PSV";
            this.buttonHelp_PSV.Size = new System.Drawing.Size(70, 70);
            this.buttonHelp_PSV.TabIndex = 2;
            this.buttonHelp_PSV.UseVisualStyleBackColor = true;
            this.buttonHelp_PSV.Click += new System.EventHandler(this.buttonHelp_PSV_Click);
            // 
            // buttonInfo_PSV
            // 
            this.buttonInfo_PSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_PSV.Image")));
            this.buttonInfo_PSV.Location = new System.Drawing.Point(1032, 12);
            this.buttonInfo_PSV.Name = "buttonInfo_PSV";
            this.buttonInfo_PSV.Size = new System.Drawing.Size(70, 70);
            this.buttonInfo_PSV.TabIndex = 1;
            this.buttonInfo_PSV.UseVisualStyleBackColor = true;
            this.buttonInfo_PSV.Click += new System.EventHandler(this.buttonInfo_PSV_Click);
            // 
            // openFileDialogMain_PSV
            // 
            this.openFileDialogMain_PSV.FileName = "openFileDialog1";
            // 
            // labelSearch_PSV
            // 
            this.labelSearch_PSV.AutoSize = true;
            this.labelSearch_PSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch_PSV.Location = new System.Drawing.Point(10, 25);
            this.labelSearch_PSV.Name = "labelSearch_PSV";
            this.labelSearch_PSV.Size = new System.Drawing.Size(100, 31);
            this.labelSearch_PSV.TabIndex = 17;
            this.labelSearch_PSV.Text = "Поиск:";
            // 
            // textBoxSearch_PSV
            // 
            this.textBoxSearch_PSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch_PSV.Location = new System.Drawing.Point(118, 25);
            this.textBoxSearch_PSV.Multiline = true;
            this.textBoxSearch_PSV.Name = "textBoxSearch_PSV";
            this.textBoxSearch_PSV.Size = new System.Drawing.Size(225, 31);
            this.textBoxSearch_PSV.TabIndex = 18;
            this.textBoxSearch_PSV.TextChanged += new System.EventHandler(this.textBoxSearch_PSV_TextChanged);
            // 
            // groupBoxFilt_PSV
            // 
            this.groupBoxFilt_PSV.Controls.Add(this.comboBoxFilt_PSV);
            this.groupBoxFilt_PSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilt_PSV.Location = new System.Drawing.Point(16, 86);
            this.groupBoxFilt_PSV.Name = "groupBoxFilt_PSV";
            this.groupBoxFilt_PSV.Size = new System.Drawing.Size(171, 84);
            this.groupBoxFilt_PSV.TabIndex = 19;
            this.groupBoxFilt_PSV.TabStop = false;
            this.groupBoxFilt_PSV.Text = "Сортировка";
            // 
            // comboBoxFilt_PSV
            // 
            this.comboBoxFilt_PSV.FormattingEnabled = true;
            this.comboBoxFilt_PSV.Location = new System.Drawing.Point(6, 48);
            this.comboBoxFilt_PSV.Name = "comboBoxFilt_PSV";
            this.comboBoxFilt_PSV.Size = new System.Drawing.Size(159, 28);
            this.comboBoxFilt_PSV.TabIndex = 0;
            this.comboBoxFilt_PSV.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilt_PSV_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 561);
            this.Controls.Add(this.splitterPanel_PSV);
            this.Controls.Add(this.panelFill_PSV);
            this.Controls.Add(this.panelLeft_PSV);
            this.Controls.Add(this.panelTop_PSV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "География";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelLeft_PSV.ResumeLayout(false);
            this.groupBoxInPut_PSV.ResumeLayout(false);
            this.groupBoxInPut_PSV.PerformLayout();
            this.panelFill_PSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_PSV)).EndInit();
            this.panelTop_PSV.ResumeLayout(false);
            this.panelTop_PSV.PerformLayout();
            this.groupBoxFilt_PSV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft_PSV;
        private System.Windows.Forms.GroupBox groupBoxInPut_PSV;
        private System.Windows.Forms.Panel panelFill_PSV;
        private System.Windows.Forms.Splitter splitterPanel_PSV;
        private System.Windows.Forms.Label labelName_PSV;
        private System.Windows.Forms.Panel panelTop_PSV;
        private System.Windows.Forms.Button buttonInfo_PSV;
        private System.Windows.Forms.Button buttonHelp_PSV;
        private System.Windows.Forms.Button buttonSave_PSV;
        private System.Windows.Forms.Button buttonOpen_PSV;
        private System.Windows.Forms.Button buttonAdd_PSV;
        private System.Windows.Forms.Button buttonReturn_PSV;
        private System.Windows.Forms.Button buttonDelete_PSV;
        private System.Windows.Forms.DataGridView dataGridViewMain_PSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain_PSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Страна;
        private System.Windows.Forms.DataGridViewTextBoxColumn Столица;
        private System.Windows.Forms.DataGridViewTextBoxColumn Площадь;
        private System.Windows.Forms.DataGridViewTextBoxColumn Экономика;
        private System.Windows.Forms.DataGridViewTextBoxColumn Население;
        private System.Windows.Forms.DataGridViewTextBoxColumn Национальность;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain_PSV;
        private System.Windows.Forms.TextBox textBoxSearch_PSV;
        private System.Windows.Forms.Label labelSearch_PSV;
        private System.Windows.Forms.GroupBox groupBoxFilt_PSV;
        private System.Windows.Forms.ComboBox comboBoxFilt_PSV;
    }
}

