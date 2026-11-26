using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    [Table("animais")]
    public class Animal
    {
        [Key]
        [Column("id_animal")]
        public int IdAnimal { get; set; }

        [Column("nome")]
        public String Nome { get; set; }

        [Column("especie")]
        public string Especie { get; set; }

        [Column("raca")]
        public string Raca { get; set; }

        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("peso")]
        public decimal Peso { get; set; }

        [Column("situacao")]
        public string Situacao { get; set; }

        [Column("fk_id_tutor")]
        public int? FkIdTutor { get; set; }
    }
}
