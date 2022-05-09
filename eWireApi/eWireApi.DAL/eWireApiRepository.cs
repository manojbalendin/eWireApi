using Dapper;
using eWireApi.Entities;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public class eWireApiRepository : IeWireApiRepository
    {
        protected readonly IConfiguration _config;
        public eWireApiRepository(IConfiguration config)
        {
            _config = config;
        }

        public MySqlConnection Connection
        {
            get
            {
                return new MySqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        public void Add(DemoEntities entity)
        {
            try
            {
                using (MySqlConnection dbConnection = this.Connection)
                {
                    dbConnection.Open();
                    string query = "INSERT INTO here";
                    dbConnection.Execute(query, entity);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<DemoEntities>> Get()
        {
            try
            {
                using (MySqlConnection dbConnection = this.Connection)
                {
                    dbConnection.Open();
                    string query = "Select * From here";
                    var result = await dbConnection.QueryAsync<DemoEntities>(query);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(int id)
        {
            try
            {
                using (MySqlConnection dbConnection = this.Connection)
                {
                    dbConnection.Open();
                    string query = "Delete Queryhere";
                    dbConnection.Execute(query, new { Id = id });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(DemoEntities entity)
        {
            try
            {
                using (MySqlConnection dbConnection = this.Connection)
                {
                    dbConnection.Open();
                    string query = "Update QUery here";
                    dbConnection.Execute(query, entity);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
