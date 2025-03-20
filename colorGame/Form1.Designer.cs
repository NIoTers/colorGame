namespace colorGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CountDown1 = new System.Windows.Forms.Timer(this.components);
            this.colorBox1 = new System.Windows.Forms.PictureBox();
            this.colorBox2 = new System.Windows.Forms.PictureBox();
            this.colorBox3 = new System.Windows.Forms.PictureBox();
            this.colorBox6 = new System.Windows.Forms.PictureBox();
            this.colorBox5 = new System.Windows.Forms.PictureBox();
            this.colorBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountDown = new System.Windows.Forms.Label();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.Dice3 = new System.Windows.Forms.PictureBox();
            this.labelMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).BeginInit();
            this.SuspendLayout();
            // 
            // Dice1
            // 
            this.Dice1.Location = new System.Drawing.Point(201, 25);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(119, 123);
            this.Dice1.TabIndex = 0;
            this.Dice1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorBox1
            // 
            this.colorBox1.Location = new System.Drawing.Point(201, 195);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(84, 88);
            this.colorBox1.TabIndex = 2;
            this.colorBox1.TabStop = false;
            this.colorBox1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // colorBox2
            // 
            this.colorBox2.Location = new System.Drawing.Point(361, 195);
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.Size = new System.Drawing.Size(84, 88);
            this.colorBox2.TabIndex = 3;
            this.colorBox2.TabStop = false;
            this.colorBox2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // colorBox3
            // 
            this.colorBox3.Location = new System.Drawing.Point(524, 195);
            this.colorBox3.Name = "colorBox3";
            this.colorBox3.Size = new System.Drawing.Size(84, 88);
            this.colorBox3.TabIndex = 4;
            this.colorBox3.TabStop = false;
            this.colorBox3.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // colorBox6
            // 
            this.colorBox6.Location = new System.Drawing.Point(524, 299);
            this.colorBox6.Name = "colorBox6";
            this.colorBox6.Size = new System.Drawing.Size(84, 88);
            this.colorBox6.TabIndex = 7;
            this.colorBox6.TabStop = false;
            this.colorBox6.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // colorBox5
            // 
            this.colorBox5.Location = new System.Drawing.Point(361, 299);
            this.colorBox5.Name = "colorBox5";
            this.colorBox5.Size = new System.Drawing.Size(84, 88);
            this.colorBox5.TabIndex = 6;
            this.colorBox5.TabStop = false;
            this.colorBox5.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // colorBox4
            // 
            this.colorBox4.Location = new System.Drawing.Point(201, 299);
            this.colorBox4.Name = "colorBox4";
            this.colorBox4.Size = new System.Drawing.Size(84, 88);
            this.colorBox4.TabIndex = 5;
            this.colorBox4.TabStop = false;
            this.colorBox4.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wins: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lose:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(56, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(56, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // CountDown
            // 
            this.CountDown.AutoSize = true;
            this.CountDown.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold);
            this.CountDown.Location = new System.Drawing.Point(343, 151);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(0, 21);
            this.CountDown.TabIndex = 12;
            // 
            // Dice2
            // 
            this.Dice2.Location = new System.Drawing.Point(346, 25);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(119, 123);
            this.Dice2.TabIndex = 13;
            this.Dice2.TabStop = false;
            // 
            // Dice3
            // 
            this.Dice3.Location = new System.Drawing.Point(489, 25);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(119, 123);
            this.Dice3.TabIndex = 14;
            this.Dice3.TabStop = false;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelMoney.Location = new System.Drawing.Point(12, 106);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(0, 21);
            this.labelMoney.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(824, 506);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorBox6);
            this.Controls.Add(this.colorBox5);
            this.Controls.Add(this.colorBox4);
            this.Controls.Add(this.colorBox3);
            this.Controls.Add(this.colorBox2);
            this.Controls.Add(this.colorBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dice1);
            this.Name = "Form1";
            this.Text = "Color Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer CountDown1;
        private System.Windows.Forms.PictureBox colorBox1;
        private System.Windows.Forms.PictureBox colorBox2;
        private System.Windows.Forms.PictureBox colorBox3;
        private System.Windows.Forms.PictureBox colorBox6;
        private System.Windows.Forms.PictureBox colorBox5;
        private System.Windows.Forms.PictureBox colorBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CountDown;
        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.PictureBox Dice3;
        private System.Windows.Forms.Label labelMoney;
    }
}

