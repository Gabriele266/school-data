CREATE DATABASE SCUOLA;
USE SCUOLA;

CREATE TABLE STUDENTI(
id INT AUTO_INCREMENT,
nome VARCHAR(30),
cognome VARCHAR(30),
assenze INT,
classe CHAR(2),
specializzazione VARCHAR(30),
PRIMARY KEY (id)
);

CREATE TABLE VOTI (
idVoto INT AUTO_INCREMENT,
idStudente INT,
voto FLOAT,
materia VARCHAR(30),
PRIMARY KEY (idVoto),
FOREIGN KEY(idStudente) REFERENCES STUDENTI(id)
);

INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Rossi", "Mario", 5, "1A", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Neri", "Chiara", 0, "1A", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Rosso", "Stefano", 3, "1A", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Nero", "Luca", 1, "1A", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Bianchi", "Luisa", 8, "1B", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Verdi", "Giovanni", 36, "1B", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Bianco", "Alessandro", 2, "1B", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Verde", "Eleonora", 3, "1B", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Bianca", "Francesca", 2, "2A", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Viola", "Fabrizio", 7, "2A", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Bordiga", "Tommaso", 2, "2A", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Audisio", "Gabriele", 3, "2A", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Carriera", "Cirillo", 0, "2B", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Malipiero", "Federica", 0, "2B", "Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Filogamo","Stefano",4,"2B","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Catenazzi","Gaspare",23,"2B","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Tanzini ","Tatiana",12,"3A","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Salvo","Vanessa",2,"3A","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Baroffio","Jolanda",6,"3A","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES
("Bruscantini","Martina",3,"3A","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Bernetti","Antonia",2,"3B","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Lombardi","Carla",6,"3B","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Cicilia","Stefano",2,"3B","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Metella","Giulietta",8,"3B","Meccanica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Barracco", "Erika", 5, "1A", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Maggioli", "Napoleone", 0, "1A", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Pulci-Ungaretti", "Severino", 3, "1A", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Gaito", "Luca", 1, "1A", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Lucchesi", "Costanzo", 8, "1B", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Bersani", "Dina", 36, "1B", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Chiappetta", "Victoria", 2, "1B", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Sgalambro", "Adele", 3, "1B", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Armani", "Vincenzo", 2, "2A", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Mozart", "Nino", 7, "2A", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Civaschi", "Amanda", 2, "2A", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Nadi", "Amadeo", 3, "2A", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Sagese", "Lodovico", 0, "2B", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Malipiero", "Federica", 0, "2B", "Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Dallara","Adriano",4,"2B","Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Micca","Evangelista",23,"2B","Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Cortese ","Napoleone",12,"3A","Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Pisacane","Stefania",2,"3A","Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Vespa","Silvia",6,"3A","Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Bellucci","Liliana",3,"3A","Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Magrassi","Gino",2,"3B","Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Stradivari","Luca",6,"3B","Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Franscini","Alessandro",2,"3B","Chimica");
INSERT INTO STUDENTI(cognome, nome, assenze, classe, specializzazione)
VALUES("Faugno","Ida",8,"3B","Chimica");

INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(1, 5.75, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(2, 3, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(3, 8, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(4, 7, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(5, 6, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(6, 6.25, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(7, 5, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(8, 9, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(9, 9.75, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(10, 7, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(11, 3, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(12, 4.5, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(13, 7.25, "Italiano");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(14, 5, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(15, 9, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(16, 8, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(17, 7.25, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(18, 5.75, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(19, 5, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(20, 5.75, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(21, 9, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(22, 7.25, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(23, 5.75, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(24, 7, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(25, 5, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(26, 8, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(27, 7.25, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(28, 5.75, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(29, 9, "Matematica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(30, 5.75, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(31, 8, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(32, 7, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(33, 5, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(34, 5.75, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(35, 7.25, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(36, 5.75, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(37, 9, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(38, 5.75, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(39, 8, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(40, 9, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(41, 7.25, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(42, 5, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(43, 5.75, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(44, 7, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(45, 6.5, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(46, 9, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(47, 5, "Fisica");
INSERT INTO VOTI (idStudente, voto, materia)
VALUES
(48, 5.75, "Fisica");