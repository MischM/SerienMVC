CREATE DATABASE SerienDB
go
use SerienDB
go
CREATE TABLE Genre
(
	ID integer IDENTITY (1,1) PRIMARY KEY,
	Name varchar(50) NOT NULL,
	ON DELETE CASCADE
)
go
CREATE TABLE Serie
(
	ID integer IDENTITY (1,1) PRIMARY KEY,
	Name varchar(50) NOT NULL,
	Rating integer NULL,
	ReleaseDate date NOT NULL
	ON DELETE CASCADE
)
go
CREATE TABLE Actor
(
	ID integer IDENTITY (1,1) PRIMARY KEY,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	ON DELETE CASCADE
)
go
CREATE TABLE SerieGenre
(
	ID integer IDENTITY (1,1) PRIMARY KEY,
	fk_Genre integer FOREIGN KEY REFERENCES Genre(ID),
	fk_Serie integer FOREIGN KEY REFERENCES Serie(ID),
	CONSTRAINT UniqueForeigKeys UNIQUE (fk_Genre, fk_Serie)
)
go
CREATE TABLE SerieActor
(
	ID integer IDENTITY (1,1) PRIMARY KEY,
	fk_Serie integer FOREIGN KEY REFERENCES Serie(ID),
	fk_Actor integer FOREIGN KEY REFERENCES Actor(ID),
	CONSTRAINT UniqueForeigKeys UNIQUE (fk_Actor, fk_Serie)
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

INSERT INTO Serie VALUES ('13 Reasons Why', 9 , convert(date,'31.03.2017',104))
INSERT INTO Serie VALUES ('The Flash', 8 , convert(date,'07.10.2014',104))
INSERT INTO Serie VALUES ('Greys Anatomy', 8 ,convert(date,'27.03.2005',104))

INSERT INTO SerieActor VALUES (1,1)
INSERT INTO SerieActor VALUES (1,2)
INSERT INTO SerieActor VALUES (2,3)
INSERT INTO SerieActor VALUES (3,4)
INSERT INTO SerieActor VALUES (3,5)

INSERT INTO SerieGenre VALUES (1,2)
INSERT INTO SerieGenre VALUES (3,1)
INSERT INTO SerieGenre VALUES (3,3)