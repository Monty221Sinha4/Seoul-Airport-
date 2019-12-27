create proc GetCities_ArrivalsData
as begin 
select City from Cities_Arrivals
end 

create proc GetCitiesDepartureData 
as begin 
select City from Cities_Departure
end 

create proc GetAirlineData_Departure
as begin 
select Airline from Airlines_Departure
end 

create proc GetFlightData_Arrivals
as begin 
select FlightNo from Flight_Arrivals
end 

create proc GetFlightData_Departure
as begin 
select FlightNo from Flight_Departure
end 