namespace quizz
{
    partial class Form4
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
            this.ra3 = new System.Windows.Forms.RadioButton();
            this.ra2 = new System.Windows.Forms.RadioButton();
            this.ra1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ra3
            // 
            this.ra3.AutoSize = true;
            this.ra3.Location = new System.Drawing.Point(64, 289);
            this.ra3.Name = "ra3";
            this.ra3.Size = new System.Drawing.Size(63, 17);
            this.ra3.TabIndex = 14;
            this.ra3.TabStop = true;
            this.ra3.Text = "ยังไม่อิ่ม";
            this.ra3.UseVisualStyleBackColor = true;
            // 
            // ra2
            // 
            this.ra2.AutoSize = true;
            this.ra2.Location = new System.Drawing.Point(64, 245);
            this.ra2.Name = "ra2";
            this.ra2.Size = new System.Drawing.Size(58, 17);
            this.ra2.TabIndex = 13;
            this.ra2.TabStop = true;
            this.ra2.Text = "อิ่มแล้ว";
            this.ra2.UseVisualStyleBackColor = true;
            // 
            // ra1
            // 
            this.ra1.AutoSize = true;
            this.ra1.Location = new System.Drawing.Point(64, 196);
            this.ra1.Name = "ra1";
            this.ra1.Size = new System.Drawing.Size(49, 17);
            this.ra1.TabIndex = 12;
            this.ra1.TabStop = true;
            this.ra1.Text = "อิ่มจัง";
            this.ra1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "อิ่มภาษาญี่ปุ่นพูดว่าอะไร?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quizz.Properties.Resources.Japan;
            this.pictureBox1.Location = new System.Drawing.Point(488, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ra3);
            this.Controls.Add(this.ra2);
            this.Controls.Add(this.ra1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ra3;
        private System.Windows.Forms.RadioButton ra2;
        private System.Windows.Forms.RadioButton ra1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}