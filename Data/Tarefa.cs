using System.ComponentModel.DataAnnotations.Schema;
namespace OlifransMinimalApiVsCode.Data;

[Table("Tarefas")]
public record Tarefa(int Id, string Atividade, string Status);
