using ProyectoASP.Models;


namespace proyectoASPNET.Datos
{
    public class PersonaAdmin
    {

        public IEnumerable<Persona> Consultar()
        {
            {
                using (PruebamvccoreContext contexto = new PruebamvccoreContext())
                {
                    return contexto.Personas.ToList();
                }
            }
        }

        //Guarda personas en la base de datos
        public void Guardar(Persona modelo)
        {
            using (PruebamvccoreContext contexto = new PruebamvccoreContext())
            {
                contexto.Personas.Add(modelo);
                contexto.SaveChanges();
            }
        }

    }
}
