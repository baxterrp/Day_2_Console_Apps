namespace Day_2_Console_Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CTRL K D to format document
            // CTRL X to cut entire line
            // CTRL S save
            // ALT up or down arrow to move lines
            // shift arrows to highlight
            // CTRL arrows to move one word at a time
            Console.Write("test");
            Console.Write("test 2");
            
            #region variables
            // concatenation
            Console.WriteLine("Hello, Tom!" + " and Boggs");

            // declare a variable
            string name;

            // initialize a variable or assign a value to a variable
            name = "some value";

            // do it all at once
            string other = "some other value";
            Console.WriteLine(name + " and another thing");

            // integer whole numbers
            int exampleInteger = 1000000000;
            long exampleLong = 1000000000000000000;

            // floating point variables
            double exampleDouble = 1.199789897;
            float exampleFloat = 11304234.00234f;
            decimal exampleDecimal = 1.1m;

            // true/false is called boolean
            bool exampleBool = false;
            #endregion

            #region operators
            // operators + - / * %
            var test = false;
            var a = 1;
            var b = 2;
            var sum = a + b;
            var difference = a - b;
            var divide = a / b;
            var multipy = a * b;

            Console.WriteLine("Modulus:");
            Console.Write(4 % 3); // 4 % 3 = 1
            // modulus returns the remainder
            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(divide);
            Console.WriteLine(multipy);
            #endregion

            #region conditionals
            var isSaturday = true;
            var dayOfWeek = "Saturday";
            //var dayOfWeek = "Sunday";

            // equals
            if (dayOfWeek == "Saturday")
            {
                Console.WriteLine("its saturday!");
            }

            // not equals
            if (dayOfWeek != "Saturday")
            {
                Console.WriteLine("its not saturday");
            }

            // equals == 
            // not equals != 
            // AND && both ahve to be true
            // OR || one can be true
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                Console.WriteLine("Its the weekend");
            }

            var age = 21;
            // >= greater than or equal to
            // <= less than or equal to
            // == equals
            // != not equals
            // < less than
            // > greater than
            // && and
            // || or
            if (age >= 21 && dayOfWeek == "Saturday")
            {
                Console.WriteLine("You can drink");
            }
            else if (age >= 21 && dayOfWeek == "Sunday")
            {
                Console.WriteLine("You can drink after 11am");
            }
            else // catch all
            {
                Console.WriteLine("You cant drink");
            }

            //if(age < 17)
            //{
            //    Console.WriteLine("You cant vote yet");
            //}

            // switch
            age = 18;
            switch (age)
            {
                case 18:
                    {
                        Console.WriteLine("You can vote but you can't drink");
                        break;
                    }
                case 21:
                    {
                        Console.WriteLine("You can drink");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You can't drink");
                        break;
                    }
            }

            #endregion
        }
    }
}