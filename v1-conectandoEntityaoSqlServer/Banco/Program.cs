// See https://aka.ms/new-console-template for more information
using Banco.Data;
using Banco.Models;

using (var context = new BancoDataContext())
{
    var cliente = new ClienteModel {Nome = "Teste01", Email = "teste01@email.com"};
    context.Clientes.Add(cliente);
    context.SaveChanges();
}