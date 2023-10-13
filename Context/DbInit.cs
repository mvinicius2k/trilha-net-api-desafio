using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;

namespace TrilhaApiDesafio.Context
{
    public class DbInit
    {
        private readonly OrganizadorContext _context;

        public DbInit(OrganizadorContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Cria e usa o banco de dados
        /// </summary>
        public void Initialize()
            =>  _context.Database.EnsureCreated();
    }
}
