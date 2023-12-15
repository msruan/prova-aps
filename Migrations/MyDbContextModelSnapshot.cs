﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using estoque.Models;

#nullable disable

namespace estoque.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("estoque.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("estoque.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<int>("Percentual")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("estoque.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("estoque.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Tipo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TipoDePagamentoId")
                        .HasColumnType("int");

                    b.Property<int?>("TransportadoraId")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TipoDePagamentoId");

                    b.HasIndex("TransportadoraId");

                    b.HasIndex("VendedorId");

                    b.ToTable("NotaDeVenda");
                });

            modelBuilder.Entity("estoque.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("estoque.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("estoque.Models.TipoDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrado")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoDePagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TipoDePagamento");
                });

            modelBuilder.Entity("estoque.Models.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Transportadora");
                });

            modelBuilder.Entity("estoque.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("estoque.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("estoque.Models.TipoDePagamento");

                    b.Property<string>("Bandeira")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroDoCartao")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("estoque.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("estoque.Models.TipoDePagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroDoCheque")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("estoque.Models.Item", b =>
                {
                    b.HasOne("estoque.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Itens")
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("estoque.Models.Produto", "Produto")
                        .WithMany("Itens")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("estoque.Models.NotaDeVenda", b =>
                {
                    b.HasOne("estoque.Models.Cliente", "Cliente")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("estoque.Models.TipoDePagamento", "TipoDePagamento")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("TipoDePagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("estoque.Models.Transportadora", "Transportadora")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("TransportadoraId");

                    b.HasOne("estoque.Models.Vendedor", "Vendedor")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TipoDePagamento");

                    b.Navigation("Transportadora");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("estoque.Models.Pagamento", b =>
                {
                    b.HasOne("estoque.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Pagamentos")
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("estoque.Models.Produto", b =>
                {
                    b.HasOne("estoque.Models.Marca", "Marca")
                        .WithMany("Produtos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("estoque.Models.Cliente", b =>
                {
                    b.Navigation("NotasDeVenda");
                });

            modelBuilder.Entity("estoque.Models.Marca", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("estoque.Models.NotaDeVenda", b =>
                {
                    b.Navigation("Itens");

                    b.Navigation("Pagamentos");
                });

            modelBuilder.Entity("estoque.Models.Produto", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("estoque.Models.TipoDePagamento", b =>
                {
                    b.Navigation("NotasDeVenda");
                });

            modelBuilder.Entity("estoque.Models.Transportadora", b =>
                {
                    b.Navigation("NotasDeVenda");
                });

            modelBuilder.Entity("estoque.Models.Vendedor", b =>
                {
                    b.Navigation("NotasDeVenda");
                });
#pragma warning restore 612, 618
        }
    }
}
