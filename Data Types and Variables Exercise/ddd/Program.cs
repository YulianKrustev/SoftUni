using System;
System.Numerics.BigInteger bigInteger = System.Numerics.BigInteger;
namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSnowballs = int.Parse(Console.ReadLine());
            BigIntiger bestSnowball = 0;
            int snowballSnow1 = 0;
            int snowballTime1 = 0;
            int snowballQuality1 = 0;

            for (int i = 0; i < countSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigIntiger snowballValue = BigIntiger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    snowballSnow1 = snowballSnow;
                    snowballTime1 = snowballTime;
                    snowballQuality1 = snowballQuality;

                }
            }
            Console.WriteLine($"{snowballSnow1} : {snowballTime1} = {bestSnowball} ({snowballQuality1})");
        }
    }
}
