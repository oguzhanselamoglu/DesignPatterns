namespace DesignPattern.TemplateMethod.Plans;

public class StandardPlan:NetflixPlans
{
    protected override string PlanType()
    {
        return "Standard";
    }

    protected override int PersonCount()
    {
        return 2;
    }

    protected override double Price()
    {
        return 50;
    }

    protected override string Resolution()
    {
        return "1080";
    }

    protected override string Content()
    {
        return "Film";
    }
}