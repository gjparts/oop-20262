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