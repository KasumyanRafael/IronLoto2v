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
            this.menuStripSettings = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStopOrGo = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPause = new System.Windows.Forms.Label();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.labelSecondGamer = new System.Windows.Forms.Label();
            this.labelSecondGamerCount = new System.Windows.Forms.Label();
            this.labelFirstGamer = new System.Windows.Forms.Label();
            this.labelFirstGamerCount = new System.Windows.Forms.Label();
            this.dataGridViewGamer1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewGamer2 = new System.Windows.Forms.DataGridView();
            this.timerChangePicture = new System.Windows.Forms.Timer(this.components);
            this.statusStripFirstLevel = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNoWay = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).BeginInit();
            this.statusStripFirstLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripSettings
            // 
            this.menuStripSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGame,
            this.информацияToolStripMenuItem});
            this.menuStripSettings.Location = new System.Drawing.Point(0, 0);
            this.menuStripSettings.Name = "menuStripSettings";
            this.menuStripSettings.Size = new System.Drawing.Size(1457, 24);
            this.menuStripSettings.TabIndex = 29;
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
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.ToolStripMenuItemStopOrGo.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemStopOrGo.Text = "Пауза";
            this.ToolStripMenuItemStopOrGo.Click += new System.EventHandler(this.ToolStripMenuItemStopOrGo_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInformation});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // ToolStripMenuItemInformation
            // 
            this.ToolStripMenuItemInformation.Name = "ToolStripMenuItemInformation";
            this.ToolStripMenuItemInformation.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemInformation.Text = "Об игре";
            this.ToolStripMenuItemInformation.Click += new System.EventHandler(this.ToolStripMenuItemInformation_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelPause);
            this.panel1.Controls.Add(this.pictureBoxShow);
            this.panel1.Controls.Add(this.labelSecondGamer);
            this.panel1.Controls.Add(this.labelSecondGamerCount);
            this.panel1.Controls.Add(this.labelFirstGamer);
            this.panel1.Controls.Add(this.labelFirstGamerCount);
            this.panel1.Controls.Add(this.dataGridViewGamer1);
            this.panel1.Controls.Add(this.dataGridViewGamer2);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 524);
            this.panel1.TabIndex = 32;
            // 
            // labelPause
            // 
            this.labelPause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPause.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPause.ForeColor = System.Drawing.Color.Black;
            this.labelPause.Location = new System.Drawing.Point(666, 458);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(98, 63);
            this.labelPause.TabIndex = 27;
            this.labelPause.Text = "пауза";
            this.labelPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPause.Visible = false;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxShow.Location = new System.Drawing.Point(606, 141);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(217, 281);
            this.pictureBoxShow.TabIndex = 18;
            this.pictureBoxShow.TabStop = false;
            // 
            // labelSecondGamer
            // 
            this.labelSecondGamer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecondGamer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSecondGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondGamer.ForeColor = System.Drawing.Color.White;
            this.labelSecondGamer.Location = new System.Drawing.Point(1289, 69);
            this.labelSecondGamer.Name = "labelSecondGamer";
            this.labelSecondGamer.Size = new System.Drawing.Size(134, 32);
            this.labelSecondGamer.TabIndex = 25;
            this.labelSecondGamer.Text = "_ _";
            this.labelSecondGamer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondGamerCount
            // 
            this.labelSecondGamerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecondGamerCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSecondGamerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondGamerCount.ForeColor = System.Drawing.Color.White;
            this.labelSecondGamerCount.Location = new System.Drawing.Point(1289, 0);
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
            this.labelFirstGamer.Location = new System.Drawing.Point(3, 69);
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
            this.labelFirstGamerCount.Location = new System.Drawing.Point(3, 0);
            this.labelFirstGamerCount.Name = "labelFirstGamerCount";
            this.labelFirstGamerCount.Size = new System.Drawing.Size(134, 69);
            this.labelFirstGamerCount.TabIndex = 21;
            this.labelFirstGamerCount.Text = "0";
            this.labelFirstGamerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewGamer1
            // 
            this.dataGridViewGamer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewGamer1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewGamer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer1.ColumnHeadersVisible = false;
            this.dataGridViewGamer1.Enabled = false;
            this.dataGridViewGamer1.Location = new System.Drawing.Point(0, 98);
            this.dataGridViewGamer1.Name = "dataGridViewGamer1";
            this.dataGridViewGamer1.ReadOnly = true;
            this.dataGridViewGamer1.RowHeadersVisible = false;
            this.dataGridViewGamer1.Size = new System.Drawing.Size(320, 426);
            this.dataGridViewGamer1.TabIndex = 16;
            // 
            // dataGridViewGamer2
            // 
            this.dataGridViewGamer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGamer2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewGamer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer2.ColumnHeadersVisible = false;
            this.dataGridViewGamer2.Enabled = false;
            this.dataGridViewGamer2.Location = new System.Drawing.Point(1106, 104);
            this.dataGridViewGamer2.Name = "dataGridViewGamer2";
            this.dataGridViewGamer2.ReadOnly = true;
            this.dataGridViewGamer2.RowHeadersVisible = false;
            this.dataGridViewGamer2.Size = new System.Drawing.Size(320, 417);
            this.dataGridViewGamer2.TabIndex = 18;
            // 
            // timerChangePicture
            // 
            this.timerChangePicture.Tick += new System.EventHandler(this.timerChangePicture_Tick);
            // 
            // statusStripFirstLevel
            // 
            this.statusStripFirstLevel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelNoWay});
            this.statusStripFirstLevel.Location = new System.Drawing.Point(0, 594);
            this.statusStripFirstLevel.Name = "statusStripFirstLevel";
            this.statusStripFirstLevel.Size = new System.Drawing.Size(1457, 22);
            this.statusStripFirstLevel.TabIndex = 33;
            this.statusStripFirstLevel.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "Первый раунд";
            // 
            // toolStripStatusLabelNoWay
            // 
            this.toolStripStatusLabelNoWay.Name = "toolStripStatusLabelNoWay";
            this.toolStripStatusLabelNoWay.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabelNoWay.Text = "Объявления:";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1457, 616);
            this.Controls.Add(this.statusStripFirstLevel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripSettings);
            this.KeyPreview = true;
            this.Name = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.menuStripSettings.ResumeLayout(false);
            this.menuStripSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).EndInit();
            this.statusStripFirstLevel.ResumeLayout(false);
            this.statusStripFirstLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGame;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUsers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStopOrGo;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Label labelSecondGamer;
        private System.Windows.Forms.Label labelSecondGamerCount;
        private System.Windows.Forms.Label labelFirstGamer;
        private System.Windows.Forms.Label labelFirstGamerCount;
        private System.Windows.Forms.DataGridView dataGridViewGamer1;
        private System.Windows.Forms.DataGridView dataGridViewGamer2;
        private System.Windows.Forms.Timer timerChangePicture;
        private System.Windows.Forms.StatusStrip statusStripFirstLevel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNoWay;
    }
}