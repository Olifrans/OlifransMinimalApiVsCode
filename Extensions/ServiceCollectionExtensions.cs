using System.Data.SqlClient;
using static OlifransMinimalApiVsCode.Data.OlifransContext;

namespace OlifransMinimalApiVsCode.Extensions;

public static class ServiceCollectionExtensions
{
    public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<GetConnection>(options => async () =>
        {
                //Cenexao ao Context BD
                var conectarBancoDados = builder.Configuration.GetConnectionString("OlifransConnection");
            var connection = new SqlConnection(conectarBancoDados);
            await connection.OpenAsync();

            return connection;
        });
        return builder;
    }

}
