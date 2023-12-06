using Dapper;
using Jumblr_v3.a.Commons;
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
        }

        private void Btntest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataSource[] EasyWordsInfo = DataSource.GetArrayOfEasyWords();
                TxtBlckTest.Text = EasyWordsInfo[1].WORDS;
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }



    }
}
