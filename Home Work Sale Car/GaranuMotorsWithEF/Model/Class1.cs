using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaranuMotorsWithEF.Model
{
    public partial class  Brand
    {
        public override string ToString()
        {
            return Name;
        }
    }
    
    public partial class Color
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public partial class FuelType
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public partial class Model
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public partial class Transmission
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
