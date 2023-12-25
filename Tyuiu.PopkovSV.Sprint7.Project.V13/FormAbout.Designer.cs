
namespace Tyuiu.PopkovSV.Sprint7.Project.V13
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_PSV = new System.Windows.Forms.PictureBox();
            this.labelInfo_PSV = new System.Windows.Forms.Label();
            this.buttonOK_PSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PSV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_PSV
            // 
            this.pictureBoxAvatar_PSV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PSV.Image")));
            this.pictureBoxAvatar_PSV.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxAvatar_PSV.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAvatar_PSV.Name = "pictureBoxAvatar_PSV";
            this.pictureBoxAvatar_PSV.Size = new System.Drawing.Size(101, 116);
            this.pictureBoxAvatar_PSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_PSV.TabIndex = 0;
            this.pictureBoxAvatar_PSV.TabStop = false;
            // 
            // labelInfo_PSV
            // 
            this.labelInfo_PSV.AutoSize = true;
            this.labelInfo_PSV.Location = new System.Drawing.Point(125, 15);
            this.labelInfo_PSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_PSV.Name = "labelInfo_PSV";
            this.labelInfo_PSV.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_PSV.TabIndex = 1;
            this.labelInfo_PSV.Text = resources.GetString("labelInfo_PSV.Text");
            // 
            // buttonOK_PSV
            // 
            this.buttonOK_PSV.Location = new System.Drawing.Point(406, 172);
            this.buttonOK_PSV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK_PSV.Name = "buttonOK_PSV";
            this.buttonOK_PSV.Size = new System.Drawing.Size(116, 31);
            this.buttonOK_PSV.TabIndex = 2;
            this.buttonOK_PSV.Text = "OK";
            this.buttonOK_PSV.UseVisualStyleBackColor = true;
            this.buttonOK_PSV.Click += new System.EventHandler(this.buttonOK_PSV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 218);
            this.Controls.Add(this.buttonOK_PSV);
            this.Controls.Add(this.labelInfo_PSV);
            this.Controls.Add(this.pictureBoxAvatar_PSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_PSV;
        private System.Windows.Forms.Label labelInfo_PSV;
        private System.Windows.Forms.Button buttonOK_PSV;
    }
}