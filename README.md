# Hello!

  Today, I'd like to introduce a modern `Asp.NET 6.0` application that I have developed. This application has been developed with the principles of clean code, maintainability, and best practices.

### API Application (`Master Branch`):
+ It solely provides an API.
+ Developed using Asp.NET 6.0.
+ Utilizes layered architecture: Core, Repository, Caching, Service layers.

### WEB Application (`AspNetMVC Branch`):
+ It provides only a web interface.
+ Developed using Asp.NET 6.0.
+ Utilizes layered architecture: Core, Repository, Service layers.

### MVC-API Application (`AspNetApi-MVC Branch`)
+ Provides both API and Web interface functionalities.
+ Developed with Asp.NET 6.0.
+ Utilizes layered architecture: Core, Repository, Caching, Service layers, API Layer Integration.


## ***Key Features***:

+ **Developed with Asp.NET 6.0**: The application has been developed using Asp.NET 6.0 to take advantage of the latest technologies.

+ **Layered Architecture:** The application utilizes a layered architecture, separating different responsibilities into distinct layers.

+ **Core Layer:** This layer contains fundamental building blocks including general business logic models, interface definitions, and other essential components.

+ **Repository Layer:** Responsible for database operations. Database operations are abstracted using the Entity Framework Code-First approach.

+ **Caching Layer:** Used for caching frequently accessed data in memory for quick access.

+ **Service Layer:** Implements business logic and facilitates communication with the external world. Houses the core business logic of the application.

+ **API Layer:** Provides a RESTful interface for web services. Allows clients to access the functionality of the application.

+ **Web Layer:** Provides the user interface and facilitates interaction with clients. Offers a visual interface for web browsers or web-based clients.

+ **Validation with Fluent Validation:** User inputs are validated using Fluent Validation, providing a robust and flexible way to ensure input correctness.

+ **Performance Improvements**: Performance enhancements are achieved using the caching layer. Caching frequently accessed data in memory reduces the load on the database.

+ **Integration with Modern Technologies**: The use of the latest technologies ensures the application remains up-to-date and adaptable to future requirements.

This project has been developed with the principles of clean code, maintainability, and best practices in mind. Each layer has specific responsibilities, and well-defined boundaries between layers enhance the modularity of the application.

**Thank you.**
