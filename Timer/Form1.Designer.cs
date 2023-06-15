namespace Timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(242, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 40);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(56, 32);
            label2.Name = "label2";
            label2.Size = new Size(168, 40);
            label2.TabIndex = 1;
            label2.Text = "Joriy vaqt :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(56, 151);
            label3.Name = "label3";
            label3.Size = new Size(213, 40);
            label3.TabIndex = 2;
            label3.Text = "Sekundomer : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(78, 208);
            label4.Name = "label4";
            label4.Size = new Size(131, 40);
            label4.TabIndex = 3;
            label4.Text = "00:00:00";
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(332, 163);
            button1.Name = "button1";
            button1.Size = new Size(105, 42);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(332, 211);
            button2.Name = "button2";
            button2.Size = new Size(105, 37);
            button2.TabIndex = 5;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(552, 304);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer2;
        private Button button1;
        private Button button2;
    }
}