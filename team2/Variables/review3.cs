public long getFibonacci(int index)
{
    if (index < 50)
    {
        if (index != 0)
        {
            if (index != 1)
            {
                return getFibonacci(index - 1) + getFibonacci(index - 2);
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