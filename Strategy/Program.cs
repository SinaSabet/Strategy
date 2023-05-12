

Context context = new Context(new BMW());

context.returnCar();


public abstract class Car
{
    public abstract void BuildCar();
}


public class BMW : Car
{
    public override void BuildCar()
    {
        Console.WriteLine("Bmw ..........");
    }


}



public class Benz : Car
{
    public override void BuildCar()
    {
        Console.WriteLine("Benz ..........");
    }
}




public class Context
{
    private readonly Car _car;
    public Context(Car car)
    {
        _car = car;
    }


    public void returnCar()
    {
        _car.BuildCar();
    }
}