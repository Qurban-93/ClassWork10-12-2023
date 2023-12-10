bool hasUp= false, hasNum = false;

l1:
Console.Write("Enter your pass: ");
string pass = Console.ReadLine();

foreach (var letter in pass)
{
    if (Char.IsUpper(letter))
    {
        hasUp = true;
    }
    else if (Char.IsNumber(letter))
    {
        hasNum = true;
    }
}
if(hasUp && hasNum)
{
    Console.WriteLine("Good pass");
}
else
{
    goto l1;
}