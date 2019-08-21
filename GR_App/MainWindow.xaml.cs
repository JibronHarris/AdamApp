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
using HtmlAgilityPack;
using System.Net.Http;

namespace GR_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }




        private async void SubButPC_Click(object sender, RoutedEventArgs e)
        {
            await PC_Class_List.GetHtmlAsync();

            string allGames = "";
            string tmp = "";

            PC_Class_List.PCList[0].PC_name = PC_Class_List.PCList[0].PC_name.ToString().Remove(43);

            var x = PC_Class_List.PCList.ToArray();

            for (int i = 10; i < 20; i++)
            {
                tmp = x[i].PC_name + "  " + x[i].PC_rankings + "\n";
                allGames = allGames + tmp;
            }

            MessageBox.Show($"                                      All-Time Best\n\n\n {allGames}");
        }

        private async void SubButXbox_Click(object sender, RoutedEventArgs e)
        {
            await XboxOne_Class_List.XboxOneGetHtmlAsync();

            string allGames = "";
            string tmp = "";

            XboxOne_Class_List.XboxOneList[0].PC_name = XboxOne_Class_List.XboxOneList[0].PC_name.ToString().Remove(43);

            var x = XboxOne_Class_List.XboxOneList.ToArray();

            for (int i = 10; i < 20; i++)
            {
                tmp = x[i].PC_name + "  " + x[i].PC_rankings + "\n";
                allGames = allGames + tmp;
            }

            MessageBox.Show($"                                      All-Time Best\n\n\n {allGames}");

        }

        private async void SubButPS4_Click(object sender, RoutedEventArgs e)
        {

            await PS4_Class_List.PS4GetHtmlAsync();

            string allGames = "";
            string tmp = "";

            PS4_Class_List.PS4List[0].PC_name = PS4_Class_List.PS4List[0].PC_name.ToString().Remove(24);

            var x = PS4_Class_List.PS4List.ToArray();

            for (int i = 10; i < 20; i++)
            {
                tmp = x[i].PC_name + "  " + x[i].PC_rankings + "\n";
                allGames = allGames + tmp;
            }

            MessageBox.Show($"                               All-Time Best\n\n\n {allGames}");

        }

        private async void SubButSwitch_Click(object sender, RoutedEventArgs e)
        {
            await Nintendo_Class_List.NintendoGetHtmlAsync();

            string allGames = "";
            string tmp = "";

            Nintendo_Class_List.NintendoList[0].PC_name = Nintendo_Class_List.NintendoList[0].PC_name.ToString().Remove(24);

            var x = Nintendo_Class_List.NintendoList.ToArray();

            for (int i = 10; i < 20; i++)
            {
                tmp = x[i].PC_name + "  " + x[i].PC_rankings + "\n";
                allGames = allGames + tmp;
            }

            MessageBox.Show($"                                   All-Time Best\n\n\n {allGames}");

        }
    }
}
