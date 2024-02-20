namespace problema_de_fisica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            densidad deresult=new densidad();
            Console.WriteLine("por favor coloca los kilogramos");
            deresult.kilos = double.Parse(Console.ReadLine());
            Console.WriteLine("coloca los metros3");
            deresult.metros3 = double.Parse(Console.ReadLine());
            deresult.resultado(deresult.kilos,deresult.metros3);
            Console.WriteLine("densidad =" + deresult.kilos / deresult.metros3);
            Console.ReadLine();
        }
    }
}