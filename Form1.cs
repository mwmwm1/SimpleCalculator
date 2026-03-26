namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstOperand = 0;      // 첫 번째 정수 저장
        string currentOperator = ""; // 입력된 연산자 (+, -, ×, ÷)
        bool isNewInput = true;// 새 숫자 입력 여부
        public Form1()
        {
            InitializeComponent();
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            // 누른 버튼이 무엇인지 가져옵니다.
            Button? btn = sender as Button;

            if (isNewInput)
            {
                InputBox.Text = btn.Text; // 처음엔 숫자를 새로 씀
                isNewInput = false;
            }
            else
            {
                InputBox.Text += btn.Text; // 다음부턴 뒤에 이어 붙임
            }
        }

        // 2. 더하기 버튼 (Plus 버튼에 연결하세요)
        private void Plus_Click(object sender, EventArgs e)
        {
            // 현재 입력된 값을 첫 번째 피연산자로 저장
            if (int.TryParse(InputBox.Text, out firstOperand))
            {
                currentOperator = "+";

                // OutputBox에 "숫자 +" 표시
                OutputBox.Text = firstOperand.ToString() + " +";

                // 다음 숫자는 새로 입력받도록 설정
                isNewInput = true;
            }
        }

        // 3. 결과 버튼 (Equal 버튼에 연결하세요)
        private void Equal_Click(object sender, EventArgs e)
        {
            int secondOperand = 0;

            // 1. InputBox에 있는 현재 값을 두 번째 숫자로 가져옴
            if (int.TryParse(InputBox.Text, out secondOperand))
            {
                // 2. 계산 수행
                int result = firstOperand + secondOperand;

                // 3. [수정된 부분] OutputBox에 수식과 결과값을 모두 표시
                // 예: "10 + 20 = 30"
                OutputBox.Text = $"{firstOperand} + {secondOperand} = {result}";

                // 4. InputBox에도 결과값을 표시 (다음 계산을 위해)
                InputBox.Text = result.ToString();

                // 5. 다음 숫자를 누르면 새로 시작하도록 설정
                isNewInput = true;

            }
        }
    }
}
