using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2.obj
{
    internal class Container
    {
        public string serial_number;
        public double cargo_mass;
        public double max_payload;
        private static int nextSerialNumber = 1;

        public Container(double maxPayload)
        {
            serial_number = GenerateSerialNumber();
            max_payload = maxPayload;
        }
        private string GenerateSerialNumber()
        {
            string type = GetType().ToLower();
            string serial = $"KON-{type}-{nextSerialNumber}";
            nextSerialNumber++;
            return serial;
        }
        public virtual void LoadCargo(double mass)
        {
            if (mass > max_payload)
                throw new OverfillException();

            cargo_mass = mass;
        }

        public virtual void EmptyCargo()
        {
            cargo_mass = 0;
        }

        public virtual bool IsOverfilled() => cargo_mass > max_payload;
        public virtual bool IsHazardous() => false;
        public virtual string GetType() => "General";
        public string GetSerialNumber() => serial_number;
        public virtual void NotifyHazard() { }
    }
}
