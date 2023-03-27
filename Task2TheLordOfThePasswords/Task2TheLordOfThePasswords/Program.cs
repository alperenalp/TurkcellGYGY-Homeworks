PasswordChecker passwordChecker = new PasswordChecker();
bool isAgain = true;
while (isAgain)
{
    try
    {
        string password = getPasswordFromUser();
        bool isLong = passwordChecker.checkPasswordLength(password);
        if (isLong)
        {
            string passwordStrength = passwordChecker.checkPasswordStrength(password);
            Console.WriteLine($"{passwordStrength} şifre!");
        }
        else
        {
            Console.WriteLine("Şifre 6 karakterden küçük olamaz");
        }
        string runChoice = getRunChoiceFromUser();
        while (runChoice =="unknown")
        {
            runChoice = getRunChoiceFromUser();
        }
        isAgain = runChoice == "continue" ? true : false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("\nBir hatayla karşılaşıldı. \nHata nedeni:\n" + ex + "\n\nTekrar denemek için bekleyiniz...\n");
        Thread.Sleep(2000);
        isAgain = true;
    }
}

string getRunChoiceFromUser()
{
    Console.Write("\nTekrar denemek için -> 1, Çıkmak için -> 2 tuşlayınız: ");
    string runChoice = Console.ReadLine();
    Console.WriteLine();
    switch (runChoice)
    {
        case "1":
            return "continue";
        case "2":
            Console.WriteLine("Çıkılıyor...");
            Thread.Sleep(1000);
            return "break";
        default:
            Console.WriteLine("Öyle bir seçenek yok abi");
            return "unknown";
    }
}

string getPasswordFromUser()
{
    Console.Write("Şifrenizi giriniz: ");
    return Console.ReadLine();
}

public class PasswordChecker
{
    /// <summary>
    /// Şifrenin gücünü tespit eder ve şifrenin gücünü string olarak size verir.
    /// </summary>
    /// <param name="password">Güç tespti yapılması istenen şifre</param>
    /// <returns></returns>
    public string checkPasswordStrength(string password)
    {
        bool isLetter = false;
        bool isNumber = false;
        bool isNonAlphanumeric = false;
        for (int i = 0; i < password.Length; i++)
        {
            if (!isLetter)
            {
                isLetter = char.IsLetter(password[i]);
            }
            if (!isNumber)
            {
                isNumber = char.IsNumber(password[i]);
            }
            if (!isNonAlphanumeric)
            {
                isNonAlphanumeric = char.IsSymbol(password[i]) || char.IsPunctuation(password[i]);
            }
        }

        if (isNonAlphanumeric && isNumber && isLetter)
        {
            return "İYİ";
        }
        else if ((isLetter && isNumber) || (isLetter && isNonAlphanumeric) || (isNumber && isNonAlphanumeric))
        {
            return "KÖTÜ";
        }
        else
        {
            return "ÇİRKİN";
        }
    }

    /// <summary>
    /// Şifre 6 karakterden uzun mu kontrolünü yapar.
    /// </summary>
    /// <param name="password">Uzunluğun bulunması istenilen şifre</param>
    /// <returns></returns>
    public bool checkPasswordLength(string password)
    {
        bool isTooLength = true;
        if (password.Length < 6)
        {
            isTooLength = false;
        }
        return isTooLength;
    }

}
