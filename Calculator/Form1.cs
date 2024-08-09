namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = string.Empty;
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {

            if (this.textBoxResult.Text.Equals("0") && ((Button)sender).Text.Equals("."))
            {
                this.textBoxResult.Text += ((Button)sender).Text;
            }

            if (this.textBoxResult.Text.Equals("0") || isOperationPerformed)
            {
                //這邊進行判斷，如果輸入數字時，顯示視窗為"0"，則在清除"0"之後，顯示輸入的數字
                //又或者isOperationPerformed(運算符是否有執行過)為"true"時，執行清除
                this.textBoxResult.Clear();
            }

            //重置前一次計算中所記錄的運算子狀態，初始值為"false"
            this.isOperationPerformed = false;

            if (!((Button)sender).Text.Equals("."))
            {
                //如果不是輸入"."，則正常輸出畫面
                this.textBoxResult.Text += ((Button)sender).Text;
            }
            else if (!this.textBoxResult.Text.Contains('.'))
            {
                //如果輸入的是"."，則判斷是否已包含"."，若沒有則正常輸出
                this.textBoxResult.Text += ((Button)sender).Text;
            }
        }

        private void Operator_click(object sender, EventArgs e)
        {

            if (resultValue != 0)
            {
                //如果resultValue的值不為"0"，這時再次輸入運算子，會將當前顯示的數字直接與resultValue做運算
                buttonEqual.PerformClick();

                operationPerformed = ((Button)sender).Text;
                this.labelCurrentOperation.Text = $"{resultValue} {operationPerformed}";
                isOperationPerformed = true;
            }
            else
            {
                //如果resultValue的值為"0"，則將當前顯示的數字存入resultValue
                resultValue = double.Parse(this.textBoxResult.Text);

                operationPerformed = ((Button)sender).Text;
                this.labelCurrentOperation.Text = $"{resultValue} {operationPerformed}";
                isOperationPerformed = true;
            }
        }

        private void ButtonCE(object sender, EventArgs e)
        {
            //只清除當前輸入的值
            this.textBoxResult.Text = "0";
        }

        private void ButtonC(object sender, EventArgs e)
        {
            //全部清空
            this.textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    this.textBoxResult.Text = (resultValue + double.Parse(this.textBoxResult.Text)).ToString();
                    break;
                case "-":
                    this.textBoxResult.Text = (resultValue - double.Parse(this.textBoxResult.Text)).ToString();
                    break;
                case "*":
                    this.textBoxResult.Text = (resultValue * double.Parse(this.textBoxResult.Text)).ToString();
                    break;
                case "/":
                    this.textBoxResult.Text = (resultValue / double.Parse(this.textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }

            //將運算後的數字，轉換後存入resultValue
            resultValue = double.Parse(this.textBoxResult.Text);
            //清空左上方的暫存顯示
            this.labelCurrentOperation.Text = string.Empty;
        }
    }
}
