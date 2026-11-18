using System;
using System.Text;

class Bai2_11
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số hàng m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Nhập số cột n: ");
        int n = int.Parse(Console.ReadLine());

        string[,] board = new string[m, n];
        Console.WriteLine("Nhập bảng mìn (nhập '*' nếu có mìn, ký tự khác nếu không):");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"cell[{i},{j}] = ");
                board[i, j] = Console.ReadLine();
            }
        }

        int[,] result = new int[m, n];
        int[] dr = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dc = { -1, 0, 1, -1, 1, -1, 0, 1 };

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i, j] == "*")
                {
                    result[i, j] = -1;
                }
                else
                {
                    int mineCount = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int ni = i + dr[k];
                        int nj = j + dc[k];
                        if (ni >= 0 && ni < m && nj >= 0 && nj < n && board[ni, nj] == "*")
                        {
                            mineCount++;
                        }
                    }
                    result[i, j] = mineCount;
                }
            }
        }

        Console.WriteLine("\nBảng Minesweeper tính số mìn xung quanh:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (result[i, j] == -1)
                    Console.Write("* ");
                else
                    Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}