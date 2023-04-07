using tugas_pbo_prakt;
using system;

namespace tugas_pbo_prakt
{
    /* Laptop */
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS
        {
            base.merk = "ASUS";
        }
}

class ROG : Laptop
{
    public ROG
        {
            base.tipe = "ROG";
        }
    }

    class Vivobook : Laptop
{
    public Vivobook
        {
            base.tipe = "Vivobook";
        }
public void Ngoding()
{
    Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
}
    }

    class ACER : Laptop
{
    public ACER
        {
            base.merk = "ACER";
        }
    }

    class Predator : Laptop
{
    public Predator
        {
            base.tipe = "Predator";
        }
public void BermainGame()
{
    Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
}
    }

    class Swift : Laptop
{
    public Swift
        {
            base.tipe = "Swift";
        }
    }

    class Lenovo : Laptop
{
    public Lenovo
        {
            base.merk = "Lenovo";
        }
    }

    class IdeaPad : Laptop
{
    public IdeaPad
        {
            base.tipe = "IdeaPad";
        }
    }

    class Legion : Laptop
{
    public Legion
        {
            base.tipe = "Legion";
        }
    }

/* Vga */
    class Vga
{
    public string merk;
}

class Nvidia : Vga
{
    public Nvidia
        {
            base.merk = "Nvidia";
        }
    }

    class AMD : Vga
{
    public AMD
        { 
            base.merk = "AMD";
        }
    }

/* processor */

    class Processor
{
    public string merk, tipe;
}

class Intel : Processor
{
    public Intel 
        { 
            base.merk = "Intel";        
        }
    }

    class CoreI3 : Processor
{
    public CoreI3
        {
            base.tipe = "Core i3";
        } 
    }

    class CoreI5 : Processor
{
    public CoreI5
        {
            base.tipe = "Core i5";
        } 
    }

    class CoreI7 : Processor
{
    public CoreI7
        {
            base.tipe = "Core i7";
        } 
    }


/* main */
    class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("test");
    }
}
}