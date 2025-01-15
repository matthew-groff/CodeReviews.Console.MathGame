var endProgram = false;

do
{
    Console.WriteLine("Select a mathematical operation to test your skills:");
    Console.WriteLine("A - Addition");
    Console.WriteLine("S - Subtraction");
    Console.WriteLine("M - Multiplication");
    Console.WriteLine("D - Division");
    Console.WriteLine("X - Exit");
    Console.Write("> ");
    
    var userSelection=Console.ReadLine();
    userSelection = userSelection.Trim().ToLower();
    
    switch (userSelection)
    {
        case "a":
            AdditionGame();
            break;
        case "s":
            SubtractionGame();
            break;
        case "m":
            MultiplicationGame();
            break;
        case "d":
            DivisionGame();
            break;
        case "x":
            Console.WriteLine("You have chosen to exit!");
            endProgram = true;
            break;
        default:
            Console.WriteLine("You selected unknown operation!");
            break;
    }
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
} while (!endProgram);

void AdditionGame()
{
    Console.Clear();
    Console.WriteLine("You selected Addition!");

    Random random = new Random();
   
    int correctAnswerCounter = 0;
    
    for (int counter = 0; counter < 5; counter++)
    {
        int number1 = random.Next(1, 10);
        int number2 = random.Next(1, 10);
        int correctAnswer = number1 + number2;
        Console.Write(@$"P. {counter + 1}/5:   {number1} + {number2} > ");

        string userAnswer = Console.ReadLine();

        
        if (Int32.TryParse(userAnswer, out int clean))
        {
            // Console.WriteLine("You entered " + userAnswer);
            // Console.WriteLine($"The correct answer is {correctAnswer}");

            if (clean == correctAnswer)
            {
                correctAnswerCounter+=1;
                Console.WriteLine($"Congratulations! You entered the correct answer! ({correctAnswerCounter}/{counter+1})");
                
            }
            else
            {
                Console.WriteLine($"You entered the incorrect answer!({correctAnswerCounter}/{counter+1})");
            }

        }
        else
        {
            Console.WriteLine("You entered an incorrect number! Here's a new problem!");
        }
       
    }
}

void SubtractionGame()
{
    Console.Clear();
    Console.WriteLine("You selected Subtraction!");
    
    Random random = new Random();
    
    int correctAnswerCounter = 0;
    
    for (int counter = 0; counter < 5; counter++)
    {
        int number1 = random.Next(1, 10);
        int number2 = random.Next(1, 10);
        int correctAnswer = number1 - number2;
        Console.Write(@$"P. {counter + 1}/5:   {number1} - {number2} > ");

        string userAnswer = Console.ReadLine();

        
        if (Int32.TryParse(userAnswer, out int clean))
        {
            // Console.WriteLine("You entered " + userAnswer);
            // Console.WriteLine($"The correct answer is {correctAnswer}");

            if (clean == correctAnswer)
            {
                correctAnswerCounter+=1;
                Console.WriteLine($"Congratulations! You entered the correct answer! ({correctAnswerCounter}/{counter+1})");
                
            }
            else
            {
                Console.WriteLine($"You entered the incorrect answer!({correctAnswerCounter}/{counter+1})");
            }

        }
        else
        {
            Console.WriteLine("You entered an incorrect number! Here's a new problem!");
        }
       
    }
    
}

void MultiplicationGame()
{
    Console.Clear();
    Console.WriteLine("You selected Multiplication!");
    
    Random random = new Random();
    
    int correctAnswerCounter = 0;
    
    for (int counter = 0; counter < 5; counter++)
    {
        int number1 = random.Next(1, 10);
        int number2 = random.Next(1, 10);
        int correctAnswer = number1 * number2;
        Console.Write(@$"P. {counter + 1}/5:   {number1} * {number2} > ");

        string userAnswer = Console.ReadLine();

        
        if (Int32.TryParse(userAnswer, out int clean))
        {
            // Console.WriteLine("You entered " + userAnswer);
            // Console.WriteLine($"The correct answer is {correctAnswer}");

            if (clean == correctAnswer)
            {
                correctAnswerCounter+=1;
                Console.WriteLine($"Congratulations! You entered the correct answer! ({correctAnswerCounter}/{counter+1})");
                
            }
            else
            {
                Console.WriteLine($"You entered the incorrect answer!({correctAnswerCounter}/{counter+1})");
            }

        }
        else
        {
            Console.WriteLine("You entered an incorrect number! Here's a new problem!");
        }
       
    }
}

void DivisionGame()
{
    Console.Clear();
    Console.WriteLine("You selected Division!"); 
    
    Random random = new Random();
    
    int correctAnswerCounter = 0;

    int counter = 0;
    
    do 
    {
        int number1 = random.Next(1, 101);
        int number2 = random.Next(1, 10); 
        
        if (number1 % number2 == 0)
        {
            int correctAnswer = number1 / number2;
            Console.Write(@$"P. {counter + 1}/5:   {number1} / {number2} > ");

            string userAnswer = Console.ReadLine();

        
            if (Int32.TryParse(userAnswer, out int clean))
            {
                // Console.WriteLine("You entered " + userAnswer);
                // Console.WriteLine($"The correct answer is {correctAnswer}");

                if (clean == correctAnswer)
                {
                    correctAnswerCounter+=1;
                    Console.WriteLine($"Congratulations! You entered the correct answer! ({correctAnswerCounter}/{counter+1})");
                
                }
                else
                {
                    Console.WriteLine($"You entered the incorrect answer!({correctAnswerCounter}/{counter+1})");
                }

            }
            else
            {
                Console.WriteLine("You entered an incorrect number! Here's a new problem!");
            }
            counter++;
        } 
    } while (counter < 5);
}