using System;

namespace NameParser.Names
{
    class LastName : NameBase
    { 
        //calls Namebase and constructs string
        public LastName() : base("last")
        { }

        public override void PrintName()
        {
            var lastNameWithSpaces = "";

            foreach (var letter in Name.ToUpper())
            {
             lastNameWithSpaces += letter + "";
            }

            Console.WriteLine(lastNameWithSpaces.Trim());
        }
    }
}
