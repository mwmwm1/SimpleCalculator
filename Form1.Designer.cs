namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            One = new Button();
            Two = new Button();
            Three = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            Seven = new Button();
            Eight = new Button();
            Nine = new Button();
            Zero = new Button();
            ClearEntry = new Button();
            Clear = new Button();
            Delete = new Button();
            Divide = new Button();
            Multiply = new Button();
            Minus = new Button();
            Plus = new Button();
            Sign = new Button();
            Dot = new Button();
            Equal = new Button();
            OutputBox = new TextBox();
            InputBox = new TextBox();
            Label = new Label();
            SuspendLayout();
            // 
            // One
            // 
            One.Location = new Point(16, 279);
            One.Name = "One";
            One.Size = new Size(58, 40);
            One.TabIndex = 0;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += btnNumber_Click;
            // 
            // Two
            // 
            Two.Location = new Point(73, 279);
            Two.Name = "Two";
            Two.Size = new Size(58, 40);
            Two.TabIndex = 1;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += btnNumber_Click;
            // 
            // Three
            // 
            Three.Location = new Point(130, 279);
            Three.Name = "Three";
            Three.Size = new Size(58, 40);
            Three.TabIndex = 2;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += btnNumber_Click;
            // 
            // Four
            // 
            Four.Location = new Point(16, 231);
            Four.Name = "Four";
            Four.Size = new Size(58, 40);
            Four.TabIndex = 3;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += btnNumber_Click;
            // 
            // Five
            // 
            Five.Location = new Point(73, 231);
            Five.Name = "Five";
            Five.Size = new Size(58, 40);
            Five.TabIndex = 4;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += btnNumber_Click;
            // 
            // Six
            // 
            Six.Location = new Point(130, 231);
            Six.Name = "Six";
            Six.Size = new Size(58, 40);
            Six.TabIndex = 5;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += btnNumber_Click;
            // 
            // Seven
            // 
            Seven.Location = new Point(16, 185);
            Seven.Name = "Seven";
            Seven.Size = new Size(58, 40);
            Seven.TabIndex = 6;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += btnNumber_Click;
            // 
            // Eight
            // 
            Eight.Location = new Point(73, 185);
            Eight.Name = "Eight";
            Eight.Size = new Size(58, 40);
            Eight.TabIndex = 7;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += btnNumber_Click;
            // 
            // Nine
            // 
            Nine.Location = new Point(130, 185);
            Nine.Name = "Nine";
            Nine.Size = new Size(58, 40);
            Nine.TabIndex = 8;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += btnNumber_Click;
            // 
            // Zero
            // 
            Zero.Location = new Point(73, 325);
            Zero.Name = "Zero";
            Zero.Size = new Size(58, 40);
            Zero.TabIndex = 9;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += btnNumber_Click;
            // 
            // ClearEntry
            // 
            ClearEntry.Location = new Point(16, 139);
            ClearEntry.Name = "ClearEntry";
            ClearEntry.Size = new Size(58, 40);
            ClearEntry.TabIndex = 10;
            ClearEntry.Text = "CE";
            ClearEntry.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            Clear.Location = new Point(73, 139);
            Clear.Name = "Clear";
            Clear.Size = new Size(58, 40);
            Clear.TabIndex = 11;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(130, 139);
            Delete.Name = "Delete";
            Delete.Size = new Size(58, 40);
            Delete.TabIndex = 12;
            Delete.Text = "DEL";
            Delete.UseVisualStyleBackColor = true;
            // 
            // Divide
            // 
            Divide.Font = new Font("맑은 고딕", 14F);
            Divide.Location = new Point(187, 139);
            Divide.Name = "Divide";
            Divide.Size = new Size(58, 40);
            Divide.TabIndex = 13;
            Divide.Text = "÷";
            Divide.UseVisualStyleBackColor = true;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("맑은 고딕", 14F);
            Multiply.Location = new Point(187, 185);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(58, 40);
            Multiply.TabIndex = 14;
            Multiply.Text = "×";
            Multiply.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            Minus.Font = new Font("맑은 고딕", 10F);
            Minus.Location = new Point(187, 231);
            Minus.Name = "Minus";
            Minus.Size = new Size(58, 40);
            Minus.TabIndex = 15;
            Minus.Text = "ㅡ";
            Minus.UseVisualStyleBackColor = true;
            // 
            // Plus
            // 
            Plus.Font = new Font("맑은 고딕", 14F);
            Plus.Location = new Point(187, 279);
            Plus.Name = "Plus";
            Plus.Size = new Size(58, 40);
            Plus.TabIndex = 16;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // Sign
            // 
            Sign.Font = new Font("맑은 고딕", 13F);
            Sign.Location = new Point(16, 325);
            Sign.Name = "Sign";
            Sign.Size = new Size(58, 40);
            Sign.TabIndex = 17;
            Sign.Text = "+/－";
            Sign.UseVisualStyleBackColor = true;
            // 
            // Dot
            // 
            Dot.Font = new Font("맑은 고딕", 15F);
            Dot.Location = new Point(130, 325);
            Dot.Name = "Dot";
            Dot.Size = new Size(58, 40);
            Dot.TabIndex = 18;
            Dot.Text = ".";
            Dot.UseVisualStyleBackColor = true;
            // 
            // Equal
            // 
            Equal.Font = new Font("맑은 고딕", 13F);
            Equal.Location = new Point(187, 325);
            Equal.Name = "Equal";
            Equal.Size = new Size(58, 40);
            Equal.TabIndex = 19;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(16, 71);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(229, 23);
            OutputBox.TabIndex = 21;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(16, 100);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(229, 23);
            InputBox.TabIndex = 22;
            // 
            // Label
            // 
            Label.Font = new Font("맑은 고딕", 19F);
            Label.ForeColor = Color.Blue;
            Label.Location = new Point(16, 9);
            Label.Name = "Label";
            Label.Size = new Size(229, 50);
            Label.TabIndex = 23;
            Label.Text = "Simple Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 382);
            Controls.Add(Label);
            Controls.Add(InputBox);
            Controls.Add(OutputBox);
            Controls.Add(Equal);
            Controls.Add(Dot);
            Controls.Add(Sign);
            Controls.Add(Plus);
            Controls.Add(Minus);
            Controls.Add(Multiply);
            Controls.Add(Divide);
            Controls.Add(Delete);
            Controls.Add(Clear);
            Controls.Add(ClearEntry);
            Controls.Add(Zero);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(One);
            Name = "Form1";
            Text = "Calculator v1.0";
            Click += btnNumber_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button One;
        private Button Two;
        private Button Three;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Zero;
        private Button ClearEntry;
        private Button Clear;
        private Button Delete;
        private Button Divide;
        private Button Multiply;
        private Button Minus;
        private Button Plus;
        private Button Sign;
        private Button Dot;
        private Button Equal;
        private TextBox OutputBox;
        private TextBox InputBox;
        private Label Label;
    }
}
