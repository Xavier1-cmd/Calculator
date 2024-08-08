namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button buttonSender = (Button)sender;

            if ((textBoxResult.Text == "0") && (buttonSender.Text == "."))
            {
                textBoxResult.Text += buttonSender.Text;
            }

            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }

            isOperationPerformed = false;

            if (!(buttonSender.Text == "."))
            {
                //如果不是輸入"."，則正常輸出畫面
                textBoxResult.Text += buttonSender.Text;
            }
            else if (!textBoxResult.Text.Contains('.'))
            {
                //如果輸入的是"."，則判斷是否已包含"."，若沒有則正常輸出
                textBoxResult.Text += buttonSender.Text;
            }
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button buttonSender = (Button)sender;

            if (resultValue != 0)
            {
                buttonEqual.PerformClick();

                operationPerformed = buttonSender.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                resultValue = Double.Parse(textBoxResult.Text);

                operationPerformed = buttonSender.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void ButtonCE(object sender, EventArgs e)
        {
            //只清除當前輸入的值
            textBoxResult.Text = "0";
        }

        private void ButtonC(object sender, EventArgs e)
        {
            //全部清空
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBoxResult.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
