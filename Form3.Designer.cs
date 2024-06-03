namespace Medecil_Rep
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
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
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1177, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(188, 131);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(356, 90);
            label1.Name = "label1";
            label1.Size = new Size(602, 81);
            label1.TabIndex = 6;
            label1.Text = "A little about yourself";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 277);
            label2.Name = "label2";
            label2.Size = new Size(180, 41);
            label2.TabIndex = 7;
            label2.Text = "Your gender";
            label2.Click += label2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 15F);
            radioButton1.Location = new Point(799, 277);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(138, 45);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 15F);
            radioButton2.Location = new Point(379, 275);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 45);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(15, 412);
            label3.Name = "label3";
            label3.Size = new Size(195, 41);
            label3.TabIndex = 10;
            label3.Text = "Your birthday";
            // 
            // button1
            // 
            button1.Location = new Point(379, 407);
            button1.Name = "button1";
            button1.Size = new Size(112, 46);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(15, 519);
            label4.Name = "label4";
            label4.Size = new Size(191, 41);
            label4.TabIndex = 14;
            label4.Text = "Your location";
            // 
            // button4
            // 
            button4.Location = new Point(273, 520);
            button4.Name = "button4";
            button4.Size = new Size(531, 49);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(692, 407);
            button6.Name = "button6";
            button6.Size = new Size(112, 46);
            button6.TabIndex = 17;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(540, 407);
            button7.Name = "button7";
            button7.Size = new Size(112, 46);
            button7.TabIndex = 18;
            button7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 379);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 19;
            label5.Text = "Day:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(692, 379);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 20;
            label6.Text = "Year:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(540, 379);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 21;
            label7.Text = "Mounth:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(374, 606);
            button2.Name = "button2";
            button2.Size = new Size(584, 58);
            button2.TabIndex = 22;
            button2.Text = "Continue";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 707);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button4;
        private Button button6;
        private Button button7;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
    }
}