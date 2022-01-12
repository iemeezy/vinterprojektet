using System;
using System.Threading;

Thread.Sleep(millisecondsTimeout: 1000);

Console.Title = "lets go for a walk";
Console.ForegroundColor = ConsoleColor.Cyan;

//introduction
Console.WriteLine("whats your name?");
string username = Console.ReadLine();
Console.WriteLine("Greetings " + username + ", pleasure to meet you.");
// Thread.Sleep(millisecondsTimeout: 1000);
Console.WriteLine($"You look quite tired {username}. Would you like a cup of coffee?");


//drink coffee route
string answer = Console.ReadLine();
if (answer == "yes")
{
    Console.WriteLine("Great! here you go " + username);
    // Thread.Sleep(millisecondsTimeout: 2000);
    Console.WriteLine("...");
    // Thread.Sleep(millisecondsTimeout: 3000);
    Console.WriteLine("is it good?");
    string coffeegood = Console.ReadLine();

    //death - coffee not good
    if (coffeegood == "no")
    {
        Console.WriteLine("you start suffocating on your coffee.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("it burns your throat and insides.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("bad ending unlocked!");
    }

    //coffee good
    else if (coffeegood == "yes")
    {
        Console.WriteLine("I am glad you enjoyed it.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("lets head out, " + username);
        // Thread.Sleep(millisecondsTimeout: 3000);
        Console.WriteLine("you head out to the woods for a late night stroll.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("youre full of energy from your coffee.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("its getting dark, its harder to navigate.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("theres a glowing light in the distance, do you want to go there?");
        // Thread.Sleep(millisecondsTimeout: 2000);

    }
}

//dont drink coffee route
else if (answer == "no")
{
    Console.WriteLine("No?... As you will. Time for your daily walk! Lets head out.");
    // Thread.Sleep(millisecondsTimeout: 2000);
    Console.WriteLine("you head out to the woods for a late night stroll.");
    // Thread.Sleep(millisecondsTimeout: 2000);
    Console.WriteLine("youre tired.");
    // Thread.Sleep(millisecondsTimeout: 2000);
    Console.WriteLine("its getting harder to navigate.");
    // Thread.Sleep(millisecondsTimeout: 2000);
    Console.WriteLine("you find yourself lost in the woods.");
    // Thread.Sleep(millisecondsTimeout: 2000);
    Console.WriteLine("theres a dim light farther away. lets head there.");
    // Thread.Sleep(millisecondsTimeout: 2000);
    Console.WriteLine("you arrive at a cabin. its unlocked. do you want to enter the cabin?");

    //enter cabin route
    string cabingo = Console.ReadLine();
    if (cabingo == "yes")
    {
        Console.WriteLine("you head into the cabin.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("no one is home.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("you pass out on a soft and warm bed.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("youre awake. its bright out.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("the smell of freshly baked bread fills the room. just now you realise how hungry you are.");
        // Thread.Sleep(millisecondsTimeout: 2000);
        Console.WriteLine("eat bread and soup?");

        string eatbread = Console.ReadLine();


    }
    //dont enter cabin route
    // else if (cabingo == "no")

}

Console.ReadKey();



