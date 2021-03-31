

CREATE TABLE Zamestnanec
(
   ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   Jmeno nvarchar(100),
   Prijmeni nvarchar(100),
   CeleJmeno nvarchar (200),
   PracovniEmail nvarchar(100),
   SoukromyEmail nvarchar(100),
   Doktorand bit,
   Uvazek float,
   PracovniTelefon nvarchar(50),
   SoukromyTelefon nvarchar (50),
   /*
   rank integer not null default 1, 
   constraint fk_user_rank foreign key (rank) references user_rank (id)  */
);
insert into Zamestnanec (Jmeno, Prijmeni, CeleJmeno, PracovniEmail, SoukromyEmail, Doktorand, Uvazek, PracovniTelefon, SoukromyTelefon)

values
	('Pavel', 'Vaøacha', 'Pavel Vaøacha', 'varacha@utb.cz', 'cestamece@kendo.cz', 0, '0.5', '123123123', '777777777'),
	('Jan', 'Novák', 'Jan Novák', 'novak@utb.cz', 'bezmece@kendo.cz', 0, '0.5', '555555555', '+420111555999');


CREATE TABLE Skupinka
(
   ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   Zkratka nvarchar(100),
   Rocnik int,
   Semestr nvarchar(50),			-- enum
   PocetStudentu int,
   FormaStudia nvarchar(50),		-- enum
   TypStudia nvarchar(50),			-- enum
   Jazyk nvarchar(50),				-- enum
   Nazev nvarchar(100),
   
   /* provazani v pripade enum
   rank integer not null default 1, 
   constraint fk_user_rank foreign key (rank) references user_rank (id)  */
);
insert into Skupinka (Zkratka, Rocnik, Semestr)

values
	('SWI', 4, 'ZS'),
	('KYB', 4, 'LS');

CREATE TABLE Predmet
(
   ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   Zkratka nvarchar(100),
   PocetTydnu int,
   HodinyPrednasek int,
   HodinyCviceni int,
   HodinySeminaru int,
   ZpusobZakonceni nvarchar(50),	-- enum
   Jazyk nvarchar(50),				-- enum
   VelikostTridy int,
   NazevPredmetu nvarchar(100),
   PocetKreditu int,
   GarantujiciUstav nvarchar(100),	--enum
   JmenoGaranta nvarchar(200)
      
 
    /* provazani v pripade enum
   rank integer not null default 1, 
   constraint fk_user_rank foreign key (rank) references user_rank (id)  */
);
insert into Predmet (Zkratka, PocetTydnu, VelikostTridy)

values
	('AK8PO', 14, 30),
	('AK7SU', 14, 12);

CREATE TABLE VahyPracovnichBodu
(
   ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	HodinaPrednasky float not null default 1,
	HodinaCviceni float not null default 1,
	HodinaSeminare float not null default 1,
	HodinaPrednaskyAnglicky float not null default 1,
	HodinaCviceniAnglicky float,
	HodinaSeminareAnglicky float,
	UdeleniJednohoZapoctu float,
	UdeleniJednohoKlasifikovanehoZapoctu float,
	UdeleniJedneZkousky float,
	UdeleniJednohoZapoctuAnglicky float,
	UdeleniJednohoKlasifikovanehoZapoctuAnglicky float,
	UdeleniJedneZkouskyAnglicky float,
      
 
    /* provazani v pripade enum
   rank integer not null default 1, 
   constraint fk_user_rank foreign key (rank) references user_rank (id)  */
);

insert into VahyPracovnichBodu (HodinaPrednasky, HodinaCviceni, HodinaSeminare) /*, HodinaPrednaskyAnglicky, HodinaCviceniAnglicky, HodinaSeminareAnglicky,
UdeleniJednohoZapoctu, UdeleniJednohoKlasifikovanehoZapoctu, UdeleniJedneZkousky, UdeleniJednohoZapoctuAnglicky, UdeleniJednohoKlasifikovanehoZapoctuAnglicky)
*/
values
	('1,8' , '1.2', '0.4')
	

CREATE TABLE PracovniStitek
(
   ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nazev nvarchar (100),
	Zamestnanec int,	-- FK
	Predmet int,		-- FK
	Typ nvarchar (100),
	PocetStudentu int,
	PocetHodin int,
	PocetTydnu int,
	Jazyk nvarchar (100),

);

CREATE TABLE Skupinka_predmety
(
	
	PredmetID int references Predmet (ID),
	SkupinkaID int references Skupinka (ID),
	constraint pk_Skupinka_predmety primary key (PredmetID, SkupinkaID)

);