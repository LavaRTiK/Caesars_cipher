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


            //test while 
            //List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9,10};
            //Console.WriteLine("--------");
            //Console.WriteLine(list[10%list.Count]);
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            var bigalph = Enumerable.Range('A', 26);
            var smallalph = Enumerable.Range('a', 26);

            foreach(var i in text)
            {
                if(i >= 65 && i <= 91)
                {
                    code += Convert.ToChar(bigalph.ToArray()[((bigalph.ToList().FindIndex(x => x == i)+move % bigalph.Count()) + bigalph.Count()) % bigalph.Count()]);
                }
                else if (i >= 97 && i <=122)
                {
                    code += Convert.ToChar(smallalph.ToArray()[((smallalph.ToList().FindIndex(x=> x==i)+move % smallalph.Count()) + smallalph.Count()) % smallalph.Count()]);
                }
                else
                {
                    code += i;
                }

                //code +=Convert.ToChar(alph.ToArray()[(alph.ToList().FindIndex(x => x == i)+move)%alph.ToArray().Length]);
            }
            Console.WriteLine(code);

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] > 91)
            //    {
            //        code = code + Convert.ToChar(text[i] + move > 122 ? text[i] - 26 + move : text[i] + move);
            //    }
            //    else
            //    {
            //        code = code + Convert.ToChar(text[i] + move > 90 ? text[i] - 26 + move : text[i] + move);
            //    }
            //}



            //for (int i = 0; i < text.Length; i++)
            //{
            //    code = code + Convert.ToChar(text[i] + move > 90 ? text[i] - 26 + move : text[i] + move);
            //}
            //Console.WriteLine(code);
        }
    }
}
