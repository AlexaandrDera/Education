namespace Metanit
{
    class Person<T, K>
    {
        //public static T? code; static
        public T Id { get; }
        public K Password { get; set; }
        public string Name { get; }

        public Person(T id, K password, string name)
        {
            Id = id;
            Password = password;
            Name = name;
        }
    }
}


