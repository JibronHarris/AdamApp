using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
namespace GR_App
{
    class XboxOne_Class_List
    {

        public static List<PC_Class> XboxOneList = new List<PC_Class>();

        public static async Task XboxOneGetHtmlAsync()
        {


            var url = "https://www.gamerankings.com/xboxone/index.html";


            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);


            var productsHtml = htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("body")).ToList();

            var productsHtml_ODD = htmlDocument.DocumentNode.Descendants("tr")
                .ToList();

            string name;
            string Ranking;

            int counter = 0;

            foreach (var item in productsHtml_ODD)
            {

                if (counter == 0)
                {
                    Console.WriteLine("Most Popular");

                    var getMostPopular = item.SelectNodes("//td[1]").ElementAtOrDefault(counter);
                    name = getMostPopular.InnerText.Trim();

                    var getRanking = item.SelectNodes("//td//span[2]//b").ElementAtOrDefault(counter);
                    Ranking = getRanking.InnerText.Trim();


                    XboxOneList.Add(new PC_Class { PC_name = name, PC_rankings = Ranking });
                    counter = counter + 1;
                }

                else
                {
                    var getMostPopular = item.SelectNodes("//td[1]").ElementAtOrDefault(counter);
                    name = getMostPopular.InnerText.Trim();

                    var getRanking = item.SelectNodes("//td[2]").ElementAtOrDefault(counter - 1);
                    Ranking = getRanking.InnerText.Trim();

                    XboxOneList.Add(new PC_Class { PC_name = name, PC_rankings = Ranking });

                    counter = counter + 1;
                }

                

            }




        }
    }
}
