namespace quizz
{
    partial class Form2
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
            this.ra1 = new System.Windows.Forms.RadioButton();
            this.ra2 = new System.Windows.Forms.RadioButton();
            this.ra3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "เงินอะไรน่ากลัวที่สุด ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ra1
            // 
            this.ra1.AutoCheck = false;
            this.ra1.AutoSize = true;
            this.ra1.Location = new System.Drawing.Point(86, 110);
            this.ra1.Name = "ra1";
            this.ra1.Size = new System.Drawing.Size(55, 17);
            this.ra1.TabIndex = 2;
            this.ra1.TabStop = true;
            this.ra1.Text = "ดอลล่า";
            this.ra1.UseVisualStyleBackColor = true;
            this.ra1.CheckedChanged += new System.EventHandler(this.ra1_CheckedChanged);
            // 
            // ra2
            // 
            this.ra2.AutoSize = true;
            this.ra2.Location = new System.Drawing.Point(86, 159);
            this.ra2.Name = "ra2";
            this.ra2.Size = new System.Drawing.Size(44, 17);
            this.ra2.TabIndex = 3;
            this.ra2.TabStop = true;
            this.ra2.Text = "บาท";
            this.ra2.UseVisualStyleBackColor = true;
            this.ra2.CheckedChanged += new System.EventHandler(this.ra2_CheckedChanged);
            // 
            // ra3
            // 
            this.ra3.AutoSize = true;
            this.ra3.Location = new System.Drawing.Point(86, 203);
            this.ra3.Name = "ra3";
            this.ra3.Size = new System.Drawing.Size(45, 17);
            this.ra3.TabIndex = 4;
            this.ra3.TabStop = true;
            this.ra3.Text = "เยน";
            this.ra3.UseVisualStyleBackColor = true;
            this.ra3.CheckedChanged += new System.EventHandler(this.ra3_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quizz.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(510, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ra3);
            this.Controls.Add(this.ra2);
            this.Controls.Add(this.ra1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ra1;
        private System.Windows.Forms.RadioButton ra2;
        private System.Windows.Forms.RadioButton ra3;
    }
}