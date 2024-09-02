namespace Caesars_cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedit text");
            string text = Console.ReadLine();
            Console.WriteLine("vedit zsuv");
            int move = Convert.ToInt32(Console.ReadLine());
            string code = "";
            //char d = Convert.ToChar(text[0]);
            //Console.WriteLine(d);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 91)
                {
                    code = code + Convert.ToChar(text[i] + move > 122 ? text[i] - 26 + move : text[i] + move);
                }
                else
                {
                    code = code + Convert.ToChar(text[i] + move > 90 ? text[i] - 26 + move : text[i] + move);
                }
            }



            //for (int i = 0; i < text.Length; i++)
            //{
            //    code = code + Convert.ToChar(text[i] + move > 90 ? text[i] - 26 + move : text[i] + move);
            //}
            Console.WriteLine(code);
        }
    }
}
