create proc GetDepartureData
as begin 
Select ID, FlightID, AirID,CityID,StatusID,TerminalID,DepartureTime
from TimeTable_Departure
end 