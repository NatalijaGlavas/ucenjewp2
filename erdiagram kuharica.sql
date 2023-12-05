
--use master;
--go

--drop database if exists kuharica;
--go



--create database kuharica;
--go
--use database kuharica;


--create table autori(
--sifra int not null primary key identity(1,1),
--ime varchar(50) not null,
--prezime varchar(50) not null,
--email varchar(100) not null,
--mjesto varchar(50) not null,
--drzava varchar(50) not null
--);



--create table recepti(
--sifra int not null primary key identity(1,1),
--naziv varchar(50) not null,
--autor int not null,
--opis varchar(255) not null
--);



--alter table recepti add foreign key (autor) references autori(sifra);