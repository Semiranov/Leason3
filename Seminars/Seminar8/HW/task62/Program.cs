// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

int[,] MatrixSpiral(int sizeX, int sizeY) //заполнение матрицы рандомом
{
    int[,] Mas = new int[sizeX, sizeY];
    int Summ = sizeX * sizeY;
    int CorrectY = 0;
    int CorrectX = 0;
    int Count = 1;
    while( sizeY > 0 )
  {
    for ( int y = 0; y < 4; y++ )
    {
      for ( int x = 0; x < ( ( sizeX < sizeY ) ? sizeY : sizeX ); x++ )
      {
        if ( y == 0 && x < sizeX - CorrectX && Count <= Summ )
          Mas[y + CorrectY, x + CorrectX] = Count++;
        if ( y == 1 && x < sizeY - CorrectY && x != 0 && Count <= Summ )
          Mas[x + CorrectY, sizeX - 1] = Count++;
        if ( y == 2 && x < sizeX - CorrectX && x != 0 && Count <= Summ )
          Mas[sizeY - 1, sizeX - (x + 1)] = Count++;
        if ( y == 3 && x < sizeY - ( CorrectY + 1 ) && x != 0 && Count <= Summ )
          Mas[sizeY - (x + 1), CorrectY] = Count++;
      }
    }
    sizeY--;
    sizeX--;
    CorrectY += 1;
    CorrectX += 1;
  }
  return Mas;
}

void MatrixOutput(int[,] matr) //вывод матрицы
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}




int line = 4; //количество стррок
int column = 4; //количество столбцов
int[,] matrix = MatrixSpiral(line, column);
MatrixOutput(matrix);

