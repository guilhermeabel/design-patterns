public class ABTestContext
{
    private IABTestStrategy _strategy;

    public ABTestContext(IABTestStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IABTestStrategy strategy)
    {
        _strategy = strategy;
    }

    public bool IsFeatureEnabled(User user, Feature feature)
    {
        return _strategy.IsFeatureEnabled(user, feature);
    }
}
