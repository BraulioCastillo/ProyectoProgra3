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