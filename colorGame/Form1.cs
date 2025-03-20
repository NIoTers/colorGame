using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace colorGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Timer colorTimer = new Timer();
        DateTime startTime;
        List<PictureBox> colorBoxes;
        Color finalColor1, finalColor2, finalColor3;
        int win = 0;
        int lose = 0;
        double timeLeft = 5.0;
        double playerMoney = 10.0;
        string divider = "--------------------------------------------------";
        Dictionary<PictureBox, Color> colorMap = new Dictionary<PictureBox, Color>();
        Dictionary<Color, int> betsPerColor = new Dictionary<Color, int>();
        //kita mo?
        public Form1()
        {
            InitializeComponent();

            colorTimer.Interval = 100;
            colorTimer.Tick += Timer1_Tick;

            Dice1.BorderStyle = BorderStyle.Fixed3D; //itong mga to style lanng yan
            Dice2.BorderStyle = BorderStyle.Fixed3D;
            Dice3.BorderStyle = BorderStyle.Fixed3D;

            colorBox1.BackColor = Color.Yellow;
            colorBox2.BackColor = Color.Pink;
            colorBox3.BackColor = Color.Red;
            colorBox6.BackColor = Color.Orange;
            colorBox5.BackColor = Color.White;
            colorBox4.BackColor = Color.Blue;

            colorMap[colorBox1] = Color.Yellow;
            colorMap[colorBox2] = Color.Pink;
            colorMap[colorBox3] = Color.Red;
            colorMap[colorBox6] = Color.Orange;
            colorMap[colorBox5] = Color.White;
            colorMap[colorBox4] = Color.Blue;

            betsPerColor[Color.Yellow] = 0;
            betsPerColor[Color.Pink] = 0;
            betsPerColor[Color.Red] = 0;
            betsPerColor[Color.Orange] = 0;
            betsPerColor[Color.White] = 0;
            betsPerColor[Color.Blue] = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorBoxes = new List<PictureBox> { colorBox1, colorBox2, colorBox3, colorBox6, colorBox5, colorBox4 };
            labelMoney.Text = "Money: " + playerMoney.ToString("0.00");
            UpdateColorLabels();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            finalColor1 = RandomColor();
            finalColor2 = RandomColor();
            finalColor3 = RandomColor();

            Dice1.BackColor = finalColor1;
            Dice2.BackColor = finalColor2;
            Dice3.BackColor = finalColor3;

            timeLeft -= 0.1;
            CountDown.Text = "Time Left: " + timeLeft.ToString("0.0");

            if (timeLeft <= 0)
            {
                colorTimer.Stop();
                CountDown.Text = "Time Left: 0.0";

                List<Color> diceColors = new List<Color> { finalColor1, finalColor2, finalColor3 };
                double totalWinnings = 0;
                int totalBet = betsPerColor.Values.Sum();

                StringBuilder resultMessage = new StringBuilder();
                resultMessage.AppendLine("Color\tBet\tWon\tWinnings");
                resultMessage.AppendLine(divider);

                foreach (var kvp in betsPerColor)
                {
                    Color betColor = kvp.Key;
                    int betAmount = kvp.Value;
                    int matchCount = diceColors.Count(c => c == betColor);
                    int winnings = 0;
                    if (matchCount > 0)
                    {
                        winnings = betAmount * (1 + matchCount);
                    }


                    totalWinnings += winnings;

                    string colorName = ColorName(betColor);
                    resultMessage.AppendLine($"{colorName}\t{betAmount}\t{matchCount}\t{winnings}");
                }

                playerMoney = playerMoney - totalBet + totalWinnings;
                labelMoney.Text = "Money: " + playerMoney.ToString("0.00");

                resultMessage.AppendLine(divider);
                resultMessage.AppendLine($"Total Bet: {totalBet}");
                resultMessage.AppendLine($"Total Won: {totalWinnings}");
                resultMessage.AppendLine($"Current Money: {playerMoney.ToString("0.00")}");

                MessageBox.Show(resultMessage.ToString(), "Result");


                if (totalWinnings > 0) win++;
                if (totalWinnings < totalBet) lose++;

                label3.Text = win.ToString();
                label4.Text = lose.ToString();

                ResetBets();
                UpdateColorLabels();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalBet = betsPerColor.Values.Sum();

            if (totalBet <= 0)
            {
                MessageBox.Show("Place at least one bet by clicking color boxes.");
                return;
            }

            if (playerMoney <= 0)
            {
                MessageBox.Show("You have no money left to play.");
                return;
            }

            timeLeft = 5.0;
            CountDown.Text = "Time Left: 5.0";
            startTime = DateTime.Now;
            colorTimer.Start();
        }

        private Color RandomColor()
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

        private void ResetBets()
        {
            foreach (var color in betsPerColor.Keys.ToList())
            {
                betsPerColor[color] = 0;
            }
        }

        private void UpdateColorLabels()
        {
            colorBox1.Refresh();
            colorBox2.Refresh();
            colorBox3.Refresh();
            colorBox6.Refresh();
            colorBox5.Refresh();
            colorBox4.Refresh();

            colorBox1.Invalidate();
            colorBox2.Invalidate();
            colorBox3.Invalidate();
            colorBox6.Invalidate();
            colorBox5.Invalidate();
            colorBox4.Invalidate();
        }

        private void DrawBetAmount(PictureBox picBox, int amount)
        {
            using (Graphics g = picBox.CreateGraphics())
            {
                g.Clear(picBox.BackColor);
                if (amount > 0)
                {
                    Font font = new Font("Arial", 10, FontStyle.Bold);
                    Brush brush = Brushes.Black;
                    g.DrawString("Bet: " + amount, font, brush, new PointF(5, 5));
                }
            }
        }

        private void ColorBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedBox = sender as PictureBox;
            Color clickedColor = colorMap[clickedBox];

            int totalCurrentBet = betsPerColor.Values.Sum();

            if (playerMoney > totalCurrentBet)
            {
                betsPerColor[clickedColor]++;
                DrawBetAmount(clickedBox, betsPerColor[clickedColor]);
            }
            else
            {
                MessageBox.Show("You don't have enough money to bet!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ColorBox_Click(colorBox1, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ColorBox_Click(colorBox2, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ColorBox_Click(colorBox3, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ColorBox_Click(colorBox6, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ColorBox_Click(colorBox5, e);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ColorBox_Click(colorBox4, e);
        }
    }
}
