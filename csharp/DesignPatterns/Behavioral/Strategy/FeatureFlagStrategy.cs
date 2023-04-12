public class FeatureFlagStrategy : IABTestStrategy
{
	public bool IsFeatureEnabled(User user, Feature feature)
	{
		return feature.IsEnabled;
	}
}
