// See https://aka.ms/new-console-template for more information
using InroEFCore.Data;
using InroEFCore.Models;

Console.WriteLine("Hello, World!");

var dbContext = new BookStoreDbContext();

Author author = new() { Name = "Jules", LastName = "Verne" };
dbContext.Authors.Add(author);
dbContext.Books.Add(new() { Title = "Denizler Altında 20.000 Fersah", Description = "Açıklama", Authors = new List<Author> { author } });

dbContext.SaveChanges();