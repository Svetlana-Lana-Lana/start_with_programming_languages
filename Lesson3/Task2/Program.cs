//int n = 5;

//int i = 1;
//while(i <= n){
//    Console.Write($"{i*i} ");
//    i = i + 1;
//}

//int n = 10;

//int i = 1;
//while(i <= n){
//    Console.Write($"{i*i} ");
//    i = i + 1;
//}

//int n = 15;

//int i = 1;
//while(i <= n){
//    Console.Write($"{i*i} ");
//    i = i + 1;
//}

void PrintSquares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}
PrintSquares(5);
PrintSquares(10);
PrintSquares(15);