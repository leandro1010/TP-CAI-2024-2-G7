# TP CAI

## Descripción General

El proyecto TP CAI es una aplicación de software diseñada para la gestión de usuarios con un sistema de autenticación. La aplicación está estructurada en cuatro capas distintas: **PRESENTACION** (Frontend), **DATOS** (Capa de Acceso a Datos), **NEGOCIO** (Capa de Lógica de Negocios) y **PERSISTENCIA** (Capa de Persistencia). Esta estructura permite una clara separación de responsabilidades y un desarrollo modular, asegurando escalabilidad y mantenibilidad.

## Versión Actual

0.0.2

## Recursos Creados

- **PRESENTACION (Frontend)**: 
  - Implementa la interfaz de usuario utilizando Windows Forms.
  - Contiene el formulario de inicio de sesión y la lógica de validación.
  - **Clases**: 
    - `frm_login.cs`: Formulario de inicio de sesión con componentes de interfaz de usuario y lógica de autenticación.
    - `frm_login.Designer.cs`: Contiene el código autogenerado para el diseño del formulario `frm_login`.

- **DATOS (Capa de Acceso a Datos)**:
  - Implementa el acceso a datos para la información del usuario.
  - **Clases**: 
    - `LoginDatos.cs`: Contiene métodos para el acceso a datos del usuario y la verificación.

- **NEGOCIO (Capa de Lógica de Negocios)**:
  - Maneja la lógica de negocios relacionada con la autenticación de usuarios y la gestión de contraseñas.
  - **Clases**:
    - `LoginNegocio.cs`: Maneja la lógica de autenticación y llama a `LoginDatos` para la verificación de usuarios.
    - `ValidacionesUtils.cs`: Contiene métodos de validación para contraseñas, incluyendo las nuevas reglas de negocio.
    - `PasswordValidator.cs`: Maneja las reglas de validación de contraseñas como longitud mínima, requisitos de caracteres y expiración.

- **PERSISTENCIA (Capa de Persistencia)**:
  - (Aún no detallado; típicamente contiene la lógica de almacenamiento y recuperación de datos).

## Historial de Cambios

{{< table id="changelog" class="bordered" data-sample=10 >}}
| Versión | Fecha (Año-MM-DD) | ID de Error Relacionado | Resumen del Cambio |
|---------|--------------------|-------------------------|---------------------|
| 0.0.1   | 2024-09-06         | N/A                     | Lanzamiento inicial del proyecto con funcionalidad básica para la autenticación de usuarios. |
| 0.0.2   | 2024-09-15         | N/A                     | Se añadieron reglas de negocio para la gestión de contraseñas: las contraseñas deben contener al menos una letra mayúscula y un número, y deben expirar cada 30 días sin reutilización de contraseñas anteriores. Se añadieron nuevas clases para la validación de contraseñas. |
