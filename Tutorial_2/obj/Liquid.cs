using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2.obj
{
    internal class Liquid : Container
    {
        protected bool hazardous;

        public Liquid(double maxPayload) : base(maxPayload) { }

        public override bool IsHazardous() => hazardous;
        public override string GetType() => "L";
    }
}
