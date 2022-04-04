namespace IronLoto2v
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.dataGridViewGamer1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewGamer2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGamer1
            // 
            this.dataGridViewGamer1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewGamer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer1.ColumnHeadersVisible = false;
            this.dataGridViewGamer1.Location = new System.Drawing.Point(1, 96);
            this.dataGridViewGamer1.Name = "dataGridViewGamer1";
            this.dataGridViewGamer1.RowHeadersVisible = false;
            this.dataGridViewGamer1.Size = new System.Drawing.Size(510, 558);
            this.dataGridViewGamer1.TabIndex = 2;
            // 
            // dataGridViewGamer2
            // 
            this.dataGridViewGamer2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewGamer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer2.ColumnHeadersVisible = false;
            this.dataGridViewGamer2.Location = new System.Drawing.Point(932, 106);
            this.dataGridViewGamer2.Name = "dataGridViewGamer2";
            this.dataGridViewGamer2.RowHeadersVisible = false;
            this.dataGridViewGamer2.Size = new System.Drawing.Size(510, 558);
            this.dataGridViewGamer2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1445, 654);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 654);
            this.Controls.Add(this.dataGridViewGamer2);
            this.Controls.Add(this.dataGridViewGamer1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGame";
            this.Text = "Осетинское лото";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGamer1;
        private System.Windows.Forms.DataGridView dataGridViewGamer2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}