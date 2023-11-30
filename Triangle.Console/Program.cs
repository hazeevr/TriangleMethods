class Program
{
    static void Main()
    {
        double sideA, sideB, sideC;

        Console.Write("Введите длину стороны A: ");
        if (double.TryParse(Console.ReadLine(), out sideA))
        {
            Console.Write("Введите длину стороны B: ");
            if (double.TryParse(Console.ReadLine(), out sideB))
            {
                Console.Write("Введите длину стороны C: ");
                if (double.TryParse(Console.ReadLine(), out sideC))
                {
                    var result = TriangleMethods.TriangleMethods.GetType(sideA, sideB, sideC);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода для стороны C.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода для стороны B.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода для стороны A.");
        }
        Console.ReadLine();
    }
}