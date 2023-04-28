using System.Text.RegularExpressions;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string pattern = new string(@"(?=\S*\d\S*\d\S*\d)[\S\d]{9,}");
        Regex regex = new Regex(pattern);

        while (true)
        {
            Console.WriteLine("придумайте пароль:");
            var isValid = regex.IsMatch(Console.ReadLine());

            if (isValid)
            {
                Console.Clear();
                Console.WriteLine("пароль прийнято!");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("невірний формат пароля!\n(пароль має складатися мінімум з 9 символів та 3 цифр)\n");
            }
        }
    }
}