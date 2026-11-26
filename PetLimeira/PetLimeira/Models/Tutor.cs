using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    [Table("tutores")]
    public class Tutor
    {
        [Key]
        [Column("id_tutor")]
        public int IdTutor { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("rua")]
        public string Rua { get; set; }

        [Column("numero")]
        public string Numero { get; set; }

        [Column("bairro")]
        public string Bairro { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("cep")]
        public string Cep { get; set; }

        [Column("fk_id_animal")]
        public int? FkIdAnimal { get; set; }
    }
}
