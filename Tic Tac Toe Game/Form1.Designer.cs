namespace Tic_Tac_Toe_Game
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
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            GameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 0;
            label1.Text = "PLayer Wins:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(340, 22);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 2;
            label3.Text = "Computer Wins:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(22, 89);
            button1.Name = "button1";
            button1.Size = new Size(148, 129);
            button1.TabIndex = 3;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += PLayerClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(167, 89);
            button2.Name = "button2";
            button2.Size = new Size(148, 129);
            button2.TabIndex = 4;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += PLayerClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(312, 89);
            button3.Name = "button3";
            button3.Size = new Size(148, 129);
            button3.TabIndex = 5;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += PLayerClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(312, 214);
            button4.Name = "button4";
            button4.Size = new Size(148, 118);
            button4.TabIndex = 8;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += PLayerClick;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(167, 214);
            button5.Name = "button5";
            button5.Size = new Size(148, 118);
            button5.TabIndex = 7;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = false;
            button5.Click += PLayerClick;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(22, 214);
            button6.Name = "button6";
            button6.Size = new Size(148, 118);
            button6.TabIndex = 6;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = false;
            button6.Click += PLayerClick;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(312, 328);
            button7.Name = "button7";
            button7.Size = new Size(148, 127);
            button7.TabIndex = 11;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = false;
            button7.Click += PLayerClick;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(167, 328);
            button8.Name = "button8";
            button8.Size = new Size(148, 127);
            button8.TabIndex = 10;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += PLayerClick;
            // 
            // button9
            // 
            button9.BackColor = Color.Red;
            button9.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(22, 328);
            button9.Name = "button9";
            button9.Size = new Size(148, 127);
            button9.TabIndex = 9;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += PLayerClick;
            // 
            // button10
            // 
            button10.BackColor = Color.Yellow;
            button10.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.Green;
            button10.Location = new Point(167, 473);
            button10.Name = "button10";
            button10.Size = new Size(128, 40);
            button10.TabIndex = 12;
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = false;
            button10.Click += RestartGame;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += CpuMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 525);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer GameTimer;
    }
}