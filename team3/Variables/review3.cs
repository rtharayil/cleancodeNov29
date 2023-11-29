public long Fibonacci(int num)
{
    if (num < 50)
    {
        
        if (num != 0)
        {
            if (num != 1)
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 0;
        }
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}