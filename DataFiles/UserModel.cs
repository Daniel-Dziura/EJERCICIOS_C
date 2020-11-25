using System;

namespace DataFiles
{
    internal class UserModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }

        internal static object DisplayText()
        {
            throw new NotImplementedException();
        }
    }
}