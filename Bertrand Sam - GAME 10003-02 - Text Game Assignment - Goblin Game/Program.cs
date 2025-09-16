// UserInputA = Username (for reference)

// Let the player declare their own username.
using System.ComponentModel.Design;
using System.Net;

Console.Write("Please Input Your Desired Name Here: ");
Console.Write("");
string UserInputA = (Console.ReadLine());

// General Welcoming to the game for the sake of User Interaction.
Console.WriteLine("Welcome " + (UserInputA) + " to my game!");
Console.WriteLine("In this game, you will be fighting against a single AI Creature: The Goblin.\nI urge you to watch your spelling\nas this game is still Very specific. If you are prompted to choose an option,\nmake sure to spell your answer EXACTLY as it is shown.\n\nThank you for your listening. Please enjoy!\n");
Console.WriteLine("Good Luck!");


// This is where the Player's Name and Health will be displayed.
// They should be prompted to insert an option from the following:
// Attack, Item, and End
// Attack should allow the user to utilize one of the designated attacks against the 'Goblin', dealing 10 Damage.
// The Items avaliable to the player should be simple: Health Potion = +15 Health

int playerHealth = 100;
int goblinHealth = 100;
int v = (playerHealth);
int x = (goblinHealth);

// added the "int v" to be able to continually calculate the Player's Health without having a bajillion different unique integers to calculate it based on each possible outcome.
// added the "int x" for the same purpose but for the Goblin's Health.




// made this so I didnt have the whole thing retyped everytime I needed this screen
// These are the lines for both the player and goblin's health
// The lines inbetween are simply for the sake of looks and appearance
Console.WriteLine("\n Please make sure to read the warning above!\n\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

string UserAction = (Console.ReadLine());


if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (goblinHealth - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\nYou find a knife stuck in your chest and take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);

// System Repeats



Console.WriteLine("\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

UserAction = (Console.ReadLine());

if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (x - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\nYour arm explodes with pain as the blade rakes along your skin.\n\nYou take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);




Console.WriteLine("\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

UserAction = (Console.ReadLine());

if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (x - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\nYou begin to feel dizzy from the loss of blood.\n\nYou take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);


Console.WriteLine("\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

UserAction = (Console.ReadLine());

if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (x - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\nYour vision is a bit blurrier than before.\n\nYou take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);



Console.WriteLine("\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

UserAction = (Console.ReadLine());

if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (x - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\nYou begin to wonder how long it's been.\n\nYou take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);


Console.WriteLine("\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

UserAction = (Console.ReadLine());

if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (x - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\nYou wish this would all end soon.\n\nYou take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);


Console.WriteLine("\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

UserAction = (Console.ReadLine());

if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (x - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\nYou feel sweat trickle down your face.\n\nAre you really taking this long to kill a goblin?\n\nYou take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);


Console.WriteLine("\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

UserAction = (Console.ReadLine());

if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (x - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\n...\n\nYou take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);


Console.WriteLine("\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

UserAction = (Console.ReadLine());

if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (x - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\nYou begin to question your own reality.\n\nYou take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);

Console.WriteLine("\n-------\n");
Console.WriteLine("Name: " + UserInputA);
Console.WriteLine("CURRENT HEALTH: " + v);
Console.WriteLine("\n-------\n");
Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
Console.WriteLine("\n-------\n");

Console.WriteLine("\n\nWhat would you like to do?" + "\n");
Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

UserAction = (Console.ReadLine());

if (UserAction == "Attack")
{
    Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
    string userAttack = (Console.ReadLine());
    if (userAttack == "Basic Attack")
    {
        x = (x - 10);
        Console.WriteLine("\n\nGoblin Health: " + x);
        Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "Items")
{
    Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
    string userItem = (Console.ReadLine());
    if (userItem == "Low Healing Potion")
    {
        v = (v + 20);
        Console.WriteLine("\n\nPlayer Health: " + v);
        Console.WriteLine("\nYou've used your only potion!");
        Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
    }
    else
    {
        Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
        return;
    }
}
else if (UserAction == "End")
{
    Console.WriteLine("\nVery well. Have a good day.");
    return;
}
else
{
    Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
    return;
}

Console.WriteLine("\n\nThe Goblin makes his attack!\n\nIs it finally over?\n\nYou take 10 points of damage!");
v = (v - 10);
Console.WriteLine("Player Health: " + v);

Console.WriteLine("Goblin Health: " + x);

// At this point, the Goblin should be at 0 health if the player keeps attacking, but the player would also have died since they wouldnt have used a turn to heal.

if (x == 0)
{
    Console.WriteLine("\n\nThe Goblin lays dead on the ground.");
    if (v == 0)
    {
        Console.WriteLine("\n\nBut as do you. The battle has ended in a draw.");
        Console.WriteLine("\n\nMaybe try using the healing potion you've been given in your 'Items' next time.");
        return;
    }
    else if (v > 0)
    {
        Console.WriteLine("\n\nYou've won! Congratulations!");
        return;
    }

}
else
{
    Console.WriteLine("\n-------\n");
    Console.WriteLine("Name: " + UserInputA);
    Console.WriteLine("CURRENT HEALTH: " + v);
    Console.WriteLine("\n-------\n");
    Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
    Console.WriteLine("\n-------\n");

    Console.WriteLine("\n\nWhat would you like to do?" + "\n");
    Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

    UserAction = (Console.ReadLine());

    if (UserAction == "Attack")
    {
        Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
        string userAttack = (Console.ReadLine());
        if (userAttack == "Basic Attack")
        {
            x = (x - 10);
            Console.WriteLine("\n\nGoblin Health: " + x);
            Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
        }
        else
        {
            Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
            return;
        }
    }
    else if (UserAction == "Items")
    {
        Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
        string userItem = (Console.ReadLine());
        if (userItem == "Low Healing Potion")
        {
            v = (v + 20);
            Console.WriteLine("\n\nPlayer Health: " + v);
            Console.WriteLine("\nYou've used your only potion!");
            Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
        }
        else
        {
            Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
            return;
        }
    }
    else if (UserAction == "End")
    {
        Console.WriteLine("\nVery well. Have a good day.");
        return;
    }
    else
    {
        Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
        return;
    }

    Console.WriteLine("\n\nThe Goblin makes his attack!\n\nIs it finally over?\n\nYou take 10 points of damage!");
    v = (v - 10);
    Console.WriteLine("Player Health: " + v);

    Console.WriteLine("Goblin Health: " + x);

    if (x == 0)
    {
        Console.WriteLine("\n\nThe Goblin lays dead on the ground.");
        if (v == 0)
        {
            Console.WriteLine("\n\nBut as do you. The battle has ended in a draw.");
            Console.WriteLine("\n\nMaybe try using the healing potion you've been given in your 'Items' next time.");
            return;
        }
        else
        {
            Console.WriteLine("\n\nYou've won! Congratulations!");
            return;
        }
    }
    else
    {

    }

    if (v > 0)
    {
        Console.WriteLine("\n\nYou're still standing, beaten and bloody but alive.");
        if (x > 0)
        {
            Console.WriteLine("\n\nBut so does the goblin. The fight continues.");
        }
        else
        {
            Console.WriteLine("\n\nThe goblin's body lay before you. Congratulations, you have emerged as the victor!");
            return;
        }
    }
    else
    {

    }
}

if (v > 0)
{
    Console.WriteLine("\n\nYou're still standing, beaten and bloody but alive.");
    if (x > 0)
    {
        Console.WriteLine("\n\nBut so does the goblin. The fight continues.");
    }
    else if (x == 0)
    {
        Console.WriteLine("\n\nThe goblin's body lay before you. Congratulations, you have emerged as the victor!");
        return;
    }
    else
    {

    }

}
else
{
    Console.WriteLine("\n-------\n");
    Console.WriteLine("Name: " + UserInputA);
    Console.WriteLine("CURRENT HEALTH: " + v);
    Console.WriteLine("\n-------\n");
    Console.WriteLine("\n" + "Goblin" + "\n" + "GOBLIN HEALTH: " + (x));
    Console.WriteLine("\n-------\n");

    Console.WriteLine("\n\nWhat would you like to do?" + "\n");
    Console.WriteLine("Attack" + "        " + "Items" + "        " + "End" + "\n");

    UserAction = (Console.ReadLine());

    if (UserAction == "Attack")
    {
        Console.WriteLine("\nHere are your current attacks:\nBasic Attack = 10 Damage\n\nPlease Choose your Attack:\n");
        string userAttack = (Console.ReadLine());
        if (userAttack == "Basic Attack")
        {
            x = (x - 10);
            Console.WriteLine("\n\nGoblin Health: " + x);
            Console.WriteLine("\nYou've dealt 10 points of damage to the Goblin.\n\nYour turn has ended. The Goblin makes a move!\n\n");
        }
        else
        {
            Console.WriteLine("\nYou did not submit a known attack. Resetting game; Please watch your spelling.");
            return;
        }
    }
    else if (UserAction == "Items")
    {
        Console.WriteLine("\nHere are your current items:\n(1x) Low Healing Potion = +20 Health\n\nPlease Choose your Item:\n");
        string userItem = (Console.ReadLine());
        if (userItem == "Low Healing Potion")
        {
            v = (v + 20);
            Console.WriteLine("\n\nPlayer Health: " + v);
            Console.WriteLine("\nYou've used your only potion!");
            Console.WriteLine("\nYou've healed yourself for 20 HP. Your turn has ended. The Goblin makes a move!\n\n");
        }
        else
        {
            Console.WriteLine("\nYou did not submit a known item. Resetting game; Please watch your spelling.");
            return;
        }
    }
    else if (UserAction == "End")
    {
        Console.WriteLine("\nVery well. Have a good day.");
        return;
    }
    else
    {
        Console.WriteLine("\nYou can't even spell those words with them right infront of you?\nHow Pathetic.");
        return;
    }

    Console.WriteLine("\n\nThe Goblin makes his attack!\n\nIs it finally over?\n\nYou take 10 points of damage!");
    v = (v - 10);
    Console.WriteLine("Player Health: " + v);

    Console.WriteLine("Goblin Health: " + x);

    if (x == 0)
    {
        Console.WriteLine("\n\nThe Goblin lays dead on the ground.");
        if (v == 0)
        {
            Console.WriteLine("\n\nBut as do you. The battle has ended in a draw.");
            Console.WriteLine("\n\nMaybe try using the healing potion you've been given in your 'Items' next time.");
        }
        else
        {
            Console.WriteLine("\n\nYou've won! Congratulations!");
            return;
        }
    }
    else
    {

    }

    if (v > 0)
    {
        Console.WriteLine("\n\nYou're still standing, beaten and bloody but alive.");
        if (x > 0)
        {
            Console.WriteLine("\n\nBut so does the goblin. The fight continues.");
        }
        else
        {
            Console.WriteLine("\n\nThe goblin's body lay before you. Congratulations, you have emerged as the victor!");
            return;
        }
    }
    else
    {

    }

}



Console.WriteLine("Thank you for playing!");