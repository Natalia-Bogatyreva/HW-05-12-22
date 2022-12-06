// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double[] point = new double[6];
for (int i=0; i < 6; i++)
{
    Console.WriteLine($"Введите {i%3+1} координату для {i/3+1} точки:");
    point[i] = Convert.ToDouble(Console.ReadLine());
}
double ras = Math.Sqrt((point[3]-point[0])*(point[3]-point[0])+(point[4]-point[1])*(point[4]-point[1])+(point[5]-point[2])*(point[5]-point[2]));
Console.Write("Расстояние между указанными точками в 3D пространстве = " + ras);