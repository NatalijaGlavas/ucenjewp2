
use master;
go

drop database if exists kuharica;
go



create database kuharica;
go

alter database kuharica collate Croatian_CI_AS;
go

use  kuharica;


create table autori(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
email varchar(100) not null,
mjesto varchar(50) not null,
drzava varchar(50) not null
);



create table recepti(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
autor int not null,
opis varchar(255) not null
);



alter table recepti add foreign key (autor) references autori(sifra);


insert into autori(ime,prezime,email,mjesto,drzava)
values


('Natalija','Glavaš','natalija-glavas@hotmail.com','Osijek','Hrvatska'),

('Jelena','Žgela','jelena25@gmail.com','Đakovo','Hrvatska'),

('Angelika','Baketarić','angelikab15@gmail.com','Dubrovnik','Hrvatska'),

('Verica','Danlinčević','vericad30@gmail.com','Osijek','Hrvatska'),

('Elizabeta','Wagner','elizabeta18@hotmail.com','Đakovo','Hrvatska');



insert into recepti(naziv,autor,opis) values

('Palačinke',1,'palačinke s džemom'),
('Tiramisu',2,'klasični talijanski desert s kavom i marscapone sirom'),
('Pizza Margherita',3,'klasična talijanska pizza s rajčicom,mocarela sirom i bosiljkom'),
('Pasta Carbonara',1,'klasična talijanska tjestenina sa slaninom,jajima,parmezanom i crnim paprom'),
('Buhtle',1,'buhtle s pekmezom od šljiva podravka'),
('Bolonjez',1,'umak s mljevenim mesom'),
('Grčka salata',3,'salata s povrćem i feta sirom'),
('Cezar salata',1,'salata s povrćem i pilećim prsima'),
('Pogačice s čvarcima',4,'pogačice s mljevenim čvarcima'),
('Sinjski uštipci',5,'prženi uštipci na ulju s dodatkom rakije'),
('Pogačice sa sirom',4,'pogačice sa svježim sirom'),
('Kiflice',1,'slane kiflice bez punjenja'),
('Božićni vinski kuglof',3,'kuglof s vinom i kakaom'),
('Čokoladni kolačići',2,'čokoladni kolačići s dodatkom oraha i nasjeckanom čokoladom'),
('Rolada s kavom',3,'biskvit s kavom i čokoladnim vrhnjem'),
('Krpice sa zeljem',1,'tjestenina s pirjanim zeljem'),
('Zapečeni grah',3,'bijeli grah s kobasicom iz pećnice'),
('Vatrena krilca',4,'pečena pileća krilca iz pećnice'),
('Sarma',5,'mljeveno mješano meso umotano u kiseli kupus'),
('Punjena patka',2,'punjena patka s telećim mljevenim mesom'),
('Pečeni zec',3,'pečeni zec s mrkvom,celerom,maslinovim uljem,rajčicom i bosiljkom'),
('Bečki odrezak',1,'panirani teleći odrezak'),
('Hrskavi pileći batak',1,'pečeni pileći batkovi s krompirom,graškom i mrkvom'),
('Pureće pečenje',1,'Pečena pureća prsa s šampinjonima,slaninom i keljom'),
('Svinjski odrezak s gljivama',4,'svinjski kotlet s dvije vrste gljiva');
