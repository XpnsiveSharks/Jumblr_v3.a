using Jumblr_v3.a.Designs;
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
    /// Interaction logic for UCGameOver.xaml
    /// </summary>
    public partial class UCGameOver : UserControl
    {
        public UCGameOver()
        {
            InitializeComponent();
        }
        private void BtnTryAgain_Click(object sender, RoutedEventArgs e)
        {
            UCChallegeMode ucChallengeMode = new UCChallegeMode();
            FormDesignFunctions.AlterContentPresenterContent(this, ucChallengeMode);
        }
        private void BtnBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            UCMenu ucMenu = new UCMenu();
            FormDesignFunctions.AlterContentPresenterContent(this, ucMenu);
        }
    }
}
