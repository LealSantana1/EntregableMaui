using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAppCrud.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Categoria_id{ get; set; }
        public virtual Categoria RefCategoria { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
       
    }
}
