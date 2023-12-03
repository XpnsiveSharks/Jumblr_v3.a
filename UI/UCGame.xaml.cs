using Jumblr_v3.a.Commons;
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

namespace Jumblr_v3.a.UI
{
    /// <summary>
    /// Interaction logic for UCGame.xaml
    /// </summary>
    public partial class UCGame : UserControl
    {
        public UCGame()
        {
            InitializeComponent();
            TxtBlkWordDisplay.Text = Functionalities.printWord();
            LblScore.Text = Functionalities.Scoring();
        }
        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            TxtBlkWordDisplay.Text = Functionalities.printWord();
        }
    }
}
