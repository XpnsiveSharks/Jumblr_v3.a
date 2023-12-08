using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dapper;

namespace Jumblr_v3.a.Commons
{
    internal class DataQueries
    {
        public static void InsertScore(int score)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    string insertQuery = "INSERT INTO TBL_HIGHSCORE (SCORE) VALUES (@SCORE)";
                    Score data = new Score { SCORE = score };
                    cnn.Execute(insertQuery, data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<int> DisplayScore()
        {
            List<int> topScores = new List<int>();
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    
                    string selectQuery = "SELECT SCORE FROM TBL_HIGHSCORE ORDER BY SCORE DESC LIMIT 3";// Retrieve the top 3 scores in descending order

                    topScores = conn.Query<int>(selectQuery).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Check if the list is null or has fewer than three elements
            if (topScores == null || topScores.Count < 3)
            {
                // Fill the list with zeros to make it contain three elements
                while (topScores.Count < 3)
                {
                    topScores.Add(0);
                }
            }

            return topScores;
        }


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
