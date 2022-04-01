using Dapper.Contrib.Extensions;
using static OlifransMinimalApiVsCode.Data.OlifransContext;
using OlifransMinimalApiVsCode.Data;



namespace OlifransMinimalApiVsCode.Endpoints
{
    public static class EndpointsTarefas
    {
        public static void MapEndpointsTarefas(this WebApplication app)
        {
            //get all
            app.MapGet("/tarefas", async (GetConnection getDbConnection) =>
            {
                using var con = await getDbConnection();
                return con.GetAll<Tarefa>().ToList();
            });


            //get id
            app.MapGet("/tarefas/{id}", async (GetConnection getDbConnection, int id) =>
            {
                using var con = await getDbConnection();
                return con.Get<Tarefa>(id);
            });


            //post
            app.MapPost("/tarefas", async (GetConnection getDbConnection, Tarefa tarefa) =>
            {
                using var con = await getDbConnection();
                var id = con.Insert(tarefa);
                return Results.Created($"/tarefas{id}", tarefa);
            });


            //put
            app.MapPut("/tarefas", async (GetConnection getDbConnection, Tarefa tarefa) =>
            {
                using var con = await getDbConnection();
                var id = con.Update(tarefa);
                return Results.Ok("Atividade atualizada com sucesso");
            });


            //delete
            app.MapDelete("/tarefas/{id}", async (GetConnection getDbConnection, int id) =>
            {
                using var con = await getDbConnection();
                con.Delete(new Tarefa(id, "", ""));
                return Results.Ok("Atividade excluida com sucesso");
            });
        }
    }
}