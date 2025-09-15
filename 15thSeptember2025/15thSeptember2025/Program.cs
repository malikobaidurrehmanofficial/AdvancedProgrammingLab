using System.Runtime.CompilerServices;

namespace YourNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var res = calculate(5, 7);
            //Console.WriteLine(res);


            //c# typle is type by value not type by refrence a practicle demonstration
            //    var tuple1 = (1, 2, "string");
            //    var tuple2 = tuple1;
            //    tuple2.Item3 = "monkey";
            //    Console.WriteLine(tuple1.Item3);
            //    Console.WriteLine(tuple2.Item3);


            int[] array1 = new int[5];


            //Array in c# can not be assainged partially
            //    if size is 5 we can not assign 4 values 
            //    we must assign 5 values 
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };


            var b=new int[5];


            //c# array collection expression

            //Array is Fixed size wheareas array collection expression can be of dynamic size
            int[] a = new int[5];

            a = [2, 3, 4];
            Console.WriteLine(a.Length);

            //a[9] = 66;
            //Console.WriteLine(a[9]);
            //Console.WriteLine(a[65]);
            //Console.WriteLine(a[67]);



        }








        //public static (int, int) calculate(int a, int b)
        //{

        //    return (a + b, a - b);
        //}
    }
}
