
int lem = 0;
int[] f = new int[100];
int[] expo = new int[100];

primeFact(46);

void primeFact(int m)
{
    int d = 2; //Division of iteration

    while (m > 1)
    {
        int k = 0; //Count of division of prime number
        while (m % d == 0)
        {
            m /= d;
            k++;
        }

        if (k > 0)
        {
            f[lem] = d;
            expo[lem] = k;
            lem++;
        }
        d++;
    }
    if (m > 1)
    {
        f[lem] = m;
        expo[lem] = 1;
    }
}

void primeFactOptimized(int m)
{
    int d = 2; 

    while (m > 1 && d * d <= m)
    {
        int k = 0; 
        while (m % d == 0)
        {
            m /= d;
            k++;
        }

        if (k > 0)
        {
            f[lem] = d;
            expo[lem] = k;
            lem++;
        }
        d++;
    }
    if (m > 1)
    {
        f[lem] = m;
        expo[lem] = 1;
    }
}




















