/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] GenerateArray(int n,int m)
{
    int[,] matrix = new int[n,m];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {        
           matrix[i,j] = new Random().Next(1, 10);
       }
    }return matrix; 
}

void PrintArray(int[,] matrix)
{
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {
           Console.Write(matrix[i,j]+" ");
       }
       Console.WriteLine("");
    }
}
int[,] matrix = new int[2,2];
int[,] ProisvedenieArray(int[,] matrix1, int[,] matrix2)
{   

    matrix[0,0] = matrix1[0,0]*matrix2[0,0]+matrix1[0,1]*matrix2[1,0];
    matrix[0,1] = matrix1[0,0]*matrix2[0,1]+matrix1[0,1]*matrix2[1,1];
    matrix[1,0] = matrix1[1,0]*matrix2[0,0]+matrix1[1,1]*matrix2[1,0];
    matrix[1,1] = matrix1[1,0]*matrix2[0,1]+matrix1[1,1]*matrix2[1,1];
    return matrix;
}

int[,] result1 = GenerateArray(2,2);
int[,] result2 = GenerateArray(2,2);
PrintArray(result1);
Console.WriteLine("");
PrintArray(result2);
int[,] result = ProisvedenieArray(result1, result2);
Console.WriteLine("");
PrintArray(result);
