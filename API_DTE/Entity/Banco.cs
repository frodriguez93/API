using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_DTE.Entity
{
    public class Banco : EntityBase
    {
        #region Propiedades
        [Key]
        [Required]
        [Column("iBancoID")]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [Column("vcNombre")]
        [MaxLength(100, ErrorMessage = "Se ha superado el largo máximo permitido para el campo")]
        public string Nombre { get; set; }

        [Required]
        [Column("vcCodigoBanco")]
        [MaxLength(10, ErrorMessage = "Se ha superado el largo máximo permitido para el campo")]
        public string Codigo { get; set; }
        #endregion

        #region Constructor
        public Banco() : base() { }
        #endregion
    }

    
}
