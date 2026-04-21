# MyShop E-Commerce Platform

A production-style, multi-layer ASP.NET Core e-commerce application built with clean architecture principles, role-based access, and payment integration.

## Highlights

- Multi-project solution with clear separation of concerns (`Web`, `DataAccess`, `Entities`, `Utilities`).
- ASP.NET Core MVC + Razor Pages (Identity UI) on .NET 8.
- Repository + Unit of Work patterns for data access abstraction.
- Authentication and authorization with ASP.NET Core Identity.
- Admin area for catalog and operations management.
- Customer area with product browsing, cart flow, and checkout path.
- Stripe integration for payment workflows.

## Tech Stack

- **Backend:** ASP.NET Core 8 (MVC)
- **ORM/Data:** Entity Framework Core 8
- **Database:** SQL Server
- **Auth:** ASP.NET Core Identity
- **Payments:** Stripe (`Stripe.net`)
- **UI:** Razor Views + AdminLTE assets

## Solution Structure

```text
MyShop/
├─ MyShop.Web/             # Presentation layer (MVC, Areas, Views, UI assets)
├─ myshop.DataAccess/      # EF Core DbContext, repositories, migrations
├─ myshop.Entities/        # Domain entities, repository contracts, view models
├─ myshop.Utilities/       # Shared constants and utility services
└─ MyShop.slnx             # Solution file
```

## Core Capabilities

- Product and category management.
- Customer shopping cart flow.
- Order header/details model and checkout pipeline.
- Identity-based user/role management.
- Session-based cart state.
- Payment provider integration via Stripe keys from configuration.

## Getting Started

### 1) Prerequisites

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
- SQL Server (LocalDB or SQL Server Express/Developer)

### 2) Clone and Restore

```bash
git clone https://github.com/Youssef-AbdelRaafi/myshop-ecommerce.git
cd myshop-ecommerce
dotnet restore
```

### 3) Configure App Settings

Update `MyShop.Web/appsettings.json`:

- `ConnectionStrings:DefaultConnection`
- `stripe:Secretkey`
- `stripe:Publishablekey`

> Recommended: store secrets in User Secrets or environment variables for production.

### 4) Apply Migrations

```bash
dotnet ef database update --project myshop.DataAccess/myshop.DataAccess.csproj --startup-project MyShop.Web/MyShop.Web.csproj
```

### 5) Run the Application

```bash
dotnet run --project MyShop.Web/MyShop.Web.csproj
```

## Architecture Notes

- `myshop.Entities` defines domain models and repository abstractions.
- `myshop.DataAccess` implements repositories and `ApplicationDbContext`.
- `MyShop.Web` composes services and exposes customer/admin features.
- `IUnitOfWork` centralizes transactional boundaries and repository access.

## Build Quality

Current baseline:

- `dotnet build` passes successfully.
- Migrations can be created and applied using EF Core CLI.

## Roadmap (Suggested)

- Add automated tests (unit + integration).
- Add CI pipeline (build/test/lint) with GitHub Actions.
- Add Docker support and environment-based deployment profiles.
- Improve observability (structured logging and health checks).

## Contributing

1. Fork the repository.
2. Create a feature branch.
3. Commit with clear messages.
4. Open a pull request with context and test notes.

## License

This project is currently unlicensed. Add a license file (`MIT`, `Apache-2.0`, etc.) before public/commercial reuse.
