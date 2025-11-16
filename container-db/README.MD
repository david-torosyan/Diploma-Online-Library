# PostgreSQL Docker Setup (Cross-Platform)

This project provides a fully portable PostgreSQL setup that works on:

- **Windows** (Docker Desktop or Podman)
- **macOS** (Docker Desktop or Podman)
- **Linux** (Docker Engine or Podman)

The setup exposes PostgreSQL on your **local machine** so you can connect using DBeaver, pgAdmin, or any client.

---

## 📦 docker-compose.yml

```yaml
services:
  container_postgres:
    image: postgres:16.6
    container_name: container_postgres
    shm_size: 128mb
    restart: always
    ports:
      - "15000:5432"   # host:container
    environment:
      POSTGRES_DB: postgres
      POSTGRES_USER: myUser
      POSTGRES_PASSWORD: myVerySecurePassword
    volumes:
      - local_pg_data:/var/lib/postgresql/data

volumes:
  local_pg_data:
```

---

# 🚀 Running the Database

### **Windows + Docker Desktop**
```powershell
docker compose up -d
```

### **macOS + Docker Desktop**
```bash
docker compose up -d
```

### **Linux (Docker Engine)**
```bash
docker compose up -d
```

### **Windows/macOS/Linux with Podman**
```bash
podman-compose up -d
```

> 💡 **If Podman is used:**  
> Ensure user-mode networking is enabled:  
> `podman machine init --user-mode-networking`  

---

# 🟢 Database Connection Info

| Setting | Value |
|--------|-------|
| **Host** | `localhost` |
| **Port** | `15000` |
| **Database** | `postgres` |
| **Username** | `myUser` |
| **Password** | `myVerySecurePassword` |

---

# 🖥 Connecting via DBeaver

1. Open DBeaver  
2. Click **New Database Connection**  
3. Select **PostgreSQL**  
4. Enter the following:

```
Host: localhost
Port: 15000
Database: postgres
Username: myUser
Password: myVerySecurePassword
```

5. Click **Test Connection**  
6. If drivers are missing, DBeaver will download them automatically  
7. Click **Finish**

You are now connected 🎉

---

# 🧪 Test the Connection (Optional CLI)

### Docker Desktop (Windows/macOS/Linux)
```bash
psql -h localhost -p 15000 -U myUser -d postgres
```

### Podman users (if `localhost` doesn’t work)
Check IP:
```bash
podman machine inspect
```
Then:
```bash
psql -h <Podman-VM-IP> -p 15000 -U myUser -d postgres
```

---

# 📂 Persistent Storage

All Postgres data is stored inside the Docker/Podman volume:

```
local_pg_data
```

This ensures:
- Data survives container restarts
- Works on all OSes
- No OS-specific file paths

To remove data entirely:

```bash
docker volume rm local_pg_data
```
or
```bash
podman volume rm local_pg_data
```

---

# 🛑 Stopping the Database

```bash
docker compose down
```

(Volume is NOT deleted.)

---

# 🔁 Restarting

```bash
docker compose restart
```

---

# 🧹 Removing Everything (containers + data)

```bash
docker compose down -v
```
or
```bash
podman-compose down -v
```

This will delete your database files.

---

# 🎉 Done!

You now have a fully cross-platform PostgreSQL environment  
that works on **Windows**, **macOS**, and **Linux**,  
with a simple and clean structure that all of your students can use.
