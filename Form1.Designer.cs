namespace STPToTXTConverterApp
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtSourceFilePath = new System.Windows.Forms.TextBox();
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // txtSourceFilePath
            // 
            this.txtSourceFilePath.Location = new System.Drawing.Point(12, 11);
            this.txtSourceFilePath.Name = "txtSourceFilePath";
            this.txtSourceFilePath.Size = new System.Drawing.Size(198, 20);
            this.txtSourceFilePath.TabIndex = 0;
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Location = new System.Drawing.Point(12, 37);
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.Size = new System.Drawing.Size(198, 20);
            this.txtOutputFilePath.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 528);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(198, 54);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "btnConvert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // listBoxContent
            // 
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.Location = new System.Drawing.Point(12, 63);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(1095, 459);
            this.listBoxContent.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 587);
            this.Controls.Add(this.listBoxContent);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutputFilePath);
            this.Controls.Add(this.txtSourceFilePath);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtSourceFilePath;
        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ListBox listBoxContent;
    }
}

