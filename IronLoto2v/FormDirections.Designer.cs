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
            this.SuspendLayout();
            // 
            // richTextBoxDirections
            // 
            this.richTextBoxDirections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDirections.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDirections.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxDirections.Name = "richTextBoxDirections";
            this.richTextBoxDirections.ReadOnly = true;
            this.richTextBoxDirections.Size = new System.Drawing.Size(855, 738);
            this.richTextBoxDirections.TabIndex = 0;
            this.richTextBoxDirections.Text = resources.GetString("richTextBoxDirections.Text");
            // 
            // FormDirections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(855, 738);
            this.Controls.Add(this.richTextBoxDirections);
            this.MaximumSize = new System.Drawing.Size(871, 777);
            this.Name = "FormDirections";
            this.Text = "ЧаВо";
            this.Load += new System.EventHandler(this.FormDirections_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDirections;
    }
}