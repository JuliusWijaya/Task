CREATE TABLE BIODATA (
	id INT NOT NULL PRIMARY KEY,
	name varchar(120) NOT NULL,
	gender nvarchar(12) NOT NULL,
	birth nvarchar(13) NOT NULL,
	hometown varchar(125) NOT NULL
)

INSERT INTO BIODATA VALUES ('1', 'Dea', 'Laki-laki', '13/05/2023', 'Bandung')
INSERT INTO BIODATA VALUES ('2', 'Eko Kurniawan', 'Laki-laki', '15/09/2022', 'Bandung')
INSERT INTO BIODATA VALUES ('3', 'David Alfa', 'Laki-laki', '29/10/2021', 'Tanggerang BSD')

SELECT * FROM BIODATA

DELETE BIODATA WHERE id='1'

DROP TABLE BIODATA