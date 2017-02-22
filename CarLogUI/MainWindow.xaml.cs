using System.Windows;

namespace CarLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Log().Info("Starting CarLog");
        }
    }
}
