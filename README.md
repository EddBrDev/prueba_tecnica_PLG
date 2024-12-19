# Prueba Técnica PLG
Desarrollo de la la Prueba Técnica PLG

Inicio: 9:22 PM 18/12/2024  
Fin: 2:56 AM 19/12/2024  

**Tiempo Transcurrido**: 5 horas y 34 minutos  

---

## Descripción
Este proyecto consta de dos partes principales:  
1. **Frontend en Angular**: Una aplicación que muestra los datos de una tabla de clientes, incluyendo su país de origen. Además, aplica un formato específico al campo de teléfono utilizando un pipe personalizado.  
2. **Backend en C# (.NET)**: Una API que expone dos servicios para obtener la información de los clientes de manera paginada, utilizando diferentes enfoques.

---

## Requisitos del Proyecto

### 1. Aplicación en Angular
- **Objetivo**: Mostrar los datos de la tabla de clientes, incluyendo el país de origen.
- **Características**:
  - Comunicación con un servicio para obtener los datos de la API.
  - Aplicación de un formato específico al campo "teléfono" utilizando un pipe:  
    Formato esperado: `+569 1234 5678` (agregando un espacio cada 4 caracteres).

- **Pruebas Unitarias**:
  - Herramientas: Jasmine y Karma.
  - Incluir un caso de prueba para validar el correcto funcionamiento del pipe de formato de teléfono.

---

### 2. API en C# (.NET)
- **Objetivo**: Exponer dos servicios para obtener los datos de los clientes y su país de origen de manera paginada.
- **Características**:
  - **Servicio 1**: Implementado mediante un *Stored Procedure*.
  - **Servicio 2**: Implementado utilizando métodos LINQ con Entity Framework Core.
- **Requisitos**:
  - Manejo eficiente de la paginación.
  - Respuesta uniforme en ambos servicios.

---

## Tecnologías Utilizadas
### Frontend
- **Framework**: Angular 17.0.1.
- **Herramientas de prueba**: Jasmine, Karma.

### Backend
- **Framework**: .NET 8.0
- **ORM**: Entity Framework Core.
- **Base de Datos**: SQL Server.

---
