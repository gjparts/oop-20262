/*DML: Data Manipulation Language, son instrucciones
que permiten manipular los registros almacenados
en las tablas de la base de datos.
Las instrucciones mas populares son:
SELECT, INSERT, UPDATE, DELETE

-> Las instrucciones DML no requieren del uso de GO, pero
   si Usted quiere separarlas por lotes puede usar GO.*/
--Importante: siempre seleccione la BD en la que va a trabajar
USE Gerardo
GO

/*Instruccion INSERT
agrega registros a una tabla, consideraciones:
1) El INSERT debe incluir todos los campos/columnas que sean NOT NULL (los obligatorios
2) Los campos NULL son opciones, Ustedes deciden si los ponen en su INSERT
3) Si hay una columna IDENTITY esas no se incluyen en el INSERT, ya que estas son
   autonumeradas por la base de datos.
*/
--INSERT que llena todas las columnas de un registro en la tabla Producto
USE Gerardo
GO

INSERT Producto(Codigo,Nombre,Costo,PrecioVenta,Existencias,Observaciones)
VALUES('CC01','Coca Cola 3L',45,65,100,'Mala para la salud')

INSERT Producto(Codigo,Nombre,Costo,PrecioVenta,Existencias,Observaciones)
VALUES('CC02','Pepsi Cola 3L',42.5,64,80,'Tambien es mala para la salud')

--INSERT no necesita mencionar las columnas en el mismo orden que estan en la tabla
INSERT Producto(Nombre,Costo,PrecioVenta,Codigo,Observaciones,Existencias)
VALUES('Mirinda Uva 2L',25,36,'CC03','Otro que es malo para la salud',15)

--INSERT sin incluir el campo opcional llamado Observaciones (admite NULL)
INSERT Producto(Codigo,Nombre,Costo,PrecioVenta,Existencias)
VALUES('CH01','Ranchita pequeña',10,14,50)

--INSERT Multiregistro:
INSERT Producto(Codigo,Nombre,Costo,PrecioVenta,Existencias,Observaciones)
VALUES
('FR99','Pera Unidad',6.25,8,100,'Buena para la salud'),
('FR43','Manzana Unidad',7.36,9,200,'Muy buena para la salud'),
('HR01','Lechuga Romana Unidad',15.67,23,90,'Buena para la ensalada'),
('CH99','Doritos Flaming Hot Grande',32,48,90,NULL),
('CH46','Taqueritos Fuego Grande',24,50.26,45,NULL),
('CC90','Bolsa con Agua Arroyo',2.5,4,500,'El agua es buena para la salud')

--Saber que hay dentro de una tabla
SELECT * FROM Producto

