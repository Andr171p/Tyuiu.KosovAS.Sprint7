namespace Tyuiu.KosovAS.Sprint7.Project.V4
{
    partial class FormTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.groupBoxTask_KAS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAS = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KAS
            // 
            this.groupBoxTask_KAS.Controls.Add(this.textBoxTask_KAS);
            this.groupBoxTask_KAS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KAS.Name = "groupBoxTask_KAS";
            this.groupBoxTask_KAS.Size = new System.Drawing.Size(776, 264);
            this.groupBoxTask_KAS.TabIndex = 0;
            this.groupBoxTask_KAS.TabStop = false;
            this.groupBoxTask_KAS.Text = "Вариант 4";
            // 
            // textBoxTask_KAS
            // 
            this.textBoxTask_KAS.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_KAS.Multiline = true;
            this.textBoxTask_KAS.Name = "textBoxTask_KAS";
            this.textBoxTask_KAS.ReadOnly = true;
            this.textBoxTask_KAS.Size = new System.Drawing.Size(764, 232);
            this.textBoxTask_KAS.TabIndex = 0;
            this.textBoxTask_KAS.Text = resources.GetString("textBoxTask_KAS.Text");
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.groupBoxTask_KAS);
            this.Name = "FormTask";
            this.Text = "Техническое задание";
            this.groupBoxTask_KAS.ResumeLayout(false);
            this.groupBoxTask_KAS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KAS;
        private System.Windows.Forms.TextBox textBoxTask_KAS;
    }
}