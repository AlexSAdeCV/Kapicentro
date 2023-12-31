﻿use master
go
Create database Karpicentro
--On
--(Name = KarpicentroDat, Filename = 'E:\5to\Karpicentro\Karpicentro Base\KarpicentroMDF.mdf', SIZE = 10, MAXSIZE	= 50, FILEGROWTH = 5)
--Log on 
--(Name = KarpicentroLog, Filename = 'E:\5to\Karpicentro\Karpicentro Base\KarpicentroLDF.ldf', SIZE = 5MB, MAXSIZE = 25MB, FILEGROWTH = 5MB);
go

use Karpicentro
go

create table Puestos 
(
	Puesto int primary key identity (1,1),
	Identificacion nvarchar(40),
	Descripcion nvarchar (40) 
)
go

insert into Puestos values 
('Administrador', 'Control total del sistema'),
('Empleado', 'Empleado')
go

create table Empleados 
(
	IDEmpleado int primary key identity (1,1) not null,
	usuario nvarchar (40),
	Contraseña nvarchar (40),
	idpuesto int,
	Nombre nvarchar (40),
	ApellidoPaterno nvarchar (40),
	ApellidoMaterno nvarchar (40),
	Telefono nvarchar (40),
	Calle nvarchar (40),
	NoExterior nvarchar (40),
	CodigoPostal nvarchar (40),
	Sueldo money,

	foreign key (idpuesto) references Puestos (Puesto)
)
go

insert into Empleados values
('Juper456', 'DuendeVerde', 1, 'Juan', 'Perez', 'Gomez', '5640719551', 'Calle Madero', '123', '12345', 50000.00),
('Maga967', 'magician67', 2, 'Maria', 'Lopez', 'Garcia', '5572668334', 'Calle Benito Juarez', '456', '67890', 60000.00),
('Carmart865', 's$iVr52', 2, 'Carlos', 'Rodriguez', 'Martinez', '5613285327', 'Paseo de la Reforma', '789', '54321', 55000.00),
('Lagura231', 'EHv57@TCC2', 2, 'Laura', 'Gutierrez', 'Ramirez', '5554793407', 'Av Alvaro Obregón', '987', '13579', 52000.00),
('Jaflora912', '11APDf9s1q', 2, 'Javier', 'Lara', 'Flores', '5657814671', 'Calle Ámsterdam', '246', '80246', 58000.00),
('AnaDiaz798', '3SbXC6w79', 2, 'Ana', 'Hernandez', 'Diaz', '7645891334', 'Calle Genova', '357', '97531', 53000.00)
go

create table Clientes
(
    IDCliente int primary key identity (1,1),
    Nombre nvarchar(40),
    ApellidoPaterno nvarchar(40),
    ApellidoMaterno nvarchar(40),
    Telefono nvarchar(40),
    Calle nvarchar(40),
    NoExterior nvarchar(40),
    CodigoPostal nvarchar(40),
    Delegacion nvarchar(40)
)
go

insert into Clientes values
('Juan', 'Gomez', 'Lopez', '55 1234 5678', 'Insurgentes Sur', '123', '01000', 'Benito Juarez'),
('Maria', 'Perez', 'Martinez', '55 2345 6789', 'Paseo de la Reforma', '456', '06500', 'Cuauhtemoc'),
('Carlos', 'Lara', 'Rodriguez', '55 3456 7890', 'Avenida Juarez', '789', '03000', 'Cuauhtemoc'),
('Ana', 'Gonzalez', 'Santos', '55 4567 8901', 'Calle Madero', '1011', '06000', 'Cuauhtemoc'),
('Pedro', 'Ramirez', 'Cruz', '55 5678 9012', 'Avenida Chapultepec', '1213', '06700', 'Cuauhtemoc'),
('Laura', 'Diaz', 'Flores', '55 6789 0123', 'Calzada de Tlalpan', '1415', '14000', 'Tlalpan'),
('Miguel', 'Fernandez', 'Rios', '55 7890 1234', 'Avenida Insurgentes Norte', '1617', '07700', 'Gustavo A. Madero'),
('Sofia', 'Lopez', 'Jimenez', '55 8901 2345', 'Calle Venustiano Carranza', '1819', '06050', 'Cuauhtemoc'),
('Raul', 'Torres', 'Hernandez', '55 9012 3456', 'Paseo de la Castellana', '2021', '01030', 'Benito Juarez'),
('Elena', 'Garcia', 'Ortiz', '55 0123 4567', 'Calle 16 de Septiembre', '2223', '06750', 'Cuauhtemoc')
go

Create Table Proveedor
(
	IDProveedor int primary key identity (1,1),
	NombreProv nvarchar (30),
	Colonia nvarchar(30),
	Delegacion nvarchar (30),
	Calle nvarchar(30),
	C_Postal nvarchar (5),
	Telefono nvarchar (10),
	PersonaContacto nvarchar (15)
)
go

insert into Proveedor values
('Troncoso S.A','Col. Juarez','Benito Juarez','Calle Madero','09930','5652328247','Jesus'),
('Muebles S.A.','Col. Alvarado','Iztapalapa','Calle San Fierro','09931','5584697136','Mateo'),
('HomeDepot S.A.','Col Tepito', 'Iztacalco','Calle Lucitania','09932','5541278159','Alejandro'),
('Coppel S.A.','Col Pueblo Nuevo', 'Iztapalapa' ,'Calle Mi palito', '09933' ,'5576959475', 'Andres')
go 

create table Almacen
(
	IDAlmacen int primary key identity (1,1),
	TipoMadera nvarchar (50),
	Stock int,
	precioparahacermueble float,
	idprov int

	foreign key (idprov) references Proveedor (IDProveedor)
)
go

insert into Almacen values
('Madera de Acacia','200', 200,4),
('Madera de Abedul','400', 500,1),
('Madera de Jungla','600', 800,3),
('Madera de Roble','100', 1100,2)
go 

Create table Producto 
(
	IDProducto int primary key not null,
	Nombre nvarchar(max),
	Descripcion nvarchar (max),
	idmadera int,
	PrecioV money,
	Alto float,
	Largo float,
	Ancho float,
	Imagen image,
	Existencia int

	foreign key (idmadera) references Almacen (IDAlmacen)
)
go

create table Ventas 
(
	IDVentas int primary key identity (1,1),
	PrecioProducto money,
	Fecha Date,
	idproducto int, 
	idempleado int,
)
go

create table Cotizacion
(
	IDCotizacion int primary key identity (1,1),
	NombreProducto nvarchar (50),
	Alto float,
	Ancho float,
	Largo float,
	PrecioMedidaInicial money,
	Acabado nvarchar (50)
)
go

insert into Cotizacion values 
('Silla', 70,50,50, 1300, 'Barnizado'),
('Buro', 70,50,58, 1300, 'Barnizado'),
('Mesa', 80,160,81, 1300, 'Barnizado'),
('Taburete', 60,40.5,31, 1300, 'Barnizado')
go