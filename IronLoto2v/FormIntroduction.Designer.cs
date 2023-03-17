namespace IronLoto2v
{
    partial class FormIntroduction
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxGamer2 = new System.Windows.Forms.TextBox();
            this.textBoxGamer1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(26, 141);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(176, 53);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Вперёд!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxGamer2
            // 
            this.textBoxGamer2.Location = new System.Drawing.Point(37, 102);
            this.textBoxGamer2.Name = "textBoxGamer2";
            this.textBoxGamer2.Size = new System.Drawing.Size(154, 20);
            this.textBoxGamer2.TabIndex = 5;
            this.textBoxGamer2.Text = "Игрок 2";
            // 
            // textBoxGamer1
            // 
            this.textBoxGamer1.Location = new System.Drawing.Point(37, 61);
            this.textBoxGamer1.Name = "textBoxGamer1";
            this.textBoxGamer1.Size = new System.Drawing.Size(154, 20);
            this.textBoxGamer1.TabIndex = 6;
            this.textBoxGamer1.Text = "Игрок 1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Впишите имена:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(237, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGamer1);
            this.Controls.Add(this.textBoxGamer2);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormIntroduction";
            this.Load += new System.EventHandler(this.FormIntroduction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxGamer2;
        private System.Windows.Forms.TextBox textBoxGamer1;
        private System.Windows.Forms.Label label1;
    }
}