using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp3.Forms;
using WpfApp3.Models;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Good> ListGoods { get; set; }
        public  Good SelectedGood { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ListGoods = new();
            DataContext = this;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogAdd add = new DialogAdd();
            add.ShowDialog();
            ListGoods.Add(add.Good);
            


        }

        private void btn_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedGood == null)
            {
                return;
            }
            DialogAdd dialogadd = new DialogAdd(SelectedGood);
            dialogadd.ShowDialog();
            //ListGoods.Add(dialogadd.Good);
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedGood == null)
            {
                return;
            }
            DialogAdd dialog = new DialogAdd(SelectedGood);
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить этот товар?",
                "Внимание",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ListGoods.Remove(dialog.Good);
            }
            

        }
    }
}
