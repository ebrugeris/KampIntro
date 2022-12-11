namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string> dictionary = new Dictionary<string>();
            dictionary.Add("table");
            dictionary.Add("desk");

            foreach (var item in dictionary.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}