namespace Calculator
{
    public partial class Form1 : Form
    {
        private static string LastOperation { get; set; }
        private static string LastResult { get; set; }

        public Form1()
        {
            InitializeComponent();
            SelectionMode.SelectedItem = "Standard";
        }
        private void AppendNumber(string number)
        {
            if (ResultText.Text == "0" || ResultText.Text == "Result Undefined")
            {
                ResultText.Text = number;
            }
            else
            {
                ResultText.Text += number;
            }
        }

        private void CompletelyDeletebtn_Click(object sender, EventArgs e)
        {
            ResultText.Text = "0";
            LastResult = null;
            LastOperation = null;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (ResultText.Text.Length > 0)
            {
                ResultText.Text = ResultText.Text.Substring(0, ResultText.Text.Length - 1);
            }
        }
        private void Ninthbtn_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void Firstbtn_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void Secondbtn_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void Third_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void Fourth_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void Fifthbtn_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void Sixthbtn_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void Seventhbtn_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void Eighthbtn_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void Collectionbtn_Click(object sender, EventArgs e)
        {
            LastOperation = "+";
            LastResult = ResultText.Text;
            ResultText.Text = "";
        }

        private void Extractionbtn_Click(object sender, EventArgs e)
        {
            LastOperation = "-";
            LastResult = ResultText.Text;
            ResultText.Text = "";
        }

        private void Multiplicationbtn_Click(object sender, EventArgs e)
        {
            LastOperation = "*";
            LastResult = ResultText.Text;
            ResultText.Text = "";
        }

        private void Dividingbtn_Click(object sender, EventArgs e)
        {
            LastOperation = "/";
            LastResult = ResultText.Text;
            ResultText.Text = "";
        }
        private void PerformOperation()
        {
            if (ResultText.Text == "Result Undefined" || LastResult == "Result Undefined")
            {
                return;
            }

            if (LastResult != null || LastOperation != null)
            {
                double result = 0;
                double lastValue = Convert.ToDouble(LastResult);
                double currentValue = Convert.ToDouble(ResultText.Text);

                switch (LastOperation)
                {
                    case "+":
                        result = lastValue + currentValue;
                        break;
                    case "-":
                        result = lastValue - currentValue;
                        break;
                    case "*":
                        result = lastValue * currentValue;
                        break;
                    case "/":
                        if (currentValue == 0)
                        {
                            ResultText.Text = "Result Undefined";
                            return;
                        }
                        result = lastValue / currentValue;
                        break;
                }

                ResultText.Text = result.ToString();
            }
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            PerformOperation();
        }

        private void Zerobtn_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void Fractionbtn_Click(object sender, EventArgs e)
        {
            if (ResultText.Text == "0" || ResultText.Text == "")
            {
                ResultText.Text = "0,";
            }
            else if (ResultText.Text.EndsWith(","))
            {
                return;
            }
            else
            {
                ResultText.Text += ",";
            }
        }
    }
}
