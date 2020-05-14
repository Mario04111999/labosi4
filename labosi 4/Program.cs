using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak 2
            //Dataset dataset = new Dataset(@"C:\Users\Mario Matić\source\repos\Labosi 3\Labosi 3\bin\Debug\LV4.cvs");
            //Analyzer3rdParty party = new Analyzer3rdParty();
            //Adapter adapter = new Adapter(party);
            //double[] rowAverage = adapter.CalculateAveragePerRow(dataset);
            //double[] columnAverage = adapter.CalculateAveragePerColumn(dataset);

            //for (int i = 0; i < rowAverage.Length; i++)
            //{
            //    Console.Write(rowAverage[i] + " ");
            //}
            //Console.WriteLine();

            //for (int j = 0; j < columnAverage.Length; j++)
            //{
            //    Console.Write(columnAverage[j] + " ");
            //}
            //Console.WriteLine("\n");


            //Zadatak3
            List<IRentable> rentable = new List<IRentable>();
            Book book = new Book("razbojnici");
            rentable.Add(book);
            Video video = new Video("Now You See Me");
            rentable.Add(video);
            RentingConsolePrinter rent = new RentingConsolePrinter();
            rent.PrintTotalPrice(rentable);
            rent.DisplayItems(rentable);
            Console.WriteLine("\n");


            //Zadatak4
            Book book2 = new Book("jama");
            Video video2 = new Video("My Spy");
            HotItem hotItem = new HotItem(book2);
            rentable.Add(hotItem);
            HotItem hotItem2 = new HotItem(video2);
            rentable.Add(hotItem2);
            rent.PrintTotalPrice(rentable);
            rent.DisplayItems(rentable);
            Console.WriteLine("\n");






        }
    }
}
