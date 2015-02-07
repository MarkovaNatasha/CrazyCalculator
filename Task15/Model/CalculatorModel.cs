using System.ComponentModel;


namespace Task15.Model
{
    class CalculatorModel : INotifyPropertyChanged
    {
        private string number;
        private string operation;

        public string Number
        {
            get { return number; }
            set
            {
                if (number != value)
                {
                    number = value;
                    OnPropertyChanged("Number");
                }
            }
        }

        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public string tempNumber { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
