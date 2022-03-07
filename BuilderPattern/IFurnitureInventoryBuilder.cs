using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface IFurnitureInventoryBuilder
    {
        void AddTitle();
        void AddDimension();
        void AddLogistics(DateTime dateTime);

        InventoryReport GetDailyReport();
    }
}
