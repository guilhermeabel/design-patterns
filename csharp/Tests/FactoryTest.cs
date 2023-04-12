using DesignPatterns.Creational.Factory;

public class FactoryTest : IDesignPatternTest
{
	public void Run()
	{

		Engine gasEngine = EngineFactory.CreateEngine(EngineType.Gas);
		Engine electricEngine = EngineFactory.CreateEngine(EngineType.Electric);
		Engine hybridEngine = EngineFactory.CreateEngine(EngineType.Hybrid);

	}
}
