namespace Library_Manegment_System
{
    partial class Dstudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Tan;
            this.btn3.BackgroundImage = global::Library_Manegment_System.Properties.Resources.sign_out;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.Location = new System.Drawing.Point(279, 350);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(108, 68);
            this.btn3.TabIndex = 0;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Tan;
            this.btn2.BackgroundImage = global::Library_Manegment_System.Properties.Resources.student__1_;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.Location = new System.Drawing.Point(377, 230);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(108, 68);
            this.btn2.TabIndex = 0;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Tan;
            this.btn1.BackgroundImage = global::Library_Manegment_System.Properties.Resources.money;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Location = new System.Drawing.Point(178, 230);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(108, 68);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsername.Location = new System.Drawing.Point(43, 79);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(173, 46);
            this.lblUsername.TabIndex = 2;
            // 
            // lbldate
            // 
            this.lbldate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldate.Location = new System.Drawing.Point(490, 450);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(173, 30);
            this.lbldate.TabIndex = 2;
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // Dstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(690, 489);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dstudent";
            this.Load += new System.EventHandler(this.Dstudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lbldate;
    }
}