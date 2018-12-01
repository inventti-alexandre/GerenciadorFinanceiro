﻿// <auto-generated />
using System;
using Gerenciador_Financeiro.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gerenciador_Financeiro.Migrations
{
    [DbContext(typeof(GerenciadorFinanceiroContext))]
    [Migration("20181201002900_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Conta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(150);

                    b.Property<long?>("ID_USUARIO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("ID_USUARIO");

                    b.ToTable("CONTA");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Despesa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataDespesa")
                        .HasColumnName("DATA_DESPESA");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<long?>("ID_CONTA");

                    b.HasKey("Id");

                    b.HasIndex("ID_CONTA");

                    b.ToTable("DESPESA");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Receita", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataReceita")
                        .HasColumnName("DATA_RECEITA");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<long?>("ID_CONTA");

                    b.HasKey("Id");

                    b.HasIndex("ID_CONTA");

                    b.ToTable("RECEITA");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("USUARIO");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Conta", b =>
                {
                    b.HasOne("Gerenciador_Financeiro.Model.Usuario", "Usuario")
                        .WithMany("Contas")
                        .HasForeignKey("ID_USUARIO");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Despesa", b =>
                {
                    b.HasOne("Gerenciador_Financeiro.Model.Conta", "Conta")
                        .WithMany("Despesas")
                        .HasForeignKey("ID_CONTA");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Receita", b =>
                {
                    b.HasOne("Gerenciador_Financeiro.Model.Conta", "Conta")
                        .WithMany("Receitas")
                        .HasForeignKey("ID_CONTA");
                });
#pragma warning restore 612, 618
        }
    }
}
