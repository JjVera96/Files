namespace Archivos
{
    partial class FileManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonFile = new System.Windows.Forms.Button();
            this.TitleFile = new System.Windows.Forms.Label();
            this.ReadFile = new System.Windows.Forms.Button();
            this.ContentFile = new System.Windows.Forms.TextBox();
            this.SaveFile = new System.Windows.Forms.Button();
            this.AddLine = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonFile
            // 
            this.BotonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonFile.AutoEllipsis = true;
            this.BotonFile.Location = new System.Drawing.Point(691, 36);
            this.BotonFile.Name = "BotonFile";
            this.BotonFile.Size = new System.Drawing.Size(86, 25);
            this.BotonFile.TabIndex = 0;
            this.BotonFile.Text = "Open file";
            this.BotonFile.UseVisualStyleBackColor = true;
            this.BotonFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitleFile
            // 
            this.TitleFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleFile.AutoEllipsis = true;
            this.TitleFile.Location = new System.Drawing.Point(22, 36);
            this.TitleFile.Name = "TitleFile";
            this.TitleFile.Size = new System.Drawing.Size(663, 25);
            this.TitleFile.TabIndex = 1;
            this.TitleFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(691, 67);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(86, 23);
            this.ReadFile.TabIndex = 2;
            this.ReadFile.Text = "Read file";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // ContentFile
            // 
            this.ContentFile.Location = new System.Drawing.Point(22, 96);
            this.ContentFile.Multiline = true;
            this.ContentFile.Name = "ContentFile";
            this.ContentFile.Size = new System.Drawing.Size(663, 258);
            this.ContentFile.TabIndex = 3;
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(691, 96);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(86, 23);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.Text = "Save file";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // AddLine
            // 
            this.AddLine.Location = new System.Drawing.Point(691, 125);
            this.AddLine.Name = "AddLine";
            this.AddLine.Size = new System.Drawing.Size(86, 23);
            this.AddLine.TabIndex = 5;
            this.AddLine.Text = "Add line";
            this.AddLine.UseVisualStyleBackColor = true;
            this.AddLine.Click += new System.EventHandler(this.AddLine_Click);
            // 
            // Line
            // 
            this.Line.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Line.Location = new System.Drawing.Point(22, 67);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(663, 23);
            this.Line.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Other";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.AddLine);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.ContentFile);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.TitleFile);
            this.Controls.Add(this.BotonFile);
            this.Name = "FileManagement";
            this.Text = "File Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BotonFile;
        private Label TitleFile;
        private Button ReadFile;
        private TextBox ContentFile;
        private Button SaveFile;
        private Button AddLine;
        private TextBox Line;
        private Button button1;
    }
}