using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_DTE.Entity
{
    public abstract class EntityBase
    {
        #region Atributos
        [Required]
        [Column("bActivo")]
        public bool Activo { get; set; }

        [Required]
        [Column("iUsuarioCreacionID")]
        public int UsuarioCreacionID { get; set; }

        [Required]
        [Column("dtmCreacion")]
        public DateTime FechaCreacion { get; set; }

        [Column("iUsuarioUltModificacionID")]
        public int? UsuarioUltModificacionID { get; set; }

        [Column("dtmUltModificacion")]
        public DateTime? FechaUltModificacion { get; set; }

        [Column("iUsuarioAnulacionID")]
        public int? UsuarioAnulacionID { get; set; }

        [Column("dtmAnulacion")]
        public DateTime? FechaAnulacion { get; set; }
        #endregion

        #region Constructor
        public EntityBase() { }
        #endregion
    }
}
