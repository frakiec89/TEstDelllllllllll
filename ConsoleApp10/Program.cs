

int[,] x = new int[,]
{
    {1,  1,  1,  1,  1},
    {1, 12, 13, 14, 1 },
    {1, 22, 23, 24, 1},
    {1, 1, 1, 1, 1 }

};


for(int i = 0;i < x.GetLength(0); i++)
{
    for (int j = 0; j < x.GetLength(1); j++)
    {
        if (x[i,j] == 1 )
        {
            Console.Write("*");
          
        }
        else
        { Console.Write(" "); }
      
    }
    Console.WriteLine();
}