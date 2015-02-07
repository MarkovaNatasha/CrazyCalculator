using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Task15.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e) //  випадкове переміщення кнопок при натисненні
        {
            var buttons = new List<Button> {button0, button1, button2, button3, button4, button5, button6, button7, button8, button9, buttonDivision, buttonEquals, buttonMinus, buttonMultiply, buttonPlus, buttonPoint};
            var rnd = new Random();
            foreach (var button in buttons)
            {
                int index = rnd.Next(0, buttons.Count);
                Thickness temp = button.Margin;
                button.Margin = buttons[index].Margin;
                buttons[index].Margin = temp;
            }
        }
    }
}
