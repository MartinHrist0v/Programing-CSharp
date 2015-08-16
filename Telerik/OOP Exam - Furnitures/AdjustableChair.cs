using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class AdjustableChair : Chair, FurnitureManufacturer.Interfaces.IAdjustableChair
    {
        public void SetHeight(decimal height)
        {
            height = Height;
        }
    }
}
