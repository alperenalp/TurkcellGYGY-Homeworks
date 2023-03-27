
while (true)
{
    try
    {
        Console.Write("Dizi uzunluğunuzu giriniz: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write($"{i + 1}.sayınızı giriniz: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        //1.döngü yöntemi
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;
        int index = 0;
        while (index < numbers.Length)
        {
            max = numbers[index] > max ? numbers[index] : max;

            if (numbers[index] < min)
            {
                min = numbers[index];
            }

            sum += numbers[index];

            index++;
        }

        double avg = (double)sum / numbers.Length;

        Console.WriteLine($"\n1.Döngü yöntemi \n" +
            $"Maksimum sayı: {max} \n" +
            $"Minumum sayı: {min} \n" +
            $"Toplam: {sum} \n" +
            $"Ortalama: {avg}");


        //2.döngü yöntemi
        min = numbers[0];
        max = numbers[0];
        sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            max = numbers[i] > max ? numbers[i] : max;

            if (numbers[i] < min)
            {
                min = numbers[i];
            }

            sum += numbers[i];
        }

        avg = (double)sum / numbers.Length;

        Console.WriteLine($"\n2.Döngü yöntemi \n" +
            $"Maksimum sayı: {max} \n" +
            $"Minumum sayı: {min} \n" +
            $"Toplam: {sum} \n" +
            $"Ortalama: {avg}");


        //3.döngü yöntemi
        min = numbers[0];
        max = numbers[0];
        sum = 0;
        foreach (int number in numbers)
        {
            max = number > max ? number : max;

            if (number < min)
            {
                min = number;
            }

            sum += number;
        }

        avg = (double)sum / numbers.Length;

        Console.WriteLine($"\n3.Döngü yöntemi \n" +
            $"Maksimum sayı: {max} \n" +
            $"Minumum sayı: {min} \n" +
            $"Toplam: {sum} \n" +
            $"Ortalama: {avg}");


        Console.WriteLine("\nÇıkmak için X işaretine basabilirsiniz tabiki :) \n");
        Thread.Sleep(2000);
        Console.WriteLine("Yo çıkmıycam diyosan yenisini gönderiyorum...\n");
        Thread.Sleep(2000);

    }
    catch (System.FormatException)
    {
        Console.WriteLine("\n!!! Lütfen bir sayı giriniz !!!\n");
        Thread.Sleep(1000);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Şu sorun ile karşılaşıldı: \n{ex.ToString()}");
    }
}

