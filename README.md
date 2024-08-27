
# School Management System

Welcome to the School Management System project! This project is built using C# and demonstrates the use of the Repository Pattern to manage data access and business logic in a school management context.

## Architecture

This project follows the Repository Pattern, which helps to:
- Abstract data access logic from business logic.
- Make the code more maintainable and testable.
- Separate concerns and promote better organization.

### Project Structure

- **Domain**: Contains the core business models and entities.
- **Repository**: Implements data access logic and interfaces for CRUD operations.
- **Service**: Contains business logic and uses repositories to interact with data.
- **WebApp**: The web application layer that interacts with users.
