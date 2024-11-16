try
{
    Console.WriteLine("┌---------------------------------------┐");
    Console.WriteLine($"|        x          |         y         |");
    Console.WriteLine("|---------------------------------------|");
    for (double x = 1.1; x <= 3 ; x +=0.2)
    {
        double y =Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 2  ;
        Console.WriteLine($"|       {x,-5:F2}       |       {y,5:F2}      | ");
    }
    Console.WriteLine("└---------------------------------------┘");
    Console.WriteLine();

}
catch
{
    Console.WriteLine("какая то ошибка");
}