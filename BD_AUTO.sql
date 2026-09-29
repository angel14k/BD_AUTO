

create database BD_AUTO

use BD_AUTO

create table AUTO
(
pk_id_auto_in int identity(1,1) primary key,
marca_vc varchar(100),
color_vc varchar(100),
modelo_vc varchar(100),
año_in int,
)

select * from AUTO

insert into AUTO
(marca_vc, color_vc, modelo_vc, año_in)
values
('TOYOTA', 'BLANCO', 'VAGONETA',2000),
('SUZUKI', 'NEGRO', 'CAMIONETA', 1999),
('CHANGAI', 'AZUL', 'CAMION',2002),
('MAZDA', 'BEIGE', 'DEPORTIVO',1994),
('BMW', 'BLANCO', 'COMPACTO',2001)

