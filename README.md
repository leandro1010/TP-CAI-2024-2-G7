

---

# Descripción de Cambios

### Integrantes
- Julian Diaz

## Resumen del Proyecto

Se ha configurado la estructura básica del proyecto `TP-CAI-2024-2-G7`, el cual está dividido en cuatro capas: `TEMPLATETPINTEGRADOR`, `DATOS`, `NEGOCIO` y `PERSISTENCIA`. El objetivo principal es implementar un sistema de autenticación básico con una validación de usuario y contraseña.

## Archivos y Estructura Creada

### 1. Proyecto `TEMPLATETPINTEGRADOR`

- **`Form1.cs`**: Implementa la interfaz de usuario para el login. Se agregó validación para asegurar que los campos de usuario y contraseña no estén vacíos antes de intentar autenticar al usuario.
- **`ValidacionesYUtiles.cs`**: Clase creada en la carpeta `UTILS` para validar si los campos de texto están vacíos y proporcionar mensajes de error adecuados.

### 2. Proyecto `DATOS`

- **`LoginDatos.cs`**: Clase ubicada en la carpeta `UTILS` que simula la lógica de acceso a datos. Implementa el método `ExisteUsuario` para verificar si las credenciales del usuario son correctas. Esta clase es responsable de la validación inicial del usuario y la contraseña.

### 3. Proyecto `NEGOCIO`

- **`LoginNegocio.cs`**: Clase ubicada en la carpeta `UTILS` que maneja la lógica de negocio relacionada con la autenticación. Implementa el método `ValidarLogin`, que utiliza la clase `LoginDatos` para verificar las credenciales del usuario.

### 4. Proyecto `PERSISTENCIA`

- **`(Aún no se han incluido detalles específicos para esta capa)`**: La capa de persistencia se ha creado, pero aún no se han implementado detalles específicos. Esta capa está reservada para la lógica relacionada con el almacenamiento y la recuperación de datos en una base de datos.

## Estructura del Proyecto

```
TP-CAI-2024-2-G7/
├── TEMPLATETPINTEGRADOR/
│   ├── Form1.cs
│   └── UTILS/
│       └── ValidacionesYUtiles.cs
├── DATOS/
│   └── UTILS/
│       └── LoginDatos.cs
├── NEGOCIO/
│   └── UTILS/
│       └── LoginNegocio.cs
└── PERSISTENCIA/
    └── (Archivos pendientes de implementación)
```

## Descripción de Cambios en el Código

- **`Form1.cs`**: Se añadió validación en el formulario de login para verificar que los campos de usuario y contraseña no estén vacíos. Si los campos están vacíos, se muestra un mensaje de advertencia.
- **`LoginDatos.cs`**: Se implementó una clase de simulación que verifica si un usuario existe con las credenciales proporcionadas.
- **`LoginNegocio.cs`**: Se creó la lógica de negocio para validar el login utilizando la clase `LoginDatos`.
- **`ValidacionesYUtiles.cs`**: Se implementaron métodos para validar que los campos de texto no estén vacíos.

## Changelog

{{< table id="changelog" class="bordered" data-sample=10 >}}
| Version | Date (Year-MM-DD) | Related Bug Id | Change Summary |
| --- | --- | --- | --- |
| 0.0.1 | 2024-09-06 | N/A | Initial setup of project structure with frontend, data access, business logic, and persistence layers. Added basic authentication and validation. |

---

