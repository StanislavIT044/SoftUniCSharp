namespace Telephony
{
    using System.Text;

    public class Smartphone : ISmartphone
    {
        private string[] numbers;
        private string[] urls;
        public Smartphone(string[] numbers, string[] urls)
        {
            this.numbers = numbers;
            this.urls = urls;
        }

        public string Browsing(string[] urls)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < urls.Length; i++)
            {
                bool isContainesDigits = true;

                for (int j = 0; j < urls[i].Length; j++)
                {
                    char symbol = urls[i][j];

                    if (char.IsDigit(symbol))
                    {
                        isContainesDigits = false;
                        break;
                    }
                }

                if (!isContainesDigits)
                {

                    sb.AppendLine("Invalid URL!");
                }
                else
                {
                    sb.AppendLine($"Browsing: {urls[i]}!");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string Calling(string[] numbers)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool areOnlyNumbers = true;

                for (int j = 0; j < numbers[i].Length; j++)
                {
                    char symbol = numbers[i][j];

                    if (!char.IsDigit(symbol))
                    {
                        areOnlyNumbers = false;
                        break;
                    }
                }

                if (areOnlyNumbers)
                {
                    sb.AppendLine($"Calling... {numbers[i]}");
                }
                else
                {
                    sb.AppendLine("Invalid number!");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
