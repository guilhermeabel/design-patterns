namespace DesignPatterns.Creational.Factory
{
	public static class EngineFactory
	{
		public static Engine CreateEngine(EngineType type)
		{
			switch (type)
			{
				case EngineType.Gas:
					return new GasEngine();
				case EngineType.Electric:
					return new ElectricEngine();
				case EngineType.Hybrid:
					return new HybridEngine();
				default:
					throw new ArgumentException("Invalid engine type");
			}
		}
	}
}
