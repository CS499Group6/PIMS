--INA CARTER
--CS 499 PIMS DATABASE 
--DATE: 03/10/2016
--CREATE TABLES

USE PIMS_Backend
GO


CREATE TABLE Location
(
	bedNo		varchar(10) NOT NULL UNIQUE,
	unit		varchar(10) NOT NULL,
	floorNo		int NOT NULL, 
	roomNo		int NOT NULL,
	occupancy	int,
	PRIMARY KEY(bedNo)
);

CREATE TABLE Patient
(
	patientID			varchar(15) NOT NULL UNIQUE,
	firstName			varchar(50),
	lastName			varchar(50),
	middleName			varchar(50),
	DOB					date,
	gender				varchar(2),
	patientAddress		varchar(100),
	phone1				int,
	phone2				int, 
	emergencyName		varchar(100),
	emergencyNumber		int,
	emergencyName2		varchar(100),
	emergencyNumber2	int,
	visitorList			varchar(500),
	bedNo				varchar(10),
	PRIMARY KEY (patientID),
	FOREIGN KEY(bedNo) REFERENCES Location(bedNo)
	ON DELETE CASCADE
);

CREATE TABLE Billing
(
	patientID		varchar(15) NOT NULL UNIQUE,
	charges			float,
	amountPaid		float,
	insurancePaid	float,
	billingAddress	varchar(100),
	dueDate			date,
	PRIMARY KEY(patientID),
	FOREIGN KEY(patientID) REFERENCES Patient(patientID)
);

CREATE TABLE Insurance
(
	patientID		varchar(15) NOT NULL UNIQUE,
	provider		varchar(15),
	BIN				int,
	ID				int,
	PCN				int,
	groupNo			int,
	insuranceType	varchar(15),
	PRIMARY KEY(patientID),
	FOREIGN KEY(patientID) REFERENCES Patient(patientID)
);

CREATE TABLE Treatment
(
	patientID			varchar(15) NOT NULL UNIQUE,
	dateAdmitted		date,
	reason				varchar(20),
	currentDate			date,
	currentTime			time,
	pHeight				int,
	pWeight				int,
	bloodPressure		int,
	heartRate			int,
	allergies			varchar(150),
	scheduledProcedure	varchar(150),
	familyDoctor		varchar(100),
	doctorNotes			varchar(500),
	nurseNotes			varchar(500),
	dateDischarged		date,
	PRIMARY KEY(patientID),
	FOREIGN KEY(patientID) REFERENCES Patient(patientID)
);

CREATE TABLE Prescriptions
(
	drugID					varchar(15) NOT NULL UNIQUE,
	drugName				varchar(15),
	NDC						varchar(20),
	SIG						varchar(20),
	prescribingPhysician	varchar(50),
	prescribedDate			date,
	cost					float,
	patientID				varchar(15) NOT NULL,
	PRIMARY KEY(drugID),
	FOREIGN KEY(patientID) REFERENCES Patient(patientID)
);

CREATE TABLE Staff
(
	staffID		varchar(15) NOT NULL UNIQUE,
	staffName	varchar(50),
	position	varchar(15),
	userID		varchar(20) NOT NULL UNIQUE,
	unit		varchar(10),
	PRIMARY KEY(staffID),
);

CREATE TABLE Login
(
	userID		varchar(20) NOT NULL UNIQUE,
	password	varchar(10),
	PRIMARY KEY(userID),
	FOREIGN KEY(userID) REFERENCES Staff(userID)
);