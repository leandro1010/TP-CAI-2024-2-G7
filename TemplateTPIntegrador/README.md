
# TP CAI

## Overview

The TP CAI project is a software application designed for user management with an authentication system. The application is structured into four distinct layers: **TemplateTPIntegrador** (Frontend), **DATOS** (Data Access Layer), **NEGOCIO** (Business Logic Layer), and **PERSISTENCIA** (Persistence Layer). This setup allows for clear separation of concerns and modular development, ensuring scalability and maintainability.

## Current Version

0.0.1

## Resources Created

- **TemplateTPIntegrador (Frontend)**: 
  - Implements the user interface using Windows Forms.
  - Contains the login form and validation logic.

- **DATOS (Data Access Layer)**:
  - Implements the `LoginDatos` class for user data access.
  - Simulates user verification for authentication purposes.

- **NEGOCIO (Business Logic Layer)**:
  - Implements the `LoginNegocio` class to handle business logic for user authentication.
  - Utilizes `LoginDatos` to validate user credentials.

- **PERSISTENCIA (Persistence Layer)**:
  - (Not detailed yet; typically contains data storage and retrieval logic).

# Changelog

{{< table id="changelog" class="bordered" data-sample=10 >}}
| Version | Date (Year-MM-DD) | Related Bug Id | Change Summary |
|---------|-------------------|----------------|----------------|
| 0.0.1   | 2024-09-06        | N/A            | Initial release of the project with basic functionality for user authentication. |

---
