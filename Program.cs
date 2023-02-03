// See https://aka.ms/new-console-template for more information
/*
string[,] table=new string[2,5];
table[1,2]="слово";
for (int rows=0; rows<2; rows++ )
{
    for (int colums=0; colums<5; colums++)
    {
        Console.WriteLine($"-{table[rows,colums]}-");
    }
}
*/
/*
void PrintArray(int[,] matr)
{

for (int rows=0; rows<matr.GetLength(0); rows++)
{
    for (int colums=0; colums<matr.GetLength(1); colums++)
    {
        Console.Write($"{matr[rows,colums]}");
    }
    Console.WriteLine( );
} 
}

void FillArray (int[,] matr)
{
for (int i=0; i<matr.GetLength(0); i++)
{
for (int j=0; j<matr.GetLength(1);j++)
{
    matr[i,j]=new Random().Next(1,10);
}
}
}

int[,] matrix= new int[3,4];
PrintArray(matrix);
Console.WriteLine(" ");
FillArray(matrix);
PrintArray(matrix);
*/
//нет картинки
/*
void FillImage(int row, int col)
{
if (pic[row, col] == 0)
{
pic[row, col] = 1;
FillImage(row - 1, col);
FillImage(row, col - 1);
FillImage(row + 1, col);
FillImage(row, col + 1);
}
}
PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);
*/
//не работает
/*
double Factor (int n)
{
if (n==1) return 1;
else return n*Factor(n-1); 
}
for (int i=1;i<17;i++)
{
    Console.WriteLine($"{i}!={Factor(i)}");
    
}
*/
/*
int Fibanachi (int N)
{
    if (N==1 || N==2) return 1;
    else return Fibanachi(N-1)+Fibanachi(N-2);
}
for (int i=1;i<10;i++)
{
    Console.WriteLine(Fibanachi(i));
}
*/