create proc SpCities_Departure_Insert
@City varchar(50)
as 
begin 
insert into Cities_Departure values (@City)
end 


create proc spAirlinesArrivals_Insert
@Airline varchar(50)
as begin 
insert into Airlines_Arrivals values (@Airline)
end 

create proc spAirlineDeparture_Insert
@Airline varchar(50) 
as begin 
insert into Airlines_Departure values (@Airline)
END 

create proc spTerminal_Arrivals_Insert
@Terminal varchar(50) 
as begin 
insert into Terminals_Arrivals values (@Terminal)
end 

create proc spTerminal_Departure_Insert
@Terminal varchar(50)
as begin 
insert into Terminals_Departure values (@Terminal)
end 

create proc SpFlight_Departure_Insert
@Flight varchar(50)
as begin 
insert into Flight_Arrivals values (@Flight)
end 