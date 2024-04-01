using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2.obj
{
    internal class ContainerShip
    {
        protected int max_speed;
        protected int max_container_num;
        protected double max_weight;
        protected List<Container> containers;

        public ContainerShip(int speed, int maxNum, double maxWeight)
        {
            max_speed = speed;
            max_container_num = maxNum;
            max_weight = maxWeight;
            containers = new List<Container>();
        }

        public void LoadContainer(Container container)
        {
            if (containers.Count >= max_container_num)
            {
                Console.WriteLine("Capaicty is max");
                return;
            }

            double totalWeight = containers.Sum(c => c.cargo_mass);
            if (totalWeight + container.cargo_mass > max_weight)
            {
                Console.WriteLine("Weight is max");
                return;
            }

            containers.Add(container);
        }

        public void PrintContainersInfo()
        {
            Console.WriteLine("Containers on the ship:");
            foreach (Container container in containers)
            {
                Console.WriteLine($"Serial Number: {container.GetSerialNumber()}, Type: {container.GetType()}, Cargo Mass: {container.cargo_mass}");
            }
        }

        public void PrintShipInfo()
        {
            Console.WriteLine($"Ship Info: Max Speed: {max_speed} knots, Max Container Number: {max_container_num}, Max Weight: {max_weight} tons");
            PrintContainersInfo();
        }
    }
}
