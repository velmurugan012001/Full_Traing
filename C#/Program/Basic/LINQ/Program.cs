using LINQ;
using System.IO.Pipes;
delegate bool EligibilityCheck(People person);
class Program
{
  

    public static void Main(string[] args)
    {

        /*
                People[] people = new People[]
                {
                    new People {Name ="Vel" , Age = 19},
                    new People {Name ="siva" , Age = 31},
                    new People {Name ="kali" , Age = 22},
                    new People {Name ="maha" , Age = 17},
                    new People {Name ="raji" , Age = 20},
                };
                /*  People[] voters = new People[people.Length];

                  int i = 0;

                  foreach (People person in people)
                  {
                      if (person.Age >=18)
                      {
                          voters[i] = person;
                          Console.WriteLine(person.Name); 
                          i++;
                      }
                  }*/


        /*  List<People> voters = VoteCheck.where(people, delegate (People person)
              {
                  return person.Age >= 18;
              });*/


        //  List<People> voters = people.Where(person => person.Age >= 18).ToList();

        /*
                var voters = from person in people where person .Age <=18 select person;

                foreach (People voter in voters)
                {
                    Console.WriteLine(voter.Name);

                }
        */

        VoteCheck voteCheck = new VoteCheck();
        voteCheck.students();
        
    }
   
}
