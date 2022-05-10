using System;

namespace value_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b = 5;
            sbyte s = 5;

            short s2 = 5;
            ushort s3 = 5;

            int s4 = 5;
            Int16 i16 = 5;
            Int32 i32 = 5;
            Int64 i64 = 5;

            uint ui = 5;
            UInt16 ui16 = 5;
            UInt32 ui32 = 5;
            UInt64 ui64 = 5;

            long l = 5;
            ulong r = 5;

            float f = 5;
            decimal d = 5;
            Double d2 = 5;

            char c = 'a';
            string str = "deger";

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.ToShortDateString());

            Console.WriteLine(b+s+s2+s3);
            Console.ReadLine();
        }
    }
}
