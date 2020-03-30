drop database if exists Juego;
create database Juego;

create table Jugador(
Username text primary key not null,
Password text not null
)ENGINE = InnoDB;

create table Partida(
Identificador integer primary key not null,
Fecha text not null,
Duracion float not null,
Ganador text not null
)ENGINE = InnoDB;

create table Performance(
Jugador text not null,
Partida integer not null,
foreign key (Jugador) references Jugador(Username),
foreign key (Partida) references Partida(Identificador)
)ENGINE = InnoDB;

insert into Jugador('Victor','Guapo');
insert into Jugador('Axel','Negro');
insert into Jugador('Sergio','Deja de dormir puerco');
insert into Jugador('Fran','Que le harias');
insert into Jugador('David','Enfermo');
insert into Jugador('Carlos','Hueles mal');

insert into Partida(1,'15/03/2019 19:08',20.5,'Axel');
insert into Partida(2,'15/03/2019 19:33',21.2,'Axel');
insert into Partida(3,'15/03/2019 20:08',17.5,'Victor');
insert into Partida(4,'11/11/2019 11:01',14.5,'Carlos');
insert into Partida(5,'11/11/2019 19:38',25.5,'Fran');

insert into Performance('Axel',1);
insert into Performance('Axel',2;
insert into Performance('Axel',3);
insert into Performance('Victor',2);
insert into Performance('Victor',3);
insert into Performance('Victor',5);
insert into Performance('Sergio',1);
insert into Performance('Sergio',2);
insert into Performance('Sergio',3);
insert into Performance('Sergio',4);
insert into Performance('Sergio',5);
insert into Performance('Fran',1);
insert into Performance('Fran',5);
insert into Performance('Carlos',1);
insert into Performance('Carlos',4);
insert into Performance('Carlos',5);
insert into Performance('David',4);
insert into Performance('David',5);

