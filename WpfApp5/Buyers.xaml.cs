using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
using WpfApp5;

namespace WpfApp5
{

    public partial class Buyers : Page
    {
        private WILDBEREntities context = new WILDBEREntities();
        public Buyers()
        {
            InitializeComponent();
            BuyersDateGrid.ItemsSource = context.BUYER.ToList();
        }
    }
}