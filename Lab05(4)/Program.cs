using Lab05_4_;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] customersInput = Console.ReadLine().Split(";");
        Dictionary<String, Person> customers = new Dictionary<String, Person>();
        try
        {
            string[] customerParams;
            Person person;
            if (customersInput.Length > 1)
            {
                for (int i = 0; i < customersInput.Length; i++)
                {
                    customerParams = customersInput[i].Split("=");
                    person = new Person(customerParams[0], int.Parse(customerParams[1]));
                    customers.Add(customerParams[0], person);
                }
            }
            else
            {
                customerParams = customersInput[0].Split("=");
                person = new Person(customerParams[0], int.Parse(customerParams[1]));
                customers.Add(customerParams[0], person);
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
            Environment.Exit(0);
        }

        string[] productInput = Console.ReadLine().Split(";");
        Dictionary<String, Product> products = new Dictionary<string, Product>();
        try
        {
            string[] productParams;
            Product product;
            if (productInput.Length > 1)
            {
                for (int i = 0; i < productInput.Length; i++)
                {
                    productParams = productInput[i].Split("=");
                    product = new Product(productParams[0], int.Parse(productParams[1]));
                    products.Add(productParams[0], product);
                }
            }
            else
            {
                productParams = productInput[0].Split("=");
                product = new Product(productParams[0], int.Parse(productParams[1]));
                products.Add(productParams[0], product);
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
            Environment.Exit(0);
        }

        string purchase = "";
        try
        {
            while (!(purchase = Console.ReadLine()).Equals("END"))
            {
                string[] input = purchase.Split(" ");
                if(customers[input[0]].AddProduct(products[input[1]]))
                {
                    Console.WriteLine("{0} bought {1}", input[0], input[1]);
                } else
                {
                    Console.WriteLine("{0} can't afford {1}", input[0], input[1]);
                }                
            }
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Invalid input");
        }

        foreach(KeyValuePair<string, Person> customer in customers)
        {
            Console.WriteLine(customer.Value.ToString());
        }
    }
}