using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace xNameLessons
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Создаём массив 
        List<int> value;
        public MainWindow()
        {

            InitializeComponent();
            //Выделяем память
            value = new List<int>();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Создаём класс  random для рандомных значений
            Random random = new Random();
            //  записываем рандомные числа в  randValue в диапозоне  tboxDo.Text
            int randValue = random.Next( int.Parse(tboxDo.Text));
            //добавляем эллементы в массив 
            value.Add(randValue);
            //отчищаем StackPanel
            Panel.Children.Clear();

            //Бегаем по всему Массиву 
            //value.Count - длинна масива 

            for (int i =0;i< value.Count; i++)
            {
                // Код для вывода значений из массива  value в TextBlock
            }

        }
        //функция отчистки
        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {//отчищаем StackPanel
            Panel.Children.Clear();
            //отчищаем массив
            value.Clear();
        }


    }
}
