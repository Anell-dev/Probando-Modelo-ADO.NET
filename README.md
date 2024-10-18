# Arquitectura ADO.NET

Este proyecto presenta una implementación del modelo ADO.NET utilizando tanto el modo conectado como el modo desconectado. En este repositorio, aprenderemos a manejar conexiones a bases de datos, ejecutar comandos SQL, agregar, leer y actualizar bases de datos utilizando ADO.NET.
<br/>

<h1>Colaboradores</h3>
<div style="font-size: 20px;">
    <img src="./icons8-linkedin.svg" alt="LinkedIn Logo" style="width: 30px; height: 30px; vertical-align: middle;" />
    <a href="https://www.linkedin.com/in/brayan-antonio-702749313">Brayan Almengor</a>
    &
    <img src="./icons8-linkedin.svg" alt="LinkedIn Logo" style="width: 30px; height: 30px; vertical-align: middle;" />
    <a href="https://www.linkedin.com/in/edwin-anel-gonz%C3%A1lez-978b6a234">Edwin Gonzalez</a>
</div>

<br/>

## Contenido del Proyecto

### 1. ADO.NET en Modo Conectado

En el modo conectado, ADO.NET mantiene una conexión constante con la base de datos mientras interactúa con ella. Las operaciones principales se realizan con los siguientes objetos:

- **Objeto `Connection` y Control de Excepciones:**
  La conexión a la base de datos se gestiona utilizando el objeto `Connection`, y se implementan mecanismos para manejar posibles excepciones durante la conexión.

- **Objeto `Command`:**
  Utilizado para ejecutar comandos SQL, como consultas, inserciones, actualizaciones o eliminaciones en la base de datos.

- **Objeto `DataReader`:**
  Utilizado para leer filas de datos obtenidas a partir de una consulta SQL. Es ideal para operaciones de lectura rápida y sencilla en bases de datos.

### 2. ADO.NET en Modo Desconectado

En el modo desconectado, los datos se recuperan de la base de datos y se almacenan en memoria local para ser manipulados sin mantener una conexión activa constante. Las operaciones clave en este modo utilizan los siguientes objetos:

- **Objeto `DataSet`:**
  Un contenedor que puede almacenar múltiples tablas de datos recuperadas desde la base de datos. Es independiente de la fuente de datos y permite trabajar con los datos desconectados de la base.

- **Objeto `DataAdapter`:**
  Responsable de llenar un `DataSet` con los datos recuperados de la base de datos y de realizar actualizaciones en la misma cuando los datos en el `DataSet` son modificados.

### 3. Actualización de la Base de Datos

Este proyecto incluye ejemplos de cómo realizar la actualización de datos en la base de datos utilizando el objeto `DataAdapter`, que facilita la sincronización entre los datos modificados en el `DataSet` y la base de datos original.

## Estructura del Proyecto

El proyecto se organiza en varias capas para separar la lógica de negocio, el acceso a datos y la interfaz de usuario (UI), siguiendo una arquitectura de tres capas:

- **BLL (Capa de Lógica de Negocios):**
  - `Negocio.vb`: Contiene la lógica de negocio del proyecto.

- **DAL (Capa de Acceso a Datos):**
  - `Dato.vb`: Gestiona el acceso a la base de datos y las consultas SQL.

- **Entities (Entidades del Modelo):**
  - `Usuario.vb`: Define las entidades o modelos de datos utilizados en el proyecto.

- **UI (Capa de Interfaz de Usuario):**
  - `frmVista.vb`: Ventana principal del proyecto que interactúa con el usuario.
  - `Desconectado.vb`: Módulo que implementa el modo desconectado utilizando ADO.NET.


## Requisitos del Proyecto

- .NET Framework o .NET Core
- SQL Server o cualquier otra base de datos compatible con ADO.NET
- Visual Studio (opcional, pero recomendado)

## Cómo Ejecutar el Proyecto

1. Clona este repositorio.
2. Abre el proyecto en Visual Studio.
3. Configura la cadena de conexión a tu base de datos en el archivo de configuración (por ejemplo, `app.config` o `web.config`).
4. Ejecuta el proyecto y prueba las diferentes operaciones de conexión, consulta y actualización de datos.
