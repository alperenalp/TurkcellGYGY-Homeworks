// See https://aka.ms/new-console-template for more information
using Task6LiskovSubstituonPrensible;

Console.WriteLine("Hello, World!");


var reserveHotelRoom = ReservingService.ReserveFactory(DateTime.Now, 30);
reserveHotelRoom.CreateReserve();


var reserveVehicle = ReservingService.ReserveFactory(DateTime.Now, 30, "VOLVO");
reserveVehicle.CreateReserve();


var reserveConferencePlace = ReservingService.ReserveFactory(DateTime.Now, 30, 500);
reserveConferencePlace.CreateReserve();