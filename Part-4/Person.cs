namespace part4
{
    public class Person
    {
        // Using Getter and Setter Methods
        /* private DateTime _birthDate;
        public void SetBirthdate(DateTime birthDate)
        {
            _birthDate=birthDate;
        }

        public DateTime getBirthdate()
        {
            return _birthDate;
        }*/

        //Using Properties
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birth)
        {
            Birthdate=Birthdate;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years=timeSpan.Days/365;
                return years;
            }
        }
    }
}