drop database if exists Proyecto;
CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE Socios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    fecha_nacimiento DATE,
    email VARCHAR(100) UNIQUE,
    dni VARCHAR(20) UNIQUE,
    apt_fisica BOOLEAN default false,
    venc_pago DATE
);

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

create table usuario(
CodUsu int auto_increment,
RolUsu int,
NombreUsu varchar (20),
PassUsu varchar (15),
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into roles values
(01,'Administrador'),
(02,'Usuario');

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(1,'Emma','123456',01);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(2,'Usuario01','123456',02);


/* Procedimiento para usuario */
delimiter //  
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))

begin
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */


end 
//

/* para probar */

call IngresoLogin('dato1', 'dato2')//

