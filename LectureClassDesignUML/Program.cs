namespace LectureClassDesignUML

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Nisse", 33, Gender.Male);
            Person p2 = new Person("Nissa", 45, Gender.Female);
            Person p3 = new Person("Lisa", 54, Gender.Female);

            List<Person> pers = new List<Person>();
            pers.Add(p1); 
            pers.Add(p2); 
            pers.Add(p3);
            foreach (Person item in pers)
            {
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Gender);
            }
            

            //Tank myTank = new Tank("Str S1", 3,"big gun");
            ////myTank.Name = "Str S1";

            ////Console.WriteLine("you are driving a "+myTank.Name);

            //Tank yourTank = new Tank("Udes 16", 3, "small gun");
            ////yourTank.Name = "Udes 16";

            //List<Tank> tanks = new List<Tank>();
            //tanks.Add(myTank);
            //tanks.Add(yourTank);

            //foreach (Tank atank in tanks)
            //{
            //    Console.WriteLine("you are driving a " + atank.Name);
            //}
            //Console.WriteLine(myTank.StartEngin());

            //foreach (Tank atank in tanks)
            //{
            //    Console.WriteLine(atank.Drive());
            //}


        }
    }
}