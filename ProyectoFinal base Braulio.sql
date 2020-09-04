create database ProyectoFinal

use ProyectoFinal

create table Usuario
(
id_area varchar(5),
id_empleado varchar(5),
nombre varchar(50),
usuario varchar(10),
contraseña varchar(10)
)

create proc Logueo
@ID int,
@contraseña varchar(50)
as
select nombre,apellidos,rol from Persona
where ID=@ID and contraseña=@contraseña

---------------------------------------
insert into Usuario values('A1','E1','Yasin','yasin','123')
insert into Usuario values('A2','E2','Allan','allan','123')
insert into Usuario values('A3','E3','Braulio','braulio','123')
---------------------------------------

create table Persona(
ID int primary key,
contraseña varchar(50) not null,
nombre varchar(50) not null,
apellidos varchar(50) not null,
telefono int not null,
email varchar(50) not null,
direccion varchar(150) not null,
rol varchar(15)
)

insert into Persona values(123, '123', 'Braulio', 'Castillo', 87690106, 'braulio', 'Corralillo', 'Cliente')
insert into Persona values(1, '1', 'Braulio', 'Castillo', 87690106, 'braulio', 'Corralillo', 'Cliente')
insert into Persona values(2, '2', 'Braulio', 'Castillo', 87690106, 'braulio', 'Corralillo', 'Admin')


select * from Persona


create table Supermercado(
ID int not null primary key,
nombre varchar(50) not null,
localidad varchar(50) not null,
ID_dueno int not null,
foreign key (ID_dueno) references Persona(ID)
)

-------inserta super--------------
go
create procedure insertaSuper
@ID int, @nombre varchar(50), @localidad varchar(50), @ID_Dueño int
as
insert into Supermercado values(@ID, @nombre, @localidad, @ID_Dueño)
go 

execute insertaSuper id, nombre, localidad, dueño

------------------visualiza super------------
go
create procedure visualizaSuper
as
select * from Supermercado
go 

--------------------modifica super-------------
go
create procedure modificaSuper
@ID int, @nombre varchar(50), @localidad varchar(50), @ID_Dueño int
as
update Supermercado set nombre = @nombre, localidad = @localidad
where ID = @ID
go 

execute modificaSuper id, 'nombre', 'localidad', IDDueño

---------------------------------------------------------
create table Sede(
Id int not null primary key,
localidad varchar(50) not null,
ID_encargado int not null,
ID_Supermercado int not null,
foreign key (ID_encargado) references Persona(ID),
foreign key (ID_Supermercado) references Supermercado(ID)
)

----------------------crea sede----------------
go
create procedure creaSede
@ID int, @localidad varchar(50), @ID_Encargado int, @ID_Supermercado int
as
insert into Sede values(@ID, @localidad, @ID_Encargado, @ID_Supermercado)
go

execute creaSede id, 'localidad', idEncargado, idSuper

---------------------modifica sede------------
go
create procedure modificaSede
@ID int, @localidad varchar(50)
as
update Sede set localidad = @localidad
where ID = @ID
go 

drop procedure modificaSede

execute modificaSede 1, 'localidad'

---------------------visualiza sede--------------
go
create procedure visualizaSede
@Id int
as
select * from Sede
where Id = @ID
go


---------------------------------------------

create table Factura(
ID int identity primary key,
fecha datetime not null,
monto money not null,
ID_usuario int not null,
foreign key (ID_usuario) references Persona(ID)
)

------------ver facturas usuario----------------
go
create procedure verFacturas 
@ID_Usuario int
as
select * from Factura f
join Persona p on p.ID = f.ID_usuario
where f.ID_usuario = @ID_Usuario
go

----------ver facturas admin--------------
go
create procedure verFacturas
as
select f.ID, f.fecha, f.monto, p.nombre, p.apellidos, p.email, p.telefono, p.direccion
from Factura f
join Persona p on p.ID = f.ID_usuario
go



------------ingresar facturas-------------
go
create procedure ingresaFactura
@fecha datetime, @monto money, @ID_Usuario int
as
insert into Factura values(@fecha, @monto, @ID_Usuario)
go


execute ingresaFactura '27/08/1994', 10000, 123
-------------modificar facturas----------
go
create procedure modificaFactura
@ID int, @fecha datetime, @monto money
as
update Factura set fecha = @fecha, monto = @monto
where ID = @ID
go

-----------elimina factura--------------
go
create procedure eliminaFactura
@ID int
as
delete from Factura
where ID = @ID
go

----------historial de compras por usuario------------
go
create procedure extraFacturasUsuario
@ID int
as
select * 
from Factura
where ID_usuario = @ID
go

-----------------detalles historial usuario--------------
go 
create procedure extraeDetalles
@ID_Factura int
as
select * 
from DetalleFactura df
where Factura f on f.ID = df.ID_Factura
go
---------------------------

---------------------
create table Articulo(
codigo int primary key,
precio money not null,
existencias int not null,
detalle varchar(250) not null,
imagen image
)

create table DetalleFactura(
ID int identity primary key,
ID_Articulo int not null,
ID_Factura int not null,
valor_Articulo money not null,
cantidad int not null,
valor_total money not null,
foreign key (ID_Articulo) references Articulo(codigo),
foreign key (ID_Factura) references Factura(ID)
)

-----------------ingresa detalle------------
go
create procedure ingresaDetalle
@ID_Articulo int, @ID_Factura int, @valor_Articulo money, @cantidad int, @valor_total money
as
insert into DetalleFactura values(@ID_Articulo, @ID_Factura, @valor_Articulo, @cantidad, @valor_total)
go

execute ingresaDetalle idArticulo, idFactura, valorArticulo, cantidad, valorTotal

-----------------visualiza detalle admin---------------
go
create procedure visualizaDetalleAdmin
as
select * from DetalleFactura
go

-----------visualiza detalle usuario------------
go
create procedure visualizaDetalleAdmin
@ID int
as
select * from DetalleFactura df
join Factura f on f.ID = df.ID
join Persona p on p.ID = f.ID_usuario
where f.ID_usuario = @ID
go


------------------Procedimientos Yashin----------
------------------------------------------------
--------------------------------------------------
go
create procedure inserta_articulo
@codigo int,
@precio money, 
@existencias int,
@detalle varchar(250),
@imagen image

as 
insert into Articulo(codigo, precio, existencias, detalle, imagen)
values (@codigo, @precio, @existencias, @detalle, @imagen)

------------
go
create procedure actualizar_Articulo
@codigo int,
@precio money, 
@existencias int,
@detalle varchar(250),
@imagen image

as 
update Articulo set precio = @precio, existencias = @existencias, detalle = @detalle, imagen = @imagen where codigo = @codigo


-----------ELIMINAR ARTICULO
create procedure eliminar_articulo
@codigo int

as 
delete from Articulo where @codigo = codigo


----------CONSULTAR ARTICULO POR ID
create procedure consultar_articulo
@codigo int

as 
select * from Articulo where @codigo = codigo


select * from Supermercado where ID = 123
select * from Articulo
select * from Sede

select s.ID, s.nombre, s.localidad, p.nombre, p.apellidos
from Supermercado s
join Persona p on s.ID_dueno = p.ID

select * 
from Sede s
join Persona p on p.ID = s.ID_encargado
where s.Id = 1;
select * from Persona

select s.Id, s.localidad, sm.nombre as super, p.nombre, p.apellidos 
from Sede s
left join Persona p on p.ID = s.ID_encargado
left join Supermercado sm on sm.ID = s.ID_encargado


select *--, p.nombre, p.apellidos 
from Sede s
join Supermercado sm on sm.ID = s.ID_encargado

select * from Factura
select * from DetalleFactura

select df.ID, a.detalle as articulo, df.valor_Articulo, df.cantidad, df.valor_total
from DetalleFactura df
join Factura f on f.ID = df.ID_Factura
join Articulo a on a.codigo = df.ID_Articulo
where f.ID = 4

select f.fecha, f.monto, p.nombre, p.apellidos
from Factura f
join Persona p on p.ID = f.ID_usuario
where f.ID = 1


----------------------------------------------------------------------
create procedure inserta_usuario
@ID int,
@contraseña varchar(50),
@nombre varchar(50),
@apellidos varchar(50),
@telefono int,
@email varchar(50),
@direccion varchar(150),
@rol varchar(15)
 
as 
insert into Persona(ID, contraseña, nombre, apellidos, telefono, email, direccion, rol)
values (@ID, @contraseña, @nombre, @apellidos, @telefono, @email, @direccion, @rol)


--------------------------------------------------------------------
create proc Logueo
@ID int,
@contraseña varchar(50)
as
select nombre,apellidos,rol from Persona 
where ID=@ID and contraseña=@contraseña
 
go
-------------------------
 
create procedure inserta_usuario
@ID int,
@contraseña varchar(50),
@nombre varchar(50),
@apellidos varchar(50),
@telefono int,
@email varchar(50),
@direccion varchar(150),
@rol varchar(15)
 
as 
insert into Persona(ID, contraseña, nombre, apellidos, telefono, email, direccion, rol)
values (@ID, @contraseña, @nombre, @apellidos, @telefono, @email, @direccion, @rol)
 
--------------------------------------------------------
------------
go
create procedure actualizar_usuario
@ID int,
@contraseña varchar(50),
@nombre varchar(50),
@apellidos varchar(50),
@telefono int,
@email varchar(50),
@direccion varchar(150),
@rol varchar(15)
 
as 
update Persona set contraseña = @contraseña, nombre = @nombre, apellidos = @apellidos, telefono = @telefono, email = @email, direccion = @direccion, rol = @rol where ID = @ID


