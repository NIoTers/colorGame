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
            this.genBox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.genBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // genBox
            // 
            this.genBox.Location = new System.Drawing.Point(337, 51);
            this.genBox.Name = "genBox";
            this.genBox.Size = new System.Drawing.Size(119, 123);
            this.genBox.TabIndex = 0;
            this.genBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Spin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorBox1
            // 
            this.colorBox1.Location = new System.Drawing.Point(201, 279);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(84, 88);
            this.colorBox1.TabIndex = 2;
            this.colorBox1.TabStop = false;
            this.colorBox1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // colorBox2
            // 
            this.colorBox2.Location = new System.Drawing.Point(361, 279);
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.Size = new System.Drawing.Size(84, 88);
            this.colorBox2.TabIndex = 3;
            this.colorBox2.TabStop = false;
            this.colorBox2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // colorBox3
            // 
            this.colorBox3.Location = new System.Drawing.Point(524, 279);
            this.colorBox3.Name = "colorBox3";
            this.colorBox3.Size = new System.Drawing.Size(84, 88);
            this.colorBox3.TabIndex = 4;
            this.colorBox3.TabStop = false;
            this.colorBox3.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // colorBox6
            // 
            this.colorBox6.Location = new System.Drawing.Point(524, 383);
            this.colorBox6.Name = "colorBox6";
            this.colorBox6.Size = new System.Drawing.Size(84, 88);
            this.colorBox6.TabIndex = 7;
            this.colorBox6.TabStop = false;
            this.colorBox6.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // colorBox5
            // 
            this.colorBox5.Location = new System.Drawing.Point(361, 383);
            this.colorBox5.Name = "colorBox5";
            this.colorBox5.Size = new System.Drawing.Size(84, 88);
            this.colorBox5.TabIndex = 6;
            this.colorBox5.TabStop = false;
            this.colorBox5.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // colorBox4
            // 
            this.colorBox4.Location = new System.Drawing.Point(201, 383);
            this.colorBox4.Name = "colorBox4";
            this.colorBox4.Size = new System.Drawing.Size(84, 88);
            this.colorBox4.TabIndex = 5;
            this.colorBox4.TabStop = false;
            this.colorBox4.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wednesday", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wins: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wednesday", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lose:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wednesday", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wednesday", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // CountDown
            // 
            this.CountDown.AutoSize = true;
            this.CountDown.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDown.Location = new System.Drawing.Point(343, 177);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(0, 17);
            this.CountDown.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(824, 506);
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
            this.Controls.Add(this.genBox);
            this.Name = "Form1";
            this.Text = "Color Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox genBox;
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
    }
}

