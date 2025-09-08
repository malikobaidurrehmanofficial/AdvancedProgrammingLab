namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "             my       name is malik          Obaid ur rehman    Obaid               ";


            //Console.WriteLine(msg.Length);

            //Console.WriteLine(msg.ToUpper());
            //Console.WriteLine(msg.ToLower());

            //Console.WriteLine(msg.Trim());

            //Console.WriteLine(msg.Substring(3));
            //Console.WriteLine(msg.Substring(3,15));


            //Console.WriteLine(msg.IndexOf("Obaid"));
            //Console.WriteLine(msg.LastIndexOf("Obaid"));

            //Console.WriteLine((msg.Replace("Obaid", "bedi")));
            //Console.WriteLine(msg.Remove(1,5));


            //Console.WriteLine(msg.Insert(5,"hellow world "));

            string msg2 = "banana,apple,kenu,kela,saaib";

            string[] msg3 = msg2.Split('a');
            Console.WriteLine(msg3[0]);
         

        }
    }
}
