using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;

namespace AA.Star_Locator
{
    public class starsRepo : IStarsRepo
    {
        private readonly IDbConnection _connection;
        public starsRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<stars> GetStars()
        {
            return _connection.Query<stars>("SELECT * FROM stars;").ToList(); //add in actualname of SQL table
        }

    }
}
