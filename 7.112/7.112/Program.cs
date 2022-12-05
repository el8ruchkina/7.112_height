using System;
public class Mainclass
{
    public static void Main()
    {
        int heightOfBoys = 0, heightOfGirls = 0, Count1 = 0, Count2 = 0;
        int[] Height = new int[30];
        Random r = new Random();
        for (int i = 0; i < Height.Length; i++)
        {
            Height[i] = r.Next(-200, 200);
            if ((Height[i] < 150 && Height[i] >= 0))
            {
                Height[i] = r.Next(150,200);
            }
            else if ((Height[i] > -150 && Height[i] <= 0))
            {
                Height[i] = r.Next(-200, -150);
            }
            Console.WriteLine($"{Height[i]} cм");
        }
        Console.WriteLine("");
        for (int i = 0; i < Height.Length; i++)
        {
            if (Height[i] < 0)
            {
                heightOfBoys += Height[i];
                Count1++;
            }
            else if (Height[i] > 0)
            {
                heightOfGirls += Height[i];
                Count2++;
            }
        }
        int abs_b = heightOfBoys / Count1;
        int abs_g = heightOfGirls / Count2;
        Console.WriteLine($"Средний рост мальчиков: {abs_b} см");
        Console.WriteLine($"Средний рост девочек: {abs_g} см");
        Console.WriteLine($"Разница в среднем росте между ними равна {abs_g+abs_b}");
        

    }
}
