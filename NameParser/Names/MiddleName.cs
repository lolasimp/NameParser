using System;

namespace NameParser.Names
{
    class MiddleName : NameBase
    {
        //field of type firstName
        private readonly FirstName _firstName;

        public MiddleName(FirstName firstName) : base("middle")
        {
            Name = "";
            _firstName = firstName;
        }

        public override void GetName()
        {
            if (UserHasMiddleName())
            {
                base.GetName();
            }
            else
            {
                Console.WriteLine($@"{_firstName.Name}, Move on.");
            }
        }

        bool UserHasMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }

        public override void PrintName()
        {
            var i = 0;
            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
    }
}
