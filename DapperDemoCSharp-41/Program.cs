﻿using System;
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

var repo = new DepartmentRepo(conn);

repo.InsertDepartment("Other Cool Stuff");

var departments = repo.GetAllDepartments();

foreach (var department in departments)
{
    Console.WriteLine($"{department.DepartmentID} | {department.Name}");
}