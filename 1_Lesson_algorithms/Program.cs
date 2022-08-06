// Виды алгоритмов 
// 1 Константный
// 2 Логарифмические
// 3 Линейные
// 4 Линейно-логарифмические
// 5 Квадратичные
// 6 Кубический
//
//Hахождения Oбщего Делителя  (Алгоритм Евклида)
// числа (140,175) = 35.
// int n = 140;
// int m = 175;
// while (n != m)
// {
//     if (n > m)
//     {
//         n = n - m;
//     }
//     else
//     {
//         m = m - n;
//     }
//     Console.WriteLine(n);
//     Console.WriteLine(m);
//     Console.WriteLine();

// }

// ​НОК(a,b) = a*b/НОД(a,b) Наименьшее общее кратное.

int n = 140;
int m = 175;
int count = n * m;
while (n != m)
{
    if (n > m)
    {
        n = n - m;
    }
    else
    {
        m = m - n;
    }
}
Console.WriteLine(count / n);