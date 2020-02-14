/*
 * Renewed Vision Test Application By: Cole Helmuth
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RenewedVisionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Blue Background Toggle Button
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.BackColor == SystemColors.Control)
            {
                this.BackColor = System.Drawing.Color.Blue;
            }

            else if (this.BackColor == Color.Blue)
            {
                this.BackColor = SystemColors.Control;//resets background to default
            }
        }

        //Red Background Toggle Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.Control)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else if (this.BackColor == Color.Red)
            {
                this.BackColor = SystemColors.Control;//resets background to default
            }

        }

        //Gray Background Toggle Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.Control)
            {
                this.BackColor = System.Drawing.Color.Gray;
            }

            else if (this.BackColor == Color.Gray)
            {
                this.BackColor = SystemColors.Control;//resets background to default
            }
        }

        //Green Background Toggle Button
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.Control)
            {
                this.BackColor = System.Drawing.Color.Green;
            }

            else if (this.BackColor == Color.Green)
            {
                this.BackColor = SystemColors.Control;//resets background to default
            }

        }

        //Transparent Background Toggle button
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.Control)
            {
                //use a color not being used to set the TransparencyKey
                this.BackColor = System.Drawing.Color.Purple;
                this.TransparencyKey = Color.Purple;
            }

            else if(this.BackColor == Color.Purple)
            {
                this.BackColor = SystemColors.Control;
            }

        }

        //Top Border Color black Toggle Button
        private void button6_Click(object sender, EventArgs e)
        {
            
            if (panel1.BackColor == SystemColors.ControlDarkDark)
            {
                panel1.BackColor = System.Drawing.Color.Black;
                
            }

            else if (panel1.BackColor == Color.Black)
            {
                panel1.BackColor = SystemColors.ControlDarkDark;
            }

        }

        //Bottom Border Color black Toggle Button
        private void button7_Click(object sender, EventArgs e)
        {
            if (panel2.BackColor == SystemColors.ControlDarkDark)
            {
                panel2.BackColor = System.Drawing.Color.Black;

            }

            else if (panel2.BackColor == Color.Black)
            {
                panel2.BackColor = SystemColors.ControlDarkDark;
            }
        }

        //Left Border Color black Toggle Button
        private void button8_Click(object sender, EventArgs e)
        {
            if (panel3.BackColor == SystemColors.ControlDarkDark)
            {
                panel3.BackColor = System.Drawing.Color.Black;

            }

            else if (panel3.BackColor == Color.Black)
            {
                panel3.BackColor = SystemColors.ControlDarkDark;
            }
        }

        //Right Border Color black Toggle Button
        private void button9_Click(object sender, EventArgs e)
        {
            if (panel4.BackColor == SystemColors.ControlDarkDark)
            {
                panel4.BackColor = System.Drawing.Color.Black;

            }

            else if (panel4.BackColor == Color.Black)
            {
                panel4.BackColor = SystemColors.ControlDarkDark;
            }
        }

        //All Borders Color black Toggle Button 
        private void button10_Click(object sender, EventArgs e)
        {
            
            if(panel1.BackColor == SystemColors.ControlDarkDark || panel2.BackColor == SystemColors.ControlDarkDark
                || panel3.BackColor == SystemColors.ControlDarkDark || panel4.BackColor == SystemColors.ControlDarkDark)
            {
                panel1.BackColor = System.Drawing.Color.Black;
                panel2.BackColor = System.Drawing.Color.Black;
                panel3.BackColor = System.Drawing.Color.Black;
                panel4.BackColor = System.Drawing.Color.Black;
            }

            else if(panel1.BackColor != SystemColors.ControlDarkDark && panel2.BackColor != SystemColors.ControlDarkDark
                && panel3.BackColor != SystemColors.ControlDarkDark && panel4.BackColor != SystemColors.ControlDarkDark)
            {
                panel1.BackColor = SystemColors.ControlDarkDark;
                panel2.BackColor = SystemColors.ControlDarkDark;
                panel3.BackColor = SystemColors.ControlDarkDark;
                panel4.BackColor = SystemColors.ControlDarkDark;
            }
        }

        //Resize the border thickness Toggle Button
        private void button11_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 521 && panel1.Height == 30 && panel2.Width == 521 && panel2.Height == 29 &&
                panel3.Width == 30 && panel3.Height == 494 && panel4.Width == 30 && panel4.Height == 494)
            {
                panel1.Height = 50;
                panel2.Height = 50;
                panel3.Width = 50;
                panel3.Height = 514;
                panel4.Width = 50;
                panel4.Height = 514;
            }
            else if (panel4.Width != 30)//since all of the border panels were resized, we only need to test one of them
            {
                panel1.Height = 30;
                panel2.Height = 29;
                panel3.Width = 30;
                panel3.Height = 494;
                panel4.Width = 30;
                panel4.Height = 494;
            }

            
        }

        //Split Background Color Green/ Gray Toggle Button
        private void button12_Click(object sender, EventArgs e)
        {

            if (this.BackColor == SystemColors.Control)
            {
                //basically splits the form into two equal rectangles and paints them different colors
                Graphics surface = this.CreateGraphics();
                surface.FillRectangle(new SolidBrush(Color.Green), 0, 0, (this.Width) / 2, this.Height);
                surface.FillRectangle(new SolidBrush(Color.Gray), (this.Width) / 2, 0, (this.Width) / 2, this.Height);
            }


        }



    }
}

