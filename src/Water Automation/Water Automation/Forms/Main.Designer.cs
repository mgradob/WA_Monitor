namespace Water_Automation
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_invalid_data = new System.Windows.Forms.RichTextBox();
            this.tbx_timeout = new System.Windows.Forms.RichTextBox();
            this.panelSerialPort = new System.Windows.Forms.Panel();
            this.btnComClose = new System.Windows.Forms.Button();
            this.btnComConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSerialPort = new System.Windows.Forms.ComboBox();
            this.panelLatestData = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWndSpd = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEto = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chartEto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbxPoints = new System.Windows.Forms.CheckBox();
            this.cbxEto = new System.Windows.Forms.CheckBox();
            this.cbxSensor6 = new System.Windows.Forms.CheckBox();
            this.cbxSensor5 = new System.Windows.Forms.CheckBox();
            this.cbxSensor4 = new System.Windows.Forms.CheckBox();
            this.cbxSensor3 = new System.Windows.Forms.CheckBox();
            this.cbxSensor2 = new System.Windows.Forms.CheckBox();
            this.cbxSensor1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.panelSerialPort.SuspendLayout();
            this.panelLatestData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEto)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_grid.BackgroundColor = System.Drawing.Color.White;
            this.data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.data_grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.data_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid.GridColor = System.Drawing.Color.White;
            this.data_grid.Location = new System.Drawing.Point(266, 11);
            this.data_grid.MultiSelect = false;
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            this.data_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.data_grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_grid.Size = new System.Drawing.Size(720, 365);
            this.data_grid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Invalid Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timeouts:";
            // 
            // tbx_invalid_data
            // 
            this.tbx_invalid_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_invalid_data.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_invalid_data.ForeColor = System.Drawing.Color.DimGray;
            this.tbx_invalid_data.Location = new System.Drawing.Point(2, 27);
            this.tbx_invalid_data.Name = "tbx_invalid_data";
            this.tbx_invalid_data.Size = new System.Drawing.Size(236, 141);
            this.tbx_invalid_data.TabIndex = 6;
            this.tbx_invalid_data.Text = "";
            // 
            // tbx_timeout
            // 
            this.tbx_timeout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_timeout.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_timeout.ForeColor = System.Drawing.Color.DimGray;
            this.tbx_timeout.Location = new System.Drawing.Point(2, 24);
            this.tbx_timeout.Name = "tbx_timeout";
            this.tbx_timeout.Size = new System.Drawing.Size(236, 131);
            this.tbx_timeout.TabIndex = 7;
            this.tbx_timeout.Text = "";
            // 
            // panelSerialPort
            // 
            this.panelSerialPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSerialPort.Controls.Add(this.btnComClose);
            this.panelSerialPort.Controls.Add(this.btnComConnect);
            this.panelSerialPort.Controls.Add(this.label3);
            this.panelSerialPort.Controls.Add(this.cbxSerialPort);
            this.panelSerialPort.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSerialPort.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSerialPort.Location = new System.Drawing.Point(13, 11);
            this.panelSerialPort.Name = "panelSerialPort";
            this.panelSerialPort.Size = new System.Drawing.Size(247, 64);
            this.panelSerialPort.TabIndex = 8;
            // 
            // btnComClose
            // 
            this.btnComClose.BackColor = System.Drawing.Color.Teal;
            this.btnComClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComClose.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComClose.Location = new System.Drawing.Point(125, 31);
            this.btnComClose.Name = "btnComClose";
            this.btnComClose.Size = new System.Drawing.Size(120, 30);
            this.btnComClose.TabIndex = 3;
            this.btnComClose.Text = "Close";
            this.btnComClose.UseVisualStyleBackColor = false;
            this.btnComClose.Click += new System.EventHandler(this.btnComClose_Click);
            // 
            // btnComConnect
            // 
            this.btnComConnect.BackColor = System.Drawing.Color.Teal;
            this.btnComConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComConnect.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComConnect.Location = new System.Drawing.Point(4, 31);
            this.btnComConnect.Name = "btnComConnect";
            this.btnComConnect.Size = new System.Drawing.Size(120, 30);
            this.btnComConnect.TabIndex = 2;
            this.btnComConnect.Text = "Connect";
            this.btnComConnect.UseVisualStyleBackColor = false;
            this.btnComConnect.Click += new System.EventHandler(this.btnComConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "COM Ports:";
            // 
            // cbxSerialPort
            // 
            this.cbxSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSerialPort.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSerialPort.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxSerialPort.FormattingEnabled = true;
            this.cbxSerialPort.Location = new System.Drawing.Point(75, 6);
            this.cbxSerialPort.Name = "cbxSerialPort";
            this.cbxSerialPort.Size = new System.Drawing.Size(168, 23);
            this.cbxSerialPort.TabIndex = 0;
            this.cbxSerialPort.DropDown += new System.EventHandler(this.cbxSerialPort_DropDown);
            // 
            // panelLatestData
            // 
            this.panelLatestData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelLatestData.Controls.Add(this.label7);
            this.panelLatestData.Controls.Add(this.lblWndSpd);
            this.panelLatestData.Controls.Add(this.pictureBox3);
            this.panelLatestData.Controls.Add(this.label9);
            this.panelLatestData.Controls.Add(this.lblEto);
            this.panelLatestData.Controls.Add(this.pictureBox4);
            this.panelLatestData.Controls.Add(this.label6);
            this.panelLatestData.Controls.Add(this.label5);
            this.panelLatestData.Controls.Add(this.lblTemp);
            this.panelLatestData.Controls.Add(this.pictureBox2);
            this.panelLatestData.Controls.Add(this.label4);
            this.panelLatestData.Controls.Add(this.lblHumidity);
            this.panelLatestData.Controls.Add(this.pictureBox1);
            this.panelLatestData.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLatestData.Location = new System.Drawing.Point(13, 81);
            this.panelLatestData.Name = "panelLatestData";
            this.panelLatestData.Size = new System.Drawing.Size(247, 295);
            this.panelLatestData.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(73, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Wind Speed";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWndSpd
            // 
            this.lblWndSpd.AutoSize = true;
            this.lblWndSpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWndSpd.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWndSpd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWndSpd.Location = new System.Drawing.Point(73, 239);
            this.lblWndSpd.Name = "lblWndSpd";
            this.lblWndSpd.Size = new System.Drawing.Size(77, 25);
            this.lblWndSpd.TabIndex = 11;
            this.lblWndSpd.Text = "--.-- m/s";
            this.lblWndSpd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Water_Automation.Properties.Resources.wnd;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(7, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(73, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Evapotranspiration";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEto
            // 
            this.lblEto.AutoSize = true;
            this.lblEto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEto.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEto.Location = new System.Drawing.Point(73, 173);
            this.lblEto.Name = "lblEto";
            this.lblEto.Size = new System.Drawing.Size(76, 25);
            this.lblEto.TabIndex = 8;
            this.lblEto.Text = "--.-- mm";
            this.lblEto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Water_Automation.Properties.Resources.sun;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(7, 163);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Current Values";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(73, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Temperature";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTemp.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTemp.Location = new System.Drawing.Point(73, 107);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(61, 25);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "--.-- °C";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Water_Automation.Properties.Resources.tmp;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(7, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(73, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Humidity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHumidity.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHumidity.Location = new System.Drawing.Point(73, 41);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(56, 25);
            this.lblHumidity.TabIndex = 1;
            this.lblHumidity.Text = "--.-- %";
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Water_Automation.Properties.Resources.hmdty;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(7, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbx_invalid_data);
            this.panel1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(992, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 171);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbx_timeout);
            this.panel2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(992, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 158);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(13, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 25);
            this.panel3.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatus.Location = new System.Drawing.Point(67, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 21);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(2, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Status:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.chartEto);
            this.panel4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(12, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1033, 253);
            this.panel4.TabIndex = 15;
            // 
            // chartEto
            // 
            this.chartEto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chartEto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chartEto.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "etoChartArea";
            this.chartEto.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEto.Legends.Add(legend1);
            this.chartEto.Location = new System.Drawing.Point(3, 3);
            this.chartEto.Name = "chartEto";
            series1.ChartArea = "etoChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Evapotranspiration";
            series2.ChartArea = "etoChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Sensor1";
            series3.ChartArea = "etoChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Sensor2";
            series4.ChartArea = "etoChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Sensor3";
            series5.ChartArea = "etoChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Sensor4";
            series6.ChartArea = "etoChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Sensor5";
            series7.ChartArea = "etoChartArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Sensor6";
            this.chartEto.Series.Add(series1);
            this.chartEto.Series.Add(series2);
            this.chartEto.Series.Add(series3);
            this.chartEto.Series.Add(series4);
            this.chartEto.Series.Add(series5);
            this.chartEto.Series.Add(series6);
            this.chartEto.Series.Add(series7);
            this.chartEto.Size = new System.Drawing.Size(1027, 247);
            this.chartEto.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.btnExport);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(992, 381);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 25);
            this.panel5.TabIndex = 9;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Teal;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExport.Location = new System.Drawing.Point(125, -1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(117, 30);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Export chart to .jpg";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.lblTime);
            this.panel6.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(992, 351);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 25);
            this.panel6.TabIndex = 10;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(14, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 18);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "clock";
            // 
            // timer_clock
            // 
            this.timer_clock.Enabled = true;
            this.timer_clock.Interval = 1000;
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.cbxPoints);
            this.panel7.Controls.Add(this.cbxEto);
            this.panel7.Controls.Add(this.cbxSensor6);
            this.panel7.Controls.Add(this.cbxSensor5);
            this.panel7.Controls.Add(this.cbxSensor4);
            this.panel7.Controls.Add(this.cbxSensor3);
            this.panel7.Controls.Add(this.cbxSensor2);
            this.panel7.Controls.Add(this.cbxSensor1);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.Location = new System.Drawing.Point(1051, 412);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(183, 254);
            this.panel7.TabIndex = 10;
            // 
            // cbxPoints
            // 
            this.cbxPoints.AutoSize = true;
            this.cbxPoints.Location = new System.Drawing.Point(6, 200);
            this.cbxPoints.Name = "cbxPoints";
            this.cbxPoints.Size = new System.Drawing.Size(58, 19);
            this.cbxPoints.TabIndex = 23;
            this.cbxPoints.Text = "Points";
            this.cbxPoints.UseVisualStyleBackColor = true;
            this.cbxPoints.CheckedChanged += new System.EventHandler(this.cbxPoints_CheckedChanged);
            // 
            // cbxEto
            // 
            this.cbxEto.AutoSize = true;
            this.cbxEto.Location = new System.Drawing.Point(6, 175);
            this.cbxEto.Name = "cbxEto";
            this.cbxEto.Size = new System.Drawing.Size(120, 19);
            this.cbxEto.TabIndex = 22;
            this.cbxEto.Text = "Evapotranspiration";
            this.cbxEto.UseVisualStyleBackColor = true;
            this.cbxEto.CheckedChanged += new System.EventHandler(this.cbxEto_CheckedChanged);
            // 
            // cbxSensor6
            // 
            this.cbxSensor6.AutoSize = true;
            this.cbxSensor6.Location = new System.Drawing.Point(6, 150);
            this.cbxSensor6.Name = "cbxSensor6";
            this.cbxSensor6.Size = new System.Drawing.Size(67, 19);
            this.cbxSensor6.TabIndex = 21;
            this.cbxSensor6.Text = "Sensor6";
            this.cbxSensor6.UseVisualStyleBackColor = true;
            this.cbxSensor6.CheckedChanged += new System.EventHandler(this.cbxSensor6_CheckedChanged);
            // 
            // cbxSensor5
            // 
            this.cbxSensor5.AutoSize = true;
            this.cbxSensor5.Location = new System.Drawing.Point(6, 125);
            this.cbxSensor5.Name = "cbxSensor5";
            this.cbxSensor5.Size = new System.Drawing.Size(67, 19);
            this.cbxSensor5.TabIndex = 20;
            this.cbxSensor5.Text = "Sensor5";
            this.cbxSensor5.UseVisualStyleBackColor = true;
            this.cbxSensor5.CheckedChanged += new System.EventHandler(this.cbxSensor5_CheckedChanged);
            // 
            // cbxSensor4
            // 
            this.cbxSensor4.AutoSize = true;
            this.cbxSensor4.Location = new System.Drawing.Point(7, 100);
            this.cbxSensor4.Name = "cbxSensor4";
            this.cbxSensor4.Size = new System.Drawing.Size(67, 19);
            this.cbxSensor4.TabIndex = 19;
            this.cbxSensor4.Text = "Sensor4";
            this.cbxSensor4.UseVisualStyleBackColor = true;
            this.cbxSensor4.CheckedChanged += new System.EventHandler(this.cbxSensor4_CheckedChanged);
            // 
            // cbxSensor3
            // 
            this.cbxSensor3.AutoSize = true;
            this.cbxSensor3.Location = new System.Drawing.Point(7, 75);
            this.cbxSensor3.Name = "cbxSensor3";
            this.cbxSensor3.Size = new System.Drawing.Size(67, 19);
            this.cbxSensor3.TabIndex = 18;
            this.cbxSensor3.Text = "Sensor3";
            this.cbxSensor3.UseVisualStyleBackColor = true;
            this.cbxSensor3.CheckedChanged += new System.EventHandler(this.cbxSensor3_CheckedChanged);
            // 
            // cbxSensor2
            // 
            this.cbxSensor2.AutoSize = true;
            this.cbxSensor2.Location = new System.Drawing.Point(6, 50);
            this.cbxSensor2.Name = "cbxSensor2";
            this.cbxSensor2.Size = new System.Drawing.Size(67, 19);
            this.cbxSensor2.TabIndex = 17;
            this.cbxSensor2.Text = "Sensor2";
            this.cbxSensor2.UseVisualStyleBackColor = true;
            this.cbxSensor2.CheckedChanged += new System.EventHandler(this.cbxSensor2_CheckedChanged);
            // 
            // cbxSensor1
            // 
            this.cbxSensor1.AutoSize = true;
            this.cbxSensor1.Location = new System.Drawing.Point(6, 25);
            this.cbxSensor1.Name = "cbxSensor1";
            this.cbxSensor1.Size = new System.Drawing.Size(67, 19);
            this.cbxSensor1.TabIndex = 16;
            this.cbxSensor1.Text = "Sensor1";
            this.cbxSensor1.UseVisualStyleBackColor = true;
            this.cbxSensor1.CheckedChanged += new System.EventHandler(this.cbxSensor1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Chart data:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1245, 678);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLatestData);
            this.Controls.Add(this.panelSerialPort);
            this.Controls.Add(this.data_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Automation";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.panelSerialPort.ResumeLayout(false);
            this.panelSerialPort.PerformLayout();
            this.panelLatestData.ResumeLayout(false);
            this.panelLatestData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEto)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbx_timeout;
        private System.Windows.Forms.RichTextBox tbx_invalid_data;
        private System.Windows.Forms.Panel panelSerialPort;
        private System.Windows.Forms.Button btnComConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSerialPort;
        private System.Windows.Forms.Panel panelLatestData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWndSpd;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEto;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnComClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer_clock;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbxSensor1;
        private System.Windows.Forms.CheckBox cbxPoints;
        private System.Windows.Forms.CheckBox cbxEto;
        private System.Windows.Forms.CheckBox cbxSensor6;
        private System.Windows.Forms.CheckBox cbxSensor5;
        private System.Windows.Forms.CheckBox cbxSensor4;
        private System.Windows.Forms.CheckBox cbxSensor3;
        private System.Windows.Forms.CheckBox cbxSensor2;
    }
}

