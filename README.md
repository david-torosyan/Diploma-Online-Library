# 📚 Online Library – Full Stack Application

## 🧩 Overview
**Online Library** is a full-stack web application that allows users to browse, read, and manage books online.  
It combines a modern **React** frontend and a robust **.NET 9 Web API** backend, integrated via REST APIs.  
This project also includes **Docker Compose** for simple multi-service deployment.

---

## 🏗️ Project Structure
```
Online Library/
├── Backend/
│   └── LibraryAPI/
│       ├── LibraryAPI.sln
│       ├── Library.DAL/
│       └── LibraryAPI/
│           ├── Controllers/
│           ├── Models/
│           ├── Services/
│           └── Program.cs
│
├── Frontend/
│   └── my-react-app/
│       ├── src/
│       ├── public/
│       ├── package.json
│       └── tsconfig.json
│
├── docker-compose.yml
├── START_Applications.bat
├── START_Containers.bat
└── STOP_Clean_Containers.bat
```

## 🚀 Features

### 🖥️ Frontend (React)
- Built with **React + TypeScript**
- **i18n** multilingual support (English, Armenian, Russian, Arabic, etc.)
- **AI-powered search assistant** integration
- Responsive and clean UI (Bootstrap)
- Supports JWT authentication

### ⚙️ Backend (.NET 9)
- Built with **ASP.NET Core Web API**
- **JWT-based authentication**
- **Entity Framework Core** with 3-layer architecture (DAL, BLL, API)
- **NSwag** integration for automatic TypeScript API client generation
- Local SQL database support

### 🐳 Docker
- Uses **docker-compose** to start both services
- Includes helper scripts for starting and stopping containers

---

## 🧠 Technologies Used
| Category | Technology |
|-----------|-------------|
| Frontend | React, TypeScript, i18next, Bootstrap |
| Backend | ASP.NET Core 9.0, Entity Framework Core, JWT Auth, NSwag |
| Database | Microsoft SQL Server (Local or Docker) |
| DevOps | Docker, Docker Compose |
| Tools | Visual Studio, VS Code, npm, Git |

---

## ⚙️ Getting Started

### 1️⃣ Clone the repository
```bash```

### 2️⃣ Run the Backend
``` cd Backend/LibraryAPI ```
``` dotnet restore ```
``` dotnet ef database update   # if using migrations ```
``` dotnet run ```

### 3️⃣ Run the Frontend
``` cd Frontend/my-react-app ```
``` npm install ``` 
``` npm start ```
Frontend will start at http://localhost:3000

### 4️⃣ Run with Docker
``` docker-compose up --build ```

🔐 Environment Variables
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=LibraryDB;Trusted_Connection=True;"
  },
  "JwtSettings": {
    "Secret": "your-secret-key",
    "Issuer": "LibraryAPI",
    "Audience": "LibraryUsers"
  }
}

🧪 API Documentation
https://localhost:5000/swagger

| Script                      | Description                                    |
| --------------------------- | ---------------------------------------------- |
| `START_Applications.bat`    | Starts both backend and frontend apps manually |
| `START_Containers.bat`      | Builds and starts all Docker containers        |
| `STOP_Clean_Containers.bat` | Stops and removes containers and networks      |



📄 License

This project is open-source and available under the MIT License.

💡 Author
👤 David Torosyan


---

Would you like me to make a slightly enhanced version with **badges** (for React, .NET, Docker, License, etc.) and maybe a **screenshot placeholder** section at the top for when you add images later? It’ll make it look like a polished portfolio README.

git clone https://github.com/david-torosyan/Dimploma-Online-Libarary.git
cd Dimploma-Online-Libarary
