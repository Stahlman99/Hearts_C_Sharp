namespace Hearts
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
            this.DisplayText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayText
            // 
            this.DisplayText.Location = new System.Drawing.Point(12, 12);
            this.DisplayText.Multiline = true;
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayText.Size = new System.Drawing.Size(260, 237);
            this.DisplayText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display Cards";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisplayText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayText;
        private System.Windows.Forms.Button button1;
    }
}

