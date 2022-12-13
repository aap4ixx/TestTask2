using TestTask2.SwaggerApi;

namespace TestTask2.Common;

public static class SwaggerClient {
    private static HttpClient httpClient;
    private static ManageServiceClient clientService;

    static SwaggerClient() {
        httpClient = new HttpClient();
        clientService = new ManageServiceClient("https://booking-test.dev-dch.com", httpClient);
    }

    public static List<Location> Locations() {
        var result = clientService.LocationsAsync().GetAwaiter().GetResult().ToList();
        return result;
    }

    public static List<Offer> Availability(int locationId) {
        var requestHead = new OfferRequest();
        requestHead.LocationId = locationId;
        
        var result = clientService.GetOffersAsync(requestHead).GetAwaiter().GetResult().ToList();

        return result;
    }

    public static string Reservation(string offerUId, string name, string surname) {
        var reservationRequest = new ReservationRequest();
        reservationRequest.OfferUId = offerUId;
        reservationRequest.Customer = new Customer();
        reservationRequest.Customer.Name = name;
        reservationRequest.Customer.Surname = surname;
            
        var result = clientService.CreateReservationAsync(reservationRequest).GetAwaiter().GetResult().ConfirmationNumber;
        return result;
    }
}