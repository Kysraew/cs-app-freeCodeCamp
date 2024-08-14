using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{

    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";

        public PersonModel CreatePerson(PersonModel model)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db));

            var p = new DynamicParameters();
            p.Add("@FirstName", model.FirstName);
            p.Add("@LastName", model.LastName);
            p.Add("@EmailAddress", model.EmailAddress);
            p.Add("@CellphoneNumber", model.CellphoneNumber);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");

            return model;
        }

        // TODO Make the CreatePrize method save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, inc</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db));

            var p = new DynamicParameters();
            p.Add("@PlaceNumber", model.PrizeNumber);
            p.Add("@PlaceName", model.PrizeName);
            p.Add("@PrizeAmount", model.PrizeAmount);
            p.Add("@PrizePercentage", model.PrizePercentage);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");
            string a;

            return model;
        }

        public List<PersonModel> GetPersonAll()
        {
            List<PersonModel> output;
            
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db));

            output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();

            return output;
        }
    }
}