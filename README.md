# Voluntier

Este repositorio contiene el código fuente de una aplicación de gestión de campañas desarrollada para una institución educativa. La aplicación se divide en tres capas: acceso a datos, lógica de negocio y presentación, y utiliza ASP.NET, SQL Server y WCF para su implementación.

## Descripción del Proyecto

La aplicación permite a la institución educativa gestionar y registrar campañas de servicio social, con la participación de tres tipos de usuarios: ViceRectorado, Direccion y Estudiantes. Cada tipo de usuario tiene sus propias funciones y responsabilidades en el sistema.

## Estructura del Proyecto

El proyecto se divide en las siguientes capas:

1. **Capa de Acceso a Datos (Proyecto WCF Service 1)**:
   - Responsable de la interacción con la base de datos SQL Server.
   - Define operaciones CRUD para entidades como Campañas, Registros de Asistencia, Solicitudes de Participación, entre otros.
   - Configura la cadena de conexión a la base de datos en el archivo de configuración.

2. **Capa de Negocios (Proyecto WCF Service 2)**:
   - Implementa la lógica de negocio de la aplicación.
   - Utiliza los servicios WCF de la capa de acceso a datos para acceder y modificar datos.
   - Define servicios WCF para operaciones de negocio como la creación y aprobación de campañas.

3. **Capa de Presentación (Proyecto ASP.NET Empty Web Site)**:
   - Proporciona la interfaz de usuario de la aplicación.
   - Permite a los usuarios interactuar con la lógica de negocio a través de páginas web.
   - Implementa autenticación y autorización basadas en roles.

## Configuración y Despliegue

1. Clona este repositorio a tu entorno de desarrollo local.

2. Configura la cadena de conexión a la base de datos en la capa de acceso a datos según tus necesidades.

3. Abre el proyecto de la capa de presentación en Visual Studio y despliega la aplicación en un servidor web compatible con ASP.NET.

4. Realiza pruebas exhaustivas para asegurarte de que todas las funcionalidades funcionan correctamente.

## Autores

- [David Calvi Arce](david.calvi.18@gmail.com) - Desarrollador Principal

## Licencia

---

## Agradecimientos

Agradecemos a todos los colaboradores y a la comunidad de código abierto por su apoyo en este proyecto.
