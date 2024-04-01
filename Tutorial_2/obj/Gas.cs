using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2.obj
{
    internal class Gas : Container
    {
        public Gas(double maxPayload) : base(maxPayload) { }

        public override bool IsHazardous() => true;
        public override string GetType() => "G";
    }
}
