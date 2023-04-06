namespace DesignPatterns.Observer
{
	// The Concrete Subject (observable) maintains a list of its observers and sends notifications to them when its state changes.
	// Concrete Observers receive notifications from the Concrete Subject and react to changes.
	public class ConcreteObserver : IObserver
	{
		private int _observerState;

		public void Update(ISubject subject)
		{
			if (subject is ConcreteSubject concreteSubject)
			{
				_observerState = concreteSubject.State;
				Console.WriteLine("Observer state updated to: " + _observerState);
			}
		}
	}


}
