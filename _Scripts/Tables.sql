create table dbo.Tickets
(
	TICKET_GUID uniqueidentifier,
	TICKET_MOVIE_GUID uniqueidentifier,
	TICKET_PRICE float not null,
	TICKET_SEAT_ROW char not null,
	TICKET_SEAT_NUMBER int not null,
	TICKET_HALL_NUMBER int not null
)


create table dbo.Seats
(
	SEAT_ID int not null,
	SEAT_NUMBER int not null,
	SEAT_ROW char not null,
	SEAT_TYPE int not null
)

create table dbo.Movies
(
	MOVIE_GUID uniqueidentifier,
	MOVIE_TITLE nvarchar(max) not null,
	MOVIE_DESCRIPTION nvarchar(max) null,
	MOVIE_RATE float null,
	MOVIE_CATEGORY int not null,
	MOVIE_TYPE int not null,
	MOVIE_LENGTH int,
	MOVIE_DIRECTOR_NAME nvarchar(max),
	MOVIE_RELEASE_DATE datetime,
	MOVIE_IS_ACTIVE bit
)

create table dbo.CinemaHalls
(
	CH_GUID uniqueidentifier not null,
	CH_NUMBER int not null,
	CH_TYPE int
)

create table CinemaHallsTypes
(
	CHT_ID int identity (1,1),
	CHT_TYPE nvarchar(50)
)

create table SeatsTypes
(
	ST_ID int identity (1,1),
	ST_TYPE nvarchar(50)
)

create table MovieCategories
(
	MC_ID int identity (1,1),
	MC_CATEGORY nvarchar(50)
)

create table MoviesTypes
(
	MT_ID int identity (1,1),
	MT_TYPE nvarchar(50)
)