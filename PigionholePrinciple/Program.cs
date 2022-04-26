

int[] fs = new int[1000000];

void FindNumber(int m)
{
    int cur_len = 0;
    for (int i = 0; i <= m; i++)
    {
        cur_len = (cur_len * 10 + 1) % m;

        if (cur_len == 0)
        {
            for (int j = 1; j <= i; j++)
                Console.WriteLine(1);
            return;
        }
        if (fs[cur_len] != 0)
        {
            for (int j = 1; j <= i - fs[cur_len]; j++)
                Console.WriteLine(1);
            for (int j = 1; j <= fs[cur_len]; j++)
                Console.WriteLine(1);
        }
        fs[cur_len] = i;
    }
}


FindNumber(5);