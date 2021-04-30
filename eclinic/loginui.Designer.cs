namespace eclinic
{
    partial class loginui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginui));
            this.doctorbutt = new System.Windows.Forms.Button();
            this.adminbutt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorbutt
            // 
            resources.ApplyResources(this.doctorbutt, "doctorbutt");
            this.doctorbutt.BackColor = System.Drawing.Color.Green;
            this.doctorbutt.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.doctorbutt.FlatAppearance.BorderSize = 0;
            this.doctorbutt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doctorbutt.Name = "doctorbutt";
            this.doctorbutt.UseVisualStyleBackColor = false;
            this.doctorbutt.Click += new System.EventHandler(this.doctorbutt_Click);
            // 
            // adminbutt
            // 
            resources.ApplyResources(this.adminbutt, "adminbutt");
            this.adminbutt.BackColor = System.Drawing.Color.Teal;
            this.adminbutt.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.adminbutt.FlatAppearance.BorderSize = 0;
            this.adminbutt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminbutt.Name = "adminbutt";
            this.adminbutt.UseVisualStyleBackColor = false;
            this.adminbutt.Click += new System.EventHandler(this.adminbutt_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eclinic.Properties.Resources.doctor;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // loginui
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminbutt);
            this.Controls.Add(this.doctorbutt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginui";
            this.Opacity = 0.95D;
            this.Load += new System.EventHandler(this.loginui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button doctorbutt;
        private System.Windows.Forms.Button adminbutt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

