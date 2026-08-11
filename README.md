# Hawassa University Centralized Event Platform

![.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-512BD4?style=for-the-badge&logo=.net)
![Entity Framework Core](https://img.shields.io/badge/EF%20Core-8.0-512BD4?style=for-the-badge&logo=.net)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-CC292B?style=for-the-badge&logo=microsoftsqlserver)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

A centralized web application engineered to manage campus-wide academic, cultural, and organizational events across Hawassa University. Built using ASP.NET Core MVC with Entity Framework Core, this platform provides role-based access control, real-time event discovery, department-level subscriptions, QR code ticket verification, and automated audit logging.

---

## Key Features

* **Multi-Domain Access Control**: Granular Role-Based Access Control (RBAC) supporting Super Admins, Department Heads, Event Organizers, and Students.
* **Event Management & Discovery**: Centralized catalog featuring dynamic search, filtering by faculty/department/category, and custom tags.
* **Digital Ticketing & QR Verification**: Automated ticket issuance with unique QR codes and a dedicated check-in module for organizers at event venues.
* **Personalized Feeds & Subscriptions**: Student department subscriptions and personalized event feeds tailored to individual preferences.
* **Multi-Channel Notifications**: Real-time reminders, updates, and cancellations delivered via email and calendar synchronization.
* **Security & System Audit Trails**: Detailed audit logging capturing administrative actions, user check-ins, and security-relevant operational changes.

---

## Tech Stack & Tools

| Component | Technology |
| :--- | :--- |
| **Framework** | ASP.NET Core MVC (.NET 8) |
| **ORM** | Entity Framework Core 8 |
| **Database** | Microsoft SQL Server |
| **Front-End** | Razor Views (`.cshtml`), HTML5, CSS3, JavaScript |
| **Authentication** | ASP.NET Core Cookie Authentication / Identity |
| **Tooling** | Visual Studio / VS Code, PowerShell |

---

## Database Schema Architecture

The platform's database consists of 18 entities organized across 8 core domain modules:

```text
CentralizedEventPlatform Domain Architecture
├── 1. Access Control          : Roles, Permissions, RolePermissions
├── 2. People & Organization   : Faculties, Departments, Users
├── 3. Venue Management        : Venues
├── 4. Events Core             : Events, EventCategories, EventTags, EventTagMaps
├── 5. Registration Module     : Registrations (Tickets)
├── 6. Notifications & Sync    : Notifications, CalendarSyncs, UserPreferences
├── 7. Personalization         : UserDeptSubscriptions, UserCategoryInterests
└── 8. Security & Audit        : AuditLogs

CentralizedEventPlatform/
│
├── Areas/                                 # Role-delimited application modules
│   ├── Admin/                             # Super Admin user & venue management
│   │   ├── Controllers/                   # UsersController, VenuesController, AuditController
│   │   └── Views/                         # Management Razor dashboards
│   └── Organizer/                         # Event organizer tools
│       ├── Controllers/                   # CheckInController (QR scanning)
│       └── Views/                         # Ticket scanner interface
│
├── Controllers/                           # Public & student route handlers
│   ├── AccountController.cs               # Authentication & user profile
│   ├── EventsController.cs                # Event listing, creation, and detail views
│   ├── RegistrationsController.cs         # Ticket reservations & user wallet
│   ├── DepartmentsController.cs           # Departmental feeds & subscriptions
│   └── HomeController.cs                  # Platform landing page
│
├── Data/                                  # Data access & persistence
│   ├── ApplicationDbContext.cs            # EF Core database context configuring all 18 entities
│   ├── DbInitializer.cs                   # Seeds initial system data (Roles, Admin, Faculties)
│   └── Configurations/                    # Fluent API entity relationship mapping
│
├── Models/                                # Domain entities, ViewModels, and Enums
│   ├── Entities/                          # Mapped database entities (8 domain folders)
│   ├── Enums/                             # Status codes (EventStatus, RegistrationStatus, etc.)
│   └── ViewModels/                        # Strongly-typed view data wrappers
│
├── Services/                              # Business logic abstraction
│   ├── Interfaces/                        # IEmailService, IQrCodeService, IAuditService
│   └── Implementations/                   # Concrete service implementations
│
├── Views/                                 # Shared Razor view templates
│   ├── Events/                            # Catalog, Details, and Form layouts
│   ├── Registrations/                     # Digital ticket views
│   └── Shared/                            # Navigation, layout wrappers, partial views
│
├── wwwroot/                               # Static assets (CSS, JS, uploads)
├── appsettings.json                       # Database connection strings & service keys
└── Program.cs                             # Dependency injection & middleware pipeline

Getting Started
Prerequisites
.NET 8.0 SDK

Microsoft SQL Server (LocalDB or Express edition)

Visual Studio 2022 or VS Code

Installation & Local Setup
Clone the Repository

Bash
git clone [https://github.com/degifetise/Hawassa_Univeristy_Projects.git](https://github.com/degifetise/Hawassa_Univeristy_Projects.git)
cd Hawassa_Univeristy_Projects/CentralizedEventPlatform
Configure Connection String
Open appsettings.json and adjust the database connection string to point to your local SQL Server instance:

JSON
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CentralizedEventPlatformDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
Apply Database Migrations
Open your terminal in the project root directory and execute EF Core migrations:

Bash
dotnet ef migrations add InitialCreate
dotnet ef database update
Run the Application

Bash
dotnet run

Routing & Application AreasPath PatternTarget AreaDescription/PublicHome landing page featuring spotlighted campus events./Events/Details/{id}PublicEvent details, venue specifications, and registration trigger./Registrations/MyTicketsStudentPersonal dashboard listing generated digital QR tickets./Admin/UsersAdmin AreaManage user accounts, system permissions, and roles./Admin/VenuesAdmin AreaManage campus event locations and spatial capacities./Organizer/CheckIn/ScanOrganizer AreaCamera/barcode scanner interface for door ticket validation.ContributingFork the project.Create your feature branch (git checkout -b feature/NewFeature).Commit your changes (git commit -m 'Add NewFeature').Push to the branch (git push origin feature/NewFeature).Open a Pull Request.
