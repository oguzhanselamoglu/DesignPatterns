namespace DesignPattern.TemplateMethod.Plans;

public class BasicPLan: NetflixPlans
{
    protected override string PlanType()
    {
        return "Basic";
    }

    protected override int PersonCount()
    {
        return 1;
    }

    protected override double Price()
    {
        return 30;
    }

    protected override string Resolution()
    {
        return "720px";
    }

    protected override string Content()
    {
        return "Film";
    }
}