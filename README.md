
# Student CRUD API (ASP.NET Core Web API – Without Database)

This project is a simple ASP.NET Core Web API that demonstrates CRUD operations using an in-memory list (no database). Ideal for beginners learning Web API basics.

## Features
- Get all students
- Get student by ID
- Create a new student
- Update an existing student
- Delete a student
- Uses in-memory list (no DB)
- Swagger UI enabled

## Tech Stack
- ASP.NET Core Web API
- .NET 7 / .NET 8
- Swagger

## Student Model
public int Id { get; set; }
public string Name { get; set; }
public int Age { get; set; }
public string Department { get; set; }

## How to Run

1. Install .NET SDK
2. Clone repository:
   git clone https://github.com/yourusername/yourrepo.git
3. Navigate:
   cd yourrepo
4. Restore:
   dotnet restore
5. Build:
   dotnet build
6. Run:
   dotnet run

## Swagger URL
https://localhost:7004/swagger  
http://localhost:5000/swagger

## API Endpoints
GET /api/student  
GET /api/student/{id}  
POST /api/student  
PUT /api/student/{id}  
DELETE /api/student/{id}

## Notes
- No database used, data resets on restart.

