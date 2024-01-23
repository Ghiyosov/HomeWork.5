
Person person1 = new Person();
person1.Age = 25;
person1.LastName = "Ghiyosov";
person1.FirstName = "Ismoil";
person1.Address = "Dushande";


Console.WriteLine("My name is " + person1.GetFullName());

Console.WriteLine("My birth year is "+ person1.GetBirthYear());




public class Person 
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Address;


    public string GetFullName() 
    {
        return $"{FirstName} {LastName}";
    }
    public  int GetBirthYear() 
    {
        return 2024 - Age;
    }
}