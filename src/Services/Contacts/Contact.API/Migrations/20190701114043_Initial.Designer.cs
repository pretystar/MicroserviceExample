﻿// <auto-generated />
using System;
using Contact.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contact.API.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20190701114043_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contact.API.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("contact");
                });

            modelBuilder.Entity("Contact.API.Models.ContactList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FContact")
                        .HasColumnName("f_contact");

                    b.Property<int>("FList")
                        .HasColumnName("f_list");

                    b.HasKey("Id");

                    b.HasIndex("FContact");

                    b.HasIndex("FList");

                    b.ToTable("contact_list");
                });

            modelBuilder.Entity("Contact.API.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(250);

                    b.Property<string>("ListName")
                        .HasColumnName("list_name")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentId")
                        .HasColumnName("parent_id");

                    b.HasKey("Id");

                    b.ToTable("list");
                });

            modelBuilder.Entity("Contact.API.Models.ContactList", b =>
                {
                    b.HasOne("Contact.API.Models.Contact", "FContactNavigation")
                        .WithMany("ContactLists")
                        .HasForeignKey("FContact")
                        .HasConstraintName("FK__contact_l__f_con__37A5467C");

                    b.HasOne("Contact.API.Models.List", "FListNavigation")
                        .WithMany("ContactLists")
                        .HasForeignKey("FList")
                        .HasConstraintName("FK__contact_l__f_lis__38996AB5");
                });
#pragma warning restore 612, 618
        }
    }
}
