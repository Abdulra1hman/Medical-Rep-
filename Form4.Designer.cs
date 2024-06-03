namespace Medecil_Rep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            button4 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 131);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1187, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(188, 131);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(541, 114);
            label1.Name = "label1";
            label1.Size = new Size(217, 81);
            label1.TabIndex = 7;
            label1.Text = "Sign In";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 342);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 20;
            label5.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 449);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 21;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Location = new Point(280, 237);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 22;
            label3.Text = "Full Name";
            // 
            // button1
            // 
            button1.Location = new Point(249, 265);
            button1.Name = "button1";
            button1.Size = new Size(824, 61);
            button1.TabIndex = 23;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(249, 370);
            button2.Name = "button2";
            button2.Size = new Size(824, 61);
            button2.TabIndex = 24;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(249, 477);
            button3.Name = "button3";
            button3.Size = new Size(824, 61);
            button3.TabIndex = 25;
            button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(290, 555);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(326, 29);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "I agree with Terms and Privacy Policy";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(333, 606);
            button4.Name = "button4";
            button4.Size = new Size(584, 58);
            button4.TabIndex = 27;
            button4.Text = "Continue";
            button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 682);
            label4.Name = "label4";
            label4.Size = new Size(249, 25);
            label4.TabIndex = 28;
            label4.Text = "Already have account? Sign In";
            label4.Click += label4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 739);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private Button button4;
        private Label label4;
    }
}