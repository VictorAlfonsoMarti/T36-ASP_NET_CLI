# T36-ASP_NET_CLI

## Descripción
### Ejercicio M8 - Front_AJAX Inventory_API
Front realizado para la  API Inventory_API_JWT (https://github.com/JoseMarin/Inventory_API_JWT) con Bootstrap, JQuery y peticiones asíncronas AJAX.
 - Se requiere loguin con Identity de AspNetCore.
 - El contenido de la web se recarga de forma asíncrona con AJAX.
 - Se realiza autentificación por medio del endpoint token, la clave se guarda en local : localStorage.setItem('token', data);
 - Paquetes Nuget 
  ```
  Microsoft.AspNetCore.EntityFrameworkCore Version="3.1.10"
  Microsoft.AspNetCore.EntityFrameworkCore Version="3.1.12"
  Microsoft.AspNetCore.Identity.UI Version="3.1.12"
  Microsoft.EntityFrameworkCore.SqlServer Version="3.1.12"
  Microsoft.EntityFrameworkCore.Tools Version="3.1.12"
  Microsoft.VisualStudio.Web.CodeGeneration.Design Version="3.1.5"
  ```
## DB:
### Inventory.sql (BD de la API)
![image](https://user-images.githubusercontent.com/9554810/108727132-82e32d00-7528-11eb-8c1d-5accfa0dd96a.png)
### UserInventory.sql (BD para el login de Identity)
![image](https://user-images.githubusercontent.com/9554810/108727178-8d9dc200-7528-11eb-97e4-57f48e119e4d.png)

## API - Swagger:
![image](https://user-images.githubusercontent.com/9554810/108727206-99898400-7528-11eb-9618-cfe3a1e82cdd.png)

## Front
### Login
![image](https://user-images.githubusercontent.com/9554810/108727468-e8371e00-7528-11eb-858e-a1eca7c378ec.png)

### Index
![image](https://user-images.githubusercontent.com/9554810/108727525-f84efd80-7528-11eb-90bb-c95ac939cc28.png)

### Inventory
![image](https://user-images.githubusercontent.com/9554810/108727557-01d86580-7529-11eb-8ca9-c133e40a3116.png)

#### GET
![image](https://user-images.githubusercontent.com/9554810/108727599-0b61cd80-7529-11eb-8824-e597ef097a49.png)

#### PUT
![image](https://user-images.githubusercontent.com/9554810/108727662-187ebc80-7529-11eb-8130-905603d55ea9.png)

#### DELETE
![image](https://user-images.githubusercontent.com/9554810/108727700-22082480-7529-11eb-9f43-4a8382bfd10d.png)

#### POST
![image](https://user-images.githubusercontent.com/9554810/108727739-2cc2b980-7529-11eb-85a7-46df0c7dcec8.png)
![image](https://user-images.githubusercontent.com/9554810/108727809-3b10d580-7529-11eb-9dc4-fc880f289eca.png)
