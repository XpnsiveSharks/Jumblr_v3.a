using Jumblr_v3.a.Commons;
using Jumblr_v3.a.Designs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

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
            TxtBlkWordDisplay.Text = Functionalities.VerifyAnswer(TxtBlkAnswer.Text);
            FormDesignFunctions.WrongAnswerImage(WrongAnsImage1, WrongAnsImage2, TxtBlkWordDisplay);
            LblScore.Text = Functionalities.Scoring();
            FormDesignFunctions.TrackDifficulty(Difficulty);
            TxtBlkAnswer.Text = "";
        }
        private void BtnHint_Click(object sender, RoutedEventArgs e)
        {
            ShowHintComponents();
            TxtBlkAnswer.Visibility = Visibility.Collapsed;
            TxtBlkHintDisplay.Text = Functionalities.printHint();
            /*MessageBox.Show($"{Functionalities.IsNotActiveHint()}");
            //CheckActiveHint();*/
            LblScore.Text = Functionalities.Scoring();
        }
        private void BtnSuffle_Click(object sender, RoutedEventArgs e)// reshuffles the word
        {
            TxtBlkWordDisplay.Text = Functionalities.ReShuffle();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)// sets the visibility of the hint component to false
        {
            TxtBlkHintDisplay.Visibility = Visibility.Collapsed;
            BorderHint.Visibility = Visibility.Collapsed;
            BtnBack.Visibility = Visibility.Collapsed;
            TxtBlkAnswer.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Extra Functions
        /// </summary>
        private void ShowHintComponents()// set the visibility of the hint components to true
        {
            TxtBlkHintDisplay.Visibility = Visibility.Visible;
            BorderHint.Visibility = Visibility.Visible;
            BtnBack.Visibility = Visibility.Visible;
        }
        /*public void CheckActiveHint()
        {
            if (Functionalities.IsPrintWordTriggered() == true && Functionalities.IsNotActiveHint() == false)
            {
                BtnActiveHint.Visibility = Visibility.Collapsed;
                //TxtBlkHintDisplay.Text = Functionalities.printActiveHint();
                TxtBlkHintDisplay.Text = Functionalities.printHint();
            }
            else if (Functionalities.IsPrintWordTriggered() == false && )
            {
                
            }
        }*/
    }
}
