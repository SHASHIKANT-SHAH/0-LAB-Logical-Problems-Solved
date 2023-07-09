

//  Write a program that prints numbers from 1 to 100. But for multiples of 3 print "valar" 
//  instead of the number For multiples of 5 print "morghulis" 
//  instead of the number For the numbers that are multiples of both 3 and 5 print "valar morghulis"

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("valar morghulis");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("valar");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("morghulis");
    }
    else
    {
        Console.WriteLine(i);
    }
}