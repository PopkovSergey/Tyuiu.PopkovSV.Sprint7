
namespace Tyuiu.PopkovSV.Sprint7.Project.V13
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.buttonOkGuide_PSV = new System.Windows.Forms.Button();
            this.labelGuide_PSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOkGuide_PSV
            // 
            this.buttonOkGuide_PSV.Location = new System.Drawing.Point(782, 355);
            this.buttonOkGuide_PSV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOkGuide_PSV.Name = "buttonOkGuide_PSV";
            this.buttonOkGuide_PSV.Size = new System.Drawing.Size(131, 43);
            this.buttonOkGuide_PSV.TabIndex = 1;
            this.buttonOkGuide_PSV.Text = "OK";
            this.buttonOkGuide_PSV.UseVisualStyleBackColor = true;
            this.buttonOkGuide_PSV.Click += new System.EventHandler(this.buttonOkGuide_PSV_Click);
            // 
            // labelGuide_PSV
            // 
            this.labelGuide_PSV.AutoSize = true;
            this.labelGuide_PSV.Location = new System.Drawing.Point(3, 11);
            this.labelGuide_PSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuide_PSV.Name = "labelGuide_PSV";
            this.labelGuide_PSV.Size = new System.Drawing.Size(910, 340);
            this.labelGuide_PSV.TabIndex = 2;
            this.labelGuide_PSV.Text = resources.GetString("labelGuide_PSV.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 409);
            this.Controls.Add(this.labelGuide_PSV);
            this.Controls.Add(this.buttonOkGuide_PSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOkGuide_PSV;
        private System.Windows.Forms.Label labelGuide_PSV;
    }
}