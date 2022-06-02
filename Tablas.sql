create database Laberinto;
use Laberinto;

CREATE TABLE DatosJugador (
    idDatosJugador int,
    time float,
    points int
);

select * from DatosJugador;
select * from DatosJugador where idDatosJugador=1;


insert into DatosJugador values(1, 12.5, 30);