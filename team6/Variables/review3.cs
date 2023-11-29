public long Fibonacci(int number)
{
    if (number < 0 || number >= 50)
    {
        throw new System.Exception("Not supported");
    }
 
    return (number == 0) ? 0 : (number == 1) ? 1 : Fibonacci(number - 1) + Fibonacci(number - 2);
}
