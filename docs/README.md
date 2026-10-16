# RaceDay API

RaceDay is a South African road running, walking and cycling event management system. This project uses ASP.NET Core Web API and Entity Framework Core to provide API endpoints and database connectivity.

## Technologies Used

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- OpenAPI

## Setup and Run Instructions

1. Clone or download this repository.
2. Open the `RaceDay.API` project in Visual Studio.
3. Configure the `RaceDayConnection` connection string in `appsettings.json` to match your local SQL Server setup.
4. Ensure the required database and tables are available.
5. Restore the NuGet packages.
6. Run the project using Visual Studio.
7. The API's OpenAPI documentation is available at `/openapi/v1.json` while running in Development mode.

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/DatabaseTest` | Checks database connectivity |
| GET | `/api/Users/{id}` | Retrieves a user by ID |
| POST | `/api/Users` | Creates a user |

## User Roles

The intended system includes two roles:

- **Administrator:** Intended to manage system information and event-related records.
- **User:** Intended to access user features.

Role-based authorization must be configured and tested before these roles can be considered enforced.

## Testing

The database connectivity endpoint was tested successfully and returned a message confirming that RaceDay API connected to the database. The user lookup endpoint was also tested and returned `User not found` for an ID that did not exist.

Unit tests and the remaining required endpoints should be implemented and verified as part of the project requirements.
