create database UsuariosDB
go 
use UsuariosDB
go
create table Usuarios(
UsuarioId int primary key identity,
Usuario varchar(20),
Tipo varchar(20),
Nombre varchar(30),
Contrasena varchar(15)

);

select * from Usuarios