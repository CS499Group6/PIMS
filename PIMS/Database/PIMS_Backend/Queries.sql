--INA CARTER
--CS 499 PIMS DATABASE 
--DATE: 03/10/2016
--CREATE QUERIES


USE PIMS_Backend
GO


--Search Patient Query
--Returns (patientID, firstName, lastName)
SELECT [lastName], [firstName], [patientID]
FROM Patient
GO

--Patient Query
--Returns (patientID, FML, DOB, Facility/Unit, roomNo, bedNo)
SELECT [patientID], [lastName], [firstName], [middleName], [DOB], [unit], [roomNo], Patient.bedNo
FROM Patient
LEFT JOIN Location ON Patient.bedNo = Location.bedNo
ORDER BY lastName, firstName
GO