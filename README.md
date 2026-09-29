# BD_AUTO

Web API desarrollada con ASP.NET Core para la gestión de vehículos,
utilizando SQL Server como sistema de base de datos.

## Tecnologías

- C#
- ASP.NET Core Web API
- SQL Server
- Microsoft.Data.SqlCliente
- Swagger / OpenAPI



## Arquitectura

El proyecto utiliza una separación por capas:

- Controller --> reciben las solicitudes HTTP.
- BLL --> contiene la lógica del negocio.
- DAL --> gestiona el acceso a SQL Server.
- Models --> representan las entidades del sistema.



## Funcionalidades

- Listar vehículos
- Buscar un vehículo por ID
- Registrar vehículos
- Actualizar vehículos
- Eliminar vehículos


## Base de Datos

La base de datos utilizada es 'BD_AUTO'


El script de creación de la base de datos se encuentra en :

'Database/BD_AUTO.sql'


## Ejecución

1. Crear la base de datos utilizando el script SQL.
2. Verificar la cadena de conexión en 'appsettings.json'
3. Abrir la solución 'BD_AUTO.sln' con Visual Studio.
4. Ejecutar el proyecto.
5. Utilizar Swagger para probar los endpoints.






