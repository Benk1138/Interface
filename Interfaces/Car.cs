using System;
namespace Interfaces
{
    public class Car : Ivehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } 
        public string Model { get; set; }
        public string Make { get; set; }
        public int SeatCount { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }
        public bool HasChangedGears { get ; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward");
        }


        public void Reverse()
        {
            if(HasChangedGears == true)
            {

            }
            Console.WriteLine($"{GetType().Name} now in reverse");
            HasChangedGears = false; 
            
        }
        else

        {
          Console.WriteLine("Can't reverse until we change gears");
        }


        public void Park()

        {


        if (HasChangedGears == true)
        {

        }
        Console.WriteLine($"{GetType().Name} now in park");
        HasChangedGears = false;

    }
        else

        {
          Console.WriteLine("Can't park until we change gears");
        }
Console.WriteLine();

            public void ChangeGears(bool hasChanged)
            {
                HasChangedGears = isChanged;
            }
        }

        public bool ChangeGears(bool isChanged)
        {
            throw new NotImplementedException();
        }
    }

}

