namespace TestProject
{
    class First
    {
        int x = 10;     //x is a non-static field which cannot be accessed by static method directly. It can be only be accessed by creating an instance of the class.
        static void Main(string[] args)
        {
            First f1 = new First();  //f1 is instance of First class

            First f2;                //f2 is variable of First class
            f2 = new First();
            Console.WriteLine(f2.x);

            First f3 = f1;           //f3 is reference of class First
            Console.WriteLine(f1.x+" "+f3.x);

            f1.x = 20;
            Console.WriteLine(f1.x + " " + f3.x);

            f3.x = 30;
            Console.WriteLine(f1.x + " " + f3.x);


           

                            
            

            System.Console.WriteLine("Hello World!");
        }
    }
}