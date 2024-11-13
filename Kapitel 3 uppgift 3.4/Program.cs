using System;
namespace uppgift3_4
{ class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Ange hur lång din låt är i minuter (i hel tal)");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv i sekunder");
            int sekunder = int.Parse(Console.ReadLine());
            if (minuter   > 4)
            {
                Console.WriteLine("Låten är för lång");

            }
            if (minuter   < 2)
            {
                Console.WriteLine("Låter är för kort");
            }
            if (minuter == 2)
            {
                
                if (sekunder < 45)
                {
                    Console.WriteLine("Låten är för kort");
                    
                }
                else 
                {
                    Console.WriteLine("Låten är till räckligt lång");
                }
            }
            if ( minuter ==3)
            {
                Console.WriteLine("Låten är tillräckligt lång");
            }
            if (minuter == 4)
            {
                if (sekunder > 20)
                {
                    Console.WriteLine("Låten är för lång");
                }
                else
                {
                    Console.WriteLine("Låten är tillräckligt lång");
                }
            }


            
            
        }
    }
}
