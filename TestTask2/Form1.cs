using System.Windows.Forms.VisualStyles;
using TestTask2.Common;
using TestTask2.SwaggerApi;

namespace TestTask2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        record OfferItem(int Listid, string OfferUId, double PriceAmount, string PriceCurrency, string VehicleImageLink, string VehicleModelName,
            string VehicleSipp, string VendorImageLink, string VendorName);

        private List<OfferItem> OfferList;

        private void Form1_Load(object sender, EventArgs e) {
            LocationsList.Items.Clear();
            var locationsList = SwaggerClient.Locations();

            foreach (var itemString in locationsList.Select(item => $"{item.Id}, {item.Country}, {item.City}, {item.Name}")) {
                LocationsList.Items.Add(itemString);
            }
        }

        private void AvailableCarList_SelectedIndexChanged(object sender, EventArgs e) {
            var idList = AvailableCarList.SelectedIndex;
            var priceAmount = $"{OfferList[idList].PriceAmount:0.00}";
            amountLabel.Text = $@"{OfferList[idList].PriceCurrency} {priceAmount}";

            modelNameLabel.Text = OfferList[idList].VehicleModelName;

            vendorNameLabel.Text = OfferList[idList].VendorName;

            pictureBox1.ImageLocation = OfferList[idList].VendorImageLink;
            pictureBox2.ImageLocation = OfferList[idList].VehicleImageLink;
        }

        private void rentButton_Click(object sender, EventArgs e) {
            var idList = AvailableCarList.SelectedIndex;
            
            var reservationId = SwaggerClient.Reservation(OfferList[idList].OfferUId, nameTextBox.Text, surnameText.Text);

            confirmNumberLabel.Text = reservationId;
        }

        private void GoButton_Click(object sender, EventArgs e) {
            AvailableCarList.Items.Clear();

            var selectedCountry = LocationsList.SelectedItem.ToString();
            var countryId = selectedCountry.Substring(0, selectedCountry.IndexOf(","));

            var availableCarList = SwaggerClient.Availability(int.Parse(countryId));
            OfferList = new List<OfferItem>();

            int listId = 0;

            foreach (var item in availableCarList) {
                AvailableCarList.Items.Add(item.Vehicle.ModelName);

                var offerItemRecord = new OfferItem(listId, item.OfferUId, item.Price.Amount, item.Price.Currency, item.Vehicle.ImageLink,
                    item.Vehicle.ModelName, item.Vehicle.Sipp, item.Vendor.ImageLink, item.Vendor.Name);
                OfferList.Add(offerItemRecord);

                listId++;
            }
        }
    }
}