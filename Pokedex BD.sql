create database Pokedex

use Pokedex

Create Table Pokemons 
(
	ID int primary key,
	Nome varchar(20) not null,
	Descricao varchar(400) not null,
	Tipo varchar(30) not null,
	PreEvolucao int null,
	Evolucao int null,
	CONSTRAINT FK_EvolucaoID Foreign key (Evolucao) REFERENCES Pokemons (ID),
	CONSTRAINT FK_PreEvolucao Foreign key (PreEvolucao) References Pokemons (ID)
	/*CONSTRAINT CHK_Tipo CHECK(Tipo in ('Bug',  'Dark', 'Dragon', 'Electric', 'Fairy',
	'Fighting', 'Fire', 'Flying', 'Ghost', 'Grass', 'Ground', 'Ice', 'Normal', 'Poison',
	'Psychic', 'Rock', 'Steel', 'Water'))*/
)

insert into Pokemons (Nome, Descricao, Tipo, Evolucao, PreEvolucao)
values ('Nulo', 'Nulo', 'Nulo', null,null)

select * from Pokemons

drop table Pokemons