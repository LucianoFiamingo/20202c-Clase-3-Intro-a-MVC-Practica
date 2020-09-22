using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Servicios
{
    public class AlimentoServicio
    {
            private static List<Alimento> Lista = new List<Alimento>();

            public List<Alimento> ObtenerTodos()
            {
                return Lista;
            }

            public void Crear(Alimento alimento)
            {
                int maxId = 0;
                if (Lista.Count > 0)
                {
                    maxId = Lista.Max(o => o.Id);
                }

            alimento.Id = maxId + 1;

            alimento.UniqueID = Guid.NewGuid();

                Lista.Add(alimento);
            }

            public void EliminarConFor(int id)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    Alimento alimento = Lista[i];
                    if (alimento.Id == id)
                    {
                        Lista.RemoveAt(i);
                        return;
                    }
                }
            }

            public void Eliminar(int id)
            {
                Lista.RemoveAll(o => o.Id == id);
            }

            public Alimento ObtenerPorId(int id)
            {
                //Lista.Where(o => o.Apellido == "argento").FirstOrDefault();
                return Lista.Find(o => o.Id == id);
            }

            public void Modificar(Alimento alimento)
            {
                Alimento alimentoActual = ObtenerPorId(alimento.Id);
            alimentoActual.Descripcion = alimento.Descripcion;
            }
    }
}
