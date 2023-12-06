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
            ButtonActiveHintVisibility();
            FormDesignFunctions.WrongAnswerImage(WrongAnsImage1, WrongAnsImage2, TxtBlkWordDisplay);
            LblScore.Text = Functionalities.Scoring();
            FormDesignFunctions.TrackDifficulty(Difficulty);
            TxtBlkAnswer.Text = "";
        }
        private void BtnHint_Click(object sender, RoutedEventArgs e)
        {
            ShowHintComponents();
            TxtBlkHintDisplay.Text = Functionalities.printHint();
            ButtonActiveHintVisibility();
            LblScore.Text = Functionalities.Scoring();
        }
        private void BtnActiveHint_Click(object sender, RoutedEventArgs e)// sets the visibility of the hint component to false
        {
            ShowAcitiveHintComponents();
            TxtBlkHintDisplay.Text = Functionalities.printActiveHint();
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
            TxtBlkAnswer.Visibility = Visibility.Collapsed;
        }
        private void ShowAcitiveHintComponents()
        {
            TxtBlkHintDisplay.Visibility = Visibility.Visible;
            BorderHint.Visibility = Visibility.Visible;
            BtnBack.Visibility = Visibility.Visible;
            TxtBlkAnswer.Visibility = Visibility.Collapsed;
        }
        private void ButtonActiveHintVisibility()
        {
            if (Functionalities.HintTriggered() == true)
                BtnActiveHint.Visibility = Visibility.Visible;

            if (Functionalities.HintTriggered() == false)
                BtnActiveHint.Visibility = Visibility.Collapsed; 
                
        }
    }
}
