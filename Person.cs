namespace Net5FeaturesTest
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person() { }

        public virtual Person Clone() => new Person() { FirstName = FirstName, LastName = LastName };
    }

    public class Student : Person
    {
        public string ID;
        // Covariant return types
        // In C# 9 you can override the Person Clone method to return a more specific "Student" instead of Person Type
        // Old Way
        //public override Person Clone() => new Student { FirstName = FirstName, LastName = LastName, ID = ID };
        // New Way
        public override Student Clone() => new Student { FirstName = FirstName, LastName = LastName, ID = ID };
    }
}
