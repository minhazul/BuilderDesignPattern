using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class InventoryReport
    {
        public string TitleSection;
        public string LogisticsSection;
        public string DimensionSection;

        public string Debug()
        {
            return new StringBuilder()
                .AppendLine(TitleSection)
                .AppendLine(DimensionSection)
                .AppendLine(LogisticsSection)
                .ToString();
        }
    }
}
