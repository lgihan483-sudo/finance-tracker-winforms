# 💰 Personal Expense & Income Tracker

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?logo=csharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Windows Forms](https://img.shields.io/badge/GUI-Windows_Forms-0078D6?logo=windows&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
[![Database](https://img.shields.io/badge/Database-MS_SQL_Server_LocalDB-CC292B?logo=microsoftsqlserver&logoColor=white)](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A modern desktop application built using **C# (.NET 8 Windows Forms)** and **Microsoft SQL Server (LocalDB)** designed for personal financial management. It allows users to monitor real-time income, track day-to-day expenses, categorize cashflows, and analyze financial reports.

---

## 📌 Key Features

- **🔐 User Authentication**: Secure User Registration & Login system with password verification and validation against duplicate accounts.
- **📊 Interactive Financial Dashboard**:
  - Real-time display of **Today's**, **This Month's**, and **This Year's** total Income.
  - Real-time display of **Today's**, **This Month's**, and **This Year's** total Expenses.
  - Dynamic **Monthly Balance Indicator** with conditional color coding (Green for surplus, Red for deficit).
- **💵 Income Management**:
  - Add, update, view, and delete income streams.
  - Record amount, source item, category, description, and transaction date.
  - Responsive `DataGridView` with quick selection for instant updates.
- **💳 Expense Management**:
  - Track day-to-day spending with categories and descriptions.
  - Complete CRUD operations with real-time balance updates.
- **🏷️ Category Customization**:
  - Categorize both income and expenses (e.g., Salary, Investments, Food, Bills, Groceries).
  - Manage status (Active / Inactive) for seamless organization.
- **📈 Reports & Advanced Search**:
  - Search and filter records flexibly by Date, Month, or Year.
  - Tabular report view for financial audits and tracking.
- **⚙️ Dynamic Database Attachment**:
  - Built-in `DatabaseConfig` helper automatically locates and attaches the local `.mdf` file across debug and development environments without hardcoded paths.

---

## 🛠️ Technology Stack

| Layer | Technology |
|---|---|
| **Programming Language** | C# (.NET 8.0) |
| **Framework** | Windows Forms (WinForms) |
| **Data Access** | ADO.NET (`Microsoft.Data.SqlClient`) |
| **Database** | Microsoft SQL Server LocalDB (`(LocalDB)\MSSQLLocalDB`) / MDF |
| **IDE** | Microsoft Visual Studio 2022 |

---

## 📸 Screenshots

> *Tip: Take screenshots of your running app and place them in an `assets/` or `screenshots/` folder.*

| Dashboard Overview | Income & Expense Management |
| :---: | :---: |
| *(Add Dashboard Screenshot here)* | *(Add Income/Expense Screenshot here)* |

| Category Management | Reports & Filtering |
| :---: | :---: |
| *(Add Category Screenshot here)* | *(Add Reports Screenshot here)* |

---

## 📂 Project Structure

```text
cmzz/
├── 1dashborduc.cs / .Designer.cs       # Dashboard UserControl (Analytics & Balance)
├── 2incomeuc.cs / .Designer.cs         # Income UserControl (CRUD operations)
├── 3expenseuc.cs / .Designer.cs        # Expense UserControl (CRUD operations)
├── 4categoryuc.cs / .Designer.cs       # Category Management UserControl
├── 5reports.cs / .Designer.cs          # Financial Reports & Filtering
├── form1login.cs / .Designer.cs        # Login Form
├── form2register.cs / .Designer.cs     # Registration Form
├── form3dashbord.cs / .Designer.cs     # Main Navigation Container
├── DatabaseConfig.cs                   # Dynamic SQL Connection & Path Resolver
├── database_schema.sql                 # SQL Table Schemas
├── logincm.mdf / logincm_log.ldf       # LocalDB database files
└── Program.cs                          # Application Entry Point
```

---

## 🚀 Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher.
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with **.NET Desktop Development** workload installed.
- **SQL Server Express LocalDB** (included by default with Visual Studio Desktop Development).

### Installation & Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/lgihan483-sudo/finance-tracker-winforms.git
   cd finance-tracker-winforms
   ```

2. **Open the Project:**
   - Double-click `cmzz.csproj` to open the solution in Visual Studio.

3. **Restore Dependencies & Build:**
   ```bash
   dotnet restore
   dotnet build
   ```

4. **Run the Application:**
   - Press `F5` in Visual Studio or execute:
   ```bash
   dotnet run
   ```
   - The application automatically links with `logincm.mdf` via `(LocalDB)\MSSQLLocalDB`.

---

## 📄 Database Schema

If you wish to host the database on a standard SQL Server instance, execute the provided script:
- Run the SQL script found in [`database_schema.sql`](./database_schema.sql) in SQL Server Management Studio (SSMS).

---

## 📜 License

This project is licensed under the [MIT License](LICENSE).

---

## 👤 Author

- **GitHub**: [@lgihan483-sudo](https://github.com/lgihan483-sudo)
- **Author**: Gihan Lahiru
- **Email**: lgihan483@gmail.com
