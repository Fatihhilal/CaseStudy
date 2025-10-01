namespace CaseStudy.Model
{
    public class Person
    {
        public Person( string _name,int _age)
        {
            Name = _name;
            Age = _age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Introduce()
        {
            return $"Merhaba, benim adım {Name} ve {Age} yaşındayım.";
        }
    }
}
