﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PBT.API.Data;

namespace PBT.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210122174738_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("PBT.API.Model.CSessao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<string>("DataDaSessao");

                    b.Property<string>("Local");

                    b.Property<string>("NomeCliente");

                    b.Property<string>("NomeSessao");

                    b.Property<int>("QtdPessoas");

                    b.Property<int>("SessaoId");

                    b.HasKey("Id");

                    b.ToTable("CSessao");
                });

            modelBuilder.Entity("PBT.API.Model.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataCadastro");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PBT.API.Model.Sessao", b =>
                {
                    b.Property<int>("SessaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Local");

                    b.Property<decimal>("Preco");

                    b.Property<string>("Sesssao");

                    b.HasKey("SessaoId");

                    b.ToTable("Sessoes");
                });
#pragma warning restore 612, 618
        }
    }
}
