
using BD_AUTO.DAL;
using BD_AUTO.Models;

namespace BD_AUTO.BLL
{
    public class AutoBLL
    {
        private readonly AutoDAL autoDAL;

        public AutoBLL(AutoDAL autoDAL)
        {
            this.autoDAL = autoDAL;
        }

        public List<Auto> Listar()
        {
            return autoDAL.Listar();
        }

        public Auto Buscar(int id)
        {
            return autoDAL.Buscar(id);
        }

        public void Insertar(Auto auto)
        {
            autoDAL.Insertar(auto);
        }

        public void Actualizar(Auto auto)
        {
            autoDAL.Actualilzar(auto);
        }

        public void Eliminar(int id)
        {
            autoDAL.Eliminar(id);
        }
    }
}
