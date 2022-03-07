using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var furnitureItems = new List<FurnitureItem>()
            {
                new FurnitureItem("Sofa", 45.5, 5.6, 78.9, 66),
                new FurnitureItem("Table", 48, 8.9, 50, 88),
                new FurnitureItem("Bed", 33.8, 7.9, 66.4, 28.3)
            };

            var inventoryBuilder = new DailyReportBuilder(furnitureItems);
            var director = new InventoryBuildDirector(inventoryBuilder);

            director.BuildCompleteReport();

            var directorReport = inventoryBuilder.GetDailyReport();
            Console.WriteLine(directorReport.Debug());
        }
    }
}
