using System;
using System.Collections.Specialized;
using System.Data;
using System.Xml.Linq;

namespace Program2
{
    struct musician
    {
        public string nameandsurname;
        public string age;
        public string role;

        public musician(string _name, string _age, string _role)
        {
            nameandsurname = _name;
            age = _age;
            role = _role;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя и Фамилия солиста: {nameandsurname} | Возраст: {age} | Роль в группе: {role}");
        }
    }
    class Group
    {
        public string group;
        
        public Group(string _group)
        {
            group = _group;
        }
        public object Clone ()
        {
            return new Group(group);
        }
        public void PrintIform()
        {
            Console.WriteLine($"Группа: {group}");
        }
    }
    internal class Program1
    {
        static void Main(string[] args)
        {
            Group grup1 = new Group("Эпидемия");
            grup1.PrintIform();
            musician soloist1 = new musician("Евгений Егоров", "36", "вокалист");
            soloist1.PrintInfo();
            musician soloist2 = new musician("Юрий Мелисов", "49", "электрогитара");
            soloist2.PrintInfo();
            musician soloist3 = new musician("Дмитрий Процко", "43", "электрогитара");
            soloist3.PrintInfo();
            musician soloist4 = new musician("Илья Мамонтов", "45", "басгитара");
            soloist4.PrintInfo();
            musician soloist5 = new musician("Дмитрий Кривенков", "51", "барабаны");
            soloist5.PrintInfo();
            Console.WriteLine($"");
            Group grup2 = (Group) grup1.Clone();
            grup2.group = "Мельница"; 
            grup2.PrintIform();
            musician soloist6 = soloist1 with
            {
                nameandsurname = "Хелависа",
                age = "47"
            };
            soloist6.PrintInfo();
            musician soloist7 = soloist2 with
            {
                nameandsurname = "Сергей Вишняков",
                age = "40"
            };
            soloist7.PrintInfo();
            musician soloist8 = soloist3 with
            {
                nameandsurname = "Дмитрий Каргин",
                age = "38",
                role = "флейта"
            };
            soloist8.PrintInfo();
            musician soloist9 = soloist4 with
            {
                nameandsurname = "Алексей Кожанов",
                age = "50"
            };
            soloist9.PrintInfo();
            musician soloist10 = soloist5 with
            {
                nameandsurname = "Дмитрий Фролов",
                age = "45"
            };
            soloist10.PrintInfo();
        }
    }
}