using System;

namespace Dog
{
    public enum Gender
        {
            Male, Female
        }
    public class Dog
    {
        
        string name;
        string owner;
        int age;
        Gender gender;
        
        public Dog(string _name, string _owner, int _age, Gender _gender)
        {
            name = _name;
            owner = _owner;
            age = _age;
            gender = _gender;
        }

        public void Bark(int count)
        {
            Console.Write("\n");
            for (int i = 0; i < count; i++)
            {
                Console.Write("Woof! ");
            }
        }
        public string GetTag()
        {
            Console.Write("\n");
            string herHis, sheHe, yearYears;
            if (gender == Gender.Male)
            {
                herHis = "His";
                sheHe = "he";
            }else{
                herHis = "Her";
                sheHe = "she";
            }
            if (age == 1)
            {
                yearYears = "year";
            }else{
                yearYears = "years";
            }
            string str = $"If lost, call {owner}. {herHis} name is {name} and {sheHe} is {age} {yearYears} old.";
            return str;
        }
            
            
        
        
        
            

    }
}
