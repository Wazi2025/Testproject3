﻿using System.Data;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

daysUntilExpiration = 11;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
    //Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5) //&& (daysUntilExpiration != 1) && (daysUntilExpiration != 0))
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
    //Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}

//Console.WriteLine(daysUntilExpiration);
// string myValue1 = "Y ";
// string myValue2 = " y";
// Console.WriteLine((myValue1 != myValue2));
// Console.WriteLine((myValue1.Trim().ToLower() != myValue2.Trim().ToLower()));
// Console.WriteLine((myValue1.Trim().ToLower() == myValue2.Trim().ToLower()));
// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");
// Console.WriteLine(flip);


string permission = "Admin|Manager";
int level = 33;

string admin = "Admin";
string manager = "Manager";

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level >= 53 && level <= 55)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
if (permission.Contains("Manager"))
{
    if (level >= 20 && level <= 52)
    {
        Console.WriteLine("Contact an Admin for access.");
    }

}

if (!permission.Contains(admin) || !permission.Contains(manager) || level <= 19)
{
    Console.WriteLine("You do not have sufficient privileges.");
}

Console.WriteLine($"Level: {level}");