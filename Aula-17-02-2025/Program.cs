

double x1, x2, y1, y2,d,p1,p2;
Console.Write("Digite x1:");
x1 = int.Parse(Console.ReadLine());

Console.Write("Digite x2:");
x2 = double.Parse(Console.ReadLine());

Console.Write("Digite y1:");
y1 = double.Parse(Console.ReadLine());

Console.Write("Digite y2:");
y2 = double.Parse(Console.ReadLine());

p1 = Math.Pow(x1 - x2, 2);
p2 = Math.Pow(y1 - y2, 2);

d = Math.Sqrt(p1 + p2);

Console.Write(d);




























