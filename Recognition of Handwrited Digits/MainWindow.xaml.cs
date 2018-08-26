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
using MNIST;
using System.IO;
using System.Reflection;


namespace Recognition_of_Handwrited_Digits
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

        private void BtnLoadMINSTData_Click(object sender, RoutedEventArgs e)
        {
            String appPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            String filePath = System.IO.Path.Combine(appPath, "Resources");
            String fullTestFilename = System.IO.Path.Combine(filePath, "OptdigitsTest.tes");
            String fullTrainingFilename = System.IO.Path.Combine(filePath, "OptdigitsTrain.tra");


            MNIST.IO.FileReaderMNIST.LoadImagesAndLables(fullTrainingFilename,)
        }
    }
}
