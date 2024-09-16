# TP CAI

## Descripci�n General

El proyecto TP CAI es una aplicaci�n de software dise�ada para la gesti�n de usuarios con un sistema de autenticaci�n. La aplicaci�n est� estructurada en cuatro capas distintas: **PRESENTACION** (Frontend), **DATOS** (Capa de Acceso a Datos), **NEGOCIO** (Capa de L�gica de Negocios) y **PERSISTENCIA** (Capa de Persistencia). Esta estructura permite una clara separaci�n de responsabilidades y un desarrollo modular, asegurando escalabilidad y mantenibilidad.

## Versi�n Actual

0.0.2

## Recursos Creados

- **PRESENTACION (Frontend)**: 
  - Implementa la interfaz de usuario utilizando Windows Forms.
  - Contiene el formulario de inicio de sesi�n y la l�gica de validaci�n.
  - **Clases**: 
    - `frm_login.cs`: Formulario de inicio de sesi�n con componentes de interfaz de usuario y l�gica de autenticaci�n.
    - `frm_login.Designer.cs`: Contiene el c�digo autogenerado para el dise�o del formulario `frm_login`.

- **DATOS (Capa de Acceso a Datos)**:
  - Implementa el acceso a datos para la informaci�n del usuario.
  - **Clases**: 
    - `LoginDatos.cs`: Contiene m�todos para el acceso a datos del usuario y la verificaci�n.

- **NEGOCIO (Capa de L�gica de Negocios)**:
  - Maneja la l�gica de negocios relacionada con la autenticaci�n de usuarios y la gesti�n de contrase�as.
  - **Clases**:
    - `LoginNegocio.cs`: Maneja la l�gica de autenticaci�n y llama a `LoginDatos` para la verificaci�n de usuarios.
    - `ValidacionesUtils.cs`: Contiene m�todos de validaci�n para contrase�as, incluyendo las nuevas reglas de negocio.
    - `PasswordValidator.cs`: Maneja las reglas de validaci�n de contrase�as como longitud m�nima, requisitos de caracteres y expiraci�n.

- **PERSISTENCIA (Capa de Persistencia)**:
  - (A�n no detallado; t�picamente contiene la l�gica de almacenamiento y recuperaci�n de datos).

## Historial de Cambios

{{< table id="changelog" class="bordered" data-sample=10 >}}
| Versi�n | Fecha (A�o-MM-DD) | ID de Error Relacionado | Resumen del Cambio |
|---------|--------------------|-------------------------|---------------------|
| 0.0.1   | 2024-09-06         | N/A                     | Lanzamiento inicial del proyecto con funcionalidad b�sica para la autenticaci�n de usuarios. |
| 0.0.2   | 2024-09-15         | N/A                     | Se a�adieron reglas de negocio para la gesti�n de contrase�as: las contrase�as deben contener al menos una letra may�scula y un n�mero, y deben expirar cada 30 d�as sin reutilizaci�n de contrase�as anteriores. Se a�adieron nuevas clases para la validaci�n de contrase�as. |
