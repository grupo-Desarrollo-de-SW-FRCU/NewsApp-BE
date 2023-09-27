using System;
using System.ComponentModel.DataAnnotations;

namespace NewsApp.Accesses
{
    public class CreateUpdateAccessDto
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime fechayHoraIngreso { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.Date)]
        public DateTime fechayHoraEgreso { get; set; }
    }
}
