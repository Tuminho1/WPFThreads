using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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

namespace tumidei.matteo._4h.threads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int NGIRI = 100;
        int _counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(Incrementa);
            Incrementa();
        }

        void Incrementa()
            {
                for(int x=0;x<NGIRI;x++)
                {
                _counter++;
                Dispatcher.Invoke(
                    () =>  
                txtCounter1.Text = _counter.ToString();
                }
            txtCounter1.Text = _counter.ToString();
            Thread.Sleep(100);
        }
    }
}
