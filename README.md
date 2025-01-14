# UserSystem
Prueba Tecnica para Ingreso a InfoDOC

Proyecto desarrollado en C#, con conexión a base de datos SQL Server 2022 Express

EL proyecto se creo usando la plantilla provista por VS 2022, para Blazor Web App

![image](https://github.com/user-attachments/assets/e1f04c71-d002-4998-b518-b72c06730f99)

con la siguientes configuraciones 

![image](https://github.com/user-attachments/assets/ea00b309-0454-4713-9904-4fbe7ef2122b)

es decir, se uso la Authentication de campo tipo cuentas individuales, esto generó la estructura requerida para el manejo de usuarios, las sessiones, los claims y demás extensiones porpias del framework


esta es la estructura del proyecto
![image](https://github.com/user-attachments/assets/8a760553-8218-40d7-8f86-a0429c93b2d7)

allí encontramos carpeta de components, la carpeta Data y el program.cs

En components encontramos los archivos razor de la aplicación, ademas de la definición del layout, el main de la aplicación en general y el main del Account
En data encontramos las migraciones, el context y la entidad basica que se usa la conexion a la base de datos

en program todo lo referente a la configuración de servicios, middleware, filters y el uso de los mismos.

