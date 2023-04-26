using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Activity_project
{
     internal class Program
    {
        static void Main(string[] args)
        // ________________________________________________________________________________________________________________
        {    //This line clears the console window to make it ready for the new output.
            Console.Clear();

            //foreground color of the console text to green
            Console.ForegroundColor
            = ConsoleColor.Green;

            //Design stuff
            Console.WriteLine("           ______________________________________________________________");
            Console.WriteLine("          |                                                             |");
            Console.WriteLine("          |           GUN         SHOP                                  |");
            Console.WriteLine("          |_____________________________________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_|");
            Console.WriteLine("          |_______________________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__|");
            Console.WriteLine("          |_________________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶____________________|");
            Console.WriteLine("          |________________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__________________________|");
            Console.WriteLine("          |¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶____________________________|");
            Console.WriteLine("          |¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_¶_¶¶¶¶¶¶¶¶____________________________|");
            Console.WriteLine("          |¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶___¶__¶¶¶¶¶¶___________________________|");
            Console.WriteLine("          |¶¶¶¶¶¶¶¶¶¶¶¶____¶¶¶¶¶¶¶¶¶___¶¶¶¶¶¶___________________________|");
            Console.WriteLine("          |_¶¶¶¶¶¶¶¶¶______¶¶¶¶¶_______¶¶¶¶¶¶¶__________________________|");
            Console.WriteLine("          |__¶¶¶¶¶¶________¶¶¶¶¶_________¶¶¶¶¶¶¶________________________|");
            Console.WriteLine("          |___¶¶¶¶_________¶¶¶¶¶__________¶¶¶¶¶¶¶¶______________________|");
            Console.WriteLine("          |                                                             |");
            Console.WriteLine("          ______________________________________________________________");

            //the foreground color of the console text to blue.
            Console.ForegroundColor
            = ConsoleColor.Blue;

            //declare and initialize three arrays to store the product codes, names, and prices. 
            // For the list of codes
            string[] code = new string[7] { "F1", "F2", "F3", "F4", "F5", "F6","F7" };
            // For the list of names
            string[] menu = new string[7] {"Glocks 17",
                                           "Dessert eagle",
                                           "9mm pistol",
                                           ".44 Magnum",
                                           "Colt M1911",
                                           "Pistol Bullets x 20 ",
                                           "Finish transaction"};
            // For the list of price of the names
            decimal[] price = new decimal[7] { 350.00m, 450.00m, 500.00m, 455.00m, 300.00m, 5.00m, 0 };

            string[] dollar = new string[7] { "$", "$", "$", "$", "$", "$", "" };

            string strprice = "";

 // ________________________________________________________________________________________________________________
            // loop repeats the code block inside it until the user inputs "N" when asked if they want to make another transaction.
            string transact = "N";
            do
            {

                //displays the menu of products by printing each product's code, name, and price
                // Pad right use to move the position of the text hence adding whitespace
                Console.WriteLine("Code".PadRight(10) + "Menu".PadRight(30) + "Price");
                for (int i = 0; i < menu.Length; i++)
                {
                    if (price[i] > 0) { strprice = price[i].ToString(); } else { strprice = ""; }
                    Console.WriteLine(code[i].PadRight(10) + menu[i].PadRight(30) + strprice + dollar[i]);
                }

                // stores quantity array used and declares a variable to prevent errors
                string[] order_list = new string[1];
                int qty;
                string strQty;
                decimal subtotal = 0;
                string order;
                int code_index;
                int current_order_index = 0;
                decimal grand_total = 0;
                decimal amount_tendered = 0;
                decimal change = 0;
                string str_amount;

 // ________________________________________________________________________________________________________________
                // starts the loop
                Console.WriteLine();
                do
                {
                    //Start to input orders
                    Console.Write("SELECT CODE TO PURCHASE WEAPON SUPPLIES: ");
                    order = Console.ReadLine();
                    // ADD a locator of the list stuff makin this into index
                    code_index = Array.IndexOf(code, order);
                    // if anything input that cannot be found in the array by index
                    if (code_index < 0)
                    {
                        Console.WriteLine("Invalid code!!!!");
                    }
                    else
                    {
                        // if order is not F7 then continue to input
                        if (order != "F7")
                        {
                            do
                                //Add a quantity statement
                            {
                                Console.Write("Enter Qty: ");
                                strQty = Console.ReadLine();
                                // parse the strQty variable as an integer

                                if (int.TryParse(strQty, out qty) == false)
                                //int.TryParse returns false, the code will print an error 
                                {
                                    Console.WriteLine("Invalid quantity value!!!");
                                }
                            }
                            // loop continues to ask to enter a valid value. (try)
                            while (int.TryParse(strQty, out qty) == false);

                            // calculates the amount by product multiply by how many are there
                            subtotal = price[code_index] * qty;
                            grand_total = grand_total + subtotal;
                            // 
                            order_list[current_order_index] = order.PadRight(10) + menu[code_index].PadRight(30) +
                                // Prints out the price
                                price[code_index].ToString().PadRight(10) + qty.ToString().PadRight(15) + subtotal.ToString().PadLeft(15);
                            // increase the visuals from arrays to print all arrays in good format
                            Array.Resize(ref order_list, order_list.Length + 1);
                            // by 1
                            current_order_index++;
                        }
                        else
                        {
                            if (grand_total == 0)
                            {
                                // Used to terminate the program 
                                System.Environment.Exit(0);
                            }
                        }
                    }
                } 

                while (order != "F7");



                if (grand_total > 0)
                {
                    //display purchase of the user
                    // CODE, MENU, PRICE, QUANTITY, SUBTOTAL or the total of each item purchased with Quantity
                    Console.WriteLine("\nCode".PadRight(11) + "Menu".PadRight(30) + "Price".PadRight(10) + "Qty".PadRight(10) + "Sub Total".PadLeft(10));
                    for (int i = 0; i < order_list.Length; i++)
                    {
                     
                        Console.WriteLine(order_list[i]);
                    }
                    // Adding the final grand total or the total of the subtotal
                    string str_total = "Total Amount: " + grand_total.ToString("#,0.00");
                    Console.WriteLine(str_total.PadLeft(70));

                    //To accept payment and compute change
                    do
                    {
                        do
                        {
                            Console.Write("\nEnter amount tendered: ");
                            str_amount = Console.ReadLine();
                        } while (decimal.TryParse(str_amount, out amount_tendered) == false);

                        if (Convert.ToDecimal(str_amount) < grand_total)
                        {
                            Console.WriteLine("Amount tendered must be greater than the total amount...");
                        }


                    } while (Convert.ToDecimal(str_amount) < grand_total);
                    // subtract the amount of money
                    change = amount_tendered - grand_total;
                    Console.WriteLine("Change: ".PadRight(24) + change.ToString("#,0.00"));
                }


                // To create another another trasaction

                do
                {
                    Console.Write("\nAnother trasaction:(Y/N): ");
                    transact = Console.ReadLine().ToUpper();
                } while (transact != "Y" && transact != "N");

            // if the user pick N then the program is terminated

            } while (transact != "N");
            Console.WriteLine("THANK YOU FOR COMING");


            Console.ReadKey();
        }
    }
}