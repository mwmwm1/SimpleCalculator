namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstOperand = 0;       // 첫 번째 숫자 저장
        string currentOperator = "";  // 표준 연산자 (+, -, *, /) 저장
        bool isNewInput = true;      // 새로운 숫자 입력 여부

        public Form1()
        {
            InitializeComponent();
        }

        // 0~9 버튼 모두 이 이벤트에 연결
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (isNewInput)
                {
                    InputBox.Text = btn.Text;
                    isNewInput = false;
                }
                else
                {
                    InputBox.Text += btn.Text;
                }
            }
        }

        //  +, ㅡ, ×, ÷ 버튼 모두 이 이벤트에 연결
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (int.TryParse(InputBox.Text, out firstOperand))
                {
                    // 버튼의 특수 기호를 표준 기호로 변환하여 저장
                    string opText = btn.Text;

                    if (opText == "÷") currentOperator = "/";
                    else if (opText == "×") currentOperator = "*";
                    else if (opText == "ㅡ") currentOperator = "-";
                    else currentOperator = opText; // "+" 등은 그대로

                    // OutputBox에는 변환된 표준 기호를 표시
                    OutputBox.Text = $"{firstOperand} {currentOperator}";

                    isNewInput = true;
                }
            }
        }

        // Equal 버튼에 연결
        private void Equal_Click(object sender, EventArgs e)
        {
            int secondOperand = 0;
            int result = 0;

            if (int.TryParse(InputBox.Text, out secondOperand))
            {
                // 계산 수행
                switch (currentOperator)
                {
                    case "+":
                        result = firstOperand + secondOperand;
                        break;
                    case "-":
                        result = firstOperand - secondOperand;
                        break;
                    case "*":
                        result = firstOperand * secondOperand;
                        break;
                    case "/":
                        if (secondOperand != 0)//0으로 나누는 경우
                        {
                            result = firstOperand / secondOperand;
                        }
                        else
                        {
                            MessageBox.Show("0으로 나눌 수 없습니다!");
                            return; // 계산 중단
                        }
                        break;
                    default:
                        return; // 연산자가 선택되지 않은 경우
                }

                // OutputBox에 전체 수식과 결과 표시 
                OutputBox.Text = $"{firstOperand} {currentOperator} {secondOperand} = {result}";

                // InputBox에 최종 결과 표시
                InputBox.Text = result.ToString();

                // 상태 초기화
                isNewInput = true;
            }
        }
    }
}
