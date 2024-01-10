using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using DapperDemoCSharp_41;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

//var repo = new DepartmentRepo(conn);

//repo.InsertDepartment("Other Cool Stuff");

//repo.DeleteDepartment(5);
//repo.DeleteDepartment(6);

//var departments = repo.GetAllDepartments();

//foreach (var department in departments)
//{
//    Console.WriteLine($"{department.DepartmentID} | {department.Name}");
//}

var repo = new ProductRepo(conn);

//repo.CreateProduct("Diablo 4", 60.00, 1, false, 1500);
//repo.UpdateProductName(940, "The Elder Scrolls III");
//repo.DeleteProduct(942);

var products = repo.GetAllProducts();

foreach (var product in products)
{
    Console.WriteLine($"{product.ProductID} | {product.Name} | {product.Price} | {product.CategoryID} | {product.OnSale} | {product.StockLevel}");
}