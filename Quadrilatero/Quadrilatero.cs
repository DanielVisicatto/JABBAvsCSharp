namespace Quadrilatero
{
    public class Quadrilatero
    {
        public static void Area(double lado)
        {
            Console.WriteLine("Area do quadrado: {0}", Math.Pow(lado,2));
        }

        public static void Area(double lado1, double lado2)
        {
            Console.WriteLine("Area do quadrado: {0}", lado1 + lado2);
        }

        public static void Area(double baseMenor, double baseMaior, double altura)
        {
            Console.WriteLine("Area do trapézio: {0}",((baseMaior + baseMenor) * altura) / 2);
        }
    }
}
