CREATE TABLE [dbo].Mitarbeiter
(
	PersonalNummer INT NOT NULL PRIMARY KEY,
	Vorname VARCHAR(255),
	Nachname VARCHAR(255),
	Eintrittsdatum DATETIME
)
