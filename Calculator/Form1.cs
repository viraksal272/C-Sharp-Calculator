namespace Calculator
{
    public partial class Form1 : Form
    {
        private double ResultValue = 0;
        private string OperationPerformed = "";
        private Boolean IsOperationPerformed = false;

        private double Theme = 1;
        public Form1()
        {
            InitializeComponent();
            textBox1.Enter += (s, e) => this.ActiveControl = null;
            textBox1.Text = "0";
            button1.Click += NumberBtn_Clicked;
            button2.Click += NumberBtn_Clicked;
            button3.Click += NumberBtn_Clicked;
            button4.Click += NumberBtn_Clicked;
            button5.Click += NumberBtn_Clicked;
            button6.Click += NumberBtn_Clicked;
            button7.Click += NumberBtn_Clicked;
            button8.Click += NumberBtn_Clicked;
            button9.Click += NumberBtn_Clicked;
            button10.Click += EqualBtn_Clicked;
            button11.Click += NumberBtn_Clicked;
            button12.Click += BackspaceBtn_Clicked;
            button13.Click += OperationBtn_Clicked;
            button14.Click += OperationBtn_Clicked;
            button15.Click += OperationBtn_Clicked;
            button16.Click += OperationBtn_Clicked;
            button17.Click += ClearBtn_Clicked;
            button18.Click += ModeBtn_Clicked;
        }
        private void NumberBtn_Clicked(Object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            
            if((textBox1.Text == "0") || (IsOperationPerformed)){
                textBox1.Text = "";
            }
            textBox1.Text += ClickedButton.Text;
        }
        private void OperationBtn_Clicked(Object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            string[] parts = textBox1.Text.Split(" ");
            if(parts.Length>=3 && !string.IsNullOrEmpty(parts[2]))
            {
                double FirstNum = double.Parse(parts[0]);
                double SecondNum = double.Parse(parts[2]);
                double TempResult = 0;
                switch (parts[1])
                {
                    case "+": TempResult = FirstNum + SecondNum;
                        break;
                    case "−": TempResult = FirstNum - SecondNum;
                        break;
                    case "×": TempResult = FirstNum * SecondNum;
                        break;
                    case "÷": TempResult = FirstNum / SecondNum;
                        break;
                }
                ResultValue = TempResult;
            }
            else
            {
                double.TryParse(parts[0], out ResultValue);
            }
            OperationPerformed = ClickedButton.Text;
            textBox1.Text = ResultValue.ToString() + " " + OperationPerformed + " ";
        }
        private void EqualBtn_Clicked(Object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            string[] parts = textBox1.Text.Split(" ");
            if (parts.Length >= 3 && !string.IsNullOrEmpty(parts[2]))
            {
                double FirstNum = double.Parse(parts[0]);
                double SecondNum = double.Parse(parts[2]);
                double Result = 0;
                switch (parts[1])
                {
                    case "+":
                        Result = FirstNum + SecondNum;
                        break;
                    case "−":
                        Result = FirstNum - SecondNum;
                        break;
                    case "×":
                        Result = FirstNum * SecondNum;
                        break;
                    case "÷":
                        Result = FirstNum / SecondNum;
                        break;
                }
                ResultValue = Result;
            }
            else
            {
                double.TryParse(parts[0], out ResultValue);
            }
            textBox1.Text = ResultValue.ToString();
        }
        private void BackspaceBtn_Clicked(object sender, EventArgs e)
        {
            string CurrentText = textBox1.Text;
            if(CurrentText.Length>0 && CurrentText != "0")
            {
                if(CurrentText.EndsWith(" "))
                {
                    textBox1.Text = CurrentText.Substring(0, CurrentText.Length - 3);
                }
                else
                {
                    textBox1.Text = CurrentText.Substring(0, CurrentText.Length - 1);
                }
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0";
            }

        }
        private void ClearBtn_Clicked(Object sender, EventArgs e)
        {
            ResultValue = 0;
            textBox1.Text = ResultValue.ToString();
            OperationPerformed = "";
        }
        private void ModeBtn_Clicked(object sender, EventArgs e)
        {
            Theme++;
            if (Theme == 5)
            {
                Theme = 1;
            }
            if (Theme == 1)
            {
                // --- DARK MODE COLORS ---
                this.BackColor = Color.FromArgb(32, 34, 46);       
                textBox1.BackColor = Color.FromArgb(44, 49, 69);   
                textBox1.ForeColor = Color.White;                   

            }
            else if(Theme == 2)
            {
                // --- LIGHT MODE COLORS ---
                this.BackColor = Color.FromArgb(240, 240, 243);   
                textBox1.BackColor = Color.FromArgb(223, 223, 223);      
                textBox1.ForeColor = Color.Black;            
            }
            else if(Theme == 3)
            {
                this.BackColor = Color.FromArgb(250, 165, 236);
                textBox1.BackColor = Color.FromArgb(255, 218, 233);
                textBox1.ForeColor = Color.FromArgb(120, 40, 75);
            }
            else if(Theme == 4)
            {
                this.BackColor = Color.FromArgb(101, 158, 247);
                textBox1.BackColor = Color.FromArgb(163, 199, 255);
                textBox1.ForeColor = Color.FromArgb(0, 111, 255);
            }
            UpdateButtonThemes();
        }
        private void UpdateButtonThemes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    if (Theme == 1)
                    {
                        btn.BackColor = Color.FromArgb(54, 58, 79); 
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.FromArgb(44, 49, 69);
                    }
                    else if(Theme == 2)
                    {
                        btn.BackColor = Color.FromArgb(223, 223, 223);
                        btn.ForeColor = Color.FromArgb(32, 34, 46);
                        btn.FlatAppearance.BorderColor = Color.LightGray;
                    }
                    else if(Theme == 3)
                    {
                        btn.BackColor = Color.FromArgb(255, 224, 252);
                        btn.ForeColor = Color.FromArgb(120, 40, 75);
                        btn.FlatAppearance.BorderColor = Color.FromArgb(242, 140, 177);
                    }
                    else if(Theme == 4)
                    {
                        btn.BackColor = Color.FromArgb(163, 199, 255);
                        btn.ForeColor = Color.FromArgb(0, 111, 255);
                        btn.FlatAppearance.BorderColor = Color.FromArgb(0, 111, 255);
                    }
                }
            }
        }
    }
}
