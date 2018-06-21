using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calstack
{
    public partial class Form1 : Form
    {
        Point locationNumbers = new Point(20, 265);
        Point locationOperators = new Point(20, 265);
        string input = "";

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 450);
            LoadButtons();
            LoadOperators();
        }
        /// <summary>
        /// Het laden van de buttons met de nummers
        /// </summary>
        private void LoadButtons()
        {
            for (int i = 10; i > 0; i--)
            {
                //voor de 0 button
                if (i == 10)
                {
                    Button b = new Button();
                    b.Size = new Size(50, 50);
                    locationNumbers.Offset(b.Width + 5, 0);
                    b.Text = Convert.ToString(10 - i);
                    b.Click += button_Click;
                    b.Location = locationNumbers;
                    Controls.Add(b);
                    locationNumbers.Offset((b.Width + 5) * -1, (b.Height + 5) * -1);
                }
                //voor de andere nummers
                else
                {
                    Button b = new Button();
                    b.Size = new Size(50, 50);
                    b.Text = Convert.ToString(10 - i);
                    b.Click += button_Click;
                    b.Location = locationNumbers;
                    locationNumbers.Offset(b.Width + 5, 0);
                    Controls.Add(b);

                    if (i == 7)
                    {
                        locationNumbers.Offset((b.Width * 3 + 5 * 3) * -1, (b.Height + 5) * -1);
                    }
                    if (i == 4)
                    {
                        locationNumbers.Offset((b.Width * 3 + 5 * 3) * -1, (b.Height + 5) * -1);
                    }
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button ButtonThatWasPushed = (Button)sender;
            //the button's Text
            //do something

            //If you store the button's numeric value in it's Tag property
            //things become even easier.
            input += ButtonThatWasPushed.Text;
            TxtBox1.Text = input;

        }

        /// <summary>
        /// Het laden van de buttons met de operators (+ - * / etc.)
        /// </summary>
        private void LoadOperators()
        {
            for (int i = 6; i > 0; i--)
            {
                Button b = new Button();
                b.Size = new Size(50, 50);

                if (i == 6)
                {
                    b.Text = "(-)";
                    b.Click += button_Click_Negative_Number;
                    b.Location = locationOperators;
                    Controls.Add(b);
                    locationOperators.Offset((b.Width + 5) * 2, 0);
                }
                if (i == 5)
                {
                    b.Text = "+";
                    b.Click += button_Click_Count;
                    b.Location = locationOperators;
                    Controls.Add(b);
                    locationOperators.Offset((b.Width + 5), 0);
                }
                if (i == 4)
                {
                    b.Text = "-";
                    b.Click += button_Click_Subtract;
                    b.Location = locationOperators;
                    Controls.Add(b);
                    locationOperators.Offset(0, (b.Height + 5) * -1);
                }
                if (i == 3)
                {
                    b.Text = "*";
                    b.Click += button_Click_Multiply;
                    b.Location = locationOperators;
                    Controls.Add(b);
                    locationOperators.Offset(0, (b.Height + 5) * -1);
                }
                if (i == 2)
                {
                    b.Text = "/";
                    b.Click += button_Click_Divide;
                    b.Location = locationOperators;
                    Controls.Add(b);
                    locationOperators.Offset(0, (b.Height + 5) * -1);
                }
                if (i == 1)
                {
                    b.Text = "=";
                    b.Click += button_Click_Awnser;
                    b.Location = locationOperators;
                    Controls.Add(b);
                    locationOperators.Offset(0, (b.Height + 5) * -1);
                }


            }
        }

        private void button_Click_Negative_Number(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_Click_Count(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void button_Click_Minus(object sender, EventArgs e)
        {
            if (TxtBox1.Text.Contains("-"))
            {
                return;
            }
            else
            {
                input = input + "-";
                TxtBox1.Text = input;
            }
        }

        private void button_Click_Multiply(object sender, EventArgs e)
        {
            //Check of er 2 getallen op de gekozen stack staan.
            if (a && Classes.ArrayStack.StackArray.Count > 1)
            {
                value2 = Classes.ArrayStack.StackArray.Pop();
                value1 = Classes.ArrayStack.StackArray.Pop();
                sum = Classes.Operator.Multiply(value1, value2);
                Classes.ArrayStack.StackArray.Push(sum);
                RefreshArrayStack();
            }
        }

        private void button_Click_Subtract(object sender, EventArgs e)
        {
            //Check of er 2 getallen op de gekozen stack staan.
            if (a && Classes.ArrayStack.StackArray.Count > 1)
            {
                value2 = Classes.ArrayStack.StackArray.Pop();
                value1 = Classes.ArrayStack.StackArray.Pop();
                sum = Classes.Operator.Subtract(value1, value2);
                Classes.ArrayStack.StackArray.Push(sum);
                RefreshArrayStack();
            }
        }
        private void button_Click_Divide(object sender, EventArgs e)
        {
            //Check of er 2 getallen op de gekozen stack staan.
            if (a && Classes.ArrayStack.array.Length > 1)
            {
                Classes.ArrayStack.arrStack.Push(Classes.ArrayStack.array);
                RefreshArrayStack();
            }
        }
        private void button_Click_Awnser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StackPushButton_Click(object sender, EventArgs e)
        {
            TxtBox2.Text = TxtBox1.Text;
        }

        private void StackPopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
