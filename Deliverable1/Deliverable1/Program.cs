// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
//initializing a variable to begin the program this will have a beginning value set to 1 so that the program will start 
bool go_again = true;
while ((go_again) == true)
{
    //displaying a message to the user on how many people are going to be eating
    Console.Write("How many people are going to be eating? ");
    //taking the user input and assigning it to variable "people"
    int people = int.Parse(Console.ReadLine());
    //creating an if statement to choose the gramatically correct text output
    if (people == 1)
    {
        Console.WriteLine("So only one lonely person");
    }
    else
    {
        Console.WriteLine("So there are going to be " + people + " people. ");
    }
    //initializing the variables for loaves of bread "Bread Loaf" as well as slices of bread "Bread_slice"
    //assigning the number of bread slices to bread loaf we will start at 0 because we dont got that bread
    int bread_loaf = 0;
    int bread_slice = 0;
    //same deal for jar of peanut butter/jelly and teaspoon/tablespoons of both
    int tablespoon_peanut = 0;
    int teaspoon_jelly = 0;
    int jar_peanut = 0;
    int jar_jelly = 0;
    int sandwich = 0;
    //creating a loop to assemble the sandwich 

    while (sandwich <= people)
    {


        //nesting if statements that will add more loaves of bread once bread slice is less than 0
        if (bread_slice <= 0)
        {
            bread_slice = 28;
            bread_loaf++;
        }
        //same goes for peanut and jelly
        if (tablespoon_peanut <= 0)
        {
            tablespoon_peanut = 32;
            jar_peanut++;
        }
        if (teaspoon_jelly <= 0)
        {
            teaspoon_jelly = 48;
            jar_jelly++;
        }
        // setting the equation that will subtract ingredients from the pool in order to create a sandwich
        bread_slice -= 2;
        teaspoon_jelly -= 4;
        tablespoon_peanut -= 2;

        sandwich++;
    }

    int total_slice = (people * 2);
    int total_peanut = (people * 2);
    int total_jelly = (people * 4);

    Console.WriteLine("So we will need to buy " + bread_loaf + " loaves of bread " + jar_peanut + " jars of peanut butter and " + jar_jelly + " jars of jelly to feed " + people + " people");
    Console.WriteLine("So we will need to buy " + total_slice + " slices of bread " + total_peanut + " tablespoons of peanut butter and " + total_jelly + " teaspoons of jelly to feed  " + people + " people");
    Console.WriteLine("Would you like to restart ? Enter y to continue, or enter any other key to exit.");
    string input = Console.ReadLine();

    if (input == "y")
    {
        go_again = true;
    }
    else
    {
        go_again = false;
    }
}
Console.WriteLine("Goodbye!");