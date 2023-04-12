public class StrategyTest : IDesignPatternTest
{
	public void Run()
	{

		User user = new User { Id = 1, Name = "Alice" };
		Feature feature = new Feature { Name = "NewFeature", IsEnabled = true };

		ABTestContext context = new ABTestContext(new FeatureFlagStrategy());

		if (context.IsFeatureEnabled(user, feature))
		{
			Console.WriteLine("Feature enabled");
		}
		else
		{
			Console.WriteLine("Feature not enabled");
		}

		context.SetStrategy(new PercentageBasedStrategy(50));

		if (context.IsFeatureEnabled(user, feature))
		{
			Console.WriteLine("Feature is enabled for the user based on percentage.");
		}
		else
		{
			Console.WriteLine("Feature is not enabled for the user based on percentage.");
		}

	}
}
