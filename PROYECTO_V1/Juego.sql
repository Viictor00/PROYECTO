drop database if exists Juego;
create database Juego;

use Juego;
create table Jugador( Username varchar(10) primary key not null,
Password text not null
)ENGINE = InnoDB;

create table Partida(Identificador integer primary key not null,
Fecha text not null,
Duracion float not null,
Ganador text not null
)ENGINE = InnoDB;

create table Performance(
Jugador varchar(10) not null,
Partida integer not null,
foreign key (Jugador) references Jugador(Username),
foreign key (Partida) references Partida(Identificador)
)ENGINE = InnoDB;

insert into Jugador values ('Victor','Guapo');
insert into Jugador values ('Axel','Negro');
insert into Jugador values ('Sergio','Yonki');
insert into Jugador values ('Fran','Que le harias');
insert into Jugador values ('David','Colgao');
insert into Jugador values ('Carlos','Hueles mal');

insert into Partida values (1,'15/03/2019 19:08',20.5,'Axel');
insert into Partida values (2,'15/03/2019 19:33',21.2,'Axel');
insert into Partida values (3,'15/03/2019 20:08',17.5,'Victor');
insert into Partida values (4,'11/11/2019 11:01',14.5,'Carlos');
insert into Partida values(5,'11/11/2019 19:38',25.5,'Fran');

insert into Performance values ('Axel',1);
insert into Performance values ('Axel',2);
insert into Performance values ('Axel',3);
insert into Performance values ('Victor',2);
insert into Performance values ('Victor',3);
insert into Performance values ('Victor',5);
insert into Performance values ('Sergio',1);
insert into Performance values ('Sergio',2);
insert into Performance values ('Sergio',3);
insert into Performance values ('Sergio',4);
insert into Performance values ('Sergio',5);
insert into Performance values ('Fran',1);
insert into Performance values ('Fran',5);
insert into Performance values ('Carlos',1);
insert into Performance values ('Carlos',4);
insert into Performance values ('Carlos',5);
insert into Performance values ('David',4);
insert into Performance values ('David',5);

