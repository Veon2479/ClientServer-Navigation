﻿
namespace Server
{
    partial class frmServer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tbSettings;
            this.pImage = new System.Windows.Forms.Panel();
            this.pbMapImage = new System.Windows.Forms.PictureBox();
            this.pSettings = new System.Windows.Forms.Panel();
            this.tbRealWidth = new System.Windows.Forms.TextBox();
            this.tbRealLength = new System.Windows.Forms.TextBox();
            this.tbCoordinateY2 = new System.Windows.Forms.TextBox();
            this.tbCoordinateX2 = new System.Windows.Forms.TextBox();
            this.tbCoordinateY1 = new System.Windows.Forms.TextBox();
            this.tbCoordinateX1 = new System.Windows.Forms.TextBox();
            this.lblRealLength = new System.Windows.Forms.Label();
            this.lblRealWidth = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCoordinateY2 = new System.Windows.Forms.Label();
            this.lblCoordinateX2 = new System.Windows.Forms.Label();
            this.lblCoordinateY1 = new System.Windows.Forms.Label();
            this.lblCoordinateX1 = new System.Windows.Forms.Label();
            this.btnDownloadImage = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tbManage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbLog = new System.Windows.Forms.TabPage();
            this.txtbLog = new System.Windows.Forms.TextBox();
            this.tbOnline = new System.Windows.Forms.TabPage();
            this.lvOnline = new System.Windows.Forms.ListView();
            this.userID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastOnline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFlush = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbQRLocation = new System.Windows.Forms.TabPage();
            this.pnlQRLocation = new System.Windows.Forms.Panel();
            this.lblQRy = new System.Windows.Forms.Label();
            this.lblQRx = new System.Windows.Forms.Label();
            this.lblQRName = new System.Windows.Forms.Label();
            this.lblQRID = new System.Windows.Forms.Label();
            this.tbQRName = new System.Windows.Forms.TextBox();
            this.tbQRx = new System.Windows.Forms.TextBox();
            this.tbQRy = new System.Windows.Forms.TextBox();
            this.tbQRID = new System.Windows.Forms.TextBox();
            this.btnDeleteQR = new System.Windows.Forms.Button();
            this.btnEditQR = new System.Windows.Forms.Button();
            this.btnAddQR = new System.Windows.Forms.Button();
            this.btnCreateQRConf = new System.Windows.Forms.Button();
            this.btnOpenQRConf = new System.Windows.Forms.Button();
            this.tbHeatMap = new System.Windows.Forms.TabPage();
            this.tmrListUpdate = new System.Windows.Forms.Timer(this.components);
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcQRLocation = new System.Windows.Forms.TabControl();
            this.tbQRMap = new System.Windows.Forms.TabPage();
            this.tbError = new System.Windows.Forms.TextBox();
            this.tbQRList = new System.Windows.Forms.TabPage();
            this.lvQRList = new System.Windows.Forms.ListView();
            this.colQRID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQRName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tbSettings = new System.Windows.Forms.TabPage();
            tbSettings.SuspendLayout();
            this.pImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapImage)).BeginInit();
            this.pSettings.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tbManage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbLog.SuspendLayout();
            this.tbOnline.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbQRLocation.SuspendLayout();
            this.pnlQRLocation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcQRLocation.SuspendLayout();
            this.tbQRList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSettings
            // 
            tbSettings.Controls.Add(this.pImage);
            tbSettings.Controls.Add(this.pSettings);
            tbSettings.Location = new System.Drawing.Point(4, 25);
            tbSettings.Margin = new System.Windows.Forms.Padding(4);
            tbSettings.Name = "tbSettings";
            tbSettings.Padding = new System.Windows.Forms.Padding(4);
            tbSettings.Size = new System.Drawing.Size(1496, 840);
            tbSettings.TabIndex = 0;
            tbSettings.Text = "Settings";
            tbSettings.UseVisualStyleBackColor = true;
            // 
            // pImage
            // 
            this.pImage.BackColor = System.Drawing.Color.DarkGray;
            this.pImage.Controls.Add(this.pbMapImage);
            this.pImage.Location = new System.Drawing.Point(308, 4);
            this.pImage.Margin = new System.Windows.Forms.Padding(4);
            this.pImage.Name = "pImage";
            this.pImage.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pImage.Size = new System.Drawing.Size(1181, 830);
            this.pImage.TabIndex = 1;
            // 
            // pbMapImage
            // 
            this.pbMapImage.BackColor = System.Drawing.Color.DarkGray;
            this.pbMapImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMapImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMapImage.Location = new System.Drawing.Point(7, 6);
            this.pbMapImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbMapImage.Name = "pbMapImage";
            this.pbMapImage.Size = new System.Drawing.Size(1167, 818);
            this.pbMapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMapImage.TabIndex = 0;
            this.pbMapImage.TabStop = false;
            this.pbMapImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMapImage_MouseDown);
            this.pbMapImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMapImage_MouseMove);
            // 
            // pSettings
            // 
            this.pSettings.Controls.Add(this.tbRealWidth);
            this.pSettings.Controls.Add(this.tbRealLength);
            this.pSettings.Controls.Add(this.tbCoordinateY2);
            this.pSettings.Controls.Add(this.tbCoordinateX2);
            this.pSettings.Controls.Add(this.tbCoordinateY1);
            this.pSettings.Controls.Add(this.tbCoordinateX1);
            this.pSettings.Controls.Add(this.lblRealLength);
            this.pSettings.Controls.Add(this.lblRealWidth);
            this.pSettings.Controls.Add(this.btnSave);
            this.pSettings.Controls.Add(this.lblCoordinateY2);
            this.pSettings.Controls.Add(this.lblCoordinateX2);
            this.pSettings.Controls.Add(this.lblCoordinateY1);
            this.pSettings.Controls.Add(this.lblCoordinateX1);
            this.pSettings.Controls.Add(this.btnDownloadImage);
            this.pSettings.Location = new System.Drawing.Point(4, 4);
            this.pSettings.Margin = new System.Windows.Forms.Padding(4);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(300, 830);
            this.pSettings.TabIndex = 0;
            // 
            // tbRealWidth
            // 
            this.tbRealWidth.Location = new System.Drawing.Point(19, 254);
            this.tbRealWidth.Margin = new System.Windows.Forms.Padding(4);
            this.tbRealWidth.Name = "tbRealWidth";
            this.tbRealWidth.Size = new System.Drawing.Size(128, 22);
            this.tbRealWidth.TabIndex = 23;
            this.tbRealWidth.TextChanged += new System.EventHandler(this.tbRealWidth_TextChanged);
            this.tbRealWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRealValue_KeyPress);
            // 
            // tbRealLength
            // 
            this.tbRealLength.Location = new System.Drawing.Point(19, 176);
            this.tbRealLength.Margin = new System.Windows.Forms.Padding(4);
            this.tbRealLength.Name = "tbRealLength";
            this.tbRealLength.Size = new System.Drawing.Size(128, 22);
            this.tbRealLength.TabIndex = 22;
            this.tbRealLength.TextChanged += new System.EventHandler(this.tbRealLength_TextChanged);
            // 
            // tbCoordinateY2
            // 
            this.tbCoordinateY2.Location = new System.Drawing.Point(192, 89);
            this.tbCoordinateY2.Margin = new System.Windows.Forms.Padding(4);
            this.tbCoordinateY2.Name = "tbCoordinateY2";
            this.tbCoordinateY2.Size = new System.Drawing.Size(68, 22);
            this.tbCoordinateY2.TabIndex = 21;
            this.tbCoordinateY2.TextChanged += new System.EventHandler(this.tbCoordinateY2_TextChanged);
            this.tbCoordinateY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCoordinate_KeyPress);
            // 
            // tbCoordinateX2
            // 
            this.tbCoordinateX2.Location = new System.Drawing.Point(192, 57);
            this.tbCoordinateX2.Margin = new System.Windows.Forms.Padding(4);
            this.tbCoordinateX2.Name = "tbCoordinateX2";
            this.tbCoordinateX2.Size = new System.Drawing.Size(68, 22);
            this.tbCoordinateX2.TabIndex = 20;
            this.tbCoordinateX2.TextChanged += new System.EventHandler(this.tbCoordinateX2_TextChanged);
            this.tbCoordinateX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCoordinate_KeyPress);
            // 
            // tbCoordinateY1
            // 
            this.tbCoordinateY1.Location = new System.Drawing.Point(59, 89);
            this.tbCoordinateY1.Margin = new System.Windows.Forms.Padding(4);
            this.tbCoordinateY1.Name = "tbCoordinateY1";
            this.tbCoordinateY1.Size = new System.Drawing.Size(68, 22);
            this.tbCoordinateY1.TabIndex = 19;
            this.tbCoordinateY1.TextChanged += new System.EventHandler(this.tbCoordinateY1_TextChanged);
            this.tbCoordinateY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCoordinate_KeyPress);
            // 
            // tbCoordinateX1
            // 
            this.tbCoordinateX1.Location = new System.Drawing.Point(59, 57);
            this.tbCoordinateX1.Margin = new System.Windows.Forms.Padding(4);
            this.tbCoordinateX1.Name = "tbCoordinateX1";
            this.tbCoordinateX1.Size = new System.Drawing.Size(68, 22);
            this.tbCoordinateX1.TabIndex = 18;
            this.tbCoordinateX1.TextChanged += new System.EventHandler(this.tbCoordinateX1_TextChanged);
            this.tbCoordinateX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCoordinate_KeyPress);
            // 
            // lblRealLength
            // 
            this.lblRealLength.AutoSize = true;
            this.lblRealLength.Location = new System.Drawing.Point(16, 137);
            this.lblRealLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealLength.Name = "lblRealLength";
            this.lblRealLength.Size = new System.Drawing.Size(191, 32);
            this.lblRealLength.TabIndex = 16;
            this.lblRealLength.Text = "Длина отмеченной области \r\n(в метрах):";
            // 
            // lblRealWidth
            // 
            this.lblRealWidth.AutoSize = true;
            this.lblRealWidth.Location = new System.Drawing.Point(16, 214);
            this.lblRealWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealWidth.Name = "lblRealWidth";
            this.lblRealWidth.Size = new System.Drawing.Size(198, 32);
            this.lblRealWidth.TabIndex = 14;
            this.lblRealWidth.Text = "Ширина отмеченной области\r\n(в метрах):";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 356);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCoordinateY2
            // 
            this.lblCoordinateY2.AutoSize = true;
            this.lblCoordinateY2.Location = new System.Drawing.Point(153, 92);
            this.lblCoordinateY2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinateY2.Name = "lblCoordinateY2";
            this.lblCoordinateY2.Size = new System.Drawing.Size(26, 16);
            this.lblCoordinateY2.TabIndex = 11;
            this.lblCoordinateY2.Text = "Y2:";
            // 
            // lblCoordinateX2
            // 
            this.lblCoordinateX2.AutoSize = true;
            this.lblCoordinateX2.Location = new System.Drawing.Point(153, 60);
            this.lblCoordinateX2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinateX2.Name = "lblCoordinateX2";
            this.lblCoordinateX2.Size = new System.Drawing.Size(25, 16);
            this.lblCoordinateX2.TabIndex = 9;
            this.lblCoordinateX2.Text = "X2:";
            // 
            // lblCoordinateY1
            // 
            this.lblCoordinateY1.AutoSize = true;
            this.lblCoordinateY1.Location = new System.Drawing.Point(20, 92);
            this.lblCoordinateY1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinateY1.Name = "lblCoordinateY1";
            this.lblCoordinateY1.Size = new System.Drawing.Size(26, 16);
            this.lblCoordinateY1.TabIndex = 7;
            this.lblCoordinateY1.Text = "Y1:";
            // 
            // lblCoordinateX1
            // 
            this.lblCoordinateX1.AutoSize = true;
            this.lblCoordinateX1.Location = new System.Drawing.Point(20, 60);
            this.lblCoordinateX1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinateX1.Name = "lblCoordinateX1";
            this.lblCoordinateX1.Size = new System.Drawing.Size(25, 16);
            this.lblCoordinateX1.TabIndex = 5;
            this.lblCoordinateX1.Text = "X1:";
            // 
            // btnDownloadImage
            // 
            this.btnDownloadImage.Location = new System.Drawing.Point(19, 14);
            this.btnDownloadImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.Size = new System.Drawing.Size(260, 31);
            this.btnDownloadImage.TabIndex = 0;
            this.btnDownloadImage.Text = "Загрузить карту помещения";
            this.btnDownloadImage.UseVisualStyleBackColor = true;
            this.btnDownloadImage.Click += new System.EventHandler(this.btnDownloadImage_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(tbSettings);
            this.tcMain.Controls.Add(this.tbManage);
            this.tcMain.Controls.Add(this.tbQRLocation);
            this.tcMain.Controls.Add(this.tbHeatMap);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1504, 869);
            this.tcMain.TabIndex = 0;
            // 
            // tbManage
            // 
            this.tbManage.Controls.Add(this.tabControl1);
            this.tbManage.Controls.Add(this.panel1);
            this.tbManage.Location = new System.Drawing.Point(4, 25);
            this.tbManage.Margin = new System.Windows.Forms.Padding(4);
            this.tbManage.Name = "tbManage";
            this.tbManage.Padding = new System.Windows.Forms.Padding(4);
            this.tbManage.Size = new System.Drawing.Size(1496, 840);
            this.tbManage.TabIndex = 1;
            this.tbManage.Text = "Management";
            this.tbManage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbLog);
            this.tabControl1.Controls.Add(this.tbOnline);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(304, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 832);
            this.tabControl1.TabIndex = 1;
            // 
            // tbLog
            // 
            this.tbLog.Controls.Add(this.txtbLog);
            this.tbLog.Location = new System.Drawing.Point(4, 25);
            this.tbLog.Name = "tbLog";
            this.tbLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbLog.Size = new System.Drawing.Size(1180, 803);
            this.tbLog.TabIndex = 0;
            this.tbLog.Text = "Log";
            this.tbLog.UseVisualStyleBackColor = true;
            // 
            // txtbLog
            // 
            this.txtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbLog.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbLog.Location = new System.Drawing.Point(3, 3);
            this.txtbLog.Multiline = true;
            this.txtbLog.Name = "txtbLog";
            this.txtbLog.ReadOnly = true;
            this.txtbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbLog.Size = new System.Drawing.Size(1174, 797);
            this.txtbLog.TabIndex = 0;
            // 
            // tbOnline
            // 
            this.tbOnline.Controls.Add(this.lvOnline);
            this.tbOnline.Location = new System.Drawing.Point(4, 25);
            this.tbOnline.Name = "tbOnline";
            this.tbOnline.Padding = new System.Windows.Forms.Padding(3);
            this.tbOnline.Size = new System.Drawing.Size(1180, 803);
            this.tbOnline.TabIndex = 1;
            this.tbOnline.Text = "Online";
            this.tbOnline.UseVisualStyleBackColor = true;
            // 
            // lvOnline
            // 
            this.lvOnline.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userID,
            this.lastOnline});
            this.lvOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOnline.GridLines = true;
            this.lvOnline.HideSelection = false;
            this.lvOnline.Location = new System.Drawing.Point(3, 3);
            this.lvOnline.MultiSelect = false;
            this.lvOnline.Name = "lvOnline";
            this.lvOnline.Size = new System.Drawing.Size(1174, 797);
            this.lvOnline.TabIndex = 0;
            this.lvOnline.UseCompatibleStateImageBehavior = false;
            this.lvOnline.View = System.Windows.Forms.View.Details;
            // 
            // userID
            // 
            this.userID.Text = "User ID";
            this.userID.Width = 200;
            // 
            // lastOnline
            // 
            this.lastOnline.Text = "Last Online";
            this.lastOnline.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFlush);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 832);
            this.panel1.TabIndex = 0;
            // 
            // btnFlush
            // 
            this.btnFlush.Location = new System.Drawing.Point(25, 104);
            this.btnFlush.Name = "btnFlush";
            this.btnFlush.Size = new System.Drawing.Size(247, 28);
            this.btnFlush.TabIndex = 2;
            this.btnFlush.Text = "Flush";
            this.btnFlush.UseVisualStyleBackColor = true;
            this.btnFlush.Click += new System.EventHandler(this.btnFlush_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(25, 70);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(247, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop server";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(247, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbQRLocation
            // 
            this.tbQRLocation.Controls.Add(this.panel2);
            this.tbQRLocation.Controls.Add(this.pnlQRLocation);
            this.tbQRLocation.Location = new System.Drawing.Point(4, 25);
            this.tbQRLocation.Name = "tbQRLocation";
            this.tbQRLocation.Size = new System.Drawing.Size(1496, 840);
            this.tbQRLocation.TabIndex = 3;
            this.tbQRLocation.Text = "QR location";
            this.tbQRLocation.UseVisualStyleBackColor = true;
            // 
            // pnlQRLocation
            // 
            this.pnlQRLocation.Controls.Add(this.lblQRy);
            this.pnlQRLocation.Controls.Add(this.lblQRx);
            this.pnlQRLocation.Controls.Add(this.lblQRName);
            this.pnlQRLocation.Controls.Add(this.lblQRID);
            this.pnlQRLocation.Controls.Add(this.tbQRName);
            this.pnlQRLocation.Controls.Add(this.tbQRx);
            this.pnlQRLocation.Controls.Add(this.tbQRy);
            this.pnlQRLocation.Controls.Add(this.tbQRID);
            this.pnlQRLocation.Controls.Add(this.btnDeleteQR);
            this.pnlQRLocation.Controls.Add(this.btnEditQR);
            this.pnlQRLocation.Controls.Add(this.btnAddQR);
            this.pnlQRLocation.Controls.Add(this.btnCreateQRConf);
            this.pnlQRLocation.Controls.Add(this.btnOpenQRConf);
            this.pnlQRLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlQRLocation.Location = new System.Drawing.Point(0, 0);
            this.pnlQRLocation.Name = "pnlQRLocation";
            this.pnlQRLocation.Size = new System.Drawing.Size(300, 840);
            this.pnlQRLocation.TabIndex = 0;
            // 
            // lblQRy
            // 
            this.lblQRy.AutoSize = true;
            this.lblQRy.Location = new System.Drawing.Point(148, 169);
            this.lblQRy.Name = "lblQRy";
            this.lblQRy.Size = new System.Drawing.Size(39, 16);
            this.lblQRy.TabIndex = 12;
            this.lblQRy.Text = "QR Y";
            // 
            // lblQRx
            // 
            this.lblQRx.AutoSize = true;
            this.lblQRx.Location = new System.Drawing.Point(21, 169);
            this.lblQRx.Name = "lblQRx";
            this.lblQRx.Size = new System.Drawing.Size(38, 16);
            this.lblQRx.TabIndex = 11;
            this.lblQRx.Text = "QR X";
            // 
            // lblQRName
            // 
            this.lblQRName.AutoSize = true;
            this.lblQRName.Location = new System.Drawing.Point(148, 107);
            this.lblQRName.Name = "lblQRName";
            this.lblQRName.Size = new System.Drawing.Size(67, 16);
            this.lblQRName.TabIndex = 10;
            this.lblQRName.Text = "QR Name";
            // 
            // lblQRID
            // 
            this.lblQRID.AutoSize = true;
            this.lblQRID.Location = new System.Drawing.Point(21, 107);
            this.lblQRID.Name = "lblQRID";
            this.lblQRID.Size = new System.Drawing.Size(43, 16);
            this.lblQRID.TabIndex = 9;
            this.lblQRID.Text = "QR ID";
            // 
            // tbQRName
            // 
            this.tbQRName.Location = new System.Drawing.Point(151, 126);
            this.tbQRName.Name = "tbQRName";
            this.tbQRName.Size = new System.Drawing.Size(120, 22);
            this.tbQRName.TabIndex = 8;
            // 
            // tbQRx
            // 
            this.tbQRx.Location = new System.Drawing.Point(24, 188);
            this.tbQRx.Name = "tbQRx";
            this.tbQRx.Size = new System.Drawing.Size(120, 22);
            this.tbQRx.TabIndex = 7;
            // 
            // tbQRy
            // 
            this.tbQRy.Location = new System.Drawing.Point(151, 188);
            this.tbQRy.Name = "tbQRy";
            this.tbQRy.Size = new System.Drawing.Size(120, 22);
            this.tbQRy.TabIndex = 6;
            // 
            // tbQRID
            // 
            this.tbQRID.Location = new System.Drawing.Point(24, 126);
            this.tbQRID.Name = "tbQRID";
            this.tbQRID.Size = new System.Drawing.Size(120, 22);
            this.tbQRID.TabIndex = 5;
            // 
            // btnDeleteQR
            // 
            this.btnDeleteQR.Location = new System.Drawing.Point(24, 304);
            this.btnDeleteQR.Name = "btnDeleteQR";
            this.btnDeleteQR.Size = new System.Drawing.Size(247, 28);
            this.btnDeleteQR.TabIndex = 4;
            this.btnDeleteQR.Text = "Delete QR";
            this.btnDeleteQR.UseVisualStyleBackColor = true;
            this.btnDeleteQR.Click += new System.EventHandler(this.btnDeleteQR_Click);
            // 
            // btnEditQR
            // 
            this.btnEditQR.Location = new System.Drawing.Point(24, 270);
            this.btnEditQR.Name = "btnEditQR";
            this.btnEditQR.Size = new System.Drawing.Size(247, 28);
            this.btnEditQR.TabIndex = 3;
            this.btnEditQR.Text = "Edit QR";
            this.btnEditQR.UseVisualStyleBackColor = true;
            this.btnEditQR.Click += new System.EventHandler(this.btnEditQR_Click);
            // 
            // btnAddQR
            // 
            this.btnAddQR.Location = new System.Drawing.Point(24, 236);
            this.btnAddQR.Name = "btnAddQR";
            this.btnAddQR.Size = new System.Drawing.Size(247, 28);
            this.btnAddQR.TabIndex = 2;
            this.btnAddQR.Text = "Add QR";
            this.btnAddQR.UseVisualStyleBackColor = true;
            this.btnAddQR.Click += new System.EventHandler(this.btnAddQR_Click);
            // 
            // btnCreateQRConf
            // 
            this.btnCreateQRConf.Location = new System.Drawing.Point(24, 59);
            this.btnCreateQRConf.Name = "btnCreateQRConf";
            this.btnCreateQRConf.Size = new System.Drawing.Size(247, 28);
            this.btnCreateQRConf.TabIndex = 1;
            this.btnCreateQRConf.Text = "Create QR config";
            this.btnCreateQRConf.UseVisualStyleBackColor = true;
            this.btnCreateQRConf.Click += new System.EventHandler(this.btnCreateQRConf_Click);
            // 
            // btnOpenQRConf
            // 
            this.btnOpenQRConf.Location = new System.Drawing.Point(24, 25);
            this.btnOpenQRConf.Name = "btnOpenQRConf";
            this.btnOpenQRConf.Size = new System.Drawing.Size(247, 28);
            this.btnOpenQRConf.TabIndex = 0;
            this.btnOpenQRConf.Text = "Open QR config";
            this.btnOpenQRConf.UseVisualStyleBackColor = true;
            this.btnOpenQRConf.Click += new System.EventHandler(this.btnOpenQRConf_Click);
            // 
            // tbHeatMap
            // 
            this.tbHeatMap.Location = new System.Drawing.Point(4, 25);
            this.tbHeatMap.Name = "tbHeatMap";
            this.tbHeatMap.Size = new System.Drawing.Size(1496, 840);
            this.tbHeatMap.TabIndex = 2;
            this.tbHeatMap.Text = "Heat Map";
            this.tbHeatMap.UseVisualStyleBackColor = true;
            // 
            // tmrListUpdate
            // 
            this.tmrListUpdate.Interval = 1000;
            this.tmrListUpdate.Tick += new System.EventHandler(this.tmrListUpdate_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbError);
            this.panel2.Controls.Add(this.tcQRLocation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 840);
            this.panel2.TabIndex = 2;
            // 
            // tcQRLocation
            // 
            this.tcQRLocation.Controls.Add(this.tbQRMap);
            this.tcQRLocation.Controls.Add(this.tbQRList);
            this.tcQRLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQRLocation.Location = new System.Drawing.Point(0, 0);
            this.tcQRLocation.Name = "tcQRLocation";
            this.tcQRLocation.SelectedIndex = 0;
            this.tcQRLocation.Size = new System.Drawing.Size(1196, 840);
            this.tcQRLocation.TabIndex = 2;
            // 
            // tbQRMap
            // 
            this.tbQRMap.Location = new System.Drawing.Point(4, 25);
            this.tbQRMap.Name = "tbQRMap";
            this.tbQRMap.Padding = new System.Windows.Forms.Padding(3);
            this.tbQRMap.Size = new System.Drawing.Size(1188, 811);
            this.tbQRMap.TabIndex = 0;
            this.tbQRMap.Text = "Map";
            this.tbQRMap.UseVisualStyleBackColor = true;
            // 
            // tbError
            // 
            this.tbError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbError.Location = new System.Drawing.Point(0, 818);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(1196, 22);
            this.tbError.TabIndex = 1;
            // 
            // tbQRList
            // 
            this.tbQRList.Controls.Add(this.lvQRList);
            this.tbQRList.Location = new System.Drawing.Point(4, 25);
            this.tbQRList.Name = "tbQRList";
            this.tbQRList.Padding = new System.Windows.Forms.Padding(3);
            this.tbQRList.Size = new System.Drawing.Size(1188, 811);
            this.tbQRList.TabIndex = 1;
            this.tbQRList.Text = "QR List";
            this.tbQRList.UseVisualStyleBackColor = true;
            // 
            // lvQRList
            // 
            this.lvQRList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colQRID,
            this.colQRName,
            this.colX,
            this.colY});
            this.lvQRList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvQRList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvQRList.FullRowSelect = true;
            this.lvQRList.GridLines = true;
            this.lvQRList.HideSelection = false;
            this.lvQRList.Location = new System.Drawing.Point(3, 3);
            this.lvQRList.Name = "lvQRList";
            this.lvQRList.Size = new System.Drawing.Size(1182, 805);
            this.lvQRList.TabIndex = 0;
            this.lvQRList.UseCompatibleStateImageBehavior = false;
            this.lvQRList.View = System.Windows.Forms.View.Details;
            this.lvQRList.SelectedIndexChanged += new System.EventHandler(this.lvQRList_SelectedIndexChanged);
            // 
            // colQRID
            // 
            this.colQRID.Text = "QR ID";
            this.colQRID.Width = 100;
            // 
            // colQRName
            // 
            this.colQRName.Text = "QR Name";
            this.colQRName.Width = 300;
            // 
            // colX
            // 
            this.colX.Text = "X";
            this.colX.Width = 100;
            // 
            // colY
            // 
            this.colY.Text = "Y";
            this.colY.Width = 100;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1504, 869);
            this.Controls.Add(this.tcMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmServer";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            tbSettings.ResumeLayout(false);
            this.pImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMapImage)).EndInit();
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tbManage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbLog.ResumeLayout(false);
            this.tbLog.PerformLayout();
            this.tbOnline.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tbQRLocation.ResumeLayout(false);
            this.pnlQRLocation.ResumeLayout(false);
            this.pnlQRLocation.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tcQRLocation.ResumeLayout(false);
            this.tbQRList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.Panel pImage;
        private System.Windows.Forms.TabPage tbManage;
        private System.Windows.Forms.Label lblCoordinateY2;
        private System.Windows.Forms.Label lblCoordinateX2;
        private System.Windows.Forms.Label lblCoordinateY1;
        private System.Windows.Forms.Button btnDownloadImage;
        private System.Windows.Forms.Label lblRealLength;
        private System.Windows.Forms.Label lblRealWidth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCoordinateX1;
        private System.Windows.Forms.PictureBox pbMapImage;
        private System.Windows.Forms.TextBox tbCoordinateY2;
        private System.Windows.Forms.TextBox tbCoordinateX2;
        private System.Windows.Forms.TextBox tbCoordinateY1;
        private System.Windows.Forms.TextBox tbCoordinateX1;
        private System.Windows.Forms.TextBox tbRealWidth;
        private System.Windows.Forms.TextBox tbRealLength;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tbHeatMap;
        private System.Windows.Forms.TabPage tbQRLocation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbLog;
        private System.Windows.Forms.TextBox txtbLog;
        private System.Windows.Forms.TabPage tbOnline;
        private System.Windows.Forms.ListView lvOnline;
        private System.Windows.Forms.ColumnHeader userID;
        private System.Windows.Forms.ColumnHeader lastOnline;
        private System.Windows.Forms.Button btnFlush;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrListUpdate;
        private System.Windows.Forms.Panel pnlQRLocation;
        private System.Windows.Forms.Button btnDeleteQR;
        private System.Windows.Forms.Button btnEditQR;
        private System.Windows.Forms.Button btnAddQR;
        private System.Windows.Forms.Button btnCreateQRConf;
        private System.Windows.Forms.Button btnOpenQRConf;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.TextBox tbQRName;
        private System.Windows.Forms.TextBox tbQRx;
        private System.Windows.Forms.TextBox tbQRy;
        private System.Windows.Forms.TextBox tbQRID;
        private System.Windows.Forms.Label lblQRy;
        private System.Windows.Forms.Label lblQRx;
        private System.Windows.Forms.Label lblQRName;
        private System.Windows.Forms.Label lblQRID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tcQRLocation;
        private System.Windows.Forms.TabPage tbQRMap;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.TabPage tbQRList;
        private System.Windows.Forms.ListView lvQRList;
        private System.Windows.Forms.ColumnHeader colQRID;
        private System.Windows.Forms.ColumnHeader colQRName;
        private System.Windows.Forms.ColumnHeader colX;
        private System.Windows.Forms.ColumnHeader colY;
    }
}
