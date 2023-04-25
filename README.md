This is a sample .NET 7.0 CRUD (Create, Read, Update, Delete) application that uses PostgresQL as its database. 
The purpose of this application is to demonstrate how to perform basic CRUD operations with .NET 7.0 and PostgresQL.


## Instructions
### 1. Create PostgreSQL Database (RailWay.app recommended)
```https://railway.app/```
### 2. Add PostgreSQL database provider from NuGet
```dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL```
### 3. Create PostgreSQL Database from code with EF Core Migrations
```dotnet tool install -g dotnet-ef```
```dotnet add package Microsoft.EntityFrameworkCore.Design```
```dotnet ef migrations add InitialCreate```
```dotnet ef database update```
