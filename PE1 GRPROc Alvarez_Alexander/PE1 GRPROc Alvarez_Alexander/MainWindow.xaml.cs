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

namespace PE1_GRPROc_Alvarez_Alexander
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
        private void Button_Click(object sender, RoutedEventArgs e)
     {
     if (int.TryParse(startnummertxt.text,out int startNumber) &&
         int.TryParse(EndStudentNumberTextBox.Text, out int endNumber))
         {
            string result =maak groepen(startNumber, endNumber);
                ResultTextBox.Text = result;
         }
    }

        

        
    }
}
