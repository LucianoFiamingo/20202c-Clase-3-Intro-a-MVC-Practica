using System;

namespace Entidades
{
    public class Alimento
    {
        public Guid UniqueID { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Peso { get; set; }
    }
}
