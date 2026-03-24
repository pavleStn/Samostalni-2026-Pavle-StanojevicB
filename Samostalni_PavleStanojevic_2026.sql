create database projekat_2026_PaveStanojevicB

use projekat_2026_PaveStanojevicB

create table Korisnici(
	id INT identity(1,1) primary key,
	email varchar(30),
	pass varchar(20),
	status INT
)