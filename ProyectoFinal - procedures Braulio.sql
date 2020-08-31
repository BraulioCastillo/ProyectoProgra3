create database ProyectoFinal

use ProyectoFinal


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

create table Supermercado(
ID int not null primary key,
nombre varchar(50) not null,
localidad varchar(50) not null,
ID_dueno int not null,
foreign key (ID_dueno) references Persona(ID)
)

create table Sede(
Id int not null primary key,
localidad varchar(50) not null,
ID_encargado int not null,
ID_Supermercado int not null,
foreign key (ID_encargado) references Persona(ID),
foreign key (ID_Supermercado) references Supermercado(ID)
)

create table Factura(
ID int identity primary key,
fecha datetime not null,
monto money not null,
ID_usuario int not null,
foreign key (ID_usuario) references Persona(ID)
)

------------ver facturas----------------
go
create procedure verFacturas 
@ID_Usuario int
as
select * from Factura f
join Persona p on p.ID = f.ID_usuario
where f.ID_usuario = @ID_Usuario
go

------------ingresar facturas-------------
go
create procedure ingresaFactura
@ID int, @fecha datetime, @monto money, @ID_Usuario int
as
insert into Factura(@ID, @fecha, @monto, @ID_Usuario)
go

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
insert into DetalleFactura(@ID_Articulo, @ID_Factura, @valor_Articulo, @cantidad, @valor_total)
go