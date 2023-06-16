namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new car();
            myCar.Make = "Ford";
            myCar.Model = "Taurus";
            myCar.Year = "2013";
            var mazda = new car()
            {
                Make = "mazda" ,
                Model="cx-5",
                Year="2010",

            };
            var chevy = new car("chevy", "malibu", 2015);
            var carlist = new List<car>() { myCar, chevy,mazda,new car() };
           foreach(var vehicule in carlist)
            {
                Console.WriteLine( $" {vehicule.Make}    {vehicule.Model}  {   vehicule.Year}");
            }
        }
    }

   
}
