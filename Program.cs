using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentfiliz3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your ID, Please");
            string id = Console.ReadLine();

           
            string[] IDs = { "21367499999", "21367488888", "21367477777", "21367466666", "21367455555", "21367444444", "21367433333" };
            string[] usernames = { "Filiz Kırkan", "Fidan Kırkan", "Özlem Kırkan", "Ceren Kırkan", "Burak Kırkan", "Başak Kırkan", "Nur Kırkan" };


            for (int i = 0; i < IDs.Length; i++)
            {
                if (id == IDs[i])
                {
                    Console.WriteLine("Login Successful! Welcome " + usernames[i]);
                    break;
                }
                else
                {

                    Console.WriteLine("User not found!");
                    Console.WriteLine("----Sign Up, Please----");
                    Console.WriteLine("Enter Your Username");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter Your ID");
                    string id1 = Console.ReadLine();

                    Console.WriteLine("Enter Your GSM");
                    string gsm = Console.ReadLine();

                    Console.WriteLine("Enter Your Email Address");
                    string email = Console.ReadLine();

                    Console.WriteLine("Login Successful");
                    break;

                }
            }





            #region Shopping 


            string[] products = { "Tomato", "Eggplant", "Onion", "Egg  ", "Bread", "Milk  ", "Toothpaste" };
            string[] units = { "kg", "kg", "kg", "piece", "loaf", "bottle", "tube" };
            double[] prices = { 21.60, 17.90, 12.40, 2.5, 8, 15.45, 33.25 }; //TAX incl. prices

            Console.WriteLine("You can see the product list below.");
            
            Console.WriteLine("----Product List---- ");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {products[i]}\t{prices[i]} TL");

            }

            string option = "y"; // 'yes' for continuing option.
            double total = 0;

            while (option == "y")
            {

                Console.WriteLine("----Enter The Product Numbers, Please----");
                int productnum = Convert.ToInt32(Console.ReadLine());
                
   
                Console.WriteLine($"How many {units[productnum - 1]} of { products[productnum - 1]}  ?");
                int unit = Convert.ToInt32(Console.ReadLine());
                total += prices[productnum - 1] * unit;

                Console.WriteLine("Do you want to continue ? Y/N?");
                option = Console.ReadLine();



            }

            Console.WriteLine("Thank You :)");
            Console.WriteLine($"SUB TOTAL = {total * 0.82} TL");
            Console.WriteLine($"TAX = {total * 0.18} TL");
            Console.WriteLine($"TOTAL = {total} TL");




            #endregion

        }
    }
}
