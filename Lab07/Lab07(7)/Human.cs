namespace Lab07_7_
{
    internal class Human : IIdentifiable, IBuyer
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public long Id { get; set; }
        public int Age { get; private set; }
        public int Food { get; set; }

        public Human (string name, int age, long id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public void BuyFood()
        {
            Food += 10;
        }

    }
}
