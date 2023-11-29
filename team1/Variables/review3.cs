public long Fibonacci(int n)
{
    if (n < 50)
    {
        if (n ==0 || n==1) {
            return n;
        }
        else {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}