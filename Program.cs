class mass1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int size = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Введите минимальное значение переменных в массиве");
        int mn = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Введите максимальное значение переменных в массиве");
        int mx = 1 + (Int32.Parse(Console.ReadLine()));

        int[] mas = new int[size];

        fillMass(mas, mn, mx);
        printMass(mas, "четвертого задания");

        Console.WriteLine("Для сортировки по убыванию введите 0, для сортировки по возрастанию введите 1");
        int v = Int32.Parse(Console.ReadLine());

        sortMass(mas, v);
        printMass(mas, "четвертого задания отсортированный");
    }

    static void fillMass(int[] massive, int minV, int maxV)
    {
        Random rnd = new Random();
        for (int i = 0; i < massive.Length; i++)
        {
            massive[i] = rnd.Next(minV, maxV);
        }
    }
    static void printMass(int[] massive, string line)
    {
        Console.WriteLine($"Массив {line} выглядит вот так:");
        Console.WriteLine("***********");
        Console.Write('|');
        for (int i = 0; i < massive.Length; i++)
        {
            Console.Write($"{massive[i]}|");
        }
        Console.WriteLine("");
        Console.WriteLine("***********");
    }
    // выбранный способ сортировки из изученных в первом модуле — простой выбор
    static void sortMass(int[] massive, int v)
    {
        switch (v)
        {
            case 0:
                for (int i = 0; i < massive.Length; i++)
                {
                    int a, b, mx;
                    a = massive[i];

                    for (int j = i; j < massive.Length; j++)
                    {
                        if (a < massive[j])
                        {
                            mx = massive[j];
                            massive[j] = a;
                            massive[i] = mx;
                            a = mx;
                        }
                    }
                }
                break;
            case 1:
                for (int i = 0; i < massive.Length; i++)
                {
                    int a, b, mx;
                    a = massive[i];

                    for (int j = i; j < massive.Length; j++)
                    {
                        if (a > massive[j])
                        {
                            mx = massive[j];
                            massive[j] = a;
                            massive[i] = mx;
                            a = mx;
                        }
                    }
                }
                break;
        }
    }
}