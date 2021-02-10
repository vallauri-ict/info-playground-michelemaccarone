﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_023_ClasseAstratta
{
    class Studente
    {
        public string Nome { get; set; }
        private string Cognome { get; set; }

        private DateTime dataNascista;

        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public string nomeCompleto()
        {
            return Nome + " " + Cognome;
        }
    }
}
