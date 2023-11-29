public long Fibonacci(int n)
{
    if (n < 50)
    {
        if (n != 1 && n != 0)
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        else
        {
            return n;
        }
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}
