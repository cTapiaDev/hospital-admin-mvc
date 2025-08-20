# 🏥 Sistema de Gestión Hospitalaria - HospitalAdminMVC

Este repositorio contiene el código fuente de un sistema de gestión hospitalaria, desarrollado como proyecto principal para el curso de **Desarrollo de Aplicaciones Web con ASP.NET Core MVC**.

---

## 📜 Sobre el Proyecto

**HospitalAdminMVC** es una aplicación web diseñada para simular las operaciones administrativas de un centro médico. El objetivo de este proyecto es aplicar de manera práctica los conceptos aprendidos durante el curso, construyendo una aplicación robusta, escalable y mantenible desde cero.

### Tecnologías Utilizadas
* **Framework:** .NET 8
* **Arquitectura:** ASP.NET Core MVC (Modelo-Vista-Controlador)
* **Lenguaje:** C#
* **Base de Datos:** Entity Framework Core con SQL Server (Se implementará en clases futuras).
* **Frontend:** HTML5, CSS3, Bootstrap.

---

## ✨ Módulos Principales

El sistema está diseñado para incluir, a futuro, los siguientes módulos:
* 👤 **Gestión de Pacientes:** Alta, baja y modificación de fichas de pacientes.
* 👤 **Gestión de Médicos:** Administración de perfiles y especialidades del personal médico.
* 📅 **Agendamiento de Citas:** Sistema para reservar, modificar y consultar horas médicas.
* 📋 **Fichas Clínicas:** Registro de historial y atenciones médicas (módulo avanzado).

---

## 🚀 Progreso del Curso

A continuación, se detalla el avance del proyecto clase a clase.

### 📚 Clase 1: Diseño y Estructura del Proyecto (13 de agosto del 2025)
En esta sesión inicial, se sentaron las bases del proyecto, creando la estructura fundamental de la aplicación y comprendiendo el flujo de una solicitud en el patrón MVC.

#### Hitos Alcanzados:
- Creación de la solución `HospitalAdminMVC` utilizando la plantilla de ASP.NET Core MVC.
- Implementación del primer controlador: `PacientesController`, con una acción `VerFicha`.
- Diseño de una vista estática (`VerFicha.cshtml`) para mostrar la información de un paciente.

### 🔬 Clase 2: Protocolos Internos y Servicios Esenciales del Sistema (18 de agosto del 2025)
En esta clase, profundizamos en la arquitectura interna de la aplicación. Se exploró cómo ASP.NET Core procesa las solicitudes a través del **pipeline de middleware** y cómo gestionar las dependencias de forma profesional utilizando el patrón de **Inyección de Dependencias**.

#### Hitos Alcanzados:
- Se creó un `RegistroDeActividadMiddleware` personalizado para interceptar y registrar en la consola todas las solicitudes HTTP entrantes y salientes, comprendiendo la importancia del orden en el pipeline.
- Se aplicó el principio de Inversión de Control para desacoplar los componentes del sistema.
- Se desarrolló un `IHospitalInfoService` para centralizar la obtención de datos de la aplicación (como el nombre del hospital).
- Se implementó un `IGeneradorIdPaciente` como parte del taller práctico, encargado de crear identificadores únicos para los pacientes.
- Los servicios fueron registrados en el contenedor de DI con un ciclo de vida `Scoped` y posteriormente inyectados en los constructores de `PacientesController` y `MedicosController` para ser utilizados en sus acciones.

### 📋 Clase 3: Gestión de Pacientes y Médicos (CRUD) (20 de agosto del 2025)
Esta sesión se centró en dar vida a la aplicación mediante la implementación de las operaciones fundamentales de **Crear** y **Leer** (CRUD). Se introdujeron los conceptos de **Modelos** con validación de datos y el manejo de formularios para la entrada de información.

#### Hitos Alcanzados:
- Se definió la clase `Paciente` en la carpeta `Models`, utilizando **Data Annotations** (`[Required]`, `[Display]`, etc.) para establecer reglas de validación de negocio.
- Se implementó la acción `Index` en `PacientesController` para mostrar una lista de pacientes (simulada en memoria) en una vista con formato de tabla.
- Se construyó el formulario de registro de nuevos pacientes (`Crear.cshtml`) utilizando **Tag Helpers** (`asp-action`, `asp-for`, `asp-validation-for`) para un código más limpio y mantenible.
- Se crearon dos acciones `Crear` en el controlador: una para mostrar el formulario (`GET`) y otra para procesar los datos enviados (`POST`), incluyendo la validación del `ModelState`.
- Se implementó la funcionalidad para ver la ficha completa de un paciente individual, pasando el `Id` a través de la ruta y buscando el registro en el controlador.

*(Aquí se agregarán las futuras clases...)*

---

## 💻 Cómo Ejecutar el Proyecto

Para ejecutar este proyecto en tu entorno local, sigue estos pasos.

#### Prerrequisitos
* [.NET 8 SDK](https://dotnet.microsoft.com/es-es/download/dotnet/8.0)
* [Visual Studio 2022 Community](https://visualstudio.microsoft.com/es/vs/community/) con la carga de trabajo "Desarrollo de ASP.NET y web".

#### Pasos
1. Clona el repositorio en tu máquina local: 
	```bash
	git clone https://github.com/cTapiaDev/hospital-admin-mvc.git
	```
2. Abre el archivo de solución (`HospitalAdminMVC.sln`) con Visual Studio 2022.
3. Presiona `F5` o el botón de inicio para compilar y ejecutar la aplicación.