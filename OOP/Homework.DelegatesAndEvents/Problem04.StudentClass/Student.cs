namespace Problem04.StudentClass
{
    using System;

    public class Student
    {
        private string name;
        private byte age;

        public Student(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public event EventHandler<PropertyChangedEventArgs<string>> PropertyChanged;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckForNullOrEmpty(value, " Name can't be null or empty string!\n");
                this.OnPropertyChanged(new PropertyChangedEventArgs<string>("Name", this.name, value));
                this.name = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }

            set
            {
                Validator.CheckForLargerThenZero(value, "Age must be larger then zaro!");
                this.OnPropertyChanged(new PropertyChangedEventArgs<string>("Age", this.Age.ToString(), value.ToString()));
                this.age = value;
            }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs<string> e)
        {
            if (null != this.PropertyChanged)
            {
                this.PropertyChanged(this, e);
            }
        }
    }
}
