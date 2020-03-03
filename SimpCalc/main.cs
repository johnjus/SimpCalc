using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpCalc
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        public double total;

        public int selector;
        //+ = 1
        //- = 2
        // / = 3
        // * = 4
        public string visual;
        public Boolean eqaulDeny = true;
        public Boolean periodUse = false;
        public Boolean deny = false;


        private void equalButton_Click(object sender, EventArgs e)
        {
            if (eqaulDeny == false)
            {
                double input = Convert.ToDouble(this.inputBox.Text);
                switch (selector)
                {
                    case 1://add
                        total += input;
                        this.inputBox.Text = Convert.ToString(total);
                        visual += "=" + total;
                        this.visualAid.Text = Convert.ToString(visual);
                        eqaulDeny = true;
                        periodUse = false;
                        break;
                    case 2://minus
                        total -= input;
                        this.inputBox.Text = Convert.ToString(total);
                        visual += "=" + total;
                        this.visualAid.Text = Convert.ToString(visual);
                        eqaulDeny = true;
                        periodUse = false;
                        break;
                    case 3://divsion
                        total /= input;
                        this.inputBox.Text = Convert.ToString(total);
                        visual += "=" + total;
                        this.visualAid.Text = Convert.ToString(visual);
                        eqaulDeny = true;
                        periodUse = false;
                        break;
                    case 4://times
                        total *= input;
                        this.inputBox.Text = Convert.ToString(total);
                        visual += "=" + total;
                        this.visualAid.Text = Convert.ToString(visual);
                        eqaulDeny = true;
                        periodUse = false;
                        break;
                    default:
                        this.inputBox.Text = "ERROR!";
                        break;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (deny == false)
            {
                eqaulDeny = false;
                double input = Convert.ToDouble(this.inputBox.Text);
                total = input;
                this.inputBox.Clear();
                visual += "+";
                this.visualAid.Text = Convert.ToString(visual);
                selector = 1;
                periodUse = false;
                deny = true;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (deny == false)
            {
                eqaulDeny = false;
                double input = Convert.ToDouble(this.inputBox.Text);
                total = input;
                this.inputBox.Clear();
                visual += "-";
                this.visualAid.Text = Convert.ToString(visual);
                selector = 2;
                periodUse = false;
                deny = true;
            }



        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            if (deny == false)
            {
                eqaulDeny = false;
                double input = Convert.ToDouble(this.inputBox.Text);
                total = input;
                this.inputBox.Clear();
                visual += "*";
                this.visualAid.Text = Convert.ToString(visual);
                selector = 4;
                periodUse = false;
                deny = true;
            }


        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (deny == false)
            {
                eqaulDeny = false;
                double input = Convert.ToDouble(this.inputBox.Text);
                total = input;
                this.inputBox.Clear();
                visual += "/";
                this.visualAid.Text = Convert.ToString(visual);
                selector = 3;
                periodUse = false;
                deny = true;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += Convert.ToString(0);
            visual += "0";
            this.visualAid.Text = Convert.ToString(visual);
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (periodUse == false)
            {
                this.inputBox.Text += ".";
                visual += ".";
                this.visualAid.Text = Convert.ToString(visual);
                periodUse = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.inputBox.Text += Convert.ToString(1);
                visual += "1";
                this.visualAid.Text = Convert.ToString(visual);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                this.inputBox.Text += Convert.ToString(2);
                visual += "2";
                this.visualAid.Text = Convert.ToString(visual);
        }

        private void button3_Click(object sender, EventArgs e)
        {
                this.inputBox.Text += Convert.ToString(3);
                visual += "3";
                this.visualAid.Text = Convert.ToString(visual);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += Convert.ToString(6);
            visual += "6";
            this.visualAid.Text = Convert.ToString(visual);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += Convert.ToString(5);
            visual += "5";
            this.visualAid.Text = Convert.ToString(visual);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += Convert.ToString(4);
            visual += "4";
            this.visualAid.Text = Convert.ToString(visual);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += Convert.ToString(7);
            visual += "7";
            this.visualAid.Text = Convert.ToString(visual);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += Convert.ToString(8);
            visual += "8";
            this.visualAid.Text = Convert.ToString(visual);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += Convert.ToString(9);
            visual += "9";
            this.visualAid.Text = Convert.ToString(visual);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            total = 0;
            this.inputBox.Clear();
            this.visualAid.Clear();
            visual = "";
            deny = false;
        }
    }
}
