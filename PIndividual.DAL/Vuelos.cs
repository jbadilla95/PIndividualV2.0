//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIndividual.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vuelos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vuelos()
        {
            this.Paises_Destino_Aeropuerto = new HashSet<Paises_Destino_Aeropuerto>();
        }
    
        public int Id_vuelo { get; set; }
        public string Escala { get; set; }
        public int Duracion { get; set; }
        public bool Round_trip { get; set; }
        public string Tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paises_Destino_Aeropuerto> Paises_Destino_Aeropuerto { get; set; }
    }
}
