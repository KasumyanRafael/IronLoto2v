namespace IronLoto2v
{
    partial class FormDirections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDirections));
            this.richTextBoxDirections = new System.Windows.Forms.RichTextBox();
            this.webBrowserDirections = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // richTextBoxDirections
            // 
            this.richTextBoxDirections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDirections.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDirections.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxDirections.Name = "richTextBoxDirections";
            this.richTextBoxDirections.ReadOnly = true;
            this.richTextBoxDirections.Size = new System.Drawing.Size(671, 628);
            this.richTextBoxDirections.TabIndex = 0;
            this.richTextBoxDirections.Text = resources.GetString("richTextBoxDirections.Text");
            // 
            // webBrowserDirections
            // 
            this.webBrowserDirections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserDirections.Location = new System.Drawing.Point(0, 0);
            this.webBrowserDirections.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserDirections.Name = "webBrowserDirections";
            this.webBrowserDirections.Size = new System.Drawing.Size(671, 628);
            this.webBrowserDirections.TabIndex = 1;
            this.webBrowserDirections.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // FormDirections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(671, 628);
            this.Controls.Add(this.webBrowserDirections);
            this.Controls.Add(this.richTextBoxDirections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(871, 777);
            this.Name = "FormDirections";
            this.Text = "ЧаВо";
            this.Load += new System.EventHandler(this.FormDirections_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDirections;
        private System.Windows.Forms.WebBrowser webBrowserDirections;
    }
}