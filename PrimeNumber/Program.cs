
Console.WriteLine(IsPrime(12));



bool IsPrime(int m)
{
    for (int i = 2; i < m; i++)
    {
        if (m % i == 0)
            return false;
    }
    return true;
}
