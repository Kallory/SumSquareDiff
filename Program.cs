// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
Console.WriteLine("This program takes the squares of the first 100 natural numbers and subtracts it from square of the sum of the first 100 natural numbers.");
Console.WriteLine(squareOfSums());
    
double sumOfSquares()
{
    double sum = 0;
    for (double i = 1; i <= 100; i++)
    {
        sum += Math.Pow(i, 2);
    }

    return sum;
}

int squareOfSums()
{
    int square = 0;
    for (int i = 1; i <= 100; i++)
    {

    }

    return square;
}