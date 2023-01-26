# Challenge Backend

## Solution structure
- API
- Core
- Infrastructure
- Persistence

### API Structure
The API project it will helps to communicate between the client through http.
    ,
    ├── controllers             #  It helps to communicate the data send of the client to the businnes logic
    └──  Program.cs               #It helps to configure services and dependency injection.

### Core Structure
The Core project it contains the domain entities, interfaces and services that will handle the business logic of the application. The project is divided by features for each entity that has the following structure.
.
    ├── DTO                   
    ├── Services                    
    ├── Entity
    ├── Repository
    
### Infrastructure Structure
The infrastructure project it handles the implementation of the interfaces defined in the Core module and validations rules for each entity.

,
    ├──  Repositories           
    └──  Validators             

### Persistence structure
The persistence project it handles the connection to the database, it contains the migrations and the configuration between entities using the Fluent API.

.
    ├── Configuration                   
    ├── Migrations                  
    ├── ChallengeContext

## How to run it
To run the application you will need to change the connection string that is located in the
appsettings.json in the API project to connect to the postgres instance in your machine.

The migrations will run automatically once the project is started and it will launch the Swagger page that will have the endpoints to create entities and list them.
