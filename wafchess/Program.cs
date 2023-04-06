using System.Globalization;
using System.Runtime.InteropServices;

//string solidLine;
string lineWithFields;
string flexibleline;
Boolean black = true;

// ask how much rows they want
Console.WriteLine("How many rows you want?");
int horizontal = Convert.ToInt32(Console.ReadLine());
// ask how much lines they want
Console.WriteLine("How many lines you want?");
int vertical = Convert.ToInt32(Console.ReadLine());

// repeat what you have been told
Console.Write("okeee here we go with " + horizontal);
Console.Write("rows ");
Console.Write("and" + vertical);
Console.WriteLine("Lines");

// construct flexible horizontal line and display

flexibleline = "+";
for (int i = 0; i < horizontal; i++)
{
    if (black == true)
    {
        flexibleline = flexibleline + "-+";
        black = false;
    }
    else
    {
        flexibleline = flexibleline + "-+";
        black = true;
    }
}

Console.WriteLine(flexibleline);

for (int j = 0; j < vertical; j++)
{
    if (j % 2 == 0)
    {
        black = true;
    }
    else
    {
        black = false;
    }
    // construct number of fields
    lineWithFields = "|";
    for (int i = 0; i < horizontal; i++)
    {
        if (black == true)
        {
            lineWithFields = lineWithFields + "w|";
            black = false;
        }
        else
        {
            lineWithFields = lineWithFields + "b|";
            black = true;
        }
    }
    Console.WriteLine(lineWithFields);
    Console.WriteLine(flexibleline);
    int x = 10;
    x += 5;
    Console.WriteLine(x);

}
