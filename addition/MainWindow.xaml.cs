using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace addition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnresult_Click(object sender, RoutedEventArgs e)
        {
              int value1= Convert.ToInt32(txtvalue1.Text);
              int value2 = Convert.ToInt32(txtvalue2.Text);
            int result= value1 + value2;
            MessageBox.Show(Convert.ToString(result));
        }
    }
}