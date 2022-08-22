// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1,y = k2 * x + b2,b1 k1 и b2 и k2 заданы

double Number(string text)
{
    Console.Write(text);
    return double.Parse(Console.ReadLine() ?? "0");
}

void XY(string text, double xY)
{
    Console.Write(text + xY);
    Console.WriteLine();
}

Console.Clear();
double k1 = Number("Enter the coordinate of the first point -k1-: ");
double k2 = Number("Enter the coordinate of the first point -k2-: ");

Console.WriteLine();

double b1 = Number("Enter the coordinate of the first point -b1-: ");
double b2 = Number("Enter the coordinate of the first point -b2-: ");

double x = (b2 - b1)/(k2-k1);
double y = k1 * x + b1;

Console.WriteLine("Point of crossing two lines is: ");
XY("On the axis X ", x);
XY("On the axis Y ", y);