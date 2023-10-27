Console.WriteLine("Введите строку для проверки:");
string str = Console.ReadLine();

bool isValidHexadecimalNumber = true;

if (string.IsNullOrWhiteSpace(str))
{
    isValidHexadecimalNumber = false;
}
else
{
    // Удалите возможные префиксы "0x" или "0X"
    if (str.StartsWith("0x") || str.StartsWith("0X"))
    {
        str = str.Substring(2);
    }

    foreach (char digit in str)
    {
        if (!IsHexadecimalDigit(digit))
        {
            isValidHexadecimalNumber = false;
            break;
        }
    }
}

if (isValidHexadecimalNumber)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
    }

    // Функция для проверки, является ли символ шестнадцатеричной цифрой (0-9, A-F, a-f)
    static bool IsHexadecimalDigit(char digit)
{
    return (digit >= '0' && digit <= '9') ||
           (digit >= 'A' && digit <= 'F') ||
           (digit >= 'a' && digit <= 'f');