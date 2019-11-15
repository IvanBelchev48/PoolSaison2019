using System;
using System.ComponentModel.DataAnnotations;

namespace PoolSaison2019.Models
{
    public class Joueur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Equipe { get; set; }
        public string Position { get; set; }
        public int Salaire { get; set; }
    }
}
