using System.Data;

namespace OlifransMinimalApiVsCode.Data
{
    public class OlifransContext
    {
        public delegate Task<IDbConnection> GetConnection();
    }
}