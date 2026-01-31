# Test2_Repo - Invoice API + UI

## What I added ✅
- ASP.NET Core Web API project setup (Program.cs, .csproj)
- EF Core with SQLite (seeded local `invoices.db`)
- `InvoiceController` exposing `GET /api/invoice`
- Swagger (Swagger UI at `/swagger`)
- Simple static UI (`wwwroot/index.html`) that fetches `/api/invoice`

## How to run 🔧
1. Ensure .NET 7 SDK is installed.
2. From the project folder run:
   - `dotnet restore`
   - `dotnet run`
3. Open these URLs in your browser:
   - **UI (Invoice):** http://localhost:5000/  ✅
   - **API (Swagger):** http://localhost:5000/swagger  ✅
