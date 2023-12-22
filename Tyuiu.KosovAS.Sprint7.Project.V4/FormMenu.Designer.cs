namespace Tyuiu.KosovAS.Sprint7.Project.V4
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonInfo_KAS = new System.Windows.Forms.Button();
            this.buttonLibrary_KAS = new System.Windows.Forms.Button();
            this.buttonTask_KAS = new System.Windows.Forms.Button();
            this.toolTipMenu_KAS = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonInfo_KAS
            // 
            this.buttonInfo_KAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonInfo_KAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_KAS.Image")));
            this.buttonInfo_KAS.Location = new System.Drawing.Point(35, 35);
            this.buttonInfo_KAS.Name = "buttonInfo_KAS";
            this.buttonInfo_KAS.Size = new System.Drawing.Size(128, 69);
            this.buttonInfo_KAS.TabIndex = 0;
            this.toolTipMenu_KAS.SetToolTip(this.buttonInfo_KAS, "Информация о проекте");
            this.buttonInfo_KAS.UseVisualStyleBackColor = false;
            this.buttonInfo_KAS.Click += new System.EventHandler(this.buttonInfo_KAS_Click);
            // 
            // buttonLibrary_KAS
            // 
            this.buttonLibrary_KAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonLibrary_KAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonLibrary_KAS.Image")));
            this.buttonLibrary_KAS.Location = new System.Drawing.Point(35, 145);
            this.buttonLibrary_KAS.Name = "buttonLibrary_KAS";
            this.buttonLibrary_KAS.Size = new System.Drawing.Size(128, 69);
            this.buttonLibrary_KAS.TabIndex = 1;
            this.toolTipMenu_KAS.SetToolTip(this.buttonLibrary_KAS, "Библиотека");
            this.buttonLibrary_KAS.UseVisualStyleBackColor = false;
            this.buttonLibrary_KAS.Click += new System.EventHandler(this.buttonLibrary_KAS_Click);
            // 
            // buttonTask_KAS
            // 
            this.buttonTask_KAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTask_KAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonTask_KAS.Image")));
            this.buttonTask_KAS.Location = new System.Drawing.Point(35, 247);
            this.buttonTask_KAS.Name = "buttonTask_KAS";
            this.buttonTask_KAS.Size = new System.Drawing.Size(128, 69);
            this.buttonTask_KAS.TabIndex = 2;
            this.toolTipMenu_KAS.SetToolTip(this.buttonTask_KAS, "Техническое задание");
            this.buttonTask_KAS.UseVisualStyleBackColor = false;
            this.buttonTask_KAS.Click += new System.EventHandler(this.buttonTask_KAS_Click);
            // 
            // toolTipMenu_KAS
            // 
            this.toolTipMenu_KAS.IsBalloon = true;
            this.toolTipMenu_KAS.ToolTipTitle = "Подсказка";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 434);
            this.Controls.Add(this.buttonTask_KAS);
            this.Controls.Add(this.buttonLibrary_KAS);
            this.Controls.Add(this.buttonInfo_KAS);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonInfo_KAS;
        private System.Windows.Forms.Button buttonLibrary_KAS;
        private System.Windows.Forms.Button buttonTask_KAS;
        private System.Windows.Forms.ToolTip toolTipMenu_KAS;
    }
}

