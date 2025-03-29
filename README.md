# 🚀 Ordering-Microservices

A **scalable, event-driven microservices-based ordering system** built using **CQRS, Domain-Driven Design (DDD), Clean Architecture, and Vertical Slice Architecture**. This system ensures **high performance, modularity, and maintainability** while handling **distributed order processing efficiently**.

## 🏗️ Architecture & Design
This system follows:
- **Microservices Architecture** – Decoupled services for better scalability & independence.
- **Event-Driven Architecture** – Services communicate asynchronously using **RabbitMQ**.
- **CQRS (Command Query Responsibility Segregation)** – Efficiently handles reads and writes.
- **Domain-Driven Design (DDD)** – Each service models a clear business domain.
- **Clean Architecture** – Applied within individual services for separation of concerns.
- **Vertical Slice Architecture** – Some services use VSA to improve maintainability and feature isolation.
- **Caching with Redis** – Improves query performance and reduces load.

---

## 🛠️ Tech Stack
| Technology      | Purpose  |
|---------------|------------------------------------------------|
| **.NET 8**   | Core framework for microservices  |
| **ASP.NET Core**  | API development  |
| **Entity Framework Core** | Database ORM |
| **PostgreSQL / SQL Server** | Relational database |
| **RabbitMQ**  | Message broker for event-driven communication |
| **Redis**  | Caching layer for performance optimization |
| **MediatR**  | Implements CQRS with command and query handling |
| **Docker** | Containerization and orchestration |


---

## 📌 Features
✅ **Order Processing:** Handles customer orders with event-driven messaging.  
✅ **CQRS Pattern:** Separates read and write operations for performance & scalability.  
✅ **Event-Driven Communication:** Services publish & subscribe to events via **RabbitMQ**.  
✅ **Resiliency & Fault Tolerance:** Uses **circuit breakers and retries** for reliability.  
✅ **Redis Caching:** Speeds up frequently accessed queries.  
✅ **Scalable & Modular:** Each microservice is independently deployable. 
