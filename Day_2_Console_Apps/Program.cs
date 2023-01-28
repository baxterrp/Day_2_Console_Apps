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

            // character char
            char character = 'A';

            // integer array
            //0, 1, 2, 3, 4, 5 doesnt exist
            int[] ages = new int[] { 98, 2, 3, 4, 5 };
            Console.WriteLine(ages[0]);
            ages[0] = 100;
            Console.WriteLine(ages[0]);
            //Console.WriteLine(ages[5]);
            //ages[5] = 100;

            int[] secondArray = new int[5];
            Console.WriteLine("****** second array *****");
            Console.WriteLine(secondArray[0]);
            secondArray[0] = 1000;
            secondArray[1] = 2000;
            secondArray[2] = 3000;
            secondArray[3] = 4000;
            secondArray[4] = 5000;
            Console.WriteLine(secondArray[0]);
            Console.WriteLine("****** second array *****");
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

            #region loops
            var people = new string[]
            {
                // 0       1      2       3            4     // 5
                "Robert", "Tom", "Boggs", "Cortney", "Ryan", "Sean"
            };

            // i j k 

            // adds 1 to i and assigns value to i
            // i = i + 1
            // i += 1
            // i++
            for (var i = 0; i < people.Length; i++)
            {
                // i = 0
                // print people[0] "Robert"
                // i++ which makes i = 1
                Console.WriteLine(people[i]);
            }

            var numbers = new int[] { 4, 5, 21, 4, 5, 9 };
            var sumOfArray = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                sumOfArray += numbers[i];
            }

            Console.WriteLine(sumOfArray);
            // FOR LOOP
            //for(var i = 1; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //var index = 0;
            //while (index < 10)
            //{
            //    Console.WriteLine("testing the while loop" + index);
            //    index++;
            //}

            var isRobert = true;
            var person = "garbage";

            // WHILE LOOP
            // might not run if condition is false
            while (!isRobert)
            {
                Console.WriteLine("Enter a name");
                person = Console.ReadLine();

                isRobert = person == "Robert";

                if (isRobert)
                {
                    Console.WriteLine("Hi Robert");
                }
                else
                {
                    Console.WriteLine("You're not Robert");
                }
            }

            // DO WHILE LOOP
            // always runs at least once
            //do
            //{
            //    // stuff here
            //    Console.WriteLine("Enter a name");
            //    person = Console.ReadLine();

            //} while (person != "Robert");

            // FOREACH LOOP
            Console.WriteLine("************* FOREACH LOOP *************");
            foreach (var dude in people)
            {
                Console.WriteLine(dude);

                if (dude == "Boggs")
                {
                    break;
                }
            }

            //var wasAbleToParse = false;

            //do
            //{
            //    int intInput;
            //    var input = "";

            //    Console.WriteLine("Enter a number");
            //    input = Console.ReadLine();
            //    wasAbleToParse = int.TryParse(input, out intInput);
            //    //intInput = int.Parse(input);
            //    if (wasAbleToParse == true)
            //    {
            //        if (intInput >= 21)
            //        {
            //            Console.WriteLine("Have a drink");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Go to school");
            //        }
            //    }
            //    else
            //    {
            //        // string concatenation
            //        Console.WriteLine(input + " is not a valid integer! with the concatenation");

            //        // string interpolation
            //        Console.WriteLine($"{input} is not valid integer with interpolation");

            //        Console.WriteLine("Try again.");
            //    }
            //} while (wasAbleToParse == false);

            #endregion

            for(var i = 2; i <= 100 ; i += 2 )
            {
                Console.WriteLine(i);
            }
        }
    }
}