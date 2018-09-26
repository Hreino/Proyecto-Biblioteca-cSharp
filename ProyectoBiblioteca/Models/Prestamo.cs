//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBiblioteca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Prestamo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prestamo()
        {
            this.detallePrestamo = new HashSet<detallePrestamo>();
            this.Devoluciones = new HashSet<Devoluciones>();
        }
    
        public int Id_prestamo { get; set; }
        [DataType(DataType.Date,ErrorMessage ="El formato de fecha es incorrecto")]
        public System.DateTime Fecha_entrega { get; set; }
        [DataType(DataType.Date, ErrorMessage = "El formato de fecha es incorrecto")]
        public Nullable<System.DateTime> Fecha_devolucion { get; set; }
        
        public string Estado { get; set; }
        public int Id_usuario { get; set; }
        public int Id_cliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detallePrestamo> detallePrestamo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devoluciones> Devoluciones { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}