namespace IlyaCode
{
    internal class GameOfLife
    {
        public static void Do()
        {
            const byte m = 50, n = 50;
            bool[,] step = new bool[m, n];
            step[5, 1] = true;
            step[5, 2] = true;
            step[6, 1] = true;
            step[6, 2] = true;

            step[3, 13] = true;
            step[3, 14] = true;
            step[4, 12] = true;
            step[5, 11] = true;
            step[6, 11] = true;
            step[7, 11] = true;
            step[8, 12] = true;
            step[9, 13] = true;
            step[9, 14] = true;

            step[6, 15] = true;
            step[4, 16] = true;
            step[5, 17] = true;
            step[6, 17] = true;
            step[6, 18] = true;
            step[7, 17] = true;
            step[8, 16] = true;

            step[3, 21] = true;
            step[3, 22] = true;
            step[4, 21] = true;
            step[4, 22] = true;
            step[5, 21] = true;
            step[5, 22] = true;
            step[2, 23] = true;
            step[6, 23] = true;
            step[1, 25] = true;
            step[2, 25] = true;
            step[6, 25] = true;
            step[7, 25] = true;

            step[3, 35] = true;
            step[3, 36] = true;
            step[4, 35] = true;
            step[4, 36] = true;
            int stepNumber = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(stepNumber);
                Output(step);
                Thread.Sleep(25);
                bool[,] nextStep = new bool[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        byte count = 0;
                        for (int y = -1; y <= 1; y++)
                        {
                            for (int x = -1; x <= 1; x++)
                            {
                                if (!(y == 0 && x == 0) &&
                                i + y >= 0 && i + y < m &&
                                j + x >= 0 && j + x < n)
                                {
                                    if (step[i + y, j + x])
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                        switch (count)
                        {
                            case 3:
                                nextStep[i, j] = true;
                                break;
                            case 2:
                                {
                                    if (step[i, j])
                                    {
                                        nextStep[i, j] = true;
                                    }
                                }
                                break;
                        }
                    }
                }
                step = nextStep;
                stepNumber++;
            }
        }

        public static void Output(bool[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] ? '#' : ' ');
                }
                Console.WriteLine();
            }
        }
    }
}
