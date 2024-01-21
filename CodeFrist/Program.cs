using CodeFrist;

var Ef = new EFDataConText();
foreach (var item in Ef.Students)
{
    if (item == null)
    {
        Console.WriteLine("NULl");
    }
    Console.WriteLine(item.FirstName);
}