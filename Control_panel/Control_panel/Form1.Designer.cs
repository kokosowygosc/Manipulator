using System;
namespace Control_panel
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.terminal = new System.Windows.Forms.TabPage();
            this.clear = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.PictureBox();
            this.connection = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.suwaki = new System.Windows.Forms.TabPage();
            this.play = new System.Windows.Forms.Button();
            this.stepbystep = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.control4 = new System.Windows.Forms.HScrollBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.HScrollBar();
            this.control5 = new System.Windows.Forms.HScrollBar();
            this.numeric5 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numeric4 = new System.Windows.Forms.NumericUpDown();
            this.control3 = new System.Windows.Forms.HScrollBar();
            this.numeric3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric2 = new System.Windows.Forms.NumericUpDown();
            this.control2 = new System.Windows.Forms.HScrollBar();
            this.control1 = new System.Windows.Forms.HScrollBar();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.options = new System.Windows.Forms.TabPage();
            this.bcancel = new System.Windows.Forms.Button();
            this.brefresh = new System.Windows.Forms.Button();
            this.bfabric = new System.Windows.Forms.Button();
            this.cbstop = new System.Windows.Forms.ComboBox();
            this.cbpair = new System.Windows.Forms.ComboBox();
            this.cbdata = new System.Windows.Forms.ComboBox();
            this.cbspeed = new System.Windows.Forms.ComboBox();
            this.cbport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.control6 = new System.Windows.Forms.HScrollBar();
            this.numeric6 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.terminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).BeginInit();
            this.suwaki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            this.options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.terminal);
            this.tabControl1.Controls.Add(this.suwaki);
            this.tabControl1.Controls.Add(this.options);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // terminal
            // 
            this.terminal.Controls.Add(this.clear);
            this.terminal.Controls.Add(this.status);
            this.terminal.Controls.Add(this.connection);
            this.terminal.Controls.Add(this.label6);
            this.terminal.Controls.Add(this.log);
            this.terminal.Location = new System.Drawing.Point(4, 22);
            this.terminal.Name = "terminal";
            this.terminal.Padding = new System.Windows.Forms.Padding(3);
            this.terminal.Size = new System.Drawing.Size(926, 535);
            this.terminal.TabIndex = 1;
            this.terminal.Text = "Terminal";
            this.terminal.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.Location = new System.Drawing.Point(727, 152);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(155, 37);
            this.clear.TabIndex = 5;
            this.clear.Text = "Wyczyść";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(22, 423);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(55, 50);
            this.status.TabIndex = 3;
            this.status.TabStop = false;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // connection
            // 
            this.connection.AutoSize = true;
            this.connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connection.Location = new System.Drawing.Point(19, 487);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(108, 16);
            this.connection.TabIndex = 2;
            this.connection.Text = "Brak połączenia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "LOG PROGRAMU";
            // 
            // log
            // 
            this.log.Enabled = false;
            this.log.Location = new System.Drawing.Point(32, 33);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.log.Size = new System.Drawing.Size(862, 80);
            this.log.TabIndex = 0;
            this.log.Text = "";
            this.log.TextChanged += new System.EventHandler(this.log_TextChanged);
            // 
            // suwaki
            // 
            this.suwaki.Controls.Add(this.label13);
            this.suwaki.Controls.Add(this.control6);
            this.suwaki.Controls.Add(this.numeric6);
            this.suwaki.Controls.Add(this.play);
            this.suwaki.Controls.Add(this.stepbystep);
            this.suwaki.Controls.Add(this.sub);
            this.suwaki.Controls.Add(this.add);
            this.suwaki.Controls.Add(this.control4);
            this.suwaki.Controls.Add(this.label11);
            this.suwaki.Controls.Add(this.label12);
            this.suwaki.Controls.Add(this.speed);
            this.suwaki.Controls.Add(this.control5);
            this.suwaki.Controls.Add(this.numeric5);
            this.suwaki.Controls.Add(this.label9);
            this.suwaki.Controls.Add(this.label10);
            this.suwaki.Controls.Add(this.numeric4);
            this.suwaki.Controls.Add(this.control3);
            this.suwaki.Controls.Add(this.numeric3);
            this.suwaki.Controls.Add(this.label8);
            this.suwaki.Controls.Add(this.label7);
            this.suwaki.Controls.Add(this.numeric2);
            this.suwaki.Controls.Add(this.control2);
            this.suwaki.Controls.Add(this.control1);
            this.suwaki.Controls.Add(this.numeric1);
            this.suwaki.Location = new System.Drawing.Point(4, 22);
            this.suwaki.Name = "suwaki";
            this.suwaki.Size = new System.Drawing.Size(926, 535);
            this.suwaki.TabIndex = 2;
            this.suwaki.Text = "Suwaki";
            this.suwaki.UseVisualStyleBackColor = true;
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play.Location = new System.Drawing.Point(361, 399);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(104, 106);
            this.play.TabIndex = 32;
            this.play.Text = "PLAY";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stepbystep
            // 
            this.stepbystep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.stepbystep.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.stepbystep.GridLines = true;
            this.stepbystep.HoverSelection = true;
            this.stepbystep.Location = new System.Drawing.Point(532, 21);
            this.stepbystep.Name = "stepbystep";
            this.stepbystep.Size = new System.Drawing.Size(374, 506);
            this.stepbystep.TabIndex = 31;
            this.stepbystep.UseCompatibleStateImageBehavior = false;
            this.stepbystep.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr kroku";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Serwo1";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Serwo2";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Serwo3";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Serwo4";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Serwo5";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Serwo6";
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sub.Location = new System.Drawing.Point(471, 455);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(47, 50);
            this.sub.TabIndex = 30;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Location = new System.Drawing.Point(471, 399);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(47, 50);
            this.add.TabIndex = 29;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // control4
            // 
            this.control4.Location = new System.Drawing.Point(281, 144);
            this.control4.Maximum = 180;
            this.control4.Name = "control4";
            this.control4.Size = new System.Drawing.Size(237, 60);
            this.control4.SmallChange = 5;
            this.control4.TabIndex = 28;
            this.control4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.control4_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Predkosc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Serwo 5";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(53, 430);
            this.speed.Maximum = 3000;
            this.speed.Minimum = 200;
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(237, 60);
            this.speed.SmallChange = 5;
            this.speed.TabIndex = 23;
            this.speed.Value = 1000;
            this.speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.control5_Scroll);
            // 
            // control5
            // 
            this.control5.Location = new System.Drawing.Point(19, 237);
            this.control5.Maximum = 180;
            this.control5.Name = "control5";
            this.control5.Size = new System.Drawing.Size(237, 60);
            this.control5.SmallChange = 5;
            this.control5.TabIndex = 23;
            this.control5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.control5_Scroll);
            // 
            // numeric5
            // 
            this.numeric5.Location = new System.Drawing.Point(19, 300);
            this.numeric5.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric5.Name = "numeric5";
            this.numeric5.Size = new System.Drawing.Size(77, 20);
            this.numeric5.TabIndex = 24;
            this.numeric5.ValueChanged += new System.EventHandler(this.numeric5_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Serwo 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Serwo 3";
            // 
            // numeric4
            // 
            this.numeric4.Location = new System.Drawing.Point(281, 207);
            this.numeric4.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric4.Name = "numeric4";
            this.numeric4.Size = new System.Drawing.Size(77, 20);
            this.numeric4.TabIndex = 20;
            this.numeric4.ValueChanged += new System.EventHandler(this.numeric4_ValueChanged);
            // 
            // control3
            // 
            this.control3.Location = new System.Drawing.Point(19, 144);
            this.control3.Maximum = 180;
            this.control3.Name = "control3";
            this.control3.Size = new System.Drawing.Size(237, 60);
            this.control3.SmallChange = 5;
            this.control3.TabIndex = 17;
            this.control3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.control3_Scroll);
            // 
            // numeric3
            // 
            this.numeric3.Location = new System.Drawing.Point(19, 207);
            this.numeric3.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric3.Name = "numeric3";
            this.numeric3.Size = new System.Drawing.Size(77, 20);
            this.numeric3.TabIndex = 18;
            this.numeric3.ValueChanged += new System.EventHandler(this.numeric3_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Serwo 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Serwo 1";
            // 
            // numeric2
            // 
            this.numeric2.Location = new System.Drawing.Point(281, 97);
            this.numeric2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(77, 20);
            this.numeric2.TabIndex = 14;
            this.numeric2.ValueChanged += new System.EventHandler(this.numeric2_ValueChanged);
            // 
            // control2
            // 
            this.control2.Location = new System.Drawing.Point(281, 34);
            this.control2.Maximum = 180;
            this.control2.Name = "control2";
            this.control2.Size = new System.Drawing.Size(237, 60);
            this.control2.SmallChange = 5;
            this.control2.TabIndex = 13;
            this.control2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.control2_Scroll);
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(19, 34);
            this.control1.Maximum = 180;
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(237, 60);
            this.control1.SmallChange = 5;
            this.control1.TabIndex = 11;
            this.control1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.control1_Scroll);
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(19, 97);
            this.numeric1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(77, 20);
            this.numeric1.TabIndex = 12;
            this.numeric1.ValueChanged += new System.EventHandler(this.numeric1_ValueChanged);
            // 
            // options
            // 
            this.options.Controls.Add(this.bcancel);
            this.options.Controls.Add(this.brefresh);
            this.options.Controls.Add(this.bfabric);
            this.options.Controls.Add(this.cbstop);
            this.options.Controls.Add(this.cbpair);
            this.options.Controls.Add(this.cbdata);
            this.options.Controls.Add(this.cbspeed);
            this.options.Controls.Add(this.cbport);
            this.options.Controls.Add(this.label5);
            this.options.Controls.Add(this.label4);
            this.options.Controls.Add(this.label3);
            this.options.Controls.Add(this.label2);
            this.options.Controls.Add(this.label1);
            this.options.Location = new System.Drawing.Point(4, 22);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(926, 535);
            this.options.TabIndex = 3;
            this.options.Text = "Opcje";
            this.options.UseVisualStyleBackColor = true;
            // 
            // bcancel
            // 
            this.bcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bcancel.Location = new System.Drawing.Point(369, 378);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(157, 49);
            this.bcancel.TabIndex = 12;
            this.bcancel.Text = "Anuluj";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // brefresh
            // 
            this.brefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brefresh.Location = new System.Drawing.Point(194, 378);
            this.brefresh.Name = "brefresh";
            this.brefresh.Size = new System.Drawing.Size(157, 49);
            this.brefresh.TabIndex = 11;
            this.brefresh.Text = "Odśwież";
            this.brefresh.UseVisualStyleBackColor = true;
            this.brefresh.Click += new System.EventHandler(this.options_Enter);
            // 
            // bfabric
            // 
            this.bfabric.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bfabric.Location = new System.Drawing.Point(19, 378);
            this.bfabric.Name = "bfabric";
            this.bfabric.Size = new System.Drawing.Size(157, 49);
            this.bfabric.TabIndex = 10;
            this.bfabric.Text = "Domyślne";
            this.bfabric.UseVisualStyleBackColor = true;
            this.bfabric.Click += new System.EventHandler(this.bfabric_Click);
            // 
            // cbstop
            // 
            this.cbstop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbstop.FormattingEnabled = true;
            this.cbstop.Location = new System.Drawing.Point(269, 296);
            this.cbstop.Name = "cbstop";
            this.cbstop.Size = new System.Drawing.Size(257, 32);
            this.cbstop.TabIndex = 9;
            // 
            // cbpair
            // 
            this.cbpair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbpair.FormattingEnabled = true;
            this.cbpair.Location = new System.Drawing.Point(269, 226);
            this.cbpair.Name = "cbpair";
            this.cbpair.Size = new System.Drawing.Size(257, 32);
            this.cbpair.TabIndex = 8;
            // 
            // cbdata
            // 
            this.cbdata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbdata.FormattingEnabled = true;
            this.cbdata.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbdata.Location = new System.Drawing.Point(269, 154);
            this.cbdata.Name = "cbdata";
            this.cbdata.Size = new System.Drawing.Size(257, 32);
            this.cbdata.TabIndex = 7;
            // 
            // cbspeed
            // 
            this.cbspeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbspeed.FormattingEnabled = true;
            this.cbspeed.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.cbspeed.Location = new System.Drawing.Point(269, 80);
            this.cbspeed.Name = "cbspeed";
            this.cbspeed.Size = new System.Drawing.Size(257, 32);
            this.cbspeed.TabIndex = 6;
            // 
            // cbport
            // 
            this.cbport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbport.FormattingEnabled = true;
            this.cbport.Location = new System.Drawing.Point(269, 11);
            this.cbport.Name = "cbport";
            this.cbport.Size = new System.Drawing.Size(257, 32);
            this.cbport.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bity stopu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bity parzystości:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bity danych: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prędkość: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa portu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Serwo 5";
            // 
            // control6
            // 
            this.control6.Location = new System.Drawing.Point(281, 237);
            this.control6.Maximum = 180;
            this.control6.Name = "control6";
            this.control6.Size = new System.Drawing.Size(237, 60);
            this.control6.SmallChange = 5;
            this.control6.TabIndex = 33;
            this.control6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.control6_Scroll);
            // 
            // numeric6
            // 
            this.numeric6.Location = new System.Drawing.Point(281, 300);
            this.numeric6.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric6.Name = "numeric6";
            this.numeric6.Size = new System.Drawing.Size(77, 20);
            this.numeric6.TabIndex = 34;
            this.numeric6.ValueChanged += new System.EventHandler(this.numeric6_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Panel Kontrolny";
            this.tabControl1.ResumeLayout(false);
            this.terminal.ResumeLayout(false);
            this.terminal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).EndInit();
            this.suwaki.ResumeLayout(false);
            this.suwaki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage terminal;
        private System.Windows.Forms.TabPage suwaki;
        private System.Windows.Forms.TabPage options;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Button brefresh;
        private System.Windows.Forms.Button bfabric;
        private System.Windows.Forms.ComboBox cbstop;
        private System.Windows.Forms.ComboBox cbpair;
        private System.Windows.Forms.ComboBox cbdata;
        private System.Windows.Forms.ComboBox cbspeed;
        private System.Windows.Forms.ComboBox cbport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.PictureBox status;
        private System.Windows.Forms.Label connection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.HScrollBar control5;
        private System.Windows.Forms.NumericUpDown numeric5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numeric4;
        private System.Windows.Forms.HScrollBar control3;
        private System.Windows.Forms.NumericUpDown numeric3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeric2;
        private System.Windows.Forms.HScrollBar control2;
        private System.Windows.Forms.HScrollBar control1;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.HScrollBar control4;
        private System.Windows.Forms.ListView stepbystep;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.HScrollBar speed;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.HScrollBar control6;
        private System.Windows.Forms.NumericUpDown numeric6;
    }
}

