Console.Write("b1:");
int b1 = int.Parse(Console.ReadLine());
Console.Write("k1:");
int k1 = int.Parse(Console.ReadLine());
Console.Write("b2:");
int b2 = int.Parse(Console.ReadLine());
Console.Write("k2:");
int k2 = int.Parse(Console.ReadLine());

Console.WriteLine($"b1={b1},k1={k1},b2={b2},k2={k2}->{func(b1, k1, b2, k2)}");

string func(double B1, double K1, double B2, double K2){
    double x = (B2-B1)/(K1-K2);
    double y = K2*x+B2;
    string answer = "(" + x.ToString() +  ";" + y.ToString() + ")";
    return answer;
}

