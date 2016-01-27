namespace Problem02_LaptopShop
{
    using System;

    public class PlayLaptops
    {
        public static void Main()
        {
            Battery cells4 = new Battery("Li-ion", 4, 2550);
            Battery cells3 = new Battery("Li-ion", 3, 1800);

            Laptop lenovo = new Laptop(
                                        "Lenovo Yoga 2 Pro",
                                        (decimal)2259.00,
                                        "Lenovo",
                                        "Intel Core i5-4210U (2-core, 1,70 - 2,70 GHz, 3MB cashe)",
                                        "8 GB",
                                        "Intel HD Graphics 4400",
                                        "128GB SSD",
                                        "13.3\" (33.78 sm) - 3200 * 1800 (QHD+), IPS sensor display",
                                        cells4,
                                        4.5);

            Laptop hp = new Laptop("HP 250 G2", (decimal)699.00);

            Console.WriteLine(lenovo);
            Console.WriteLine();
            Console.WriteLine(hp);
        }
    }
}
