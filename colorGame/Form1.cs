using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace colorGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Timer colorTimer = new Timer(); //timer initialization 
        DateTime startTime;
        List<PictureBox> colorBoxes;
        Color? selectedColor = null;
        Color finalColor;
        int win = 0;
        int lose = 0;
        double timeLeft = 5.0;

        //fun fact pede kayo mag change ng ID para ndi generalize ung name example pictureBox1 pede nyo yan irename ung ID
        //make sure na pag nirename nyo irerename nyo rin ung iba dito
        public Form1()
        {
            InitializeComponent();

            //setting up the speed of color rotation
            colorTimer.Interval = 100;
            colorTimer.Tick += Timer1_Tick;

            //adding a borderstyle for the random color box
            genBox.BorderStyle = BorderStyle.Fixed3D; 

            //color selection
            colorBox1.BackColor = Color.Yellow;
            colorBox2.BackColor = Color.Pink;
            colorBox3.BackColor = Color.Red;
            colorBox6.BackColor = Color.Orange;
            colorBox5.BackColor = Color.White;
            colorBox4.BackColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setting up color boxess
            colorBoxes = new List<PictureBox> { colorBox1, colorBox2, colorBox3, colorBox6, colorBox5, colorBox4 };
        }

        private void DrawBorderAround(PictureBox picBox)
            //black border
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3);
            Rectangle rect = picBox.Bounds;
            rect.Inflate(3, 3);
            g.DrawRectangle(pen, rect);
            pen.Dispose();
            g.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            finalColor = RandomColor();
            genBox.BackColor = finalColor;
            timeLeft -= 0.1;
            CountDown.Text = "Time Left: " + timeLeft.ToString("0.0");

            if (timeLeft <= 0)
            {
                colorTimer.Stop();
                CountDown.Text = "Time Left: 0.0";
                string resultName = ColorName(finalColor);
                MessageBox.Show("The color is: " + resultName);

                if (selectedColor.HasValue)
                {
                    if (selectedColor.Value == finalColor)
                    {
                        win++;
                        label3.Text = win.ToString();
                        MessageBox.Show("🎉 You Win!");
                    }
                    else
                    {
                        lose++;
                        label4.Text = lose.ToString();
                        MessageBox.Show("You lose! you select: " + ColorName(selectedColor.Value) + "\n❌ Try Again!");
                    }
                }
                else
                {
                    MessageBox.Show("No color selected!");
                }

                selectedColor = null;
                this.Refresh();
            }
        }


        private string ColorName(Color color)
        {
            if (color == Color.Yellow) return "Yellow";
            if (color == Color.Pink) return "Pink";
            if (color == Color.Red) return "Red";
            if (color == Color.Orange) return "Orange";
            if (color == Color.White) return "White";
            if (color == Color.Blue) return "Blue";
            return "Unknown";
        }

        private Color RandomColor() //randomize color return
        {
            List<Color> fixedColors = new List<Color>
            {
                Color.Yellow,
                Color.Pink,
                Color.Red,
                Color.Orange,
                Color.White,
                Color.Blue
            };
            int index = random.Next(fixedColors.Count);
            return fixedColors[index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!selectedColor.HasValue) //if user didn't select a color
            {
                MessageBox.Show("Please select a color before starting!");
                return;
            }

            timeLeft = 5.0; //set timer to 5 sec in double
            CountDown.Text = "Time Left: 5.0";
            startTime = DateTime.Now;
            colorTimer.Start(); //start the timer
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Yellow;
            this.Refresh();
            DrawBorderAround(colorBox1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Pink;
            this.Refresh();
            DrawBorderAround(colorBox2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Red;
            this.Refresh();
            DrawBorderAround(colorBox3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Orange;
            this.Refresh();
            DrawBorderAround(colorBox6);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            selectedColor = Color.White;
            this.Refresh();
            DrawBorderAround(colorBox5);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Blue;
            this.Refresh();
            DrawBorderAround(colorBox4);
        }

       
    }
}
