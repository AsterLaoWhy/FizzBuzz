Console.WriteLine("Starting the fizzbuzz challenge");
Random rnd = new Random();
int randomNumber = rnd.Next();
int GetUserNumber()
{
    Console.WriteLine("Please type a number using arabic numbers\n");
    var userNumber = Console.ReadLine();
    int num = -1;
    while (!int.TryParse(userNumber, out num))
    {
        Console.WriteLine("Please type a number using arabic numbers\n");
        userNumber = Console.ReadLine();
    }
    return Convert.ToInt32(userNumber);
}
string FizzBuzz(int randomNumber) 
{
    if (randomNumber % 15 == 0)
    {
        Console.WriteLine("fizzbuzz");
        return "fizzbuzz";
    }
    if (randomNumber % 5 == 0) 
    {
        Console.WriteLine("buzz");
        return "buzz";
    }
    if (randomNumber % 3 == 0) 
    {
        Console.WriteLine("fizz");
        return "fizz";
    }
    return "Number is not divisible by three or five";
}
FizzBuzz(randomNumber);
int userNumber = GetUserNumber();
FizzBuzz(userNumber);
//Now, for a user generated number

