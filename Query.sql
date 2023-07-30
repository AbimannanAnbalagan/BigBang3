Use Tourism

Create table "User"(UserId int identity(1,1) primary key, UserName nvarchar(max), Password varbinary(max),
HashKey varbinary(max), EmailId nvarchar(max) , Role nvarchar(max));

Create table Traveler (TravelerId int identity(1,1) primary key , UserId int , Age int , Gender nvarchar(9) ,
Address nvarchar(max) , Image nvarchar(max) , PhoneNumber bigint
Constraint TravelerUserId Foreign Key (userId) References "User"(UserId) )

Create table TravelAgent (AgentId int identity(1,1) primary key ,UserId int , TravelAgency nvarchar(max) , Age int , Gender nvarchar(9) ,
Address nvarchar(max) , Image nvarchar(max) , PhoneNumber bigint
Constraint TravelAgentUserId Foreign Key (userId) References "User"(UserId) )

Create table Package (PackageId int identity(1,1) primary key , PackageName nvarchar(max),Region nvarchar(max) , 
Image nvarchar(max) , Description nvarchar(max) , Price money ) 

Create table Hotels (HotelId int identity(1,1) primary key , HotelName nvarchar(max) , PackageId int 
Constraint HotelsPackageId Foreign Key (PackageId) References Package(PackageId))

Create table Bookings(BookingId int identity(1,1) primary key , userId int , PackageId int , AgentId int , 
BoardingLocation nvarchar(max), NoOfPerson int, TotalAmount Money , Date nvarchar(max) 
Constraint BookingsUserId Foreign Key (UserId) References "User"(UserId),
Constraint BookingsPackageId Foreign Key (PackageId) References Package(PackageId),
Constraint BookingsAgentId Foreign Key (AgentId) References TravelAgent(AgentId))

Create table ContactUs(ContactUsId int identity(1,1) primary key, "Message" nvarchar(max),Name nvarchar(max) , EmailId nvarchar(max))

Create table Feedback(FeedbackId int identity(1,1) primary key , Feedback nvarchar(max) , BookingId int , Rating int
Constraint FeedbackBookingId Foreign Key(BookingId) References Bookings(BookingId))

Create table Gallery (ImageId int identity(1,1) primary key , "Image" nvarchar(max) , "Location" nvarchar(max))