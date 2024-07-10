using UsuariosRoles.Models;
using UsuariosRoles.Models;
namespace UsuariosRoles.Data
{
    public class DA_Logica
    {
        public List<Usuario> ListaUsuario()
        {
            return new List<Usuario>
            {
                new Usuario { Nombre = "Jose", Correo = "Administrador@gmail.com", Clave = "123", Roles = new string[] { "Administrador" } },
                new Usuario { Nombre = "maria", Correo = "Supervisor@gmail.com", Clave = "123", Roles = new string[] { "Supervisor" } },
                new Usuario { Nombre = "Juan", Correo = "Empleado@gmail.com", Clave = "123", Roles = new string[] { "Empleado" } },
                new Usuario { Nombre = "Oscar", Correo = "Superempleado@gmail.com", Clave = "123", Roles = new string[] { "Supervisor", "Empleado" } }

            };
        }

        public Usuario ValidarUsuario(string _correo, string _clave)
        {
            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();
        }
    }
}
