using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class InventoryBuildDirector
    {
        private IFurnitureInventoryBuilder _builder;

        public InventoryBuildDirector(IFurnitureInventoryBuilder concreteBuilder)
        {
            _builder = concreteBuilder;
        }

        public void BuildCompleteReport()
        {
            _builder.AddTitle();
            _builder.AddDimension();
            _builder.AddLogistics(DateTime.Now);
        }
    }
}
