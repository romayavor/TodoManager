# 📝 TodoManager

Full-stack task management application built with ASP.NET Core Web API + Blazor WebAssembly + SQLite.

## 🛠️ Tech Stack

**Backend:**
- ASP.NET Core Web API (.NET 10)
- Entity Framework Core
- SQLite

**Frontend:**
- Blazor WebAssembly
- Bootstrap 5

## ✨ Features

- ✅ Create, Read, Update, Delete tasks (full CRUD)
- ✅ Mark tasks as completed
- ✅ Inline editing of task names
- ✅ Data persists between restarts (SQLite)
- ✅ REST API with Swagger documentation
- ✅ Blazor WebAssembly frontend

## 🚀 How to Run

1. Clone the repository:
git clone https://github.com/romayavor/TodoManager.git
2. Open `Code2.sln` in Visual Studio 2022

3. Set both projects as startup:
   - Right-click Solution → **Set Startup Projects**
   - Set `Code2` and `Code2.Client` to **Start**

4. Press `F5`

5. API runs on: `http://localhost:5159`
6. Swagger UI: `http://localhost:5159/swagger`
7. Frontend runs on: `http://localhost:5279`

## 📁 Project Structure
Code2/                  # ASP.NET Core Web API
├── Controllers/        # API endpoints
├── Models/             # Data models
├── Data/               # DbContext (Entity Framework)
└── Migrations/         # Database migrations
Code2.Client/           # Blazor WebAssembly
├── Pages/              # Razor components
└── Layout/             # App layout
## 👤 Author

Roman Yavorenko  
[GitHub](https://github.com/romayavor)
