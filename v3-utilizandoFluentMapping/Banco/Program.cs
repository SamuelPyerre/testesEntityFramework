// See https://aka.ms/new-console-template for more information
using Banco.Data;
using Banco.Models;

using var context = new BancoDataContext();

var cliente1 = new ClienteModel{
    Nome = "Teste04",
    Email = "teste04@email.com"
};

var cliente2 = new ClienteModel{
    Nome = "Teste05",
    Email = "teste05@email.com"
};

context.Clientes.Add(cliente1);
context.Clientes.Add(cliente2);
context.SaveChanges();
