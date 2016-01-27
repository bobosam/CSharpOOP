namespace Problem03_PCCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PlayPC
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Component motherboardFM2 = new Component("ASROCK FM2A88X Extreme6+", 218.40M, "AMD A88 FCH (Bolton-D4)");
            Component motherboardB85 = new Component("ASROCK B85M-ITX", 181.20M);
            Component boxCooler = new Component("COOLER MASTER Storm Trooper", 321.60M, "Steel body, Front Mesh / Plastic bezel");
            Component boxSuperMicro = new Component("Supermicro SuperChassis 813MTQ-600CB", 634.80M);
            Component hddSeagate2T = new Component("SEAGATE 2T, ES.3, SATA III", 373.20M, "SATA 6Gb/s");
            Component hddSeagate3T = new Component("SEAGATE 3T, ES.3, SATA III", 526.80M);
            Component procesor = new Component("Intel Core I3-3250 (3.5GHZ, 3MB)", 254.40M);
            Component ram = new Component("GEIL 8GB DDR3 1600MHz EVO VELOCE", 166.80m, "1600 MHz");
            Component graficsCard = new Component("SAPPHIRE HD6450, 2GB, DDR3 BULK", 128.40m);

            Computer firstComp = new Computer("HP Elite", motherboardFM2, boxCooler, hddSeagate2T, procesor);
            Computer secondComp = new Computer("Lenovo", motherboardB85, boxSuperMicro, hddSeagate3T, procesor, ram, graficsCard);
            Computer thirdComp = new Computer("ASUS", motherboardB85, boxCooler, hddSeagate2T, procesor);

            List<Computer> computers = new List<Computer> { firstComp, secondComp, thirdComp };

            computers
                .OrderBy(computer => computer.Price)
                .ThenBy(computer => computer.Name)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
