        Console.WriteLine("ВВедите длинну массива");

        int ArrayLenght = Convert.ToInt32(Console.ReadLine());

        int[] Array = new int[ArrayLenght];

        int ArraySum = 0;

        for (int i = 0; i < ArrayLenght; i++)
        {
            Console.WriteLine("Введите число " + i + "го значения массива");
            Array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < ArrayLenght; ArrayLenght--)
        {
            Console.WriteLine(Array[ArrayLenght - 1]);

        }

        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] % 2 == 0)
            {
                ArraySum += Array[i];
            }
        }
        Console.WriteLine(ArraySum);
