namespace Get_Set
{
    class Person
    {
        
        public string name //property
        {
            get;set;
            
        }
        
    }
    class Program
    {
            static void Main(string[] args)
            {
                Person myObj = new Person();
                myObj.name = "Swetha";
                Console.WriteLine(myObj.name);
                Console.ReadLine();

            }

    }
}
