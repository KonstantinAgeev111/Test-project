
class Program
{
    static void Main()
    {
          
        string a = Console.ReadLine();
        
        double firstfigure = Convert.ToDouble(a);

        string b = Console.ReadLine();

        double secondfigure = Convert.ToDouble(b);

        string c = Console.ReadLine();

        double thirdfigure = Convert.ToDouble(c);

        double sum = firstfigure + secondfigure + thirdfigure;

        Console.WriteLine(sum); 

    }
}