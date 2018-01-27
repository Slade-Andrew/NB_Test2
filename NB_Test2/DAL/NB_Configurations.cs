using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace NB_Test2.DAL
{
    public class NB_Configurations : DbConfiguration
    {
        public NB_Configurations()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}