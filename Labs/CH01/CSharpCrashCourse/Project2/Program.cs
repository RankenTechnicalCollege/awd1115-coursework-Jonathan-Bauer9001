//Loops - make your program POWERFUL - Write small amount of code, that does something repetively 
//and makes your program DO a lot of work

//Count Controlled Loop
//PreTest loop - The condition is tested before the body executes the first iteration of the loop

//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine($"THe current value of i is {i}");
//}

////while loop 
//int j = 0;

//while ( j <= 10)
//{
//    Console.WriteLine($"The current value of j is {j}");
//    j+=2;
//}

////do while loop
////Post-Test loop

//int e = 100;

//do
//{
//    Console.WriteLine($"The current value of e is {e}");
//}while (e <= 10);

//Conditionals - Make your program SMART - Humans make decisions baserd based on conditions
//Conditionals allow our software to do the same thing.

//int testScore = 90;

//if(testScore >= 90)
//{
//    Console.WriteLine("You got an A");
//}
//else if (testScore >= 80)
//{
//    Console.WriteLine("You got a B");
//}
//else if (testScore >= 70)
//{
//    Console.WriteLine("You got a C");
//}
//else if (testScore >= 60)
//{
//    Console.WriteLine("You got a D");
//}
//else
//{
//    Console.WriteLine("You got a F");
//}

//int age = 40;

//switch (age)
//{
//    case > 10 :
//        Console.WriteLine("You are an infant");
//        break;
//    case 2:
//        Console.WriteLine("you are a toddler");
//        break;
//    case 3:
//        Console.WriteLine("You are a young child");
//        break;
//    default:
//        Console.WriteLine("I don't know how old you are");
//        break;
//}
//int age = 400;

//if (age < 50)
//{
//    Console.WriteLine("You're not over the hill!");
//}
//else
//{
//    Console.WriteLine("You are over the hill!");
//}

Console.WriteLine("What is the upper limit of our Fizz Buzz?");
int upperLimit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i < upperLimit; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }else if(i % 3 == 0 )
    {
        Console.WriteLine("Fizz");
    }else if(i % 5 == 0 )
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}

//Conditional Operator
//Short Hand for if-else


//int i = 100;

//string result = i < 200 ? "i less than 200" : "i greater or equal to 200";