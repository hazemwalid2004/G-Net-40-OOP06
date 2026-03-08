namespace assOOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Q1_part1
            // What is abstraction in OOP?
            //the process of exposing only what the user needs and hiding how it is implemented
            // How is it different from encapsulation?
            //abstraction-> what an object does / how fields is protected 
            // Give a real-world example (not from the session) that shows the difference between the two.
            //make a coffee/ i don't care how the coffee made press the button to make a coffee
            #endregion
            #region Q2_Part1
            // What is the difference between an abstract class and an interface? Give at least four differences.
            //abstract class -> has an constractor \ has a fields \ has an implemented method \ can use all access modifiers 
            // interface - > don't has a constractor \ access modifier in Methods public\ class can implement multiple interfaces\contains only abstract methods
            // When would you choose one over the other?
            // interface -> when we make 100% abstract / abstract class -> when we want make partial abstract
            #endregion
            #region Q3_Part1
            //a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
            // no becouse we can't make object from abstract class
            //b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()? Why did the designer make each one abstract, virtual, or concrete?
            //PowerConsumption() -> this is an abstract method \ Status() - > this is a virtual method \ Label() -> this is  concrete method 
            // becouse abstract ->  power consumption is calculated differs for each device / virtual - >most devices may use the default status behavior but some of the devices override this method/ concrete-> labeling is the same for all devices
            //c) If you call Status() on a Toaster object, what will it return? Why?
            // Standby because the toaster inhert from appliance so the status inhert to in the toaster
            #endregion
            #region Q4_Part1
            //a) What is a partial class? Why would a developer split Calculator into two files?
            // split a single class definition across multiple files adn the compiler merges them into one class/ to Team collaboration and Organize large classes
            //b) What is a partial method? What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile? Why?
            //declare in one part of a partial class and optionally implemented in another part/the compiler skip it and continue the work 
            //c) What is an extension method? What are the three rules for writing one?
            //add new methods to an existing type without modifying its source code/1-static class 2-static method 3- use this in first parameter 
            //d) What will the following code print?
            //$20.00
            #endregion
            #region Part2
            Cinema cinema = new Cinema();
            cinema.OpenCinema();
            //Ticket t = new Ticket("Test", 100);
            Ticket[] ticket = { new StandardTicket("Inception", 80.00m, "A5"), new VIPTicket("Avengers", 200.00m, true),
            new IMAXTicket("Dune", 130.00m, false)};
            foreach (Ticket t in ticket)
            {
                t.book();
                cinema.AddTicket(t);  
            }
            cinema.Print();
            Console.WriteLine("--- Polymorphism: Final Price per Ticket ---");
            foreach (Ticket t in ticket)
            {
                
                Console.WriteLine($"{t.GetType().Name} => Final Price = {t.PriceAfterTax()}");
            }
            ticket[1].receipt();
            ticket.TotalRevenue();
            cinema.CloseCinema();
            #endregion
        }
    }
}
