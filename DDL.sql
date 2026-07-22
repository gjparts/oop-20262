/*DDL: Data Definition Language, son instrucciones usadas para
la creacion, alteracion y eliminacion de objetos a nivel
de servidor y de base de datos (tablas, bases de datos, llaves, usuatios, vistas, etc.)
Las DDL mas conocidas son: CREATE, ALTER, DROP, TRUNCATE, USE*/

--a estos archivos de SQL se les conoce como Script de bases de datos o tambine
--se les conoce popularmente como queries.

--Crear una base de datos en el servidor donde estamos conectados
CREATE DATABASE Gerardo
GO
/*En toda instruccion de DDL colocamos la instruccion GO, es opcional; pero es
una buena practica.
La instruccion GO permite separar los lotes de ejecucion de instrucciones,
o sea hace una pausa hasta que se termine de ejecutar las instrucciones
que estan antes del GO.*/
--el GO es como un CHECKPOINT.

--Eliminar una base de datos (Importante si no tiene copia de seguridad la pierde)
--Una recomendacion antes de eliminar una base de datos es reiniciar el servidor
--y desconectarlo de la red (si esta fisicamente Usted en el servidor)
USE master --seleccionar la base de datos maestra (sistema)
GO
DROP DATABASE Gerardo --base de datos a borrar
GO

--Crear una tabla dentro de la base de datos que tiene su nombre
--Antes de trabajar en una base de datos, hay que seleccionarla
USE Gerardo
GO
CREATE TABLE Producto(
	ProductoID bigint NOT NULL IDENTITY(1,1), --columna autonumerica de 1 en 1 (solo una por tabla)
	Codigo varchar(20) NOT NULL,
	Nombre varchar(200) NOT NULL,
	Costo decimal(12,2) NOT NULL, --numero decimal de 12 digitos de los cuales reserva 2 para decimales
	PrecioVenta decimal(12,2) NOT NULL,
	Existencias int NOT NULL, --int es entero de 4 bytes, bigint es entero de 8 bytes
	Observaciones text NULL, --text permite almacenar hasta 2GB de texto por registro, depende de la arquitectura
	PRIMARY KEY(ProductoID) --columna que hace unico a cada registro, evita duplicados (llave primaria)
)
GO
/*NOT NULL es una columna que se debe llenar de forma obligatoria
NULL es una columna que su llenado es opcional o sea admite valores nulos.*/

--Borrar una tabla que esta en una base de datos
--IMPORTANTE: borrar una tabla sucede aunque esta este en uso
--siempre seleccione la base de datos antes de borrar la tabla
USE Gerardo
GO
DROP TABLE Producto
GO

--Vaciar el contenido de una tabla (borrar sus registros sin destruir la tabla)
USE Gerardo
GO
TRUNCATE TABLE Producto
GO
--TRUNCATE tambie les reinicia el campo autonumerico, a esto se le conoce
--como TRUNCAR LA TABLA.
