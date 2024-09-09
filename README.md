# Blazor, clean architecture web application

## Introduction

This repository contains a Blazor Web Application developed using .NET 8 and C# following the principles of clean architecture, Domain-Driven Design (DDD), Command Query Responsibility Segregation (CQRS) with MediatR, Fluent APIs, and Generic Repositories. This project aims to demonstrate a scalable, maintainable, and highly decoupled system design for complex web application development.

## About the Application

The application showcases the implementation of advanced software architecture and design patterns in a real-world Blazor project. By leveraging the power of .NET 8 and the versatility of Blazor, this project serves as a comprehensive guide and template for building enterprise-level web applications.

### Key Features:

- **CLEAN Architecture:** Organizes the project into independent layers, enhancing separation of concerns, and making the system more maintainable and adaptable to changes.
- **Domain-Driven Design (DDD):** Focuses on understanding the business domain and modeling the application based on the business requirements, ensuring the codebase is aligned with business expectations.
- **CQRS with MediatR:** Implements the CQRS pattern using the MediatR library to separate read and write operations, improving performance, scalability, and security.
- **Fluent API:** Utilizes Fluent API for configuration in Entity Framework Core, enabling more readable and maintainable code for entity configurations.
- **Generic Repositories:** Implements generic repository pattern to abstract and encapsulate all data access in the application, reducing code redundancy and promoting code reuse. Additionally, asynchronous functions have been used in the generic repositories' implementation in the infrastructure layer, leveraging Entity Framework operations to efficiently manipulate the Entities asynchronously, enhancing application performance and responsiveness.

## System Requirements

- .NET 8 SDK
- A suitable IDE like Visual Studio 2022 or later, or Visual Studio Code
- SQL Server (or any compatible relational database for the Entity Framework Core)

## Architecture Overview

The project is structured into the following main layers:

- **Domain Layer:** Contains the business domain entities and rules.
- **Application Layer:** Houses the application logic, CQRS commands, and queries, DTOs, and interfaces.
- **Infrastructure Layer:** Implements persistence logic, external services integration, and repositories.
- **Presentation Layer:** The Blazor Web UI interacts with the application layer to present data and send commands.

## Technologies Used

- .NET 8
- Blazor
- SQL Server
- Fluent APIs
- Fluent Validation
- Generic repositories
- MediatR
- Minimal APIs
