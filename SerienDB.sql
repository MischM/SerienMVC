CREATE DATABASE SerienDB
go
use SerienDB
go
CREATE TABLE Genre
(
	ID integer IDENTITY (1,1) PRIMARY KEY,
	Name varchar(50) NOT NULL,
)
go
CREATE TABLE Serie
(
	ID integer IDENTITY (1,1) PRIMARY KEY,
	Name varchar(50) NOT NULL,
	Rating integer NULL,
	ReleaseDate date NOT NULL
)
go
CREATE TABLE Actor
(
	ID integer IDENTITY (1,1) PRIMARY KEY,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
)
go
CREATE TABLE SerieGenre
(
	fk_Genre integer NOT NULL,
	fk_Serie integer NOT NULL,
	FOREIGN KEY (fk_Genre) REFERENCES Genre(ID),
	FOREIGN KEY (fk_Serie) REFERENCES Serie(ID),
	PRIMARY KEY (fk_Genre, fk_Serie)
)
go
CREATE TABLE SerieActor
(
	fk_Serie integer NOT NULL,
	fk_Actor integer NOT NULL,	
	FOREIGN KEY (fk_Actor) REFERENCES Actor(ID),
	FOREIGN KEY (fk_Serie) REFERENCES Serie(ID),
	PRIMARY KEY (fk_Actor, fk_Serie)	
)

go

INSERT INTO Genre VALUES ('Action')
INSERT INTO Genre VALUES ('Fantasy')
INSERT INTO Genre VALUES ('Romance')

INSERT INTO Actor VALUES ('Katherin','Langford')
INSERT INTO Actor VALUES ('Dylan','Minnette')
INSERT INTO Actor VALUES ('Grant','Gustin')
INSERT INTO Actor VALUES ('Ellen','Pompeo')
INSERT INTO Actor VALUES ('Sandra','Oh')

INSERT INTO Serie VALUES ('13 Reasons Why', 9 , '2017-03-31')
INSERT INTO Serie VALUES ('The Flash', 8 ,'2014-10-07')
INSERT INTO Serie VALUES ('Greys Anatomy', 8 ,'2005-03-27')

INSERT INTO SerieActor VALUES (1,1)
INSERT INTO SerieActor VALUES (1,2)
INSERT INTO SerieActor VALUES (2,3)
INSERT INTO SerieActor VALUES (3,4)
INSERT INTO SerieActor VALUES (3,5)

INSERT INTO SerieGenre VALUES (1,2)
INSERT INTO SerieGenre VALUES (2,2)
INSERT INTO SerieGenre VALUES (3,1)
INSERT INTO SerieGenre VALUES (3,3)