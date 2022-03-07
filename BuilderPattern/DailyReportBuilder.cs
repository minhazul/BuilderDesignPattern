using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public class DailyReportBuilder : IFurnitureInventoryBuilder
    {
        private InventoryReport _report;
        private IEnumerable<FurnitureItem> _items;

        public DailyReportBuilder(IEnumerable<FurnitureItem> items)
        {
            Reset();
            _items = items;
        }

        public void Reset()
        {
            _report = new InventoryReport();
        }

        public void AddTitle()
        {
            _report.TitleSection = "----------------------Daily Inventory Report----------------------\n\n";
        }

        public void AddDimension()
        {
            _report.DimensionSection = String.Join(Environment.NewLine, _items.Select(product =>
                $"Product: {product.Name} \n Price: {product.Price}\n" +
                $"Height: {product.Height} x Width: {product.Width} -> Weight: {product.Weight} lbs\n"));
        }

        public void AddLogistics(DateTime dateTime)
        {
            _report.LogisticsSection = $"Report generated on {dateTime}";
        }

        public InventoryReport GetDailyReport()
        {
            var finishedReport = _report;
            Reset();

            return finishedReport;
        }
    }
}
