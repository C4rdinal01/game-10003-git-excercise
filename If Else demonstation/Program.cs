Console.WriteLine("Is this your first time using If/Else Coding?");

String UserInput = (Console.ReadLine());

if (UserInput == "Yes")
{
    Console.WriteLine("Welocme to the demonstration!");
}
else if (UserInput == "No")
{
    Console.WriteLine("Well then what are you doing here?");
}
else
{
    Console.WriteLine("Its a Yes or No question fool.");
}

// you don't need to follow up statements starting with [if], [else if], or else with a semicolon (;)