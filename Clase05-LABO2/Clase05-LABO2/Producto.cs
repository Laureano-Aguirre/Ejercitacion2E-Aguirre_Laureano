using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05_LABO2
{
    internal class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigo;
        }
        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DATOS DEL PRODUCTO: ");
            sb.AppendLine($"Codigo de barra: {(string)p}");
            sb.AppendLine($"Marca: {p.marca}");
            sb.AppendLine($"Precio: {p.precio}");

            return sb.ToString();
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {

            if (p.codigoDeBarra == marca)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if(!(p1 is null || p2 is null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
    }
}
