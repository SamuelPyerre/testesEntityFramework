using Banco.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Banco.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {

        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            //NOME DA TABELA NO BANCO
            builder.ToTable("Cliente");
            //CHAVE PRIMARIA
            builder.HasKey(x=> x.Id);
            //IDENTITY
            builder.Property(x=> x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(); // (1,1)
            
            //OUTRAS PROPRIEDADES
            builder.Property(x=> x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x=> x.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);

        }
    }
}