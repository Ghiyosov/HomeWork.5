


























public class Car 
{
    public string Make;
    public string Model;
    public int Year;
    public double Mileage;
    public double Fuel;




    public void Drive(double miles) 
    {
        if (Fuel < miles) 
        {

        }
    }

    public void AddFuel(ref double gallons) 
    {
        Fuel = Fuel + gallons;
    }
}