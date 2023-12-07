
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

('Jelena','Žgela','jelena25@gmail.com','?akovo','Hrvatska'),

('Angelika','Beketari?','angelikab15@gmaul.com','Dubrovnik','Hrvatska'),

('Verica','Danlin?evi?','verica-danlincevic@.com','Osijek','Hrvatska'),

('Elizabeta','Wagner','elizabeta18@hotmail.com','?akovo','Hrvatska');


insert into recepti(naziv,autor,opis) values

('Palačinke',1,'pala?inke s džemom'),
('Tiramisu',2,'klasi?ni talijanski desert s kavom i marscapone sirom'),
('Pizza Margherita',3,'klasi?na talijanska pizza s raj?icom, mocarela sirom i bosiljkom'),
('Pasta Carbonara',1,'klasi?na talijanska tjestenina sa slaninom,jajima,parmezanom i crnim paprom'),
('Buhtle',1,'buhtle s pekmezom od šljiva podravka'),
('Bolonjez',1,'umak s mljevenim mesom'),
('Gr?ka salata',3,'salata s povr?em i feta sirom'),
('Cezar salata',1,'salata s povr?em i pile?im prsima'),
('Poga?ice s ?varcima',4,'poga?ice s mljevenim ?varcima'),
('Integralni krekeri',5,'krekeri sa svježim sirom'),
('Sinjski uštipci',5,'prženi uštipci na ulju s dodatkom rakije'),
('Poga?ice sa sirom',4,'poga?ice sa svježim sirom'),
('Kiflice',1,'slane kiflice bez punjenja'),
('Boži?ni vinski kuglof',3,'kuglof s vinom i kakaom'),
('Kola?i? od roga?a',5,'keksi od roga?a s dodatkom meda'),
('?okoladni kola?i?i',2,'?okoladni kola?i?i s dodatkom oraha i nasjeckanom ?okoladom'),
('Rolada s kavom',3,'biskvit s kavom i ?okoladnim vrhnje'),
('Krpice sa zeljm',1,'tjestenina s pirjanim zaljem'),
('Zape?eni grah',3,'bijeli grah skobasicom iz pe?nice'),
('Vatrena krilca',4,'pe?ena pile?a krilca iz pe?nice'),
('Sarma',5,'mljeveno mješano meso umotano u kiseli kupus');



