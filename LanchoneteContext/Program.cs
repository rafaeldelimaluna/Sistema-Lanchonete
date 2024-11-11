using System.Collections;
using Models;

var db = new LanchoneteContext.Database.LanchoneteContext();

var usuario = new Usuario();
var nivelAcesso = new NivelAcesso();


nivelAcesso.Nome="Admin";
nivelAcesso.TiposAcessos.Add(NivelAcesso.TiposAcesso.Estoque);
nivelAcesso.TiposAcessos.Add(NivelAcesso.TiposAcesso.Ingredientes);
nivelAcesso.TiposAcessos.Add(NivelAcesso.TiposAcesso.Pedidos);
nivelAcesso.TiposAcessos.Add(NivelAcesso.TiposAcesso.Produtos);

usuario.Nome = "Rafael";
usuario.NivelAcessoId = db.NivelAcesso.FirstOrDefault(x => x.Nome.Contains("Admin"))!.Id;
usuario.Senha = "123";





/*#region ConfigureService()

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LanchoneteContext.LanchoneteContext>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

#endregion

var app = builder.Build();

var serviceScope = app.Services.CreateScope();

*/