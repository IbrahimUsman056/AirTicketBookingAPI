# ✈️ Air Ticket Booking API

## Overview

Air Ticket Booking API is a RESTful web service developed using ASP.NET Core Web API, Entity Framework Core, and SQL Server. The API manages flight records and provides endpoints for creating, retrieving, updating, and deleting flight information.

The project demonstrates modern backend development practices, database integration, asynchronous programming, and business rule validation for airline ticket booking systems.

---

## Features

### ✈️ Flight Management

Manage airline flight records including departure and arrival information.

### 📋 View All Flights

Retrieve a complete list of available flights.

### 🔍 View Flight Details

Fetch details of a specific flight using its unique identifier.

### ➕ Add New Flight

Create and store new flight records in the database.

### ✏️ Update Flight Information

Modify existing flight details through API endpoints.

### ❌ Delete Flight

Remove flight records from the system.

### ✔ Business Rule Validation

Validate flight data before saving:

* Departure time must be earlier than arrival time.
* Departure city and destination city cannot be the same.

### 🗄 Database Integration

Store and manage flight data using SQL Server and Entity Framework Core.

---

## Technologies Used

* ASP.NET Core Web API
* C#
* Entity Framework Core
* SQL Server
* RESTful Architecture
* LINQ
* Asynchronous Programming
* JSON

---

## API Endpoints

### Get All Flights

GET /api/flights

Returns all flight records.

### Get Flight by ID

GET /api/flights/{id}

Returns details of a specific flight.

### Create Flight

POST /api/flights

Creates a new flight record after validation.

### Update Flight

PUT /api/flights/{id}

Updates an existing flight record.

### Delete Flight

DELETE /api/flights/{id}

Deletes a flight from the database.

---

## Key Features Implemented

### CRUD Operations

* Create
* Read
* Update
* Delete

### Entity Framework Core

Object-Relational Mapping (ORM) for database operations.

### Data Validation

Business logic validation before database transactions.

### Asynchronous Programming

Async/Await implementation for improved API performance.

### RESTful API Design

Standard HTTP methods and status codes.

---

## Business Rules

The API enforces the following validations:

* Departure Time must be earlier than Arrival Time.
* Departure City and Destination City cannot be identical.
* Invalid requests return appropriate HTTP error responses.

---

## Learning Outcomes

This project helped in understanding:

* ASP.NET Core Web API Development
* Entity Framework Core
* SQL Server Integration
* RESTful API Design
* HTTP Status Codes
* CRUD Operations
* Business Rule Validation
* Asynchronous Programming
* Dependency Injection

---

## Future Enhancements

* Passenger Management
* Flight Booking Module
* Seat Reservation System
* Authentication and Authorization (JWT)
* Flight Search and Filtering
* Ticket Generation
* Payment Integration
* Swagger/OpenAPI Documentation

---

## Conclusion

The Air Ticket Booking API provides a robust backend solution for managing flight information through RESTful endpoints. By integrating ASP.NET Core Web API with Entity Framework Core and SQL Server, the project demonstrates modern API development practices, data validation, and scalable backend architecture.
