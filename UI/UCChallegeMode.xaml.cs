using Jumblr_v3.a.Commons;
using Jumblr_v3.a.Designs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Interaction logic for UCChallegeMode.xaml
    /// </summary>
    public partial class UCChallegeMode : UserControl
    {
        public UCChallegeMode()
        {
            InitializeComponent();
            TxtBlkWordDisplay.Text = Functionalities.printWord();
            LblScore.Text = Functionalities.Scoring();
            Loaded += Test_Loaded;

        }
        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            EnterEvents();
        }
        private void BtnGoToMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit the challenge?\nYour current score will be recorded as your final score", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                DataQueries.InsertScore(Functionalities.ScoringForChallengeMode());
                Functionalities.ResetDataFromFunctions();
                UCMenu ucMenu = new UCMenu();
                FormDesignFunctions.AlterContentPresenterContent(this, ucMenu);
            } 
        }
        private void BtnHint_Click(object sender, RoutedEventArgs e)
        {
            FormDesignFunctions.ShowHintComponents(TxtBlkHintDisplay, BorderHint, BtnBack, TxtBlkAnswer);
            TxtBlkHintDisplay.Text = Functionalities.printActiveHint();
            LblScore.Text = Functionalities.Scoring();
        }
        private void BtnSuffle_Click(object sender, RoutedEventArgs e)
        {
            TxtBlkWordDisplay.Text = Functionalities.ReShuffle();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FormDesignFunctions.HideHintComponents(TxtBlkHintDisplay, BorderHint, BtnBack, TxtBlkAnswer);

        }
        private void EnterEvents()
        {
            if(TxtBlkAnswer.Text == "")
            {
                MessageBox.Show("Answer must be not null");
            }
            else
            {
                TxtBlkWordDisplay.Text = Functionalities.VerifyAnswer(TxtBlkAnswer.Text);
                FormDesignFunctions.WrongAnswerImage(WrongAnsImage1, WrongAnsImage2, TxtBlkWordDisplay);
                LblScore.Text = Functionalities.Scoring();
                TxtBlkAnswer.Text = "";
                LifeDisplay();
                LastScoreInserted();
            }
        }
        private void LifeDisplay()
        {
            if(Functionalities.LivesLeft() == 2)
            {
                Heart3.Visibility = Visibility.Collapsed;
            }
            else if(Functionalities.LivesLeft() == 1)
            {
                Heart2.Visibility = Visibility.Collapsed;
            }
            else if(Functionalities.LivesLeft() == 0)
            {
                Heart1.Visibility = Visibility.Collapsed;
            }
            else
            {
                Heart1.Visibility = Visibility.Visible;
                Heart2.Visibility = Visibility.Visible;
                Heart3.Visibility = Visibility.Visible;
            }
        }
        private void LastScoreInserted()
        {
            if (Functionalities.GameOver() == 0)
            {
                DataQueries.InsertScore(Functionalities.ScoringForChallengeMode());
                Functionalities.ResetDataFromFunctions();
                UCGameOver ucGameOver = new UCGameOver();
                FormDesignFunctions.AlterContentPresenterContent(this, ucGameOver);
            }
        }
        private void Test_Loaded(object sender, RoutedEventArgs e)
        {
            OnEnterPressed += Test_OnEnterPressed;
        }
        private void Test_OnEnterPressed(object sender, EventArgs e)
        {
            EnterEvents();
        }
        public delegate void OnEnterPressedEventHandler(object sender, EventArgs e);
        public event OnEnterPressedEventHandler OnEnterPressed;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Key == Key.Enter)
            {
                OnEnterPressed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
