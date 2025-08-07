using System:

public class Program
{
    public class Customer
    {
        public string Name { get; set; }
        private string Address { get; set; }

    }
    public class Restaurant
    {
        public string RestaurantName { get; set; }

    }
    public class Order
    {

    }



    public static void Main()
    {
        List<Customer> CustomerList = new List<Customer>();

        List<Restaurant> RestaurantList = new List<Restaurant>();

        while (true)
        {
            int UserRole = 0;



            Console.WriteLine("Welcome to Grabberoo food delivery");
            Console.WriteLine("1. Use as Customer");
            Console.WriteLine("2. Use as Restaurant owner");
            Console.Write("Your choice:");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Your name:");
                string? name = Console.ReadLine();

                foreach (Customer customer in CustomerList)
                {
                    if (customer.Name == name)
                    {
                        Console.WriteLine($"Welcome {name}");
                        UserRole = 1;
                        while (true)
                        {
                            //choice 1, View All order
                            //choice 2, Search restaurant
                            //choice 3, log out using break
                            //display list of restaurant available
                            //Let the user choose one restaurant
                            //Display all the food item or menu
                            //let user choose 
                        }
                    }
                    else
                    {

                    }
                }
            }
            else if (option == 2)
            {
                Console.Write("Your restaurant name:");
                string? name = Console.ReadLine();

                foreach (Restaurant restaurant in RestaurantList)
                {
                    if (restaurant.RestaurantName == name)
                    {
                        Console.WriteLine($"Welcome ");
                        UserRole = 2;
                        while (true)
                        {

                        }
                    }
                    else
                    {

                    }

                }
            }
            else
            {

            }




        }



    }
    static void Start()
    {


    }
}
