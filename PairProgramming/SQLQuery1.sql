CREATE TABLE PairMusik(

	Title VARCHAR(80) NOT NULL,
	Artist VARCHAR(80) NOT NULL,
	Dura FLOAT NOT NULL,
	YearOfPub int NOT NULL,
	Label VARCHAR(80) NOT NULL,
	Genre VARCHAR(80) NOT NULL,


	Primary KEY (Title, Artist)


);
