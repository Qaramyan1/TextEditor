namespace TextEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lightmode = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.Button();
            this.saveas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lightmode);
            this.panel1.Controls.Add(this.openfile);
            this.panel1.Controls.Add(this.saveas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 395);
            this.panel1.TabIndex = 1;
            // 
            // lightmode
            // 
            this.lightmode.BackColor = System.Drawing.Color.DarkGray;
            this.lightmode.FlatAppearance.BorderSize = 0;
            this.lightmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightmode.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lightmode.ForeColor = System.Drawing.Color.Black;
            this.lightmode.Location = new System.Drawing.Point(-22, 188);
            this.lightmode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lightmode.Name = "lightmode";
            this.lightmode.Size = new System.Drawing.Size(131, 28);
            this.lightmode.TabIndex = 5;
            this.lightmode.Text = "  💡Light mode";
            this.lightmode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lightmode.UseVisualStyleBackColor = false;
            this.lightmode.Click += new System.EventHandler(this.button3_Click);
            // 
            // openfile
            // 
            this.openfile.BackColor = System.Drawing.Color.DarkGray;
            this.openfile.FlatAppearance.BorderSize = 0;
            this.openfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openfile.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openfile.ForeColor = System.Drawing.Color.Black;
            this.openfile.Location = new System.Drawing.Point(-2, 15);
            this.openfile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(112, 26);
            this.openfile.TabIndex = 4;
            this.openfile.Text = "📂 Open file";
            this.openfile.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.openfile.UseVisualStyleBackColor = false;
            this.openfile.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveas
            // 
            this.saveas.BackColor = System.Drawing.Color.DarkGray;
            this.saveas.FlatAppearance.BorderSize = 0;
            this.saveas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveas.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveas.ForeColor = System.Drawing.Color.Black;
            this.saveas.Location = new System.Drawing.Point(-10, 360);
            this.saveas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.saveas.Name = "saveas";
            this.saveas.Size = new System.Drawing.Size(100, 25);
            this.saveas.TabIndex = 3;
            this.saveas.Text = "  💾 Save As";
            this.saveas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.saveas.UseVisualStyleBackColor = false;
            this.saveas.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(98, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(680, 395);
            this.textBox1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(778, 395);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Notes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private TextBox textBox1;
        private Button saveas;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button openfile;
        private Button lightmode;
    }
}