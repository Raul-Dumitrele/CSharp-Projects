using System;

public class Joc
{
    private int numardeghicit;
    private int incercari;

    public void Init()
    {
        Random random = new Random();
        numardeghicit = random.Next(1, 100);
        incercari = 0;
        Console.WriteLine("Am ales un numar intre 1 si 100.Incercati sa-l ghiciti!");
    }

    public void Joaca()
    {
        int ghicit;
        do
        {
            Console.WriteLine("Introduceti numarul ghicit: ");
            ghicit = Convert.ToInt32(Console.ReadLine());
            incercari++;

            if (ghicit < numardeghicit)
            {
                Console.WriteLine("Numarul este prea mic!Incercati din nou");
            }
            else if (ghicit > numardeghicit)
            {
                Console.WriteLine("Numarul este prea mare!Incercati din nou");
            }
            else
            {
                Console.WriteLine($"Felicitari!Ati ghicit numarul in {incercari} incercari!");
            }
        }while(ghicit != numardeghicit);
    }
    
    
}