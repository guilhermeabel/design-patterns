namespace DesignPatterns.Behavioral.Observer
{
	// The Concrete Subject (observable) maintains a list of its observers and sends notifications to them when its state changes.
	public class ConcreteSubject : ISubject
	{
		private List<IObserver> _observers = new List<IObserver>();
		private int _state;

		public int State
		{
			get { return _state; }
			set
			{
				_state = value;
				Notify();
			}
		}

		public void Attach(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void Detach(IObserver observer)
		{
			_observers.Remove(observer);
		}

		public void Notify()
		{
			foreach (IObserver observer in _observers)
			{
				observer.Update(this);
			}
		}
	}

}
