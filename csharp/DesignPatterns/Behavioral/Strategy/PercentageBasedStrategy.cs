public class PercentageBasedStrategy : IABTestStrategy
{
	private readonly int _percentage;

	public PercentageBasedStrategy(int percentage)
	{
		_percentage = percentage;
	}

	public bool IsFeatureEnabled(User user, Feature feature)
	{
		// Check if the user falls within the percentage range for the feature
		return (user.Id % 100) < _percentage;
	}
}
