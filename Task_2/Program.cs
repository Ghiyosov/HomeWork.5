
Rectangle rectan1 = new Rectangle();
rectan1.Width = 25;
rectan1.Height = 35;

Console.WriteLine("Area = " + rectan1.GetArea());

rectan1.Width = 15;
rectan1.Height = 12;

Console.WriteLine("Area = " + rectan1.GetArea());






public class Rectangle 
{
    public int Width;
    public int Height;

    public int GetArea() 
    {
        return (Width * Height);
    }
}
