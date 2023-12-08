using EO.WebBrowser;
using Slack.Webhooks.Blocks;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
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
using System.Windows.Shapes;
using Dapper;
using Jumblr_v3.a.Commons;

namespace Jumblr_v3.a.UI
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window 
    {
        public Test()
        {
            InitializeComponent();
            Loaded += Test_Loaded;  // Subscribe to the Loaded event
        }

        private void Test_Loaded(object sender, RoutedEventArgs e)
        {
            // Now that the window is loaded, you can handle events or perform other initialization
            OnEnterPressed += Test_OnEnterPressed;  // Subscribe to the custom event
        }

        private void Test_OnEnterPressed(object sender, EventArgs e)
        {
            TxtBlckTest.Text = "Enter Pressed";
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
/*        public static void InsertScore(int score)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string insertQuery = "INSERT INTO TBL_HIGHSCORE (SCORE) VALUES (@Score)";
                cnn.Execute(insertQuery, new { Score = score });
            }
        }*/

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<int> topScores = new List<int>();
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    // Retrieve the top 3 scores in descending order
                    string selectQuery = "SELECT SCORE FROM TBL_HIGHSCORE ORDER BY SCORE DESC LIMIT 3";

                    topScores = conn.Query<int>(selectQuery).ToList();

                    // Display the top scores
                    MessageBox.Show($"Top 3 Scores: {string.Join(", ", topScores)}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int score = 1970;
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (var transaction = cnn.BeginTransaction())
                    {
                        string insertQuery = "INSERT INTO TBL_HIGHSCORE (SCORE) VALUES (@Score)";

                        cnn.Execute(insertQuery, new { Score = score });

                        MessageBox.Show("Score inserted successfully!");
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();

                    string updateQuery = "DELETE FROM TBL_HIGHSCORE";

                    cnn.Execute(updateQuery);

                    MessageBox.Show("Scores cleared successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
