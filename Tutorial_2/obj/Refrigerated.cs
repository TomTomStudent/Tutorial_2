using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2.obj
{
    internal class Refrigerated : Container, IHazardNotifier
    {
        protected string product_type;
        protected double temperature;

        public Refrigerated(double maxPayload) : base(maxPayload) { }

        public override bool IsHazardous() => false;
        public override string GetType() => "C";

        public void NotifyHazard()
        {
            Console.WriteLine($"Hazardous container: {serial_number}");
        }
    }
}
