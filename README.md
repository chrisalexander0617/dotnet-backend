This is a sample .NET 7.0 CRUD (Create, Read, Update, Delete) application that uses PostgresQL as its database. 
The purpose of this application is to demonstrate how to perform basic CRUD operations with .NET 7.0 and PostgresQL.


## Instructions
### 1. Create PostgreSQL Database (RailWay.app recommended)
```https://railway.app/```


![postgres](https://user-images.githubusercontent.com/44784345/234330075-ffbc4c59-7693-4527-aaec-88864cedc07c.png)

Replace the variables in `appsettings.json` with the credentials from your PostgreSQL instance
```
  "ConnectionStrings": {
    "WebApiDatabase": "Host={host}; Database={database; port={port}; Username={user}; Password={password}"
},
```

### 2. Add PostgreSQL database provider from NuGet
```dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL```

### 3. Create PostgreSQL Database from code with EF Core Migrations
```dotnet tool install -g dotnet-ef```

#### 4. Add EF Core Design package from NuGet
```dotnet add package Microsoft.EntityFrameworkCore.Design```

#### 4. Generate EF Core migrations
```dotnet ef migrations add <Name of migration>```

#### 5. Execute EF Core migrations
```dotnet ef database update```
