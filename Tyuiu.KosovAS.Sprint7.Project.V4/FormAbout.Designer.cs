namespace Tyuiu.KosovAS.Sprint7.Project.V4
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
            this.pictureBoxInfo_KAS = new System.Windows.Forms.PictureBox();
            this.labelInfo_KAS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_KAS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInfo_KAS
            // 
            this.pictureBoxInfo_KAS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo_KAS.Image")));
            this.pictureBoxInfo_KAS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxInfo_KAS.Name = "pictureBoxInfo_KAS";
            this.pictureBoxInfo_KAS.Size = new System.Drawing.Size(365, 426);
            this.pictureBoxInfo_KAS.TabIndex = 0;
            this.pictureBoxInfo_KAS.TabStop = false;
            // 
            // labelInfo_KAS
            // 
            this.labelInfo_KAS.AutoSize = true;
            this.labelInfo_KAS.Location = new System.Drawing.Point(383, 12);
            this.labelInfo_KAS.Name = "labelInfo_KAS";
            this.labelInfo_KAS.Size = new System.Drawing.Size(413, 180);
            this.labelInfo_KAS.TabIndex = 1;
            this.labelInfo_KAS.Text = resources.GetString("labelInfo_KAS.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.labelInfo_KAS);
            this.Controls.Add(this.pictureBoxInfo_KAS);
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_KAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInfo_KAS;
        private System.Windows.Forms.Label labelInfo_KAS;
    }
}