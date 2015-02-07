using System.Windows;
using System;
using System.Windows.Input;
using Task15.Model;

namespace Task15.ViewModel
{
    /// <summary>
    /// Калькулятор проводить розрахунок наступним чином: число [операція] число = результат
    /// </summary>
    class MainViewModel
    {
        private bool checkClick;
        public CalculatorModel Calculator { get; set; }

        public MainViewModel()
        {
            ClickOneNumber = new Command(arg => ClickOne());
            ClickTwoNumber = new Command(arg => ClickTwo());
            ClickThreeNumber = new Command(arg => ClickThree());
            ClickFourNumber = new Command(arg => ClickFour());
            ClickFiveNumber = new Command(arg => ClickFive());
            ClickSixNumber = new Command(arg => ClickSix());
            ClickSevenNumber = new Command(arg => ClickSeven());
            ClickEightNumber = new Command(arg => ClickEight());
            ClickNineNumber = new Command(arg => ClickNine());
            ClickZeroNumber = new Command(arg => ClickZero());
            ClickPointButton = new Command(arg => ClickPoint());
            ClickPlusButton = new Command(arg => ClickPlus());
            ClickSubtractionButton = new Command(arg => ClickSubtraction());
            ClickDivisionButton = new Command(arg => ClickDivision());
            ClickMultiplyButton = new Command(arg => ClickMultiply());
            ClickEqualsButton = new Command(arg => ClickEqual());
            Calculator = new CalculatorModel {Number = ""};
        }

        public ICommand ClickOneNumber { get; set; }
        public ICommand ClickTwoNumber { get; set; }
        public ICommand ClickThreeNumber { get; set; }
        public ICommand ClickFourNumber { get; set; }
        public ICommand ClickFiveNumber { get; set; }
        public ICommand ClickSixNumber { get; set; }
        public ICommand ClickSevenNumber { get; set; }
        public ICommand ClickEightNumber { get; set; }
        public ICommand ClickNineNumber { get; set; }
        public ICommand ClickZeroNumber { get; set; }
        public ICommand ClickPointButton { get; set; }
        public ICommand ClickPlusButton { get; set; }
        public ICommand ClickDivisionButton { get; set; }
        public ICommand ClickSubtractionButton { get; set; }
        public ICommand ClickMultiplyButton { get; set; }
        public ICommand ClickEqualsButton { get; set; }

        private void ClickOne()
        {
            if(checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "1";
            checkClick = false;
        }

        private void ClickTwo()
        {
            if (checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "2";
            checkClick = false;
        }

        private void ClickThree()
        {
            if (checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "3";
            checkClick = false;
        }

        private void ClickFour()
        {
            if (checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "4";
            checkClick = false;
        }

        private void ClickFive()
        {
            if (checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "5";
            checkClick = false;
        }

        private void ClickSix()
        {
            if (checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "6";
            checkClick = false;
        }

        private void ClickSeven()
        {
            if (checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "7";
            checkClick = false;
        }

        private void ClickEight()
        {
            if (checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "8";
            checkClick = false;
        }

        private void ClickNine()
        {
            if (checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "9";
            checkClick = false;
        }

        private void ClickZero()
        {
            if (checkClick)
            {
                Calculator.Number = "";
            }
            Calculator.Number += "0";
            checkClick = false;
        }

        private void ClickPoint()
        {
            if(Calculator.Number.Contains(","))
            {
                return;
            }
            Calculator.Number += ",";
        }

        private void ClickPlus()
        {
            Calculator.tempNumber = Calculator.Number;
            Calculator.Operation = "+";
            checkClick = true;
        }

        private void ClickSubtraction()
        {
            Calculator.tempNumber = Calculator.Number;
            Calculator.Operation = "-";
            checkClick = true;
        }

        private void ClickDivision()
        {
            Calculator.tempNumber = Calculator.Number;
            Calculator.Operation = "/";
            checkClick = true;
        }

        private void ClickMultiply()
        {
            Calculator.tempNumber = Calculator.Number;
            Calculator.Operation = "*";
            checkClick = true;
        }

        private void ClickEqual()
        {
            switch (Calculator.Operation)
            {
                case "+": Calculator.Number = Convert.ToString((Convert.ToDouble(Calculator.tempNumber) + Convert.ToDouble(Calculator.Number)));
                    break;
                case "-": Calculator.Number = Convert.ToString((Convert.ToDouble(Calculator.tempNumber) - Convert.ToDouble(Calculator.Number)));
                    break;
                case "/":
                    if (Calculator.Number == "0")
                    {
                        MessageBox.Show("0 is incorrect number");
                        Calculator.Number = "";
                        break;
                    }
                    Calculator.Number = Convert.ToString((Convert.ToDouble(Calculator.tempNumber) / Convert.ToDouble(Calculator.Number)));
                    break;
                case "*": Calculator.Number = Convert.ToString((Convert.ToDouble(Calculator.tempNumber) * Convert.ToDouble(Calculator.Number)));
                    break;
                default:
                    MessageBox.Show("Incorrect operation!");
                    break;
            }   
        }
    }
}
