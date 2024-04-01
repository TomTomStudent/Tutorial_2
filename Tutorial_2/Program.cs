using Tutorial_2.obj;

static void LoadAndPrintContainer(ContainerShip ship, Container container)
{
    try
    {
        ship.LoadContainer(container);
        Console.WriteLine($"Container: Serial Number - {container.GetSerialNumber()}, Type - {container.GetType()}, Cargo Mass - {container.cargo_mass}");
    }
    catch (OverfillException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

ContainerShip ship1 = new ContainerShip(20, 200, 50000);

Gas gasContainer = new Gas(8000);
Liquid liquidContainer = new Liquid(10000);
Refrigerated refrigeratedContainer = new Refrigerated(12000);

LoadAndPrintContainer(ship1, gasContainer);
LoadAndPrintContainer(ship1, liquidContainer);
LoadAndPrintContainer(ship1, refrigeratedContainer);

ship1.PrintShipInfo();