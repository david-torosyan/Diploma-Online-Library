# 📚 Online Library – Full Stack Application

## 🧾 Overview
**Online Library** is a full-stack web application that enables users to browse, search, and manage books online.  
It’s built with a **React + TypeScript** frontend and a **.NET 10 Web API** backend, orchestrated with **Docker Compose** for easy multi-service deployment.

---

## 🏗️ Project Structure
```
Dimploma-Online-Library/
├── Backend/
│   └── LibraryAPI/
│       ├── Controllers/
│       ├── Models/
│       ├── Services/
│       ├── LibraryAPI.csproj
│       ├── Dockerfile
│       └── Program.cs
│
├── Frontend/
│   └── my-react-app/
│       ├── src/
│       ├── public/
│       ├── package.json
│       ├── tsconfig.json
│       └── Dockerfile
│
├── docker-compose.yml
├── .gitignore
├── .dockerignore
│
├── START_Applications.bat
├── START_Containers.bat
├── STOP_Clean_Containers.bat
│
└── .github/workflows/ci.yml
```

---

## ✨ Features

### 🌐 Frontend (React + TypeScript)
- Modern UI built with **Bootstrap 5**
- **Multilingual support** (EN, HY, RU, AR, DE, ES, FR)
- **AI assistant integration**
- JWT-based authentication
- Fully responsive for desktop and mobile devices

### ⚙️ Backend (.NET 9 Web API)
- **Three-layer architecture** (DAL, BLL, API)
- **Entity Framework Core** with SQL Server
- **JWT authentication & authorization**
- **NSwag** for automatic TypeScript client generation
- Global exception handling (ready for Serilog integration)
- Designed for unit testing (xUnit support)

### 🐳 Docker & DevOps
- Full **Docker Compose** orchestration for backend, frontend, and SQL Server
- **GitHub Actions CI** for automated build verification
- Expandable for AWS or Docker Hub deployments

---

## 🧠 Technologies Used

| Category | Technologies |
|-----------|---------------|
| **Frontend** | React 18, TypeScript, i18next, Bootstrap |
| **Backend** | ASP.NET Core 10.0, Entity Framework Core, NSwag, JWT |
| **Database** | Microsoft SQL Server 2022 |
| **DevOps** | Docker, Docker Compose, GitHub Actions |
| **Tools** | Visual Studio 2022, VS Code, npm, Git |

---

## ⚙️ Getting Started

### 🧩 Prerequisites
- .NET 9 SDK  
- Node.js 20+  
- Docker Desktop Or Podaman (with docker-compose)
- SQL Server (local or Docker)

---

### 🚀 1️⃣ Clone the Repository
```bash
git clone https://github.com/david-torosyan/Dimploma-Online-Libarary.git
cd Dimploma-Online-Libarary
```

---

### 🖥️ 2️⃣ Run the Application (Two Options)

#### 🅰️ **Option 1 — Run Locally (No Containers)**
Run the script:

```bash
START_Applications.bat
```

This script will:
- Start the **backend** using `dotnet run`  
- Start the **frontend** using `npm start`  
- Connect them locally (using your local development environment)

Access:
- Frontend → http://localhost:3000  
- Backend → http://localhost:5000  

---

#### 🅱️ **Option 2 — Run Inside Docker Containers**
Run the script:

```bash
START_Containers.bat
```

This script will:
- Build Docker images for all services (backend, frontend, database)  
- Start containers using `docker-compose up --build`  
- Automatically run the full application stack inside containers

Access:
- Frontend → http://localhost:3000  
- Backend API → http://localhost:5000/swagger/index.html

---

#### 🧹 **Option 3 — Stop and Clean Everything**
Run the cleanup script:

```bash
STOP_Clean_Containers.bat
```

This script will:
- Stop all running containers  
- Remove all Docker containers, images, and volumes related to the project  
- Ensure a completely clean Docker environment (useful for resetting everything)

---

## ⚙️ Environment Variables

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=db,1433;Database=LibraryDb;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;"
  },
  "JwtSettings": {
    "Secret": "your-secret-key",
    "Issuer": "LibraryAPI",
    "Audience": "LibraryUsers"
  }
}
```

---

## 🧪 CI/CD (GitHub Actions)

The repository includes a GitHub Action at `.github/workflows/ci.yml`:

```yaml
- name: 🔨 Build all docker-compose services
  run: docker compose -f docker-compose.yml build
```

✅ This workflow automatically verifies that:
- Backend (.NET 9) builds successfully  
- Frontend (React) compiles without errors  
- Dockerfiles and `docker-compose.yml` are valid  
- All images are created successfully  

---

## 📖 API Documentation
Once the backend is running, Swagger UI is available at:  
👉 **http://localhost:5000/swagger**

---

## 🧭 Future Improvements
- Add xUnit + Moq test coverage  
- Integrate Serilog and global exception handling  
- Extend CI/CD to auto-deploy on AWS ECS or ECR  
- Add caching (Redis) and request performance metrics  
- Implement role-based access control (Admin/User)

---

## 👨‍💻 Author
**David Torosyan**  
📧 [LinkedIn Profile](https://www.linkedin.com/in/davit-torosyan)
🖥️ [GitHub Profile](https://github.com/david-torosyan)

---

## 📝 License
This project is open-source and available under the **MIT License**.

---

> 🚀 *A production-ready full-stack demo combining React, .NET 9, SQL Server, and Docker — engineered for scalability, clean architecture, and modern CI/CD pipelines.*
