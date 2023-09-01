// 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины. (Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон).

bool ExistenceOfTriangle(int sideA, int sideB, int sideC)
{
    if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB) return true;
    return false;
}

Console.WriteLine("Введите стороны треугольника: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
bool answer = ExistenceOfTriangle(A, B, C);
string result = answer ? "может" : "не может";
Console.WriteLine($"Треугольник со сторонами {A}, {B} и {C} существовать {result}");