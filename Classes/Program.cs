namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Taurus";
            myCar.Year = "2013";
            var mazda = new Car()
            {
                Make = "mazda" ,
                Model="cx-5",
                Year="2010",

            };
            var chevy = new Car("chevy", "malibu", 2015);
            var carlist = new List<Car>() { myCar, chevy,mazda,new Car() };
           foreach(var vehicule in carlist)
            {
                Console.WriteLine( $" {vehicule.Make}    {vehicule.Model}  {   vehicule.Year}");
            }
        }
    }

   
}
