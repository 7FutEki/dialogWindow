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
using System.Windows.Shapes;
using WpfApp3.Models;

namespace WpfApp3.Forms
{
    /// <summary>
    /// Логика взаимодействия для DialogAdd.xaml
    /// </summary>
    public partial class DialogAdd : Window
    {
        public Good Good { get; set; }
        
        public DialogAdd()
        {

            InitializeComponent();
            Good = new Good();
            DataContext = Good;
        }

        public DialogAdd(Good good)
        {
            InitializeComponent();
            Good= good;
            DataContext = Good; 
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
