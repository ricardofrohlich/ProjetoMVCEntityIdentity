using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoMVCEntityIdenty.Models;

namespace ProjetoMVCEntityIdenty.DAL
{
    public class AppContexto : IdentityDbContext
    {
        public AppContexto(DbContextOptions<AppContexto> options) : base (options) 
        {
            
        }
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    AlunoId = 1,
                    Nome = "Ricardo",
                    Email = "ricardo@frohlich.inf.br",
                    Idade = 39,
                    Curso = "Engenharia da Computação"
                });
        }

    }
}
