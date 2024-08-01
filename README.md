# NestQuest

NestQuest is a robust, scalable backend application for a vacation rental booking system. Built with .NET 8 and following clean architecture principles, it provides a solid foundation for managing apartments, bookings, and user interactions.

## Table of Contents

1. [Features](#features)
2. [Technology Stack](#technology-stack)
3. [Architecture](#architecture)
4. [Getting Started](#getting-started)
   - [Prerequisites](#prerequisites)
   - [Installation](#installation)
   - [Running the Application](#running-the-application)
5. [API Documentation](#api-documentation)
6. [Testing](#testing)
7. [Deployment](#deployment)
8. [Contributing](#contributing)
9. [License](#license)

## Features

- User registration and authentication
- Apartment listing and search
- Booking creation and management
- Review system for apartments
- Caching for improved performance
- Comprehensive logging and error handling
- API versioning
- Health checks for monitoring

## Technology Stack

- **Framework**: ASP.NET Core 8
- **ORM**: Entity Framework Core
- **Databases**: 
  - PostgreSQL (main database)
  - Redis (caching)
- **Authentication**: Keycloak
- **Messaging**: Outbox pattern with Quartz.NET
- **Containerization**: Docker and Docker Compose
- **Logging**: Serilog with Seq
- **Validation**: FluentValidation
- **Testing**: xUnit, NSubstitute, FluentAssertions
- **Other Libraries**: MediatR, Dapper, Bogus

## Architecture

NestQuest follows a clean architecture approach with the following layers:

1. **Domain Layer** (`NestQuest.Domain`): Contains enterprise logic and types.
2. **Application Layer** (`NestQuest.Application`): Contains business logic and types.
3. **Infrastructure Layer** (`NestQuest.Infrastructure`): Contains all external concerns.
4. **API Layer** (`NestQuest.Api`): Contains everything related to the API.

The project also implements the CQRS (Command Query Responsibility Segregation) pattern using MediatR.

## Getting Started

### Prerequisites

- .NET 8 SDK
- Docker and Docker Compose
- (Optional) Visual Studio 2022 or later, or Visual Studio Code

### Installation

1. Clone the repository:
   ```
   git clone https://github.com/yourusername/NestQuest.git
   ```

2. Navigate to the project directory:
   ```
   cd NestQuest
   ```

3. Restore the .NET packages:
   ```
   dotnet restore
   ```

### Running the Application

1. Start the Docker containers:
   ```
   docker-compose up -d
   ```

2. Run the application:
   ```
   dotnet run --project src/NestQuest.Api
   ```

3. The API should now be running on `https://localhost:5001` (HTTPS) and `http://localhost:5000` (HTTP).

4. Access the Swagger UI at `https://localhost:5001/swagger` to explore the API.

## API Documentation

The API is versioned and the current version is v1. You can explore the available endpoints using the Swagger UI when running the application.

Key endpoints include:

- `POST /api/v1/users/register`: Register a new user
- `POST /api/v1/users/login`: Log in a user
- `GET /api/v1/apartments`: Search for apartments
- `POST /api/v1/bookings`: Create a new booking
- `POST /api/v1/reviews`: Add a review for an apartment

## Testing

The project includes unit tests, integration tests, and architecture tests. To run the tests:

```
dotnet test
```

## Deployment

The application is containerized and can be deployed using Docker. The `Dockerfile` and `docker-compose.yml` files are provided in the repository.
