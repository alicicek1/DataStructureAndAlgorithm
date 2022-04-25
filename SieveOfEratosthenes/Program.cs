
bool[] isPrime = new bool[100];

SieveOfErastosthenes(17);

void SieveOfErastosthenes(int m)
{
    for (int i = 2; i <= m; i++)
    {
        isPrime[i] = true;
    }
    for (int i = 2; i <= m / 2; i++)
    {
        if (isPrime[i])
            for (int j = i * 2; j <= m; j += i)
            {
                isPrime[j] = false;
            }
    }
}