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
                //�o��i��P�_�A�p�G��J�Ʀr�ɡA��ܵ�����"0"�A�h�b�M��"0"����A��ܿ�J���Ʀr
                //�S�Ϊ�isOperationPerformed(�B��ŬO�_������L)��"true"�ɡA����M��
                this.textBoxResult.Clear();
            }

            //���m�e�@���p�⤤�ҰO�����B��l���A�A��l�Ȭ�"false"
            this.isOperationPerformed = false;

            if (!((Button)sender).Text.Equals("."))
            {
                //�p�G���O��J"."�A�h���`��X�e��
                this.textBoxResult.Text += ((Button)sender).Text;
            }
            else if (!this.textBoxResult.Text.Contains('.'))
            {
                //�p�G��J���O"."�A�h�P�_�O�_�w�]�t"."�A�Y�S���h���`��X
                this.textBoxResult.Text += ((Button)sender).Text;
            }
        }

        private void Operator_click(object sender, EventArgs e)
        {

            if (resultValue != 0)
            {
                //�p�GresultValue���Ȥ���"0"�A�o�ɦA����J�B��l�A�|�N��e��ܪ��Ʀr�����PresultValue���B��
                buttonEqual.PerformClick();

                operationPerformed = ((Button)sender).Text;
                this.labelCurrentOperation.Text = $"{resultValue} {operationPerformed}";
                isOperationPerformed = true;
            }
            else
            {
                //�p�GresultValue���Ȭ�"0"�A�h�N��e��ܪ��Ʀr�s�JresultValue
                resultValue = double.Parse(this.textBoxResult.Text);

                operationPerformed = ((Button)sender).Text;
                this.labelCurrentOperation.Text = $"{resultValue} {operationPerformed}";
                isOperationPerformed = true;
            }
        }

        private void ButtonCE(object sender, EventArgs e)
        {
            //�u�M����e��J����
            this.textBoxResult.Text = "0";
        }

        private void ButtonC(object sender, EventArgs e)
        {
            //�����M��
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

            //�N�B��᪺�Ʀr�A�ഫ��s�JresultValue
            resultValue = double.Parse(this.textBoxResult.Text);
            //�M�ť��W�誺�Ȧs���
            this.labelCurrentOperation.Text = string.Empty;
        }
    }
}
