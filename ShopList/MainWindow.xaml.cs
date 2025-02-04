using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Text.Json.Nodes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopList
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

        private void InputAdd_Click(object sender, RoutedEventArgs e)
        {
            Data example = new Data
            {
                List = TxtInput.Text
            };
            string json = JsonConvert.SerializeObject(example);

            File.WriteAllText($"{Environment.CurrentDirectory}/file.json", json);


        }

        private void InputLoad_Click(object sender, RoutedEventArgs e)
        {
            string filePath = $"{Environment.CurrentDirectory}/file.json";

            if (File.Exists(filePath))
            {
                string js = File.ReadAllText(filePath);
                Data example = JsonConvert.DeserializeObject<Data>(js);

                TxtOutput.Text = example.List;

            }
        }


        private void InputDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}