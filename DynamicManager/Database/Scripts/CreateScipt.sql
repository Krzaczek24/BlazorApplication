DROP TABLE IF EXISTS Form;

CREATE TABLE Form
(
	Id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	AddDate TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	AddLogin VARCHAR(256) NOT NULL,
	ModifDate TIMESTAMP NULL ON UPDATE CURRENT_TIMESTAMP,
	ModifLogin VARCHAR(256) NULL,
	IsActive BOOLEAN NOT NULL DEFAULT TRUE,
	Title VARCHAR(256) NOT NULL
);

INSERT INTO Form(AddLogin, Title) VALUES('SYSTEM', 'Tytuł');

SELECT * FROM Form;