namespace IronLoto2v
{
    partial class FormFinalRound
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
            this.ToolStripMenuItemCount = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripFinalLevel = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCountdown = new System.Windows.Forms.Label();
            this.labelNoWayGamer2 = new System.Windows.Forms.Label();
            this.labelNoWayGamer1 = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.labelSecondGamer = new System.Windows.Forms.Label();
            this.labelSecondGamerCount = new System.Windows.Forms.Label();
            this.labelFirstGamer = new System.Windows.Forms.Label();
            this.labelFirstGamerCount = new System.Windows.Forms.Label();
            this.dataGridViewGamer1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewGamer2 = new System.Windows.Forms.DataGridView();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.menuStripSettings.SuspendLayout();
            this.statusStripFinalLevel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripSettings
            // 
            this.menuStripSettings.BackColor = System.Drawing.Color.Gold;
            this.menuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGame,
            this.информацияToolStripMenuItem});
            this.menuStripSettings.Location = new System.Drawing.Point(0, 0);
            this.menuStripSettings.Name = "menuStripSettings";
            this.menuStripSettings.Size = new System.Drawing.Size(1457, 24);
            this.menuStripSettings.TabIndex = 35;
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
            // statusStripFinalLevel
            // 
            this.statusStripFinalLevel.BackColor = System.Drawing.Color.Gold;
            this.statusStripFinalLevel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripFinalLevel.Location = new System.Drawing.Point(0, 594);
            this.statusStripFinalLevel.Name = "statusStripFinalLevel";
            this.statusStripFinalLevel.Size = new System.Drawing.Size(1457, 22);
            this.statusStripFinalLevel.TabIndex = 36;
            this.statusStripFinalLevel.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(252, 17);
            this.toolStripStatusLabel1.Text = "Третий раунд (картинка - осетинское слово)";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.labelCountdown);
            this.panel1.Controls.Add(this.labelNoWayGamer2);
            this.panel1.Controls.Add(this.labelNoWayGamer1);
            this.panel1.Controls.Add(this.labelPause);
            this.panel1.Controls.Add(this.pictureBoxShow);
            this.panel1.Controls.Add(this.labelSecondGamer);
            this.panel1.Controls.Add(this.labelSecondGamerCount);
            this.panel1.Controls.Add(this.labelFirstGamer);
            this.panel1.Controls.Add(this.labelFirstGamerCount);
            this.panel1.Controls.Add(this.dataGridViewGamer1);
            this.panel1.Controls.Add(this.dataGridViewGamer2);
            this.panel1.Location = new System.Drawing.Point(15, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 524);
            this.panel1.TabIndex = 37;
            // 
            // labelCountdown
            // 
            this.labelCountdown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCountdown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountdown.ForeColor = System.Drawing.Color.Black;
            this.labelCountdown.Location = new System.Drawing.Point(606, 326);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(98, 63);
            this.labelCountdown.TabIndex = 31;
            this.labelCountdown.Text = "10";
            this.labelCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNoWayGamer2
            // 
            this.labelNoWayGamer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNoWayGamer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelNoWayGamer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoWayGamer2.ForeColor = System.Drawing.Color.Blue;
            this.labelNoWayGamer2.Location = new System.Drawing.Point(1081, 0);
            this.labelNoWayGamer2.Name = "labelNoWayGamer2";
            this.labelNoWayGamer2.Size = new System.Drawing.Size(345, 220);
            this.labelNoWayGamer2.TabIndex = 30;
            this.labelNoWayGamer2.Text = "ход невозможен";
            this.labelNoWayGamer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNoWayGamer2.Visible = false;
            // 
            // labelNoWayGamer1
            // 
            this.labelNoWayGamer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNoWayGamer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelNoWayGamer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoWayGamer1.ForeColor = System.Drawing.Color.Blue;
            this.labelNoWayGamer1.Location = new System.Drawing.Point(-3, 0);
            this.labelNoWayGamer1.Name = "labelNoWayGamer1";
            this.labelNoWayGamer1.Size = new System.Drawing.Size(345, 220);
            this.labelNoWayGamer1.TabIndex = 29;
            this.labelNoWayGamer1.Text = "ход невозможен";
            this.labelNoWayGamer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNoWayGamer1.Visible = false;
            // 
            // labelPause
            // 
            this.labelPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPause.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPause.ForeColor = System.Drawing.Color.Black;
            this.labelPause.Location = new System.Drawing.Point(606, 461);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(98, 63);
            this.labelPause.TabIndex = 27;
            this.labelPause.Text = "пауза";
            this.labelPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPause.Visible = false;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxShow.Location = new System.Drawing.Point(483, 98);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(320, 320);
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
            this.dataGridViewGamer1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewGamer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer1.ColumnHeadersVisible = false;
            this.dataGridViewGamer1.Enabled = false;
            this.dataGridViewGamer1.Location = new System.Drawing.Point(0, 98);
            this.dataGridViewGamer1.Name = "dataGridViewGamer1";
            this.dataGridViewGamer1.ReadOnly = true;
            this.dataGridViewGamer1.RowHeadersVisible = false;
            this.dataGridViewGamer1.Size = new System.Drawing.Size(630, 930);
            this.dataGridViewGamer1.TabIndex = 16;
            // 
            // dataGridViewGamer2
            // 
            this.dataGridViewGamer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGamer2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewGamer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGamer2.ColumnHeadersVisible = false;
            this.dataGridViewGamer2.Enabled = false;
            this.dataGridViewGamer2.Location = new System.Drawing.Point(1106, 104);
            this.dataGridViewGamer2.Name = "dataGridViewGamer2";
            this.dataGridViewGamer2.ReadOnly = true;
            this.dataGridViewGamer2.RowHeadersVisible = false;
            this.dataGridViewGamer2.Size = new System.Drawing.Size(650, 950);
            this.dataGridViewGamer2.TabIndex = 18;
            // 
            // timerCountdown
            // 
            this.timerCountdown.Enabled = true;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // FormFinalRound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1457, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStripFinalLevel);
            this.Controls.Add(this.menuStripSettings);
            this.KeyPreview = true;
            this.Name = "FormFinalRound";
            this.Load += new System.EventHandler(this.FormFinalRound_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFinalRound_KeyDown);
            this.menuStripSettings.ResumeLayout(false);
            this.menuStripSettings.PerformLayout();
            this.statusStripFinalLevel.ResumeLayout(false);
            this.statusStripFinalLevel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGamer2)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCount;
        private System.Windows.Forms.StatusStrip statusStripFinalLevel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.Label labelNoWayGamer2;
        private System.Windows.Forms.Label labelNoWayGamer1;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Label labelSecondGamer;
        private System.Windows.Forms.Label labelSecondGamerCount;
        private System.Windows.Forms.Label labelFirstGamer;
        private System.Windows.Forms.Label labelFirstGamerCount;
        private System.Windows.Forms.DataGridView dataGridViewGamer1;
        private System.Windows.Forms.DataGridView dataGridViewGamer2;
        private System.Windows.Forms.Timer timerCountdown;
    }
}