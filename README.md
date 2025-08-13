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

<details>
	<summary><strong>📚 Clase 1: Diseño y Estructura del Proyecto (13 de agosto del 2025)</strong></summary>

	En esta sesión inicial, se sentaron las bases del proyecto, creando la estructura fundamental de la aplicación y comprendiendo el flujo de una solicitud en el patrón MVC.

	<strong>Hitos Alcanzados:</strong>
	- Creación de la solución `HospitalAdminMVC` utilizando la plantilla de ASP.NET Core MVC.
	- Implementación del primer controlador: `PacientesController`, con una acción `VerFicha`.
	- Diseño de una vista estática (`VerFicha.cshtml`) para mostrar la información de un paciente.

</details>

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