namespace CCMovieDatabase.Services
{
    public class ToastCounterService
    {
        // stateful data
        public int ToastCount { get; private set; }

        // constructor
        public ToastCounterService()
        {
            ToastCount = 0;
        }

        // Methods
        public void Increment()
        {
            ToastCount++;
        }
    }
}
