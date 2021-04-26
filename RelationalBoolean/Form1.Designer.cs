
namespace RelationalBoolean
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
            this.components = new System.ComponentModel.Container();
            this.BoolHolder = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameName = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.NoneButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoolHolder
            // 
            this.BoolHolder.Location = new System.Drawing.Point(271, 172);
            this.BoolHolder.Name = "BoolHolder";
            this.BoolHolder.Size = new System.Drawing.Size(203, 23);
            this.BoolHolder.TabIndex = 1;
            this.BoolHolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameName.Location = new System.Drawing.Point(201, 36);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(368, 30);
            this.GameName.TabIndex = 2;
            this.GameName.Text = "All None: A Relational Boolean Game";
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Red;
            this.RestartButton.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestartButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RestartButton.Location = new System.Drawing.Point(291, 257);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(170, 93);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoneButton
            // 
            this.NoneButton.Location = new System.Drawing.Point(201, 215);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(75, 23);
            this.NoneButton.TabIndex = 4;
            this.NoneButton.Text = "None";
            this.NoneButton.UseVisualStyleBackColor = true;
            this.NoneButton.Click += new System.EventHandler(this.NoneButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(339, 133);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score = ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(376, 115);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(13, 15);
            this.Score.TabIndex = 8;
            this.Score.Text = "0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(291, 215);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(75, 23);
            this.Option1.TabIndex = 9;
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.Click += new System.EventHandler(this.Option1_Click);
            // 
            // Option2
            // 
            this.Option2.Location = new System.Drawing.Point(376, 215);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(75, 23);
            this.Option2.TabIndex = 10;
            this.Option2.UseVisualStyleBackColor = false;
            this.Option2.Click += new System.EventHandler(this.button3_Click);
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeedbackLabel.Location = new System.Drawing.Point(339, 66);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(0, 46);
            this.FeedbackLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NoneButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.BoolHolder);
            this.Name = "Form1";
            this.Text = "All None: A Relational Boolean Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BoolHolder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button NoneButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;
        private System.Windows.Forms.Label FeedbackLabel;
    }
}

