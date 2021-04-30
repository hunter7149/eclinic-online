namespace eclinic
{
    partial class userinfo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userinfo2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.doctorlist1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.INFO = new System.Windows.Forms.Label();
            this.info6 = new System.Windows.Forms.Label();
            this.info5 = new System.Windows.Forms.Label();
            this.info4 = new System.Windows.Forms.Label();
            this.info3 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            this.neuro = new System.Windows.Forms.Button();
            this.gyn = new System.Windows.Forms.Button();
            this.pediat = new System.Windows.Forms.Button();
            this.surgery = new System.Windows.Forms.Button();
            this.cancer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radiology = new System.Windows.Forms.Button();
            this.dermat = new System.Windows.Forms.Button();
            this.allergy = new System.Windows.Forms.Button();
            this.emed = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorlist1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 447);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.confirm);
            this.panel5.Controls.Add(this.doctorlist1);
            this.panel5.Location = new System.Drawing.Point(400, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 284);
            this.panel5.TabIndex = 1;
            this.panel5.Visible = false;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(8, 223);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "SEARCH:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(75, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(94, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 22);
            this.label17.TabIndex = 8;
            this.label17.Text = "SELECT A DOCTOR: ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Green;
            this.confirm.FlatAppearance.BorderSize = 0;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirm.Location = new System.Drawing.Point(304, 257);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(85, 24);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "CONFIRM";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // doctorlist1
            // 
            this.doctorlist1.AllowUserToAddRows = false;
            this.doctorlist1.AllowUserToDeleteRows = false;
            this.doctorlist1.AllowUserToResizeColumns = false;
            this.doctorlist1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.doctorlist1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.doctorlist1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctorlist1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorlist1.BackgroundColor = System.Drawing.Color.Maroon;
            this.doctorlist1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doctorlist1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.doctorlist1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorlist1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.doctorlist1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.doctorlist1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doctorlist1.DefaultCellStyle = dataGridViewCellStyle6;
            this.doctorlist1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.doctorlist1.Location = new System.Drawing.Point(6, 30);
            this.doctorlist1.MultiSelect = false;
            this.doctorlist1.Name = "doctorlist1";
            this.doctorlist1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.doctorlist1.RowHeadersVisible = false;
            this.doctorlist1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.doctorlist1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.doctorlist1.Size = new System.Drawing.Size(380, 180);
            this.doctorlist1.TabIndex = 0;
            this.doctorlist1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorlist1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.next);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Location = new System.Drawing.Point(400, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 163);
            this.panel4.TabIndex = 1;
            this.panel4.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.HotTrack;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.next.Location = new System.Drawing.Point(192, 126);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(194, 27);
            this.next.TabIndex = 5;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "YOUR PROBLEM:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(192, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 78);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECT  DATE : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DarkRed;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 14);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.INFO);
            this.panel3.Controls.Add(this.info6);
            this.panel3.Controls.Add(this.info5);
            this.panel3.Controls.Add(this.info4);
            this.panel3.Controls.Add(this.info3);
            this.panel3.Controls.Add(this.info2);
            this.panel3.Controls.Add(this.info1);
            this.panel3.Controls.Add(this.neuro);
            this.panel3.Controls.Add(this.gyn);
            this.panel3.Controls.Add(this.pediat);
            this.panel3.Controls.Add(this.surgery);
            this.panel3.Controls.Add(this.cancer);
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 447);
            this.panel3.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Honeydew;
            this.label21.Location = new System.Drawing.Point(3, 393);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 21);
            this.label21.TabIndex = 26;
            this.label21.Text = " BILLING ID:";
            this.label21.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label19.Location = new System.Drawing.Point(3, 352);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 21);
            this.label19.TabIndex = 24;
            this.label19.Text = " FEE:";
            this.label19.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(99, 393);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 18);
            this.label16.TabIndex = 23;
            this.label16.Text = " ";
            this.label16.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Snow;
            this.label14.Location = new System.Drawing.Point(3, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = " ";
            this.label14.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(50, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = " ";
            this.label12.Visible = false;
            // 
            // INFO
            // 
            this.INFO.AutoSize = true;
            this.INFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INFO.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INFO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.INFO.Location = new System.Drawing.Point(9, 23);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(177, 16);
            this.INFO.TabIndex = 12;
            this.INFO.Text = "PATIENT\'S INFORMATION: ";
            this.INFO.Visible = false;
            this.INFO.Click += new System.EventHandler(this.INFO_Click);
            // 
            // info6
            // 
            this.info6.AutoSize = true;
            this.info6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info6.ForeColor = System.Drawing.Color.Red;
            this.info6.Location = new System.Drawing.Point(2, 310);
            this.info6.Name = "info6";
            this.info6.Size = new System.Drawing.Size(13, 19);
            this.info6.TabIndex = 11;
            this.info6.Text = " ";
            this.info6.Visible = false;
            this.info6.Click += new System.EventHandler(this.info6_Click);
            // 
            // info5
            // 
            this.info5.AutoSize = true;
            this.info5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info5.Location = new System.Drawing.Point(4, 216);
            this.info5.Name = "info5";
            this.info5.Size = new System.Drawing.Size(12, 16);
            this.info5.TabIndex = 10;
            this.info5.Text = " ";
            this.info5.Visible = false;
            this.info5.Click += new System.EventHandler(this.info5_Click);
            // 
            // info4
            // 
            this.info4.AutoSize = true;
            this.info4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info4.Location = new System.Drawing.Point(4, 184);
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(12, 16);
            this.info4.TabIndex = 9;
            this.info4.Text = " ";
            this.info4.Visible = false;
            this.info4.Click += new System.EventHandler(this.info4_Click);
            // 
            // info3
            // 
            this.info3.AutoSize = true;
            this.info3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info3.Location = new System.Drawing.Point(4, 140);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(12, 16);
            this.info3.TabIndex = 8;
            this.info3.Text = " ";
            this.info3.Visible = false;
            this.info3.Click += new System.EventHandler(this.info3_Click);
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info2.Location = new System.Drawing.Point(3, 108);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(12, 16);
            this.info2.TabIndex = 7;
            this.info2.Text = " ";
            this.info2.Visible = false;
            this.info2.Click += new System.EventHandler(this.info2_Click);
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info1.Location = new System.Drawing.Point(4, 75);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(12, 16);
            this.info1.TabIndex = 6;
            this.info1.Text = " ";
            this.info1.Visible = false;
            this.info1.Click += new System.EventHandler(this.info1_Click);
            // 
            // neuro
            // 
            this.neuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.neuro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.neuro.FlatAppearance.BorderSize = 0;
            this.neuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neuro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.neuro.Location = new System.Drawing.Point(3, 363);
            this.neuro.Name = "neuro";
            this.neuro.Size = new System.Drawing.Size(194, 59);
            this.neuro.TabIndex = 5;
            this.neuro.Text = "N E U R O L O G Y";
            this.neuro.UseVisualStyleBackColor = false;
            this.neuro.Click += new System.EventHandler(this.neuro_Click);
            // 
            // gyn
            // 
            this.gyn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gyn.BackColor = System.Drawing.Color.Crimson;
            this.gyn.FlatAppearance.BorderSize = 0;
            this.gyn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gyn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gyn.Location = new System.Drawing.Point(3, 281);
            this.gyn.Name = "gyn";
            this.gyn.Size = new System.Drawing.Size(194, 59);
            this.gyn.TabIndex = 5;
            this.gyn.Text = "G Y N E C O L O G Y";
            this.gyn.UseVisualStyleBackColor = false;
            this.gyn.Click += new System.EventHandler(this.gyn_Click);
            // 
            // pediat
            // 
            this.pediat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pediat.BackColor = System.Drawing.Color.Navy;
            this.pediat.FlatAppearance.BorderSize = 0;
            this.pediat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pediat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pediat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pediat.Location = new System.Drawing.Point(3, 194);
            this.pediat.Name = "pediat";
            this.pediat.Size = new System.Drawing.Size(194, 59);
            this.pediat.TabIndex = 6;
            this.pediat.Text = "P E D I A T R I C S";
            this.pediat.UseVisualStyleBackColor = false;
            this.pediat.Click += new System.EventHandler(this.pediat_Click);
            // 
            // surgery
            // 
            this.surgery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surgery.BackColor = System.Drawing.Color.DarkCyan;
            this.surgery.FlatAppearance.BorderSize = 0;
            this.surgery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surgery.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.surgery.Location = new System.Drawing.Point(3, 107);
            this.surgery.Name = "surgery";
            this.surgery.Size = new System.Drawing.Size(194, 59);
            this.surgery.TabIndex = 5;
            this.surgery.Text = "S U R G E R Y";
            this.surgery.UseVisualStyleBackColor = false;
            this.surgery.Click += new System.EventHandler(this.surgery_Click);
            // 
            // cancer
            // 
            this.cancer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancer.BackColor = System.Drawing.Color.DarkGreen;
            this.cancer.FlatAppearance.BorderSize = 0;
            this.cancer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancer.Location = new System.Drawing.Point(3, 23);
            this.cancer.Name = "cancer";
            this.cancer.Size = new System.Drawing.Size(194, 59);
            this.cancer.TabIndex = 5;
            this.cancer.Text = "O N C O L O G Y";
            this.cancer.UseVisualStyleBackColor = false;
            this.cancer.Click += new System.EventHandler(this.cancer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.radiology);
            this.panel2.Controls.Add(this.dermat);
            this.panel2.Controls.Add(this.allergy);
            this.panel2.Controls.Add(this.emed);
            this.panel2.Controls.Add(this.help);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 447);
            this.panel2.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Honeydew;
            this.label20.Location = new System.Drawing.Point(0, 393);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 21);
            this.label20.TabIndex = 25;
            this.label20.Text = " BILLING ID: ";
            this.label20.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Honeydew;
            this.label18.Location = new System.Drawing.Point(9, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 21);
            this.label18.TabIndex = 23;
            this.label18.Text = " FEE:";
            this.label18.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gold;
            this.label15.Location = new System.Drawing.Point(102, 393);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = " ";
            this.label15.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(62, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = " ";
            this.label13.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(19, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = " ";
            this.label11.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "PATIENT\'S INFORMATION: ";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(18, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = " ";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(19, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = " ";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(19, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = " ";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(19, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = " ";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(19, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = " ";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(19, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = " ";
            this.label10.Visible = false;
            // 
            // radiology
            // 
            this.radiology.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radiology.BackColor = System.Drawing.Color.DarkGreen;
            this.radiology.FlatAppearance.BorderSize = 0;
            this.radiology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiology.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiology.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radiology.Location = new System.Drawing.Point(3, 281);
            this.radiology.Name = "radiology";
            this.radiology.Size = new System.Drawing.Size(194, 59);
            this.radiology.TabIndex = 3;
            this.radiology.Text = "R A D I O L O G Y";
            this.radiology.UseVisualStyleBackColor = false;
            this.radiology.Click += new System.EventHandler(this.radiology_Click);
            // 
            // dermat
            // 
            this.dermat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dermat.BackColor = System.Drawing.Color.Maroon;
            this.dermat.FlatAppearance.BorderSize = 0;
            this.dermat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dermat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dermat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dermat.Location = new System.Drawing.Point(3, 195);
            this.dermat.Name = "dermat";
            this.dermat.Size = new System.Drawing.Size(194, 59);
            this.dermat.TabIndex = 2;
            this.dermat.Text = "D E R M A T O L O G Y";
            this.dermat.UseVisualStyleBackColor = false;
            this.dermat.Click += new System.EventHandler(this.dermat_Click);
            // 
            // allergy
            // 
            this.allergy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allergy.BackColor = System.Drawing.Color.Olive;
            this.allergy.FlatAppearance.BorderSize = 0;
            this.allergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allergy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.allergy.Location = new System.Drawing.Point(3, 107);
            this.allergy.Name = "allergy";
            this.allergy.Size = new System.Drawing.Size(194, 59);
            this.allergy.TabIndex = 1;
            this.allergy.Text = "A L L E R G Y &\r\n I M M U N O L O G Y";
            this.allergy.UseVisualStyleBackColor = false;
            this.allergy.Click += new System.EventHandler(this.allergy_Click);
            // 
            // emed
            // 
            this.emed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.emed.FlatAppearance.BorderSize = 0;
            this.emed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emed.Location = new System.Drawing.Point(3, 23);
            this.emed.Name = "emed";
            this.emed.Size = new System.Drawing.Size(194, 59);
            this.emed.TabIndex = 0;
            this.emed.Text = "M E D I C I N E";
            this.emed.UseVisualStyleBackColor = false;
            this.emed.Click += new System.EventHandler(this.emed_Click);
            // 
            // help
            // 
            this.help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.help.BackColor = System.Drawing.Color.Red;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.help.Location = new System.Drawing.Point(3, 363);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(194, 59);
            this.help.TabIndex = 4;
            this.help.Text = "I  D O N\'T \r\nK N O W";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // userinfo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(795, 449);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userinfo2";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userinfo2";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorlist1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button radiology;
        private System.Windows.Forms.Button dermat;
        private System.Windows.Forms.Button allergy;
        private System.Windows.Forms.Button emed;
        private System.Windows.Forms.DataGridView doctorlist1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button neuro;
        private System.Windows.Forms.Button gyn;
        private System.Windows.Forms.Button pediat;
        private System.Windows.Forms.Button surgery;
        private System.Windows.Forms.Button cancer;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label info5;
        private System.Windows.Forms.Label info4;
        private System.Windows.Forms.Label info3;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label info6;
        private System.Windows.Forms.Label INFO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox2;
    }
}