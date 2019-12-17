create table Status_Arrivals
(
StatusID int primary key identity(1,1) not null,
Status varchar(50) not null,

);


create table Status_Departure
(
StatusID int primary key identity (1,1) not null,
Status varchar(50) not null,
); 


Create table Terminals_Arrivals 
(
TerminalID int primary key identity (1,1) not null,
Terminal varchar(50) not null,
); 

Create table Terminals_Departure
(
TerminalID int primary key identity (1,1) not null,
Terminal varchar(50) not null,
); 