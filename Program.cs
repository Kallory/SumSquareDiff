// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
Console.WriteLine("This program takes the squares of the first 100 natural numbers and subtracts it from square of the sum of the first 100 natural numbers.");
Console.WriteLine("sum of squares = " + sumOfSquares(100));
Console.WriteLine("Square of sums = " + squareOfSums(100));
Console.WriteLine("Difference between the sum of the squares of the first one hundred natural numbers and the square of the sum = " + diffBetweenSumOfSquaresAndSquareOfSums(squareOfSums(100), sumOfSquares(100)));
    
double sumOfSquares(int num)
{
    double sum = 0;
    for (double i = 1; i <= num; i++)
    {
        sum += Math.Pow(i, 2);
    }

    return sum;
}

double squareOfSums(int num)
{
    double square = 0;
    for (int i = 1; i <= num; i++)
    {
        square += i;
    }

    return Math.Pow(square, 2);
}

double diffBetweenSumOfSquaresAndSquareOfSums(double square, double sum)
{
    return square - sum;
}