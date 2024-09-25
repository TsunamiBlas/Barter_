//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barter
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carrito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carrito()
        {
            this.Producto = new HashSet<Producto>();
            this.Usuario = new HashSet<Usuario>();
            this.Producto_Usuario = new HashSet<Producto_Usuario>();
        }
    
        public int Id_Carrito { get; set; }
        public string Cantidad_Carrito { get; set; }
        public string Numero_Tarjeta_Carrito { get; set; }
        public string Banco_Carrito { get; set; }
        public System.DateTime Fecha_Vencimiento_Carrito { get; set; }
        public string CVV_Carrito { get; set; }
        public decimal Total_Carrito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto_Usuario> Producto_Usuario { get; set; }
    }
}
