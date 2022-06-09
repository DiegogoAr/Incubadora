//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Incubadora.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatCarreras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatCarreras()
        {
            this.DatosLaborales = new HashSet<DatosLaborales>();
            this.Estudiantes = new HashSet<Estudiantes>();
        }
    
        public string Id { get; set; }
        public string StrValor { get; set; }
        public string StrDescripcion { get; set; }
        public int IdStatus { get; set; }
        public string IdUnidadAcademica { get; set; }
    
        public virtual CatUnidadesAcademicas CatUnidadesAcademicas { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosLaborales> DatosLaborales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estudiantes> Estudiantes { get; set; }
    }
}
