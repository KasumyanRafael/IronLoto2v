namespace IronLoto2v
{
    partial class FormSecond
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNoWayGamer2 = new System.Windows.Forms.Label();
            this.labelNoWayGamer1 = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.menuStripSettings = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStopOrGo = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCount = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.labelSecondGamer = new System.Windows.Forms.Label();
            this.labelSecondGamerCount = new System.Windows.Forms.Label();
            this.labelFirstGamer = new System.Windows.Forms.Label();
            this.labelFirstGamerCount = new System.Windows.Forms.Label();
            this.dataGridViewGamer1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewGamer2 = new System.Windows.Forms.DataGridView();
            this.timerChangePicture = new System.Windows.Forms.Timer(this.components);
            this.labelCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStripSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.labelNoWayGamer2);
            this.panel1.Controls.Add(this.labelNoWayGamer1);
            this.panel1.Controls.Add(this.labelPause);
            this.panel1.Controls.Add(this.menuStripSettings);
            this.panel1.Controls.Add(this.pictureBoxShow);
            this.panel1.Controls.Add(this.labelSecondGamer);
            this.panel1.Controls.Add(this.labelSecondGamerCount);
            this.panel1.Controls.Add(this.labelFirstGamer);
            this.panel1.Controls.Add(this.labelFirstGamerCount);
            this.panel1.Controls.Add(this.dataGridViewGamer1);
            this.panel1.Controls.Add(this.dataGridViewGamer2);
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1457, 616);
            this.panel1.TabIndex = 17;
            // 
            // labelNoWayGamer2
            // 
            this.labelNoWayGamer2.BackColor = System.Drawing.Color.White;
            this.labelNoWayGamer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoWayGamer2.ForeColor = System.Drawing.Color.Black;
            this.labelNoWayGamer2.Location = new System.Drawing.Point(1050, 158);
            this.labelNoWayGamer2.Name = "labelNoWayGamer2";
            this.labelNoWayGamer2.Size = new System.Drawing.Size(329, 126);
            this.labelNoWayGamer2.TabIndex = 30;
            this.labelNoWayGamer2.Text = "ход невозможен";
            this.labelNoWayGamer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNoWayGamer2.Visible = false;
            // 
            // labelNoWayGamer1
            // 
            this.labelNoWayGamer1.BackColor = System.Drawing.Color.White;
            this.labelNoWayGamer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoWayGamer1.ForeColor = System.Drawing.Color.Black;
            this.labelNoWayGamer1.Location = new System.Drawing.Point(48, 147);
            this.labelNoWayGamer1.Name = "labelNoWayGamer1";
            this.labelNoWayGamer1.Size = new System.Drawing.Size(329, 126);
            this.labelNoWayGamer1.TabIndex = 29;
            this.labelNoWayGamer1.Text = "ход невозможен";
            this.labelNoWayGamer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNoWayGamer1.Visible = false;
            // 
            // labelPause
            // 
            this.labelPause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPause.BackColor = System.Drawing.Color.Yellow;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPause.ForeColor = System.Drawing.Color.Black;
            this.labelPause.Location = new System.Drawing.Point(677, 37);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(98, 63);
            this.labelPause.TabIndex = 28;
            this.labelPause.Text = "пауза";
            this.labelPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPause.Visible = false;
            // 
            // menuStripSettings
            // 
            this.menuStripSettings.BackColor = System.Drawing.Color.Yellow;
            this.menuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGame,
            this.информацияToolStripMenuItem});
            this.menuStripSettings.Location = new System.Drawing.Point(480, 0);
            this.menuStripSettings.Name = "menuStripSettings";
            this.menuStripSettings.Size = new System.Drawing.Size(497, 24);
            this.menuStripSettings.TabIndex = 26;
            this.menuStripSettings.Text = "menuStrip1";
            // 
            // ToolStripMenuItemGame
            // 
            this.ToolStripMenuItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.ToolStripMenuItemStopOrGo});
            this.ToolStripMenuItemGame.Name = "ToolStripMenuItemGame";
            this.ToolStripMenuItemGame.Size = new System.Drawing.Size(46, 20);
            this.ToolStripMenuItemGame.Text = "Игра";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExit,
            this.ToolStripMenuItemUsers,
            this.ToolStripMenuItemMenu});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItemExit.Text = "Из приложения";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemUsers
            // 
            this.ToolStripMenuItemUsers.Name = "ToolStripMenuItemUsers";
            this.ToolStripMenuItemUsers.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItemUsers.Text = "Смена пользователей";
            this.ToolStripMenuItemUsers.Click += new System.EventHandler(this.ToolStripMenuItemUsers_Click);
            // 
            // ToolStripMenuItemMenu
            // 
            this.ToolStripMenuItemMenu.Name = "ToolStripMenuItemMenu";
            this.ToolStripMenuItemMenu.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItemMenu.Text = "Меню";
            this.ToolStripMenuItemMenu.Click += new System.EventHandler(this.ToolStripMenuItemMenu_Click);
            // 
            // ToolStripMenuItemStopOrGo
            // 
            this.ToolStripMenuItemStopOrGo.Name = "ToolStripMenuItemStopOrGo";
            this.ToolStripMenuItemStopOrGo.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItemStopOrGo.Text = "Пауза";
            this.ToolStripMenuItemStopOrGo.Click += new System.EventHandler(this.ToolStripMenuItemStopOrGo_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInformation,
            this.ToolStripMenuItemCount});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // ToolStripMenuItemInformation
            // 
            this.ToolStripMenuItemInformation.Name = "ToolStripMenuItemInformation";
            this.ToolStripMenuItemInformation.Size = new System.Drawing.Size(188, 22);
            this.ToolStripMenuItemInformation.Text = "Об игре";
            this.ToolStripMenuItemInformation.Click += new System.EventHandler(this.ToolStripMenuItemInformation_Click);
            // 
            // ToolStripMenuItemCount
            // 
            this.ToolStripMenuItemCount.Name = "ToolStripMenuItemCount";
            this.ToolStripMenuItemCount.Size = new System.Drawing.Size(188, 22);
            this.ToolStripMenuItemCount.Text = "Узнать текущий счёт";
            this.ToolStripMenuItemCount.Click += new System.EventHandler(this.ToolStripMenuItemCount_Click);
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxShow.Location = new System.Drawing.Point(516, 206);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(409, 387);
            this.pictureBoxShow.TabIndex = 18;
            this.pictureBoxShow.TabStop = false;
            // 
            // labelSecondGamer
            // 
            this.labelSecondGamer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecondGamer.BackColor = System.Drawing.Color.Red;
            this.labelSecondGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondGamer.ForeColor = System.Drawing.Color.White;
            this.labelSecondGamer.Location = new System.Drawing.Point(806, 116);
            this.labelSecondGamer.Name = "labelSecondGamer";
            this.labelSecondGamer.Size = new System.Drawing.Size(134, 32);
            this.labelSecondGamer.TabIndex = 25;
            this.labelSecondGamer.Text = "_ _";
            this.labelSecondGamer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondGamerCount
            // 
            this.labelSecondGamerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecondGamerCount.BackColor = System.Drawing.Color.Red;
            this.labelSecondGamerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondGamerCount.ForeColor = System.Drawing.Color.White;
            this.labelSecondGamerCount.Location = new System.Drawing.Point(806, 37);
            this.labelSecondGamerCount.Name = "labelSecondGamerCount";
            this.labelSecondGamerCount.Size = new System.Drawing.Size(134, 69);
            this.labelSecondGamerCount.TabIndex = 24;
            this.labelSecondGamerCount.Text = "0";
            this.labelSecondGamerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstGamer
            // 
            this.labelFirstGamer.BackColor = System.Drawing.Color.Blue;
            this.labelFirstGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstGamer.ForeColor = System.Drawing.Color.White;
            this.labelFirstGamer.Location = new System.Drawing.Point(520, 116);
            this.labelFirstGamer.Name = "labelFirstGamer";
            this.labelFirstGamer.Size = new System.Drawing.Size(134, 32);
            this.labelFirstGamer.TabIndex = 23;
            this.labelFirstGamer.Text = "_ _";
            this.labelFirstGamer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstGamerCount
            // 
            this.labelFirstGamerCount.BackColor = System.Drawing.Color.Blue;
            this.labelFirstGamerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstGamerCount.ForeColor = System.Drawing.Color.White;
            this.labelFirstGamerCount.Location = new System.Drawing.Point(520, 37);
            this.labelFirstGamerCount.Name = "labelFirstGamerCount";
            this.labelFirstGamerCount.Size = new System.Drawing.Size(134, 69);
            this.labelFirstGamerCount.TabIndex = 21;
            this.labelFirstGamerCount.Text = "0";
            this.labelFirstGamerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewGamer1
            // 
            this.dataGridViewGamer1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewGamer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer1.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGamer1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGamer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewGamer1.Enabled = false;
            this.dataGridViewGamer1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGamer1.Name = "dataGridViewGamer1";
            this.dataGridViewGamer1.ReadOnly = true;
            this.dataGridViewGamer1.RowHeadersVisible = false;
            this.dataGridViewGamer1.Size = new System.Drawing.Size(480, 616);
            this.dataGridViewGamer1.TabIndex = 16;
            // 
            // dataGridViewGamer2
            // 
            this.dataGridViewGamer2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewGamer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer2.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGamer2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewGamer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewGamer2.Enabled = false;
            this.dataGridViewGamer2.Location = new System.Drawing.Point(977, 0);
            this.dataGridViewGamer2.Name = "dataGridViewGamer2";
            this.dataGridViewGamer2.ReadOnly = true;
            this.dataGridViewGamer2.RowHeadersVisible = false;
            this.dataGridViewGamer2.Size = new System.Drawing.Size(480, 616);
            this.dataGridViewGamer2.TabIndex = 18;
            // 
            // timerChangePicture
            // 
            this.timerChangePicture.Tick += new System.EventHandler(this.timerChangePicture_Tick);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCount.BackColor = System.Drawing.Color.Yellow;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.ForeColor = System.Drawing.Color.Black;
            this.labelCount.Location = new System.Drawing.Point(660, 37);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(140, 63);
            this.labelCount.TabIndex = 31;
            this.labelCount.Text = "0";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 616);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FormSecond";
            this.Text = "Раунд 2. Теперь ты знаешь русские названия. Поэтому русский перевод слова появлят" +
    "ься не будет.";
            this.Load += new System.EventHandler(this.FormSecond_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSecond_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStripSettings.ResumeLayout(false);
            this.menuStripSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStripSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGame;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUsers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStopOrGo;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInformation;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Label labelSecondGamer;
        private System.Windows.Forms.Label labelSecondGamerCount;
        private System.Windows.Forms.Label labelFirstGamer;
        private System.Windows.Forms.Label labelFirstGamerCount;
        private System.Windows.Forms.DataGridView dataGridViewGamer1;
        private System.Windows.Forms.DataGridView dataGridViewGamer2;
        private System.Windows.Forms.Timer timerChangePicture;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCount;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelNoWayGamer2;
        private System.Windows.Forms.Label labelNoWayGamer1;
        private System.Windows.Forms.Label labelCount;
    }
}