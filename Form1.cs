using System.Data;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double firstOperand = 0;       // 첫 번째 숫자 저장
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
                    // 0만 있을 때 숫자를 누르면 0이 지워지고 새 숫자가 써지도록 처리
                    if (InputBox.Text == "0") InputBox.Text = btn.Text;
                    else InputBox.Text += btn.Text;
                }

                OutputBox.Text = InputBox.Text;
            }
        }

        //  +, ㅡ, ×, ÷ 버튼 모두 이 이벤트에 연결
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                string op = btn.Text;
                if (op == "÷") op = "/";
                else if (op == "×") op = "*";
                else if (op == "ㅡ") op = "-";

                InputBox.Text += " " + op + " ";
                OutputBox.Text = InputBox.Text;
                isNewInput = false;
            }
        }

        // Equal 버튼에 연결
        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = InputBox.Text;
                expression = System.Text.RegularExpressions.Regex.Replace(expression, @"(\d)\s*\(", "$1*(");
                expression = System.Text.RegularExpressions.Regex.Replace(expression, @"\)\s*(\d)", ")*$1");

                DataTable table = new DataTable();
                var result = table.Compute(expression, "");
                double finalValue = Convert.ToDouble(result);

                finalValue = Math.Round(finalValue, 6);
                string printResult = finalValue.ToString("G");

                OutputBox.Text = $"{InputBox.Text} = {printResult}";
                InputBox.Text = printResult;
                isNewInput = true;
            }
            catch
            {
                MessageBox.Show("수식이 올바르지 않습니다.");
            }
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            InputBox.Text = "0";     // 현재 입력창만 0으로 바꿈
            isNewInput = true;

            if (string.IsNullOrEmpty(currentOperator))
            {
                OutputBox.Text = "";
            }
            else
            {
                OutputBox.Text = $"{firstOperand} {currentOperator} ";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            currentOperator = "";
            InputBox.Text = "";
            OutputBox.Text = "";     // 수식창 비우기
            isNewInput = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // 입력창에 글자가 있고, "0"이 아닐 때만 지우기 수행
            if (InputBox.Text.Length > 0 && InputBox.Text != "")
            {
                // 마지막 한 글자를 제거
                InputBox.Text = InputBox.Text.Substring(0, InputBox.Text.Length - 1);


                if (InputBox.Text == "")
                {
                    InputBox.Text = "";
                    isNewInput = true;
                }
                if (string.IsNullOrEmpty(currentOperator))
                {
                    OutputBox.Text = InputBox.Text;
                }
                else
                {
                    OutputBox.Text = $"{firstOperand} {currentOperator} {InputBox.Text}";
                }
            }
        }

        private void Sign_Click(object sender, EventArgs e)
        {

        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                InputBox.Text = "0.";
                isNewInput = false;
            }
            else
            {
                // 이미 소수점이 있다면 무시 (중복 방지)
                if (!InputBox.Text.Contains("."))
                {
                    InputBox.Text += ".";
                }
            }

            // 실시간 OutputBox 업데이트 (기존 로직 활용)
            UpdateOutput();
        }
        private void UpdateOutput()
        {
            if (string.IsNullOrEmpty(currentOperator))
            {
                OutputBox.Text = InputBox.Text;
            }
            else
            {
                OutputBox.Text = $"{firstOperand} {currentOperator} {InputBox.Text}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Parentheses_Click(object sender, EventArgs e)
        {
            int openCount = InputBox.Text.Count(f => f == '(');
            int closeCount = InputBox.Text.Count(f => f == ')');

            if (openCount > closeCount && (char.IsDigit(InputBox.Text.Last()) || InputBox.Text.Last() == ')'))
            {
                InputBox.Text += ")";
            }
            else
            {
                if (InputBox.Text != "0" && (char.IsDigit(InputBox.Text.Last()) || InputBox.Text.Last() == ')'))
                {
                    InputBox.Text += " * (";
                }
                else
                {
                    if (InputBox.Text == "0") InputBox.Text = "(";
                    else InputBox.Text += "(";
                }
            }
            OutputBox.Text = InputBox.Text;
            isNewInput = false;
        }
    }
}
