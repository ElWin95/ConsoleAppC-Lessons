namespace ConsoleAppC_Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UnsafeFixed
            //int a = 14;
            //unsafe // Bununla evvelce mohurle tesdiqlemelisen, classin propertiesinden allow unsafe tapib qus qoymalisan.
            //{
            //    int* addr = &a; // bu isare ile a deyisenin yerini gore bilirsen. Hetta bunu Main classinda da istifade etmek olar.
            //    Console.WriteLine(a);
            //    Console.WriteLine((IntPtr)addr);
            //}
            //a = 100; // a-nin deyeri deyisse de stack yaddasda yeri deyismir.
            //unsafe
            //{
            //    string name = "code";
            //    fixed (char* sAddr = name) // string-ler ucun bundan istifade olunur ve heap yaddasda yeri deyisir.
            //    {
            //        Console.WriteLine(name);
            //        Console.WriteLine((IntPtr)sAddr);
            //    }
            //}
            #endregion
            #region SizeOfMinMaxValueTypeOf
            //Console.WriteLine(sizeof(bool));
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(sizeof(short));
            //Console.WriteLine(sizeof(ushort));
            //Console.WriteLine(sizeof(long));
            //Console.WriteLine($"Min: {byte.MinValue}");
            //Console.WriteLine($"Max: {byte.MaxValue}");
            //Console.WriteLine($"Min: {long.MinValue}");
            //Console.WriteLine($"Max: {float.MaxValue}");
            //Console.WriteLine($"CTS Type Name: {typeof(int)}");
            //Console.WriteLine($"Default: {default(int)}");
            #endregion
            #region new

            #endregion
        }
    }
}