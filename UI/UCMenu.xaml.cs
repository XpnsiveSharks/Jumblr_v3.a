using Jumblr_v3.a.Commons;
using Jumblr_v3.a.Designs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for UCMenu.xaml
    /// </summary>
    public partial class UCMenu : UserControl
    {
        public UCMenu()
        {
            InitializeComponent();
            DisplayTopScores();
        }
        private void DisplayTopScores()
        {
            List<int> _scores = DataQueries.DisplayScore();
            LblBestScore.Text = _scores.Max().ToString();
            LblsecondBestScore.Text = _scores[1].ToString();
            LblThirdBestScore.Text = _scores.Min().ToString();
        }
        private void BtnCasual_Click(object sender, RoutedEventArgs e)
        {
            UCGame _cd = new UCGame();
            FormDesignFunctions.AlterContentPresenterContent(this, _cd);
        }
        private void BtnChallenge_Click(object sender, RoutedEventArgs e)
        {
            UCChallegeMode uCChallegeMode = new UCChallegeMode();
            FormDesignFunctions.AlterContentPresenterContent(this, uCChallegeMode);

        }
    }
    
}
