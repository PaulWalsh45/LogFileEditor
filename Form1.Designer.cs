namespace LogFileEditor
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
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtWriteFilepath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReadFilepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAppendFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteFile.Location = new System.Drawing.Point(41, 266);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(110, 32);
            this.btnWriteFile.TabIndex = 7;
            this.btnWriteFile.Text = "Write File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(41, 105);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(110, 32);
            this.btnReadFile.TabIndex = 8;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtWriteFilepath
            // 
            this.txtWriteFilepath.Location = new System.Drawing.Point(199, 232);
            this.txtWriteFilepath.Name = "txtWriteFilepath";
            this.txtWriteFilepath.Size = new System.Drawing.Size(254, 20);
            this.txtWriteFilepath.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Writefile Filepath";
            // 
            // txtReadFilepath
            // 
            this.txtReadFilepath.Location = new System.Drawing.Point(199, 70);
            this.txtReadFilepath.Name = "txtReadFilepath";
            this.txtReadFilepath.Size = new System.Drawing.Size(254, 20);
            this.txtReadFilepath.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Readfile Filepath";
            // 
            // btnAppendFile
            // 
            this.btnAppendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppendFile.Location = new System.Drawing.Point(199, 266);
            this.btnAppendFile.Name = "btnAppendFile";
            this.btnAppendFile.Size = new System.Drawing.Size(107, 32);
            this.btnAppendFile.TabIndex = 9;
            this.btnAppendFile.Text = "AppendFile";
            this.btnAppendFile.UseVisualStyleBackColor = true;
            this.btnAppendFile.Click += new System.EventHandler(this.btnAppendFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 369);
            this.Controls.Add(this.btnAppendFile);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.txtWriteFilepath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReadFilepath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtWriteFilepath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReadFilepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppendFile;
    }
}

