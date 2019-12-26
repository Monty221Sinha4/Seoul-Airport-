create proc spArrivalsTimeTable_Insert

@FlightID int,
@AirID int ,
@CityID int,
@StatusID int,
@TerminalID int ,
@DepartureTime time(7) 
as begin 
insert into TimeTable_Departure values (@FlightID,@AirID,@CityID,@StatusID,@TerminalID,@DepartureTime)
end 