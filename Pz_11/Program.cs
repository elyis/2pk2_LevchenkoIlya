using System;

namespace Pz_11
{
    class Test
    {
        public Test(double val) => this.val = val;
        public double val;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test val = new Test(12.45);
            Console.WriteLine(val.val);
            string str;

            unsafe
            {
                fixed (void* ptrs = &val.val)
                {
                    char* ptr = (char*)ptrs;
                    *ptr = 'w';
                    *(ptr + 1) = 'o';
                    *(ptr + 2) = 'r';
                    *(ptr + 3) = 'd';
                    for (int i = 0; i < 4; i++)
                        Console.Write(*(ptr + i));
                    Console.WriteLine();
                    str = new String(ptr);
                    Console.WriteLine(str);
                }
            }
            Console.WriteLine(val.val);
            /*получаю прямой доступ к double val через указатель (ссылку), тип char = 2 байта, а double = 8
              поэтому к начальной позиции прибавляется 2 * номер символа и изменяются биты double - ла
            */
        }
    }
}