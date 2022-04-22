using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz : ");
            try
            {
                int sayı = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı = " + sayı);
            }

            catch (FormatException e)
            {
                Console.WriteLine("Hata : " + e.Message);
            }

            //finally
            //{
            //    Console.WriteLine("Program Sonlandı !");
            //}

            try
            {
                int a = int.Parse(null);
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Bir hata meydana geldi !");
                Console.WriteLine("Hata : " + ex.Message.ToString());
            }

            finally { Console.WriteLine("Program sonlandı !"); }
            Console.ReadLine();
        }
    }
}
