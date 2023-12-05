using Jumblr_v3.a.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Jumblr_v3.a.Designs
{
    internal class FormDesignFunctions
    {
        static DispatcherTimer timer = new DispatcherTimer();
        public static void DisplayDifficultyImage(string imgName, Image difficultyImage)
        {
            difficultyImage.Source = new BitmapImage(new Uri($"/Jumblr_v3.a;component/Resources/{imgName}.png", UriKind.Relative));
        }
        public static void TrackDifficulty(Image control)// tracks the difficulty 
        {
            if (Functionalities.TrackLevel().Equals("21"))
            {
                FormDesignFunctions.DisplayDifficultyImage("Average", control);
            }
            else if (Functionalities.TrackLevel().Equals("41"))
            {
                FormDesignFunctions.DisplayDifficultyImage("Difficult", control);
            }
            else
            {
                FormDesignFunctions.DisplayDifficultyImage("Easy", control);
            }
        }
        public static void WrongAnswerImage(Image wrongAnsImg1, Image wrongAnsImg2, TextBlock TxtBlkForeCol)
        {
            if (Functionalities.WrongGuess() == 1)
            {
                wrongAnsImg1.Visibility = Visibility.Visible;
                wrongAnsImg2.Visibility = Visibility.Visible;
                TxtBlkForeCol.Foreground = Brushes.Red;
                // Create and configure a timer
                //DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(2); // Set the interval according to your preference
                timer.Tick += (sender, e) =>
                {
                    // Set the visibility to Collapse after the timer ticks
                    wrongAnsImg1.Visibility = Visibility.Collapsed;
                    wrongAnsImg2.Visibility = Visibility.Collapsed;
                    TxtBlkForeCol.Foreground = Brushes.Black;
                    timer.Stop();// Stop the timer to prevent further ticks
                };
                timer.Start();// Start the timer
            }
        }
        public static void HideFormComponents(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Visibility = Visibility.Collapsed;
            }
        }
        public static void ShowFormComponents(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Visibility = Visibility.Visible;
            }
        }
    }
}
