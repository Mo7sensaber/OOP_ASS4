using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_4
{
    internal interface IRectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }
    }
}
