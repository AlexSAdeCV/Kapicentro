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
('Administrado', 'Control total del sistema'),
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
	idproveedor int

	foreign key (idproveedor) references Proveedor (IDProveedor)
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
	IDProducto int primary key identity (1,1) not null,
	Nombre nvarchar(max),
	Descripcion nvarchar (max),
	idmadera int,
	PrecioV money,
	Alto float,
	Largo float,
	Ancho float,
	Existencia int

	foreign key (idmadera) references Almacen (IDAlmacen)
)
go

insert into Producto values 
('Silla Luisiana', 'Silla con diseño vanguardista, Ideal para complementar tu espacio.' ,1,5390.00,40,48,99,10),
('Mesa Chicago', 'Mesa con el color ideal para tu hogar' ,2,4423.00,40,69,55,25),
('Buro Renata', 'Buro Renata para complementar tu habitacion' ,3,3599.00,50,69,65,2),
('Taburete Kim', 'Diseño vanguardista ideal para complementar tu sala' ,4,3990.00,60,25,55,15)
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
	idmadera int,
	Acabado nvarchar (50)

	foreign key (idmadera) references Almacen (IDAlmacen)
)
go

insert into Cotizacion values 
('Silla', 70,50,50, 1300, 1, 'Barnizado'),
('Buro', 70,50,58, 1300, 1, 'Barnizado'),
('Mesa', 80,160,81, 1300, 1, 'Barnizado'),
('Taburete', 60,40.5,31, 1300, 1, 'Barnizado')
go

select * from Ventas
go