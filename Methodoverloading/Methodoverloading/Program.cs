class Program
{
    public void t1()
    {
        Console.WriteLine("1st");
    }
    public void t1(int i)
    {
        Console.WriteLine("2nd ");
    }
    public void t1(string s)
    {
        Console.WriteLine("3rd");
    }
    public void t1(int i, string s)
    {
        Console.WriteLine("4th");
    }
    static void Main(string[] args)
    {
        Program p = new Program();
        p.t1();
        p.t1(10);
        p.t1("xx");
        p.t1(10, "ss");
        
        Console.ReadLine();
    }
}

