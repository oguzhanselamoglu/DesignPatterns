namespace DesignPattern.TemplateMethod.Plans;

public abstract class NetflixPlans
{
    protected abstract string PlanType();
    protected abstract int PersonCount();
    protected abstract double Price();

    protected abstract string Resolution();
    protected abstract string Content();

    public void Create()
    {
       string planType =  PlanType();
        PersonCount();
        Price();
        Resolution();
        Content();
        Console.WriteLine($"{planType} Plan Olusturuldu");
        
    }
    
    
}