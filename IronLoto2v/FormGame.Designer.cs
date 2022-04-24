﻿namespace IronLoto2v
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewGamer1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewGamer2 = new System.Windows.Forms.DataGridView();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.labelWord = new System.Windows.Forms.Label();
            this.buttonNoWord = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerChangePicture = new System.Windows.Forms.Timer(this.components);
            this.menuStripSettings = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGamer1
            // 
            this.dataGridViewGamer1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewGamer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer1.ColumnHeadersVisible = false;
            this.dataGridViewGamer1.Location = new System.Drawing.Point(1, 96);
            this.dataGridViewGamer1.Name = "dataGridViewGamer1";
            this.dataGridViewGamer1.RowHeadersVisible = false;
            this.dataGridViewGamer1.Size = new System.Drawing.Size(510, 558);
            this.dataGridViewGamer1.TabIndex = 2;
            this.dataGridViewGamer1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGamer1_CellContentClick);
            // 
            // dataGridViewGamer2
            // 
            this.dataGridViewGamer2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewGamer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer2.ColumnHeadersVisible = false;
            this.dataGridViewGamer2.Location = new System.Drawing.Point(932, 96);
            this.dataGridViewGamer2.Name = "dataGridViewGamer2";
            this.dataGridViewGamer2.RowHeadersVisible = false;
            this.dataGridViewGamer2.Size = new System.Drawing.Size(510, 558);
            this.dataGridViewGamer2.TabIndex = 3;
            this.dataGridViewGamer2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGamer2_CellContentClick);
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxShow.Location = new System.Drawing.Point(517, 141);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(409, 387);
            this.pictureBoxShow.TabIndex = 4;
            this.pictureBoxShow.TabStop = false;
            // 
            // labelWord
            // 
            this.labelWord.BackColor = System.Drawing.Color.Yellow;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.Location = new System.Drawing.Point(578, 531);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(295, 59);
            this.labelWord.TabIndex = 5;
            this.labelWord.Text = "_ _";
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNoWord
            // 
            this.buttonNoWord.BackColor = System.Drawing.Color.Red;
            this.buttonNoWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNoWord.Location = new System.Drawing.Point(578, 593);
            this.buttonNoWord.Name = "buttonNoWord";
            this.buttonNoWord.Size = new System.Drawing.Size(295, 61);
            this.buttonNoWord.TabIndex = 6;
            this.buttonNoWord.Text = "Нет слова";
            this.buttonNoWord.UseVisualStyleBackColor = false;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Yellow;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(578, 79);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(295, 59);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripSettings
            // 
            this.menuStripSettings.BackColor = System.Drawing.Color.Yellow;
            this.menuStripSettings.Location = new System.Drawing.Point(0, 0);
            this.menuStripSettings.Name = "menuStripSettings";
            this.menuStripSettings.Size = new System.Drawing.Size(1445, 24);
            this.menuStripSettings.TabIndex = 8;
            this.menuStripSettings.Text = "menuStrip1";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1445, 654);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonNoWord);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.dataGridViewGamer2);
            this.Controls.Add(this.dataGridViewGamer1);
            this.Controls.Add(this.menuStripSettings);
            this.MainMenuStrip = this.menuStripSettings;
            this.Name = "FormGame";
            this.Text = "Раунд 1. Угадывание слов по картинке, запоминание переводов";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGamer1;
        private System.Windows.Forms.DataGridView dataGridViewGamer2;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button buttonNoWord;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerChangePicture;
        private System.Windows.Forms.MenuStrip menuStripSettings;
    }
}