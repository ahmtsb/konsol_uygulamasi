using System;
using System.Xml;

public class Program
{
    public static void Main(string[] args)
    {


        string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
        XmlDocument myXmlDocument = new XmlDocument();
        myXmlDocument.Load(url);

        XmlNodeList unit_values = myXmlDocument.GetElementsByTagName("Unit"); //xml dosyasından tagname'i "Unit" olan dosyaları değişkene yazdırdık.
        XmlNodeList isim_values = myXmlDocument.GetElementsByTagName("Isim");
        XmlNodeList currencyName_values = myXmlDocument.GetElementsByTagName("CurrencyName");
        XmlNodeList forexBuying_values = myXmlDocument.GetElementsByTagName("ForexBuying");

        Console.Write("-----------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------"); //Okunurluğu artırmak ve başlığı vurgulamak amacıyla yazılan komut
        Console.WriteLine(string.Format("{0,-35} | {1,-10} | {2,35} | {3,30}", "Döviz Kodu  ", "Unit  ", "Döviz Cinsi  ", "Döviz Alış")); // Sütun başlıkları
        Console.Write("-----------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------"); //Okunurluğu artırmak ve başlığı vurgulamak amacıyla yazılan komut



        for (int i = 0; i < unit_values.Count - 1; i++) // unit_values.Count -1 olmasının sebebi listenin sonuncu elemanını istemiyoruz.
        {
            Console.Write(string.Format("{0,-35} | {1,-10} | {2,35} | {3,30}", currencyName_values[i].InnerText, unit_values[i].InnerText, isim_values[i].InnerText, forexBuying_values[i].InnerText));

            Console.WriteLine("");
        }

        string v = Console.ReadLine();


    }
}