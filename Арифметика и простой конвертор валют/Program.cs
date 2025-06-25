        Console.WriteLine("Введите первое число");
        string a1 = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string b1 = Console.ReadLine();
        double a2 = Convert.ToDouble(a1);
        double b2 = Convert.ToDouble(b1);
        Console.WriteLine("Среднее арифмитическое =" + (a2 + b2) / 2);


        Console.WriteLine("Введите первое число");
        string z1 = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string x1 = Console.ReadLine();
        Console.WriteLine("ВВедите третье число");
        string c1 = Console.ReadLine();
        int z2 = Convert.ToInt32(z1);
        int x2 = Convert.ToInt32(x1);
        int c2 = Convert.ToInt32(c1);
        Console.WriteLine("Сумма чисел =" + (z2 + x2 + c2));
        Console.WriteLine("произведение чисел =" + (z2 * x2 * c2));


        Console.WriteLine("Сколько хотите обменять белоруских рублей?");
        string q = Console.ReadLine();
        Console.WriteLine("Сумма составит");
        int q1 = Convert.ToInt32(q);
        Console.WriteLine("euro =" + (q1 * 0.2928));
        Console.WriteLine("usd =" + (q1 * 0.3139));
        Console.WriteLine("rub =" + (q1 * 27.7391));

