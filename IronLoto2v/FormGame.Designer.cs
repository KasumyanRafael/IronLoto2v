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
            this.components = new System.ComponentModel.Container();
            this.timerChangePicture = new System.Windows.Forms.Timer(this.components);
            this.buttonNoWord = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.dataGridViewGamer1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewGamer2 = new System.Windows.Forms.DataGridView();
            this.menuStripSettings = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изПриложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спецвозможностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подсказкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обИгреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFirstGamerCount = new System.Windows.Forms.Label();
            this.labelSecondGamerCount = new System.Windows.Forms.Label();
            this.labelFirstGamer = new System.Windows.Forms.Label();
            this.labelSecondGamer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).BeginInit();
            this.menuStripSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerChangePicture
            // 
            this.timerChangePicture.Tick += new System.EventHandler(this.timerChangePicture_Tick);
            // 
            // buttonNoWord
            // 
            this.buttonNoWord.BackColor = System.Drawing.Color.Red;
            this.buttonNoWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNoWord.Location = new System.Drawing.Point(578, 593);
            this.buttonNoWord.Name = "buttonNoWord";
            this.buttonNoWord.Size = new System.Drawing.Size(295, 61);
            this.buttonNoWord.TabIndex = 13;
            this.buttonNoWord.Text = "Нет слова";
            this.buttonNoWord.UseVisualStyleBackColor = false;
            // 
            // labelWord
            // 
            this.labelWord.BackColor = System.Drawing.Color.Yellow;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.Location = new System.Drawing.Point(578, 531);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(295, 59);
            this.labelWord.TabIndex = 12;
            this.labelWord.Text = "_ _";
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxShow.Location = new System.Drawing.Point(521, 141);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(409, 387);
            this.pictureBoxShow.TabIndex = 17;
            this.pictureBoxShow.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Yellow;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(673, 79);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(115, 59);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewGamer1
            // 
            this.dataGridViewGamer1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewGamer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer1.ColumnHeadersVisible = false;
            this.dataGridViewGamer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewGamer1.Enabled = false;
            this.dataGridViewGamer1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGamer1.Name = "dataGridViewGamer1";
            this.dataGridViewGamer1.ReadOnly = true;
            this.dataGridViewGamer1.RowHeadersVisible = false;
            this.dataGridViewGamer1.Size = new System.Drawing.Size(510, 672);
            this.dataGridViewGamer1.TabIndex = 16;
            // 
            // dataGridViewGamer2
            // 
            this.dataGridViewGamer2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewGamer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer2.ColumnHeadersVisible = false;
            this.dataGridViewGamer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewGamer2.Enabled = false;
            this.dataGridViewGamer2.Location = new System.Drawing.Point(946, 0);
            this.dataGridViewGamer2.Name = "dataGridViewGamer2";
            this.dataGridViewGamer2.ReadOnly = true;
            this.dataGridViewGamer2.RowHeadersVisible = false;
            this.dataGridViewGamer2.Size = new System.Drawing.Size(511, 672);
            this.dataGridViewGamer2.TabIndex = 18;
            // 
            // menuStripSettings
            // 
            this.menuStripSettings.BackColor = System.Drawing.Color.Yellow;
            this.menuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStripSettings.Location = new System.Drawing.Point(510, 0);
            this.menuStripSettings.Name = "menuStripSettings";
            this.menuStripSettings.Size = new System.Drawing.Size(436, 24);
            this.menuStripSettings.TabIndex = 19;
            this.menuStripSettings.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.спецвозможностиToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изПриложенияToolStripMenuItem,
            this.сменаПользователейToolStripMenuItem});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // изПриложенияToolStripMenuItem
            // 
            this.изПриложенияToolStripMenuItem.Name = "изПриложенияToolStripMenuItem";
            this.изПриложенияToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.изПриложенияToolStripMenuItem.Text = "Из приложения";
            // 
            // сменаПользователейToolStripMenuItem
            // 
            this.сменаПользователейToolStripMenuItem.Name = "сменаПользователейToolStripMenuItem";
            this.сменаПользователейToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.сменаПользователейToolStripMenuItem.Text = "Смена пользователей";
            // 
            // спецвозможностиToolStripMenuItem
            // 
            this.спецвозможностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подсказкаToolStripMenuItem});
            this.спецвозможностиToolStripMenuItem.Name = "спецвозможностиToolStripMenuItem";
            this.спецвозможностиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.спецвозможностиToolStripMenuItem.Text = "Спец.возможности";
            // 
            // подсказкаToolStripMenuItem
            // 
            this.подсказкаToolStripMenuItem.Name = "подсказкаToolStripMenuItem";
            this.подсказкаToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.подсказкаToolStripMenuItem.Text = "Подсказка";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обИгреToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // обИгреToolStripMenuItem
            // 
            this.обИгреToolStripMenuItem.Name = "обИгреToolStripMenuItem";
            this.обИгреToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.обИгреToolStripMenuItem.Text = "Об игре";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSecondGamer);
            this.panel1.Controls.Add(this.labelFirstGamer);
            this.panel1.Controls.Add(this.labelSecondGamerCount);
            this.panel1.Controls.Add(this.labelFirstGamerCount);
            this.panel1.Controls.Add(this.menuStripSettings);
            this.panel1.Controls.Add(this.dataGridViewGamer2);
            this.panel1.Controls.Add(this.dataGridViewGamer1);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.pictureBoxShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1457, 672);
            this.panel1.TabIndex = 16;
            // 
            // labelFirstGamerCount
            // 
            this.labelFirstGamerCount.BackColor = System.Drawing.Color.Blue;
            this.labelFirstGamerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstGamerCount.ForeColor = System.Drawing.Color.White;
            this.labelFirstGamerCount.Location = new System.Drawing.Point(518, 28);
            this.labelFirstGamerCount.Name = "labelFirstGamerCount";
            this.labelFirstGamerCount.Size = new System.Drawing.Size(134, 69);
            this.labelFirstGamerCount.TabIndex = 20;
            this.labelFirstGamerCount.Text = "0";
            this.labelFirstGamerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondGamerCount
            // 
            this.labelSecondGamerCount.BackColor = System.Drawing.Color.Red;
            this.labelSecondGamerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondGamerCount.ForeColor = System.Drawing.Color.White;
            this.labelSecondGamerCount.Location = new System.Drawing.Point(806, 28);
            this.labelSecondGamerCount.Name = "labelSecondGamerCount";
            this.labelSecondGamerCount.Size = new System.Drawing.Size(134, 69);
            this.labelSecondGamerCount.TabIndex = 21;
            this.labelSecondGamerCount.Text = "0";
            this.labelSecondGamerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstGamer
            // 
            this.labelFirstGamer.BackColor = System.Drawing.Color.Blue;
            this.labelFirstGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstGamer.ForeColor = System.Drawing.Color.White;
            this.labelFirstGamer.Location = new System.Drawing.Point(518, 106);
            this.labelFirstGamer.Name = "labelFirstGamer";
            this.labelFirstGamer.Size = new System.Drawing.Size(134, 32);
            this.labelFirstGamer.TabIndex = 22;
            this.labelFirstGamer.Text = "_ _";
            this.labelFirstGamer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondGamer
            // 
            this.labelSecondGamer.BackColor = System.Drawing.Color.Red;
            this.labelSecondGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondGamer.ForeColor = System.Drawing.Color.White;
            this.labelSecondGamer.Location = new System.Drawing.Point(806, 106);
            this.labelSecondGamer.Name = "labelSecondGamer";
            this.labelSecondGamer.Size = new System.Drawing.Size(134, 32);
            this.labelSecondGamer.TabIndex = 23;
            this.labelSecondGamer.Text = "_ _";
            this.labelSecondGamer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1457, 672);
            this.Controls.Add(this.buttonNoWord);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FormGame";
            this.Text = "Раунд 1. Угадывание слов по картинке, запоминание переводов";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).EndInit();
            this.menuStripSettings.ResumeLayout(false);
            this.menuStripSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerChangePicture;
        private System.Windows.Forms.Button buttonNoWord;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DataGridView dataGridViewGamer1;
        private System.Windows.Forms.DataGridView dataGridViewGamer2;
        private System.Windows.Forms.MenuStrip menuStripSettings;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изПриложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спецвозможностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подсказкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обИгреToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSecondGamer;
        private System.Windows.Forms.Label labelFirstGamer;
        private System.Windows.Forms.Label labelSecondGamerCount;
        private System.Windows.Forms.Label labelFirstGamerCount;
    }
}