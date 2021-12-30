using System;
using System.Globalization;

namespace VctHotel
{
    public class Rooms
    {
        public string Name { get; set; }
        public string Email { get; private set; }

        public Rooms(string nome, string email)
        {
            Name = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
