using eWireApi.Entities.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public class SchemeRepository : ISchemeRepository
    {
        protected readonly IConfiguration _config;
        public SchemeRepository(IConfiguration config)
        {
            _config = config;
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public async Task<SchemeDetails> SchemeDetails(RequestBaseModel request)
        {
            throw new NotImplementedException();
        }
    }
}
