using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumEComp.Classes
{
    class Cliente
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {
        }

        public Cliente(string name, string email, DateTime dataNascimento)
        {
            Name = name;
            Email = email;
            DataNascimento = dataNascimento;
        }
    }
}
