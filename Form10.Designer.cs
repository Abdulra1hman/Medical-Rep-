namespace Medecil_Rep
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button39 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 136);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1219, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(188, 131);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(464, 78);
            label1.Name = "label1";
            label1.Size = new Size(419, 81);
            label1.TabIndex = 8;
            label1.Text = "Google Mapse";
            // 
            // button1
            // 
            button1.Location = new Point(181, 234);
            button1.Name = "button1";
            button1.Size = new Size(1090, 90);
            button1.TabIndex = 15;
            button1.Text = " Search location, ZIP code..";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            button39.BackColor = SystemColors.GradientActiveCaption;
            button39.Font = new Font("Segoe UI", 11F);
            button39.Location = new Point(353, 592);
            button39.Name = "button39";
            button39.Size = new Size(584, 58);
            button39.TabIndex = 63;
            button39.Text = "Confirm Location";
            button39.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 416);
            label3.Name = "label3";
            label3.Size = new Size(314, 50);
            label3.TabIndex = 64;
            label3.Text = " Confirm your address :\r\nEgypt, 6th of October ,EL-Wahat Road";
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 733);
            Controls.Add(label3);
            Controls.Add(button39);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "Form10";
            Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Button button1;
        private Button button39;
        private Label label3;
    }
}