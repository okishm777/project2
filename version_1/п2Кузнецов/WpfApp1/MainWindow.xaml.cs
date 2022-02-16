using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool done = true;
        private UdpClient client;
        private IPAddress groupAddress;
        private int localPort;
        private int remotePort;
        private int ttl;

        private IPEndPoint remoteEP;
        private UnicodeEncoding encoding = new UnicodeEncoding();

        private string name;
        private string message;

        private readonly SynchronizationContext _syncContext;
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}