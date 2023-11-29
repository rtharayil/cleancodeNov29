public long Fibonacci(int n)
{
    if (n < 50 && n>=0)
    {
        if (n >1)
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
