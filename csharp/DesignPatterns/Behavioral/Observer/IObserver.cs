// The Subject interface declares the methods that the Concrete Subject (observable) should implement.
public interface ISubject
{
	void Attach(IObserver observer); // Attach an observer to the subject.
	void Detach(IObserver observer); // Detach an observer from the subject.
	void Notify(); // Notify all observers about the state change.
}

// The Observer interface declares the method that Concrete Observers should implement.
public interface IObserver
{
	void Update(ISubject subject);
}

