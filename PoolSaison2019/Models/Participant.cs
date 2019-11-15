using System;
using System.ComponentModel.DataAnnotations;

namespace PoolSaison2019.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Gains { get; set; }
    }
}
