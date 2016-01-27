namespace Problem03.AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsyncTimer
    {
        private Action<string> actionMethod;
        private int ticks;
        private int interval;

        public AsyncTimer(Action<string> actionMethod, int ticks, int interval)
        {
            this.actionMethod = actionMethod;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        public int Interval
        {
            get
            {
                return this.interval;
            }

            set
            {
                Validator.CheckForLargerThenZero(value, " Interval must by positive number!\n");
                this.interval = value;
            }
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            set
            {
                Validator.CheckForLargerThenZero(value, " Number of ticks must by positive!\n");
                this.ticks = value;
            }
        }

        public void OnTick()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep(this.interval);

                if (this.actionMethod != null)
                {
                    this.actionMethod(this.ticks + string.Empty);
                }

                this.ticks--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.OnTick);
            thread.Start();
        }
    }
}
