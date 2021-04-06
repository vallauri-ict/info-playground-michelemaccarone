﻿using System;

namespace _4_026_Stagisti
{
    class Stagista : Alunno
    {
        #region attributi
        private string azienda;
        private int ore;
        #endregion

        internal string Azienda { get => azienda; set => azienda = value; }

        internal string Ore
        {
            get {
                return ore.ToString();
            }
            set
            {
                if (Convert.ToInt32(value) < 1)
                {
                    throw new Exception("Numero ore non valido");
                }
                else ore = Convert.ToInt32(value);
            }
        }

        public Stagista(string nome, string cognome, string citta, string classe, string sezione,
            string spec, string azienda, string ore)
            : base(nome, cognome, citta, classe, sezione, spec)
        {
            Azienda = azienda;
            Ore = ore;
        }

        public override string visualizza()
        {
            return base.visualizza() + " " + Azienda + " " + Ore;
        }
    }
}
