using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class bogusAddresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 1,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "93007 Reilly Lodge", "South Loy", "K4A8N3", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 2,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "276 Feil Junction", "Hammesside", "G4Y7G9", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 3,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "45604 Lockman Court", "Erdmanmouth", "M0J8O3", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 4,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "78021 Lynn Crossroad", "New Columbuston", "H6L8B6", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 5,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "53821 Reed Row", "East Serenitystad", "C0K3Q5", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 6,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "611 Cassie Bridge", "Port Anderson", "S6Y8V4", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 7,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1435 Ayana Brooks", "East Kylatown", "K1J3C6", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 8,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "197 Marjorie Square", "Port Dulceberg", "Z2D3G8", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 9,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "089 Champlin Vista", "Angusmouth", "Q7E6F3" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 10,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "15993 Dickinson Square", "East Dollymouth", "K0Z0U2", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 11,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "676 Garett Points", "Anissaburgh", "V9Y0W8", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 12,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8378 Ashley Manor", "East Madelineville", "K1U3O8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 13,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2724 Goyette Isle", "Collierborough", "C4F1P4", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 14,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "488 Schmeler Mountains", "Kristianchester", "Q4A7Z7", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 15,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "390 Caleb Dam", "Kilbackton", "E9F8E8", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 16,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "416 Salma Meadows", "Rosenbaumport", "E3M5K8", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 17,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "55474 Kunde Summit", "Lake Shany", "H2K2K8", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 18,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "150 Jon Pike", "New Maurine", "O3O9Z8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 19,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "620 Amaya Point", "Robelmouth", "Z2C5R5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 20,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "51077 O'Kon Way", "South Cristopherborough", "P3P5E1", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 21,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "42745 Halvorson Spur", "New Americomouth", "Y2V7W5" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 22,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2738 Hartmann Mountain", "Trevaport", "W0I3F0", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 23,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8155 Bryce Crest", "Bettiemouth", "H5K7T9", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 24,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "01179 Harber Parkways", "Leifside", "S9F6K7", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 25,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7712 Friesen Run", "Kingborough", "J9X3A7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 26,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "90210 Koelpin Ramp", "West Natalia", "A5X5H5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 27,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "42056 Wintheiser Village", "Oberbrunnerville", "H6U9Z3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 28,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3705 Bode Valleys", "Beierbury", "L8U0S5", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 29,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2617 Margot Lock", "West Nayelishire", "Y9G6W0", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 30,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "645 Jarod River", "Bergnaumport", "B3U7Q8", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 31,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "910 Christophe Valley", "Lake Bulahport", "E2R9M3", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 32,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "475 Stanton Circle", "Prohaskastad", "F2J4B7", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 33,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "554 Eleanora Plain", "South Ezequielborough", "L3K0X3", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 34,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "33409 Dooley Mall", "East Meghan", "Y5Q0G3", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 35,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "14314 Denesik Glen", "Cristport", "C5Q6V8", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 36,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "16248 Kub Vista", "Ettiefort", "C7O5X2", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 37,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "17603 Lesley Crest", "Zulaufberg", "D2S1F1", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 38,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "43994 Goodwin Spur", "Beahanchester", "X1T9J8", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 39,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "60448 Ambrose Village", "Jaskolskiborough", "T7D0V6", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 40,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "827 O'Conner Knoll", "Port Isidro", "V3S5B8", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 41,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "14569 Sadye Mission", "Cruickshanktown", "C6B5J4", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 42,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "44159 Gaylord Bridge", "East Marionburgh", "S2Y3N2", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 43,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "97713 Walker Gateway", "North Koleberg", "S9V0R2" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 44,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "703 Kuvalis Manors", "North Daryl", "H8W0K7", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 45,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "911 Jamal Ports", "South Alaynaburgh", "H8Y8M5", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 46,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "728 Modesto Isle", "West Gina", "R5C5Z8", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 47,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "65310 Howell Isle", "Bartellborough", "J5Y9J9", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 48,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "860 April Summit", "New Ward", "W1I4R0", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 49,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1929 Alta Plaza", "North Brooke", "E1A7U6", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 50,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9302 Bailey Mission", "East Loyalshire", "W5X8A1", "PE" });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 51, "02075 Sipes Fork", null, "Haleymouth", null, "X5W4R0", "PE" },
                    { 99, "7945 Dickinson Falls", null, "North Lurline", null, "J0E7W1", "NU" },
                    { 73, "1145 Carlie Estate", null, "Elijahstad", null, "L1D6E9", "NB" },
                    { 72, "32022 Rohan Rapid", null, "Melvinashire", null, "I0W2F5", "BC" },
                    { 71, "10636 Tracey Ports", null, "West Carmelaport", null, "X1C4K0", "MB" },
                    { 70, "803 Kenyatta Streets", null, "West Malvina", null, "N7K0S4", "ON" },
                    { 69, "209 Dooley Stravenue", null, "Leschshire", null, "T4M3O2", "NU" },
                    { 68, "913 Manuela Creek", null, "Port Monserrate", null, "V8E9Z7", "NU" },
                    { 67, "1311 Ken Brook", null, "Langmouth", null, "R3T6J9", "ON" },
                    { 66, "50494 Turcotte Walk", null, "Dariusfurt", null, "N1V2A2", "YT" },
                    { 65, "665 Adolf Parkway", null, "Port Emmet", null, "W4C8L9", "NL" },
                    { 64, "01416 Kaci Drives", null, "Angelicabury", null, "K1P8Y2", "NS" },
                    { 63, "3126 Graham Plaza", null, "West Bernadette", null, "J2X4J0", "SK" },
                    { 62, "600 Beahan Grove", null, "Jaylinfort", null, "F8F5G8", "MB" },
                    { 61, "85185 DuBuque Hills", null, "South Tiannaview", null, "Y8H8B5", "MB" },
                    { 60, "08125 Darryl Plaza", null, "Conradton", null, "I9G2J4", "ON" },
                    { 59, "3016 Betsy Lock", null, "Mauricefort", null, "S7B6S5", "NB" },
                    { 58, "8885 Bednar Fort", null, "South Juliet", null, "H0Q0S1", "NB" },
                    { 57, "243 Emelie Club", null, "Judahfort", null, "V0L4H7", "NU" },
                    { 56, "8959 Rau Overpass", null, "West Peggie", null, "U0N8C6", "MB" },
                    { 55, "8811 Nasir Bypass", null, "New Effie", null, "V0E2Q3", "NT" },
                    { 54, "58426 Freida Prairie", null, "New Ceceliaborough", null, "V0T8R9", "QC" },
                    { 53, "01936 Halvorson Unions", null, "East Toby", null, "E4O0M9", "QC" },
                    { 74, "451 Bayer Isle", null, "Port Robyn", null, "W2V8K6", "MB" },
                    { 100, "231 Gladys Circles", null, "West Tom", null, "C7I4R4", "YT" },
                    { 75, "4790 Daugherty Tunnel", null, "South Zachary", null, "K6G3W5", "BC" },
                    { 77, "63746 Eula Falls", null, "Raulshire", null, "Y6Q9N3", "MB" },
                    { 98, "96208 Kirk Port", null, "New Cyrilville", null, "G4X5B4", "SK" },
                    { 97, "0912 Joana Circle", null, "Port Juanaborough", null, "P4Z5U7", "MB" },
                    { 96, "6790 Beier Knoll", null, "Arvillaberg", null, "Y3S4K2", "YT" },
                    { 95, "82630 Cronin Motorway", null, "Hellershire", null, "T0Q4E7", "BC" },
                    { 94, "809 Nathen Views", null, "East Javier", null, "Y1U4I2", "QC" },
                    { 93, "69772 Mitchell Green", null, "Armstronghaven", null, "S3D6W3", "QC" },
                    { 92, "831 Schowalter Summit", null, "New Delphiahaven", null, "T1X6J1", "NS" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 91, "0196 Crooks Locks", null, "Port Julianneton", null, "J5I3Z7", "MB" },
                    { 90, "3345 Gleason Lane", null, "Pabloton", null, "K3F8K1", "NS" },
                    { 76, "84724 Miller Alley", null, "South Lemuel", null, "L3Q4Q8", "PE" },
                    { 89, "21336 Brennon Estate", null, "New Kolby", null, "M6A9F2", "YT" },
                    { 87, "738 Anastacio Springs", null, "Aufderharberg", null, "U5G2F2", "YT" },
                    { 86, "40216 Ryan View", null, "South Stone", null, "V2S7O2", "SK" },
                    { 85, "669 Jerde Mountains", null, "Eusebiofort", null, "V3K0H0", "MB" },
                    { 84, "930 Ezra Avenue", null, "East Nicklausborough", null, "D0O6K1", "NS" },
                    { 83, "19529 Daniel Turnpike", null, "East Juanita", null, "M5G3S7", "NT" },
                    { 82, "5640 Billie Walks", null, "Kiehnton", null, "J5D0D5", "PE" },
                    { 81, "384 Estevan Passage", null, "Lake Jennyfer", null, "X3T7B6", "ON" },
                    { 80, "0358 Maudie Coves", null, "Port Rupertmouth", null, "G5D8V3", "SK" },
                    { 79, "6865 Luigi Hill", null, "Lake Rosamond", null, "Q9G3M8", "NU" },
                    { 78, "892 Kailyn Ramp", null, "Bayleeton", null, "T0K1Q3", "PE" },
                    { 88, "0514 Evans Manor", null, "Kubstad", null, "Q5Z4Q8", "NS" },
                    { 52, "70376 Bergnaum Run", null, "East Osbaldofurt", null, "Q9T7M7", "NB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 99, "9762 Ramon Terrace", null, "South Camille", null, "R1B2S3", "ON" },
                    { 100, "042 Renner Alley", null, "Kaiastad", null, "R6A9W9", "YT" },
                    { 1, "92362 Mosciski Drive", null, "Ratkechester", null, "E5T4G1", "PE" },
                    { 73, "74062 Rocky Row", null, "Cassinbury", null, "O9Y0P7", "NB" },
                    { 72, "4587 Hulda Circle", null, "New Rocio", null, "M1L0W3", "PE" },
                    { 71, "220 White Stravenue", null, "Lake Brice", null, "G9T3Q5", "BC" },
                    { 70, "07021 Tad Ports", null, "Kuhlmanshire", null, "T9D0K2", "QC" },
                    { 69, "94363 Nickolas Parks", null, "Lake Dustin", null, "V9P5R0", "NB" },
                    { 68, "25123 Spencer Way", null, "Port Julesbury", null, "T7T9A4", "AB" },
                    { 67, "8380 Strosin Neck", null, "Lenoraland", null, "B8O3Z3", "BC" },
                    { 66, "953 Gusikowski Rue", null, "North Margarettabury", null, "Y7S5M9", "NL" },
                    { 65, "131 Burley Expressway", null, "Mohamedburgh", null, "R1W0H1", "SK" },
                    { 64, "740 Prohaska Extensions", null, "North Desmondchester", null, "H3Z8E5", "YT" },
                    { 63, "056 Nicholas Spur", null, "Christiansenshire", null, "L8X2E3", "ON" },
                    { 62, "041 Mohammed Squares", null, "East Asia", null, "X2G0Y7", "QC" },
                    { 61, "76872 Golda Lake", null, "Port Charlotteshire", null, "K3S8D8", "MB" },
                    { 60, "61591 Candida Run", null, "Lake Shayne", null, "J0E6B0", "NB" },
                    { 59, "9862 Mitchell Spring", null, "New Tomfort", null, "K3T9A8", "NT" },
                    { 58, "359 Hershel River", null, "Jedidiahborough", null, "N9U1V5", "BC" },
                    { 57, "414 Travon Crossroad", null, "Juddland", null, "Z7X8S0", "MB" },
                    { 56, "84614 Barrows Brook", null, "South Lon", null, "J0J0T0", "ON" },
                    { 55, "40870 Eli Road", null, "Elnoraberg", null, "H9Z5F0", "ON" },
                    { 54, "8296 Junior Gateway", null, "Everetteberg", null, "L1U1T4", "SK" },
                    { 53, "577 Hailie Garden", null, "New Lennastad", null, "F7K1I4", "NT" },
                    { 74, "4406 Koch Street", null, "Lake Veronahaven", null, "C4R6M7", "SK" },
                    { 52, "70916 Ebert Summit", null, "Diegoberg", null, "S4B6J3", "MB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 75, "2242 Murray Spring", null, "Corenebury", null, "D1E1Z0", "NL" },
                    { 77, "35789 Cole Summit", null, "New Lura", null, "L1C3E7", "BC" },
                    { 98, "83707 Aurore Hill", null, "Susanatown", null, "S6P2J0", "YT" },
                    { 97, "777 Ferry Junctions", null, "West Kayden", null, "G6Y9C1", "MB" },
                    { 96, "95222 Lauretta Lodge", null, "Langoshtown", null, "C8V6G4", "NL" },
                    { 95, "351 Dare Summit", null, "East Armandland", null, "S8R9D3", "PE" },
                    { 94, "0468 Carley Forks", null, "Mooreland", null, "G2K0W2", "BC" },
                    { 93, "2382 Eva Square", null, "West Josiane", null, "X0H3F5", "YT" },
                    { 92, "30079 Dicki Ville", null, "Enriqueland", null, "L1Y4I4", "AB" },
                    { 91, "3826 Weber Mission", null, "Romaguerashire", null, "U0R5Q8", "NB" },
                    { 90, "44069 Taylor Terrace", null, "East Abe", null, "B0S8P3", "NL" },
                    { 89, "796 Julian Plaza", null, "North Charlene", null, "S0Y6U1", "YT" },
                    { 88, "584 Dickinson Loop", null, "West Harryfort", null, "R1Y3S8", "ON" },
                    { 87, "2574 Schumm Shoal", null, "New Zelda", null, "Y8U8G5", "NB" },
                    { 86, "53025 Grant Burg", null, "Mavisshire", null, "V6H4H6", "SK" },
                    { 85, "6401 Breitenberg Estates", null, "Hillardton", null, "A1E9U6", "BC" },
                    { 84, "95027 Rosalee Hollow", null, "Vanessaview", null, "V9E5S9", "NS" },
                    { 83, "570 Romaguera Point", null, "South Oliver", null, "P8O6V1", "NL" },
                    { 82, "3241 Corkery Common", null, "South Odabury", null, "T9D9G3", "SK" },
                    { 81, "510 Kyler Glen", null, "O'Reillychester", null, "Y6L0H7", "NB" },
                    { 80, "424 Wiza Springs", null, "East Carson", null, "M8R1F5", "BC" },
                    { 79, "37663 Kuphal Overpass", null, "Port Luella", null, "D9N4U6", "YT" },
                    { 78, "985 Carli Fall", null, "Johnstonchester", null, "H4A2R2", "PE" },
                    { 76, "40232 Flossie Parks", null, "West Edamouth", null, "D7L3S5", "QC" },
                    { 51, "3693 Deshawn Isle", null, "East Vidal", null, "T2R8L7", "NL" },
                    { 50, "2777 Homenick Landing", null, "Caterinashire", null, "H4Z0R4", "QC" },
                    { 49, "69642 Franco Islands", null, "Bergstromside", null, "F2Y1L5", "SK" },
                    { 23, "170 Trinity Light", null, "Walkerberg", null, "X8F0U2", "ON" },
                    { 22, "91039 Kathryne Islands", null, "West Nadiaport", null, "W5I6C7", "SK" },
                    { 21, "12352 Krystel Fords", null, "South Brooks", null, "Q8N3B7", "AB" },
                    { 20, "362 Thelma Station", null, "Gleichnerhaven", null, "S4Q7R5", "ON" },
                    { 19, "67319 Lakin Islands", null, "Auerview", null, "B3B1X8", "PE" },
                    { 18, "19419 Lessie Rue", null, "North Billy", null, "Y2I5S4", "NB" },
                    { 17, "82381 O'Connell Bypass", null, "Lake Laury", null, "M2G3X8", "QC" },
                    { 16, "567 Jovany Plains", null, "West Curt", null, "F0K3R0", "NU" },
                    { 15, "87325 Gaston Plaza", null, "North Emmaleeshire", null, "J7K6I1", "PE" },
                    { 14, "859 Swaniawski Curve", null, "New Sid", null, "S5A5U3", "SK" },
                    { 13, "32924 Dock Causeway", null, "Ignatiuston", null, "T4N4O5", "NL" },
                    { 12, "2934 Kirlin Mill", null, "Gibsonside", null, "O8M3X8", "QC" },
                    { 11, "35929 Zulauf Circle", null, "South Ryanside", null, "J3Q4C8", "NT" },
                    { 10, "421 Marlee Fork", null, "Collinsfort", null, "V9B4M5", "PE" },
                    { 9, "626 Jeramy Spurs", null, "New Cesarbury", null, "T4L0Y4", "QC" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 8, "421 Goodwin River", null, "Paolohaven", null, "I9L8R6", "SK" },
                    { 7, "190 Wisozk Knolls", null, "Kirlinmouth", null, "Q6R0G6", "BC" },
                    { 6, "77009 Kreiger Rest", null, "Schoenton", null, "V6C9V1", "NT" },
                    { 5, "33731 Lura Prairie", null, "Sauerborough", null, "Q4X2Y2", "NU" },
                    { 4, "4913 Jonas View", null, "Hahnchester", null, "W7M5Y9", "NL" },
                    { 3, "9860 Patsy Ferry", null, "South Tristian", null, "J3A5D7", "NS" },
                    { 24, "10761 Althea Plains", null, "Gleichnerville", null, "Y0G2Q6", "ON" },
                    { 25, "096 Vivien Lane", null, "Ondrickachester", null, "T1I0N4", "PE" },
                    { 26, "52675 Oberbrunner Mill", null, "Stiedemannstad", null, "K1H5R2", "SK" },
                    { 27, "9495 Gretchen Villages", null, "West Salvatoreport", null, "C3R2H7", "QC" },
                    { 48, "753 Lang Terrace", null, "Royceborough", null, "M9P1W6", "ON" },
                    { 47, "111 Edmund Rapid", null, "East Lacy", null, "D7W8C1", "PE" },
                    { 46, "7480 Leffler Mews", null, "Beerfort", null, "W3L9B0", "PE" },
                    { 45, "96753 Herzog Loaf", null, "Madisenville", null, "X8R2Y3", "YT" },
                    { 44, "1807 Bergnaum Locks", null, "Hansenmouth", null, "M4K7G7", "AB" },
                    { 43, "822 Wolff Gateway", null, "North Tiannamouth", null, "M5B5V4", "NL" },
                    { 42, "86595 Schmidt Underpass", null, "Port Reina", null, "S7W3L0", "AB" },
                    { 41, "00004 Hermann Isle", null, "Streichhaven", null, "C4L9M1", "NT" },
                    { 40, "18084 Predovic Stravenue", null, "Lake Berneicemouth", null, "K3M9R2", "BC" },
                    { 38, "034 Ignacio Pass", null, "Kiehntown", null, "U3F4C9", "MB" },
                    { 39, "019 Beer Shoals", null, "Tracybury", null, "K9V9M3", "ON" },
                    { 36, "998 Mya Flats", null, "Franeckistad", null, "T4A4E3", "YT" },
                    { 35, "4750 Austen Key", null, "Douglasport", null, "F5O4P0", "NB" },
                    { 34, "656 Kshlerin Rapid", null, "North Brayan", null, "W6X4J0", "NU" },
                    { 33, "9309 Ryan Freeway", null, "North Demond", null, "E8D1Q5", "SK" },
                    { 32, "416 Jaleel Locks", null, "Lake Franco", null, "L3E1Q4", "NL" },
                    { 31, "3930 Viva Points", null, "Marquardtview", null, "Z2I9S6", "PE" },
                    { 30, "5926 Toy Rapids", null, "East Araceli", null, "G1P7P3", "NS" },
                    { 29, "6083 Emery Corners", null, "Rosston", null, "Z2Y5V2", "NT" },
                    { 28, "907 Hallie Terrace", null, "South Rosalind", null, "K3U5C5", "PE" },
                    { 37, "5649 Melyssa Creek", null, "Vonton", null, "E3J5F5", "NB" },
                    { 2, "93787 Leffler Unions", null, "Viviennemouth", null, "U8V3P5", "NB" }
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolores temporibus sed sed alias sint quisquam unde provident.", 43, 5349m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Veniam nobis illum distinctio aut odio in.", 65, 8171m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est soluta minus quia qui optio est illo molestias.", 56, 3223m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit quia est.", 51, 5868m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum consequuntur molestiae.", 14, 19475m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Magni iste et.", 4, 3820m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dignissimos quis est cumque.", 64, 1928m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eveniet aut in quibusdam commodi tenetur.", 58, 11033m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eveniet pariatur iure rerum consequatur quam doloremque.", 2, 9897m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ea in pariatur quia pariatur.", 77, 12970m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Occaecati velit accusantium voluptas.", 61, 5775m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Expedita et non ipsam mollitia voluptatibus aut necessitatibus.", 14, 13503m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ab illum eaque in sint harum.", 56, 14008m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui voluptas aut.", 14, 12273m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut quis consectetur ab voluptatem dicta aliquam laboriosam voluptas possimus.", 36, 6919m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi quia et.", 98, 17810m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odit quia explicabo qui ut aut qui et perspiciatis eum.", 15, 4896m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Necessitatibus enim voluptatem nostrum eos illo sed commodi possimus.", 62, 6735m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et perferendis molestiae neque.", 85, 7416m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Maiores sit dignissimos quo aut voluptas aut.", 51, 11958m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Culpa doloribus soluta tenetur eos ut voluptas suscipit dolore accusantium.", 76, 7992m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem quidem omnis assumenda molestiae fugiat consequatur ad a.", 41, 8308m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Id ullam aut delectus magnam nam accusantium et.", 19, 4129m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aliquam sapiente non qui vitae quas doloremque temporibus.", 74, 19255m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Assumenda quo quisquam.", 50, 10785m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Molestias qui exercitationem accusantium quas quidem temporibus beatae.", 59, 8576m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Omnis ipsam accusantium.", 90, 19240m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Omnis dolores consequatur ducimus ipsum saepe enim cupiditate libero.", 68, 17251m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut quidem molestiae in et et quo provident.", 60, 17976m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "In eligendi in molestias.", 83, 12010m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Non in sit maxime voluptatum omnis omnis.", 25, 8099m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Beatae reprehenderit provident natus aperiam magnam ratione et ut.", 20, 4199m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum sunt ex dicta pariatur sed sit rerum nihil at.", 77, 4896m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quos voluptatem ut necessitatibus esse voluptatem ullam ipsa hic.", 68, 11349m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quisquam quisquam dolores et error.", 6, 14466m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Debitis repellendus odio est soluta ipsam.", 100, 18217m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Rerum molestias enim voluptatem deserunt provident quae ea.", 53, 10407m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Maiores magni aut illo sed.", 45, 8687m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut et debitis laborum ea quidem expedita aspernatur est sit.", 22, 12410m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut consectetur fuga facilis quis consequuntur ex quaerat neque.", 21, 14056m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Iste consequatur exercitationem quos omnis.", 72, 5983m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Assumenda et ipsum fugiat molestias expedita non sint.", 24, 5744m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quibusdam ipsum eum expedita quis porro.", 44, 18191m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Magni est quia veniam distinctio cupiditate ipsum quaerat ad.", 43, 18794m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Placeat quas quos harum sint id quae.", 50, 6296m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Facilis voluptatem repellat aut officiis suscipit veritatis aliquid.", 34, 14046m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Omnis beatae reiciendis ut sed.", 88, 18413m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Non quam dolor sint adipisci est illum.", 97, 15146m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptates quaerat voluptatem et ut ea animi illum necessitatibus ipsum.", 16, 11204m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ut ex culpa.", 51, 11412m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Officia optio qui accusamus culpa rerum aut excepturi ut.", 17, 6351m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rem vel reprehenderit enim ipsam minus eaque vero.", 67, 15999m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "In et reprehenderit dicta quis enim.", 37, 9445m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem recusandae temporibus distinctio deserunt veritatis.", 36, 5446m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Velit dolor culpa consectetur voluptates placeat minus eveniet praesentium velit.", 71, 17442m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Incidunt molestias eveniet dolore accusantium aut nam.", 39, 17985m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut quod sunt nemo ex dolorem.", 22, 10284m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ea est earum rem.", 16, 5200m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui perferendis eum.", 11, 15283m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sed minima suscipit consequatur delectus quis laudantium nesciunt consequatur.", 59, 17817m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Consequatur est voluptas ut.", 64, 10424m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Explicabo et at maiores magnam voluptates voluptas.", 22, 16997m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Non quia quis qui ex deleniti ipsam.", 64, 17842m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia est odit iusto et qui provident sequi magni tempore.", 12, 4763m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolore ipsa ipsa voluptatem.", 71, 7546m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tenetur qui dolorem id ipsam excepturi quia.", 96, 9191m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut necessitatibus non libero soluta in vel.", 43, 5145m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ut et pariatur ea quis omnis ducimus laudantium non omnis.", 42, 9646m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolorum laudantium omnis perferendis neque in id odio voluptatem.", 70, 2238m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolor et non et velit.", 67, 6740m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vel quas nisi.", 41, 7872m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Facere quod omnis autem sequi.", 40, 8291m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Optio dolore est vero similique eos aperiam recusandae.", 23, 19093m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sapiente et est harum distinctio incidunt non.", 96, 3759m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eos similique iure praesentium fugit placeat et cum dolorum sapiente.", 53, 12011m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ea voluptatem qui labore.", 15, 600m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Totam dolor blanditiis dolorem.", 96, 8995m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptates molestiae similique facilis rem voluptas.", 92, 3306m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit autem aut est voluptatem at accusamus nostrum quisquam voluptatem.", 77, 15633m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sit nostrum quidem tempora sit aut enim necessitatibus laborum molestias.", 85, 12800m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Laborum dolore dolor.", 10, 16027m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Qui mollitia similique distinctio similique odit magni iusto.", 48, 15963m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolor est repellendus doloribus nihil atque et numquam vel dolores.", 65, 506m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Consequatur ut illo et nam iste quos.", 35, 12538m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Atque architecto voluptas veniam consequatur aut velit eum natus.", 46, 7873m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Occaecati omnis laudantium perspiciatis.", 41, 19561m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum autem sunt nulla voluptatem nostrum veritatis quia.", 71, 12794m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut at distinctio culpa.", 98, 8880m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Id ullam quos aperiam.", 7, 14585m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Vel rerum ducimus perferendis et autem aliquam aut ut.", 18, 9937m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sequi vel modi est rerum in deleniti non fuga quia.", 28, 13474m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Natus eveniet aut ut ratione.", 70, 6503m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et quia error suscipit voluptatum velit voluptatibus aut qui laboriosam.", 56, 13080m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Suscipit at voluptatem labore laboriosam magni sint et mollitia voluptatibus.", 91, 11985m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem eligendi optio distinctio sit architecto sint.", 2, 3854m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Debitis perferendis et illo laboriosam sint exercitationem consequatur.", 45, 9471m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ut quam delectus ex debitis vitae beatae voluptas qui.", 82, 6328m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eveniet esse distinctio fugit.", 47, 4594m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "Quantity", "State", "Unit" },
                values: new object[] { "Ut molestiae quaerat adipisci est sed aut sequi et molestias.", 16825m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Enim non laborum eveniet inventore optio nam et dignissimos.", 40, 15084m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eius ut aliquid impedit non repellat molestiae dolorum rerum.", 72, 9398m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Corporis illo dolores et laudantium qui nulla ullam.", 59, 722m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Soluta vel dignissimos non qui.", 3, 5773m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sapiente consequuntur a velit et quae.", 35, 2840m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Earum iure quaerat sequi non asperiores et et quas dolor.", 70, 2547m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dignissimos quaerat dicta molestiae facere cumque laboriosam error provident.", 42, 2292m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Saepe ut labore distinctio ex.", 19, 14837m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Exercitationem et aut praesentium.", 80, 14161m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nulla id rerum culpa repudiandae dolor et animi.", 4, 16436m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Impedit nam laborum debitis rerum libero laboriosam.", 26, 88m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolores aliquam animi debitis vero optio ipsam dolore maxime.", 2, 6955m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Debitis fugit eos id blanditiis.", 72, 373m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Pariatur eum rerum consequuntur et distinctio.", 69, 9388m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Non facilis est sapiente doloremque quisquam dolor quo commodi.", 56, 273m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempora et est aut sit dicta nihil laudantium dolorem.", 76, 534m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dicta debitis enim voluptas dolorum.", 47, 10941m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestiae exercitationem laborum officiis molestiae quam magnam ad.", 70, 7731m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut quas dolorum ex veritatis deleniti cumque recusandae.", 86, 5560m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nihil ad itaque perferendis odio possimus.", 38, 9021m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Unde eaque maxime omnis facere commodi.", 30, 17072m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolorem repellat consectetur nostrum doloribus porro nihil voluptatem voluptas.", 95, 15177m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Laboriosam quis eveniet earum nisi error neque et ratione consequatur.", 93, 442m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Soluta tempora praesentium corporis recusandae qui itaque dolorem ratione voluptas.", 23, 14720m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestiae aspernatur accusantium et esse doloribus tenetur nobis.", 61, 18973m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum enim aliquam autem cupiditate ut vitae provident nam.", 53, 12792m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Facere quia est eos recusandae dolores iusto.", 71, 7618m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et est perspiciatis molestias nobis quia et dicta odio.", 95, 17514m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eaque sit omnis blanditiis et minima perferendis dignissimos sed molestias.", 68, 6820m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Alias nisi unde tempore omnis enim.", 16, 7213m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Minima enim aut debitis libero nam.", 46, 4787m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Totam laudantium voluptas placeat deleniti occaecati aperiam.", 66, 3373m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Odio provident a enim eos cum cum adipisci.", 79, 12133m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Suscipit voluptas voluptas cum labore qui aliquam neque.", 9, 7659m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Fugiat voluptas tenetur.", 81, 19730m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Libero nisi impedit qui aut ut dolor inventore.", 69, 250m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ratione consectetur consectetur.", 93, 9850m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Illo expedita officiis odio consequuntur nulla quo.", 76, 4758m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Veritatis nam voluptatibus dolores.", 47, 5620m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quis voluptates ea.", 69, 19676m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolores omnis necessitatibus totam magni laborum est fugiat tenetur.", 95, 19481m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia impedit mollitia voluptatibus atque non.", 84, 1178m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptate nobis maxime rem blanditiis nesciunt nesciunt amet voluptatum.", 9, 2523m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ab nostrum ullam quia neque ipsa non minima reiciendis cumque.", 99, 13898m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nihil veniam rerum et distinctio quisquam.", 37, 18582m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem possimus ut ut tempora dolorum illum quae iusto.", 89, 18385m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Minima consequuntur impedit ipsa omnis quasi.", 76, 3460m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aperiam expedita sed non sed ut itaque dolorem ut.", 94, 15631m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Architecto similique itaque assumenda sint rerum.", 2, 7925m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Modi et qui et rerum nemo consequatur.", 20, 11548m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Fugiat ipsam sunt qui veritatis voluptatem harum molestias.", 57, 3891m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ut amet ut dolorem ducimus possimus.", 62, 12807m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aliquid qui impedit voluptatum assumenda ex.", 11, 5787m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Blanditiis rerum quia.", 39, 6702m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempora suscipit aut non voluptate sed.", 98, 15429m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "A numquam esse magni rem.", 16, 13330m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nihil quis animi et magni minus quis nihil aut.", 87, 15974m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Odit totam laudantium ullam ea repellat id ipsam.", 92, 16896m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Vel est libero.", 14, 6945m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quae veniam corporis minima iure atque ab.", 7, 17258m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Maxime accusantium consequatur sed enim et quod ut reprehenderit dignissimos.", 25, 16388m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Illo dignissimos qui aperiam est distinctio.", 19, 3022m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ut excepturi iste.", 72, 9025m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Exercitationem repellendus facilis totam aperiam nihil qui voluptas magni id.", 4, 9288m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Asperiores quam amet.", 34, 698m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui ipsa nostrum eum tempora soluta earum ut aut eveniet.", 70, 6933m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Esse est sit suscipit voluptatem blanditiis quisquam sunt voluptatibus minima.", 4, 10172m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dignissimos iste nihil qui dolorem nihil quod mollitia.", 19, 3324m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eligendi eligendi exercitationem ipsam qui.", 43, 8836m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sunt molestias aut.", 55, 9404m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptates numquam et.", 70, 9118m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Omnis tempore aut neque est fugiat sunt.", 30, 7282m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Reiciendis officia aliquam dolore.", 14, 7974m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tenetur et quae ducimus non minima sequi et.", 61, 4706m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Necessitatibus explicabo esse aut ipsam id quam id officia sit.", 14, 11386m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sit inventore ut natus iste et mollitia et sapiente porro.", 94, 3227m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Iure autem maxime maiores cumque nesciunt fugiat occaecati.", 90, 4797m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Velit deleniti sint iure sapiente.", 18, 3890m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Necessitatibus magni nostrum.", 17, 17046m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Atque exercitationem rerum et.", 16, 3836m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aliquid ut asperiores dolorem distinctio debitis ut eum atque.", 60, 15958m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Totam quisquam suscipit vero at velit nemo autem.", 22, 7114m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quam repellendus quis eos ut nisi qui iure.", 88, 12788m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Inventore voluptatem aut commodi vel.", 60, 11770m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Vero molestiae ullam quia quos aut sit voluptates hic aliquam.", 5, 3743m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ut magnam ut enim eum ab praesentium et.", 29, 12053m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nihil fuga nam explicabo earum officiis et numquam recusandae eos.", 46, 18034m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut et et reiciendis omnis nihil voluptas laboriosam in veniam.", 40, 13012m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "At non sunt consectetur sed voluptas officia sunt.", 77, 17451m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut dignissimos ut quis quis sed et.", 31, 10755m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et quis ut vel nostrum.", 92, 360m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eligendi voluptas voluptatem natus animi.", 38, 7704m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem ut tempora.", 28, 19071m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Facilis nesciunt quod et earum voluptates suscipit eaque quia.", 16, 5535m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur dolorem facere veritatis odit qui itaque.", 74, 5359m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem et inventore enim et aut ducimus.", 8, 3473m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eveniet ex modi natus veritatis optio temporibus expedita minima.", 41, 14764m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ipsum voluptas molestiae autem mollitia.", 33, 61m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatibus aut voluptas similique cumque iste magnam nostrum.", 17, 5707m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Autem quia et hic quo laboriosam veniam.", 12, 15236m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est dolore eveniet atque ut autem sunt totam occaecati.", 86, 11568m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quisquam corrupti culpa fugit ut nesciunt quam suscipit unde ipsum.", 58, 14574m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Rerum quia eveniet qui qui explicabo nemo.", 75, 7027m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Veniam maiores quibusdam voluptatem perferendis minus aut.", 19, 12332m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "A quam enim cumque qui facere corrupti et qui et.", 16, 11479m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eos esse dolores est consequatur est.", 36, 11310m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Porro voluptatem eligendi.", 77, 7393m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est enim qui.", 6, 12152m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Consequatur quam velit perspiciatis asperiores necessitatibus et sit sed.", 18, 13171m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Minima et hic impedit eaque dolorem.", 6, 2197m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolores aliquid quia ipsa aut excepturi.", 86, 14358m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Itaque quia voluptatem dolorem beatae tempore dolorem voluptatem.", 80, 6984m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eveniet expedita repudiandae.", 68, 307m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Animi quasi eos ut et.", 15, 19547m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Consequatur eum natus.", 69, 19691m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Iusto ab et.", 35, 9274m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Qui voluptatem animi cumque.", 78, 292m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolores neque quis aut optio.", 66, 15409m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Omnis rem repudiandae voluptates tempora aut.", 74, 97m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia occaecati sunt et.", 55, 16657m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Amet inventore sed.", 53, 12911m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quod minima eveniet.", 92, 16171m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Incidunt labore autem eveniet aut earum doloremque eveniet.", 65, 4071m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eos cupiditate praesentium.", 24, 13273m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut ullam cumque debitis molestiae.", 57, 9989m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Animi sequi magnam animi consequatur ipsum explicabo eaque dolore doloremque.", 69, 6088m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Asperiores debitis facere iusto.", 69, 2899m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Delectus itaque tempore sit dicta dignissimos.", 88, 11402m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Natus quo voluptatem.", 58, 10329m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Laudantium delectus dolorem et qui libero recusandae dolorum nihil quia.", 92, 3642m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quidem quasi et architecto tenetur et praesentium delectus error.", 66, 12851m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Labore ratione sunt consequatur eligendi praesentium odio.", 86, 2777m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui et numquam eligendi.", 33, 19510m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ducimus autem et et amet consequatur repellat.", 99, 5199m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Consequatur totam reiciendis est optio modi est velit et.", 73, 14962m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Mollitia facere accusamus libero impedit quia ipsum doloribus temporibus ex.", 51, 1513m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Debitis ut accusamus sit autem illum.", 9, 7935m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Omnis culpa consequuntur cumque ratione omnis optio quia voluptate dolore.", 28, 7778m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Perferendis cum fuga provident eum quisquam ipsam.", 41, 19411m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Molestiae dolorem velit excepturi repellendus iure.", 60, 16143m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quia ullam ipsum.", 20, 5935m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Mollitia quidem assumenda.", 62, 16058m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sit ut est molestias exercitationem consequatur.", 5, 7649m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Id et laudantium et perferendis ratione qui esse.", 43, 4645m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Magni consequatur sit possimus expedita commodi voluptatum ut incidunt.", 54, 18764m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Autem voluptas sint eveniet aliquam.", 89, 16694m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quo facere et dolores.", 80, 3958m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum vel non amet fuga et soluta minus fugiat quis.", 39, 19642m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Temporibus in ipsam omnis dolorem iusto voluptatem et dolore.", 91, 976m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Cumque voluptates ratione eos sunt.", 87, 3069m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Veniam sunt aut fuga excepturi.", 33, 2697m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ut fuga consequatur doloremque deserunt non molestias dolores soluta.", 72, 2750m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Magni laudantium fugiat reiciendis vel aut.", 93, 16243m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Mollitia suscipit optio qui fugit possimus.", 85, 14297m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ut sed enim.", 85, 863m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Impedit error animi impedit quos ab ullam.", 85, 6238m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Cumque maiores omnis repellat adipisci vel.", 38, 8100m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Consequuntur qui illo natus porro impedit assumenda.", 75, 4703m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Repudiandae asperiores et sed soluta.", 20, 16275m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "In autem sint similique enim pariatur fugiat odio laborum.", 3, 2748m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Odio corrupti qui id maxime.", 68, 12119m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quidem consequatur similique est est facere recusandae libero.", 82, 3951m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem iusto et ea non dolores ut totam.", 32, 17668m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Incidunt voluptas qui minus.", 8, 14211m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ut veniam modi quo vero sed quia fugiat eos dolores.", 44, 15311m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sed omnis ut doloremque quia facere atque magnam nulla.", 10, 10693m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Fuga repudiandae mollitia in eius dolorem.", 82, 12746m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nostrum ab vel.", 35, 16390m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et non nesciunt commodi quae aperiam quia repellendus.", 18, 616m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sapiente consequatur sint.", 45, 11627m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Amet accusantium id.", 92, 5274m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et nulla consectetur.", 59, 14540m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Unde unde consequatur ipsa eum est.", 95, 15958m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nobis et labore eum eveniet.", 44, 11686m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut beatae sed rem soluta mollitia.", 61, 10664m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et quae aperiam fuga beatae ipsum.", 23, 12342m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sit qui sit ut adipisci.", 15, 379m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et ab ducimus totam.", 71, 4940m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Est suscipit magnam tenetur magnam.", 21, 16392m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Inventore vero ad ipsam dolor inventore.", 45, 10652m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Optio laudantium a tempora repellat repellat qui.", 60, 3079m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sapiente blanditiis voluptatibus assumenda harum assumenda esse.", 48, 19783m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quis nesciunt minus libero voluptate quo sed aliquam.", 96, 12103m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Est magnam qui dolorum ab.", 15, 19702m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eos quibusdam nostrum ut nobis.", 71, 576m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ad earum voluptas voluptatem sint maxime sed deleniti.", 22, 13186m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rem et sint.", 77, 11901m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut alias nulla officiis accusamus sed vel et tempora consectetur.", 14, 1000m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit iste cumque nemo et suscipit atque ipsam aspernatur.", 82, 7107m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et quae itaque minus.", 94, 16504m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quae et nemo ab et omnis.", 98, 3256m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odit eaque nam.", 58, 9117m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Maxime occaecati sit ullam illum quaerat autem ratione.", 32, 2240m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Velit dolorem expedita soluta natus quis ab ut itaque.", 37, 11625m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Description", "Quantity", "State" },
                values: new object[] { "Qui vel atque.", 2168m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Accusamus et voluptas corrupti temporibus.", 6, 12761m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolor enim eligendi accusamus aut omnis veritatis nostrum.", 81, 63m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Itaque earum adipisci in voluptas et.", 60, 17808m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Exercitationem temporibus aliquid architecto.", 91, 9908m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Inventore sit est quis cupiditate consequatur nihil quae sapiente.", 45, 13600m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Iure unde deserunt labore et quam.", 59, 17700m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "In modi nihil doloribus autem officia labore.", 41, 18457m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolorem officiis qui molestiae nulla.", 50, 2057m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iure sapiente cupiditate ut quia.", 93, 825m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Itaque voluptas hic ratione veniam inventore dolorem.", 53, 1813m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quidem numquam assumenda consequatur rem dolores ipsa quos nam quia.", 84, 16290m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Saepe esse velit blanditiis non earum.", 99, 3033m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Rerum repellendus itaque dolorem et.", 40, 3947m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Magni aut sunt ut aut.", 76, 19419m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Enim qui mollitia enim cum libero veritatis deserunt.", 82, 1021m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eius vero aliquam iste voluptas unde.", 45, 12343m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptas est fuga corrupti.", 22, 6620m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sit earum qui consectetur nam voluptatem sapiente dolores ut nisi.", 35, 16914m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut fuga esse aspernatur non.", 87, 8168m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestias et ipsa sunt quaerat beatae.", 83, 5382m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eaque veritatis necessitatibus est officia.", 10, 9646m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quam magnam ad vel nihil iste fugit molestiae.", 8, 10995m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sequi dicta sint error impedit voluptatem in voluptatem.", 8, 10284m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Cupiditate voluptate fuga molestiae voluptate assumenda ea.", 82, 15808m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Omnis cupiditate sequi facere.", 21, 5586m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Minus id libero et ut.", 34, 16721m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sed corporis ratione doloremque.", 63, 14142m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Est tenetur et enim voluptatem.", 75, 7347m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut non et dolorem et autem aut.", 44, 19114m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui sit distinctio similique saepe voluptate quos ducimus.", 48, 18993m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi nam sit occaecati.", 10, 11054m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempore modi suscipit dolores ut labore ut nulla et.", 3, 5109m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Est qui voluptatum placeat magnam reiciendis et culpa qui a.", 13, 19701m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Qui dolorum quo velit nobis excepturi.", 77, 8766m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Perspiciatis aut eaque modi ut.", 79, 3101m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Beatae et nulla nemo sequi sunt est vel ratione voluptatem.", 41, 2252m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Non dolorum illum quis ipsum aliquid quo labore.", 52, 19939m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quam eum sit nisi.", 38, 15002m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut non quam libero pariatur laborum atque eos sed eligendi.", 1, 17484m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit omnis qui.", 85, 7303m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Omnis ut a voluptatem alias assumenda cum voluptates.", 54, 15786m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Hic quas quas aut possimus.", 82, 17128m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Velit exercitationem reiciendis non velit sint aut est.", 89, 2935m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Saepe exercitationem deleniti quis.", 9, 8777m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sit facere praesentium ab beatae voluptatem.", 56, 1419m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eveniet unde accusantium accusantium quo deleniti doloribus dolor ea iure.", 8, 5799m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Consequatur ad atque debitis aperiam culpa qui.", 23, 18743m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quo maxime et sequi.", 99, 13363m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Enim blanditiis provident a quibusdam.", 9, 6104m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum tempore totam blanditiis quibusdam.", 79, 10118m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Laborum placeat et consequatur sit voluptatem aperiam impedit incidunt.", 10, 12437m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sed illum tenetur sint labore.", 86, 5538m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sunt deleniti consequatur nostrum vero est maiores veniam nobis.", 52, 9543m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et facilis enim et.", 3, 17047m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sed sint reiciendis omnis omnis unde accusantium.", 21, 14979m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "At dolor maxime pariatur qui.", 41, 12699m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sit neque repellendus nostrum mollitia consequatur sunt.", 85, 19992m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolorem quis debitis explicabo modi minus distinctio qui ut enim.", 78, 14427m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Culpa enim rem aut aut at nam.", 77, 18000m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sit dolor omnis assumenda dicta deleniti eveniet et autem aut.", 32, 9750m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Error nihil dignissimos ut sint minus deleniti doloribus qui sapiente.", 11, 17424m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Description", "Quantity", "State", "Unit" },
                values: new object[] { "Veritatis voluptas facere dolor rerum omnis.", 4236m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolore sequi est dolor veritatis expedita eos voluptates aut adipisci.", 96, 7447m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Amet doloremque consequatur numquam error quibusdam fugit.", 16, 18064m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut reprehenderit aliquid neque consequatur quos rerum.", 39, 9774m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Numquam dolor consectetur in minima eligendi praesentium et natus aut.", 74, 7276m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Beatae magni magnam cumque dolorum voluptate quia aperiam occaecati.", 57, 14969m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Minus numquam aut vitae et.", 61, 66m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eius cumque vero reiciendis alias accusantium ipsum et.", 57, 7822m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nobis voluptas dolores.", 68, 1830m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequuntur dicta corrupti eum.", 11, 17724m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Inventore voluptatum esse fuga deleniti et.", 4, 10966m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Animi ipsum est facere quis eos quia.", 92, 15090m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Veritatis vel sunt laborum quis voluptatem fugit totam quasi animi.", 9, 19538m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sed ea rerum rerum porro sit.", 96, 1477m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Blanditiis maxime iusto ut esse quas voluptatem perspiciatis.", 39, 7053m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Asperiores repudiandae voluptatem molestias.", 14, 19945m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Est sint aliquid laudantium delectus voluptatem.", 73, 14968m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quidem eligendi quis doloremque quisquam.", 58, 3711m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia vel explicabo assumenda tenetur et neque.", 76, 11307m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Accusantium inventore occaecati.", 54, 19912m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi sint magnam inventore perspiciatis ullam perspiciatis doloribus repellendus.", 56, 16234m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Atque odit quaerat optio perferendis sint officia nihil beatae.", 57, 7553m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Excepturi qui ut itaque officiis.", 69, 14933m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempora et quaerat.", 85, 3429m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Hic amet in velit id aliquam cupiditate sit.", 45, 4167m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Reiciendis harum incidunt.", 58, 9513m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Autem laborum quibusdam perspiciatis modi totam ea quaerat.", 24, 8319m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et atque id aut doloribus.", 70, 19584m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolore nobis repellat dolore sit.", 73, 539m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Maiores sunt sunt dolor accusamus.", 17, 10323m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Exercitationem quia sed eligendi commodi ratione dolores autem quasi.", 100, 11964m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Unde vero tempora modi nisi.", 93, 4639m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ea ipsa repudiandae.", 48, 19121m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptas maxime doloribus ipsa.", 89, 3013m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem et nam debitis doloribus id dolore.", 30, 4624m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eligendi quasi quis incidunt ducimus suscipit voluptatem ut ut.", 41, 2839m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sunt suscipit molestias impedit.", 48, 18446m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Enim nemo quia consequatur nemo nam.", 19, 14498m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Architecto tempore dolorum consequatur nihil ut.", 100, 11322m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quaerat facere omnis.", 73, 12877m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Tempora aliquid doloribus tempore aspernatur.", 97, 18463m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Vel sint esse est cumque sequi quam.", 1, 14293m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quo impedit eius eius ab blanditiis est nam facere.", 82, 28m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dicta alias occaecati.", 1, 17730m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia quaerat rerum.", 61, 9707m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Accusantium exercitationem esse praesentium.", 46, 10280m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Repellendus ea ut illum vel repellat animi quis et.", 20, 1380m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Hic numquam est sed a culpa error.", 44, 8100m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Fuga in earum natus aut unde rerum aut soluta facilis.", 37, 4136m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut nihil ut.", 22, 16170m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et quod maxime dolores ullam enim.", 91, 7567m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quis sed molestiae et voluptatem accusamus omnis et eos.", 53, 6120m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut qui voluptatibus praesentium et iste omnis accusamus.", 82, 18669m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Laboriosam cumque corporis.", 100, 5666m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quo soluta ea ad itaque qui esse saepe nesciunt ut.", 80, 4381m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "In ut minima cumque architecto quas ut qui dolore.", 22, 4099m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem quo provident est aut nihil assumenda.", 70, 12442m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Reiciendis est totam animi atque.", 84, 5085m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sit quis ducimus iure similique tenetur.", 12, 2231m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Suscipit eos cupiditate est molestiae.", 10, 19814m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Description", "Quantity", "State", "Unit" },
                values: new object[] { "Officia mollitia qui cupiditate dolores voluptatem est quisquam.", 11299m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eligendi et velit quam eos vel excepturi sed.", 4, 11477m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum repudiandae natus voluptatem provident maxime magni libero.", 73, 8579m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eligendi laudantium aliquid.", 6, 11067m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eum dignissimos est sunt sint minima.", 2, 5302m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut vero ipsam id nesciunt corporis aspernatur excepturi.", 27, 10526m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Natus veritatis quia quae voluptas voluptatem.", 97, 5105m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Totam quo eligendi.", 87, 12309m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "A accusantium reiciendis eius autem qui.", 52, 3841m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Non natus saepe dolore.", 16, 247m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Asperiores voluptatum quo et porro velit ut quia est.", 67, 9622m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Deserunt qui culpa nulla placeat ipsam in assumenda quod.", 62, 8808m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Officia soluta omnis ipsam facilis et quam.", 6, 9669m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Praesentium accusamus facilis aperiam.", 64, 9908m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Autem et consequatur voluptate ut.", 74, 5115m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Odit facilis eligendi.", 72, 14653m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et et odit.", 35, 2803m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nihil consequuntur impedit rerum voluptatem reiciendis voluptas enim quibusdam.", 91, 4969m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Adipisci placeat eaque hic reprehenderit non voluptas eos porro ipsam.", 99, 15292m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et voluptates distinctio quo.", 11, 909m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Temporibus magni et nihil recusandae.", 83, 13597m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut ea aut sunt tenetur ipsa sunt similique.", 19, 8204m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Natus beatae ratione laboriosam explicabo quasi optio iusto explicabo quisquam.", 27, 14221m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sed aperiam ut itaque velit.", 84, 6308m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nihil autem a voluptatibus est.", 95, 12697m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nisi temporibus laboriosam officiis.", 23, 15135m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Reprehenderit esse eligendi ipsam maxime consequatur autem ipsa.", 69, 4826m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Deserunt alias iure ad.", 41, 14833m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eius magni corrupti repellat velit eligendi voluptatum.", 9, 3649m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Neque et aut deleniti.", 32, 4233m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nostrum qui est aspernatur velit laboriosam atque atque fugiat est.", 83, 14653m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eum maxime a soluta similique inventore accusantium.", 6, 11895m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Autem autem non.", 50, 16783m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cum omnis eveniet numquam ex asperiores cumque temporibus ipsam quia.", 73, 12769m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Totam distinctio harum voluptatem pariatur ut vero sed.", 26, 985m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Corporis recusandae rerum veritatis ipsum enim necessitatibus et.", 33, 16913m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Labore minima et velit explicabo.", 15, 7146m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Blanditiis rem consequatur distinctio.", 86, 16446m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut perferendis atque.", 58, 7582m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iste officia dolorum sint nemo ducimus.", 58, 9780m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Tempore ut dolor perspiciatis et facere sit deserunt.", 7, 7231m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ullam tempora eligendi ut possimus ut eveniet fugiat non et.", 45, 7460m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem voluptatem quidem dolore.", 78, 19095m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Totam et fuga aliquid maiores aut quo quos.", 62, 3292m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui ut tempore autem et quod asperiores aut doloribus.", 4, 15976m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Reiciendis illum totam.", 3, 15639m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sint minima perspiciatis nulla consequuntur quasi aut reprehenderit illum facilis.", 18, 1341m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Neque velit doloremque quia ut deleniti dignissimos.", 42, 2683m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Tempore optio nulla explicabo illo est voluptatem placeat qui.", 62, 4929m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Mollitia voluptatibus nulla ut nemo et laborum et corporis quis.", 9, 9851m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Qui incidunt molestiae.", 21, 7280m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Omnis perferendis quos repudiandae et dolor sint blanditiis esse minima.", 47, 19506m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut eveniet dolore et reprehenderit.", 23, 9466m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Cum magnam perferendis cupiditate magnam quo porro ut aut.", 82, 5852m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Veritatis iure repudiandae beatae perspiciatis aut sint laborum at rerum.", 97, 6357m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et hic repellendus consequatur quae.", 91, 18817m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Similique aliquam reiciendis qui.", 30, 19944m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Consequatur alias natus cupiditate est.", 7, 11460m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quia repellendus placeat earum.", 35, 12016m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Description", "Quantity", "State" },
                values: new object[] { "Et illo dolores.", 9767m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ut neque vero dolores voluptatem cupiditate quo voluptate ullam.", 10, 18802m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Debitis non est est vel illum ipsam vel.", 22, 18870m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Velit incidunt sint.", 72, 11570m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ut ut harum amet voluptatem eaque sed ullam similique.", 78, 18330m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Est porro aliquam sed.", 17, 3152m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ad qui atque excepturi.", 37, 3511m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sint necessitatibus reiciendis maiores eos sed.", 78, 2308m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Id ratione occaecati eum voluptatem.", 33, 12504m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolor est nobis laboriosam ea blanditiis omnis.", 52, 10475m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est aliquam voluptatem.", 58, 3979m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Autem voluptas vitae voluptas laudantium magni.", 50, 4241m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eaque maxime eum laboriosam labore exercitationem est dolor vitae laboriosam.", 57, 5145m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Blanditiis voluptatem molestias dolorem consequatur modi id et.", 57, 3548m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Tempora et sed aperiam consequatur non dolorem ex vero sint.", 98, 1658m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vitae sed ut cupiditate cum dolorem tempore hic.", 55, 2975m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Explicabo et molestiae tempore qui est.", 22, 11049m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aperiam alias veniam animi nisi nihil sint.", 97, 717m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et ipsa dolorem.", 30, 1027m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut omnis qui voluptatem sed.", 46, 19835m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et et eveniet quod.", 55, 9778m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est placeat molestias nisi rem cupiditate mollitia.", 29, 17207m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Description", "Quantity", "State", "Unit" },
                values: new object[] { "Perspiciatis dolore vero laboriosam enim enim sit qui aliquid perferendis.", 9318m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Neque quia iste quos molestias deleniti est dolore.", 43, 12409m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Est magni dolor dolorem deleniti dolore quaerat et.", 22, 795m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Soluta magnam impedit veniam tempore neque nemo.", 54, 16436m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT94347-0", 1, new DateTime(2021, 10, 2, 20, 12, 20, 89, DateTimeKind.Unspecified).AddTicks(1330), new DateTime(2021, 5, 20, 8, 3, 59, 222, DateTimeKind.Unspecified).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT69790-0", new DateTime(2021, 10, 4, 3, 26, 9, 777, DateTimeKind.Unspecified).AddTicks(8923), new DateTime(2021, 8, 8, 22, 1, 18, 161, DateTimeKind.Unspecified).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT81093-1", 1, new DateTime(2021, 9, 14, 11, 37, 25, 362, DateTimeKind.Unspecified).AddTicks(6679), new DateTime(2021, 8, 3, 22, 24, 49, 857, DateTimeKind.Unspecified).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT57976-0", 3, new DateTime(2021, 12, 8, 16, 30, 11, 568, DateTimeKind.Unspecified).AddTicks(2610), new DateTime(2021, 7, 20, 23, 21, 16, 904, DateTimeKind.Unspecified).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT58669-0", 4, new DateTime(2021, 12, 11, 14, 22, 3, 569, DateTimeKind.Unspecified).AddTicks(3219), new DateTime(2021, 6, 26, 6, 27, 39, 86, DateTimeKind.Unspecified).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT78179-1", 4, new DateTime(2021, 10, 23, 14, 10, 46, 391, DateTimeKind.Unspecified).AddTicks(8640), new DateTime(2021, 6, 8, 16, 6, 47, 188, DateTimeKind.Unspecified).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT76923-1", 4, new DateTime(2021, 10, 21, 2, 21, 59, 498, DateTimeKind.Unspecified).AddTicks(9155), new DateTime(2021, 7, 22, 1, 53, 0, 25, DateTimeKind.Unspecified).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT76470-1", new DateTime(2021, 10, 6, 15, 23, 18, 928, DateTimeKind.Unspecified).AddTicks(8692), new DateTime(2021, 5, 30, 15, 28, 32, 686, DateTimeKind.Unspecified).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT73121-0", new DateTime(2021, 9, 29, 12, 12, 25, 985, DateTimeKind.Unspecified).AddTicks(1112), new DateTime(2021, 5, 17, 2, 7, 22, 271, DateTimeKind.Unspecified).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT19809-0", 4, new DateTime(2021, 9, 2, 15, 4, 10, 284, DateTimeKind.Unspecified).AddTicks(6464), new DateTime(2021, 7, 29, 4, 32, 44, 796, DateTimeKind.Unspecified).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT67544-0", new DateTime(2021, 9, 24, 10, 38, 59, 437, DateTimeKind.Unspecified).AddTicks(2046), new DateTime(2021, 8, 7, 7, 8, 30, 835, DateTimeKind.Unspecified).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT52715-0", 4, new DateTime(2021, 12, 3, 10, 34, 11, 392, DateTimeKind.Unspecified).AddTicks(6191), new DateTime(2021, 7, 8, 10, 0, 43, 782, DateTimeKind.Unspecified).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT39077-1", 2, new DateTime(2021, 12, 25, 11, 22, 20, 36, DateTimeKind.Unspecified).AddTicks(2563), new DateTime(2021, 5, 12, 11, 47, 44, 999, DateTimeKind.Unspecified).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT92374-1", 5, new DateTime(2021, 9, 4, 6, 47, 29, 275, DateTimeKind.Unspecified).AddTicks(8462), new DateTime(2021, 7, 2, 20, 30, 4, 154, DateTimeKind.Unspecified).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT72197-1", 3, new DateTime(2021, 9, 15, 0, 22, 51, 636, DateTimeKind.Unspecified).AddTicks(128), new DateTime(2021, 6, 6, 4, 21, 7, 757, DateTimeKind.Unspecified).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT84148-0", new DateTime(2021, 9, 22, 5, 48, 22, 677, DateTimeKind.Unspecified).AddTicks(570), new DateTime(2021, 6, 19, 15, 18, 5, 610, DateTimeKind.Unspecified).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT85726-0", 5, new DateTime(2021, 12, 3, 3, 18, 26, 221, DateTimeKind.Unspecified).AddTicks(4847), new DateTime(2021, 6, 21, 0, 50, 25, 831, DateTimeKind.Unspecified).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT64082-0", 5, new DateTime(2021, 11, 7, 6, 55, 37, 31, DateTimeKind.Unspecified).AddTicks(1168), new DateTime(2021, 7, 15, 2, 26, 17, 233, DateTimeKind.Unspecified).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT86726-0", new DateTime(2021, 9, 4, 19, 19, 0, 227, DateTimeKind.Unspecified).AddTicks(7510), new DateTime(2021, 6, 20, 2, 30, 3, 466, DateTimeKind.Unspecified).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT20489-0", 5, new DateTime(2021, 12, 25, 3, 29, 7, 388, DateTimeKind.Unspecified).AddTicks(1139), new DateTime(2021, 8, 7, 23, 13, 38, 455, DateTimeKind.Unspecified).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT69269-1", 1, new DateTime(2021, 9, 10, 17, 55, 44, 576, DateTimeKind.Unspecified).AddTicks(3903), new DateTime(2021, 8, 2, 11, 37, 16, 844, DateTimeKind.Unspecified).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT54506-1", 1, new DateTime(2021, 12, 5, 17, 55, 12, 829, DateTimeKind.Unspecified).AddTicks(5498), new DateTime(2021, 6, 7, 12, 59, 28, 327, DateTimeKind.Unspecified).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT15337-0", 2, new DateTime(2021, 10, 14, 14, 9, 27, 510, DateTimeKind.Unspecified).AddTicks(4170), new DateTime(2021, 7, 30, 18, 6, 3, 106, DateTimeKind.Unspecified).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT24390-0", 2, new DateTime(2021, 10, 1, 11, 1, 30, 715, DateTimeKind.Unspecified).AddTicks(900), new DateTime(2021, 7, 28, 18, 50, 4, 940, DateTimeKind.Unspecified).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT99578-0", 1, new DateTime(2021, 9, 8, 7, 56, 16, 626, DateTimeKind.Unspecified).AddTicks(7865), new DateTime(2021, 7, 22, 17, 3, 46, 77, DateTimeKind.Unspecified).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT26554-0", 3, new DateTime(2021, 10, 28, 2, 39, 48, 104, DateTimeKind.Unspecified).AddTicks(2242), new DateTime(2021, 5, 13, 12, 34, 11, 399, DateTimeKind.Unspecified).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT63667-0", 2, new DateTime(2021, 9, 6, 7, 48, 15, 922, DateTimeKind.Unspecified).AddTicks(6143), new DateTime(2021, 8, 17, 9, 49, 35, 533, DateTimeKind.Unspecified).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT46354-1", 4, new DateTime(2021, 9, 21, 2, 27, 32, 338, DateTimeKind.Unspecified).AddTicks(7116), new DateTime(2021, 7, 15, 16, 4, 17, 537, DateTimeKind.Unspecified).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT75800-1", 3, new DateTime(2021, 10, 29, 16, 21, 49, 458, DateTimeKind.Unspecified).AddTicks(3309), new DateTime(2021, 6, 21, 8, 16, 27, 678, DateTimeKind.Unspecified).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT73137-1", 1, new DateTime(2021, 11, 10, 17, 40, 22, 431, DateTimeKind.Unspecified).AddTicks(799), new DateTime(2021, 7, 13, 23, 39, 45, 205, DateTimeKind.Unspecified).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT10167-0", new DateTime(2021, 12, 27, 7, 57, 13, 682, DateTimeKind.Unspecified).AddTicks(6428), new DateTime(2021, 5, 10, 17, 7, 54, 557, DateTimeKind.Unspecified).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT40892-0", new DateTime(2021, 11, 25, 7, 52, 15, 302, DateTimeKind.Unspecified).AddTicks(9696), new DateTime(2021, 7, 8, 1, 11, 7, 92, DateTimeKind.Unspecified).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT98815-0", 3, new DateTime(2021, 9, 9, 0, 13, 8, 966, DateTimeKind.Unspecified).AddTicks(9139), new DateTime(2021, 7, 13, 3, 25, 35, 434, DateTimeKind.Unspecified).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT56375-1", new DateTime(2021, 11, 20, 22, 42, 54, 29, DateTimeKind.Unspecified).AddTicks(9174), new DateTime(2021, 7, 6, 5, 50, 21, 970, DateTimeKind.Unspecified).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT53083-1", new DateTime(2021, 10, 15, 14, 20, 42, 89, DateTimeKind.Unspecified).AddTicks(7396), new DateTime(2021, 6, 4, 19, 36, 30, 967, DateTimeKind.Unspecified).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT34501-1", 3, new DateTime(2021, 11, 16, 15, 54, 17, 805, DateTimeKind.Unspecified).AddTicks(1685), new DateTime(2021, 8, 6, 6, 5, 15, 573, DateTimeKind.Unspecified).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT23876-0", 4, new DateTime(2021, 10, 29, 5, 29, 41, 639, DateTimeKind.Unspecified).AddTicks(3631), new DateTime(2021, 8, 29, 9, 15, 48, 531, DateTimeKind.Unspecified).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT10493-1", new DateTime(2021, 9, 2, 11, 58, 22, 489, DateTimeKind.Unspecified).AddTicks(2635), new DateTime(2021, 7, 21, 2, 53, 21, 40, DateTimeKind.Unspecified).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT14684-0", 1, new DateTime(2021, 12, 20, 21, 10, 47, 214, DateTimeKind.Unspecified).AddTicks(7909), new DateTime(2021, 6, 23, 17, 41, 27, 233, DateTimeKind.Unspecified).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT11285-0", new DateTime(2021, 10, 27, 23, 51, 43, 433, DateTimeKind.Unspecified).AddTicks(2705), new DateTime(2021, 7, 17, 11, 31, 58, 50, DateTimeKind.Unspecified).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT15345-0", new DateTime(2021, 12, 13, 14, 33, 36, 629, DateTimeKind.Unspecified).AddTicks(6547), new DateTime(2021, 7, 10, 22, 49, 57, 690, DateTimeKind.Unspecified).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT33811-0", new DateTime(2021, 10, 2, 19, 9, 14, 14, DateTimeKind.Unspecified).AddTicks(5554), new DateTime(2021, 5, 13, 23, 13, 30, 23, DateTimeKind.Unspecified).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT50032-1", new DateTime(2021, 11, 14, 2, 22, 16, 325, DateTimeKind.Unspecified).AddTicks(1368), new DateTime(2021, 8, 20, 7, 30, 24, 752, DateTimeKind.Unspecified).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT28941-1", 5, new DateTime(2021, 11, 30, 7, 40, 41, 380, DateTimeKind.Unspecified).AddTicks(2395), new DateTime(2021, 8, 20, 18, 24, 46, 668, DateTimeKind.Unspecified).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT33784-0", 2, new DateTime(2021, 11, 24, 3, 44, 21, 242, DateTimeKind.Unspecified).AddTicks(5420), new DateTime(2021, 8, 5, 1, 40, 30, 894, DateTimeKind.Unspecified).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT91044-1", 4, new DateTime(2021, 11, 13, 7, 11, 1, 930, DateTimeKind.Unspecified).AddTicks(4658), new DateTime(2021, 7, 28, 8, 20, 33, 361, DateTimeKind.Unspecified).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT64649-0", 2, new DateTime(2021, 10, 25, 0, 36, 22, 994, DateTimeKind.Unspecified).AddTicks(746), new DateTime(2021, 7, 17, 9, 27, 16, 11, DateTimeKind.Unspecified).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT48158-0", 3, new DateTime(2021, 11, 19, 14, 30, 2, 149, DateTimeKind.Unspecified).AddTicks(2650), new DateTime(2021, 7, 26, 4, 56, 57, 178, DateTimeKind.Unspecified).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT31262-1", 1, new DateTime(2021, 9, 2, 7, 31, 58, 556, DateTimeKind.Unspecified).AddTicks(2797), new DateTime(2021, 5, 9, 4, 38, 22, 939, DateTimeKind.Unspecified).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT60668-0", 3, new DateTime(2021, 10, 21, 12, 10, 29, 122, DateTimeKind.Unspecified).AddTicks(8603), new DateTime(2021, 7, 7, 16, 43, 43, 900, DateTimeKind.Unspecified).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT62924-1", new DateTime(2021, 9, 15, 8, 15, 48, 574, DateTimeKind.Unspecified).AddTicks(4436), new DateTime(2021, 8, 19, 8, 51, 1, 522, DateTimeKind.Unspecified).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT60697-0", 1, new DateTime(2021, 11, 23, 22, 22, 46, 70, DateTimeKind.Unspecified).AddTicks(3855), new DateTime(2021, 7, 2, 9, 55, 44, 677, DateTimeKind.Unspecified).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT33914-1", 5, new DateTime(2021, 11, 19, 15, 45, 36, 204, DateTimeKind.Unspecified).AddTicks(7385), new DateTime(2021, 7, 1, 12, 0, 59, 98, DateTimeKind.Unspecified).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT37260-0", 3, new DateTime(2021, 12, 12, 18, 24, 21, 767, DateTimeKind.Unspecified).AddTicks(1172), new DateTime(2021, 6, 10, 2, 51, 8, 716, DateTimeKind.Unspecified).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT56193-1", new DateTime(2021, 11, 6, 1, 14, 4, 755, DateTimeKind.Unspecified).AddTicks(2538), new DateTime(2021, 7, 14, 13, 9, 19, 142, DateTimeKind.Unspecified).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT22295-0", 4, new DateTime(2021, 12, 15, 11, 40, 39, 133, DateTimeKind.Unspecified).AddTicks(6145), new DateTime(2021, 5, 9, 15, 12, 39, 85, DateTimeKind.Unspecified).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT12067-1", 2, new DateTime(2021, 10, 18, 17, 2, 11, 675, DateTimeKind.Unspecified).AddTicks(2883), new DateTime(2021, 6, 8, 23, 49, 56, 363, DateTimeKind.Unspecified).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT65505-0", 3, new DateTime(2021, 10, 19, 15, 54, 5, 19, DateTimeKind.Unspecified).AddTicks(2793), new DateTime(2021, 8, 14, 7, 45, 40, 820, DateTimeKind.Unspecified).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT11886-0", 4, new DateTime(2021, 9, 13, 17, 1, 7, 155, DateTimeKind.Unspecified).AddTicks(6624), new DateTime(2021, 8, 10, 20, 4, 44, 169, DateTimeKind.Unspecified).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT97073-1", 3, new DateTime(2021, 9, 15, 9, 46, 22, 489, DateTimeKind.Unspecified).AddTicks(2089), new DateTime(2021, 6, 20, 15, 49, 3, 794, DateTimeKind.Unspecified).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT27602-1", 4, new DateTime(2021, 9, 1, 6, 23, 19, 928, DateTimeKind.Unspecified).AddTicks(1648), new DateTime(2021, 8, 23, 20, 10, 27, 497, DateTimeKind.Unspecified).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT10724-0", 3, new DateTime(2021, 12, 24, 2, 0, 15, 641, DateTimeKind.Unspecified).AddTicks(1711), new DateTime(2021, 6, 27, 10, 29, 12, 524, DateTimeKind.Unspecified).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT37403-1", 1, new DateTime(2021, 9, 16, 6, 11, 45, 901, DateTimeKind.Unspecified).AddTicks(4722), new DateTime(2021, 8, 30, 6, 17, 16, 591, DateTimeKind.Unspecified).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT46536-0", 5, new DateTime(2021, 10, 29, 19, 12, 11, 466, DateTimeKind.Unspecified).AddTicks(3389), new DateTime(2021, 7, 23, 18, 45, 9, 227, DateTimeKind.Unspecified).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT87247-0", 4, new DateTime(2021, 9, 5, 9, 54, 26, 6, DateTimeKind.Unspecified).AddTicks(3612), new DateTime(2021, 8, 26, 14, 30, 7, 66, DateTimeKind.Unspecified).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT47750-0", 1, new DateTime(2021, 10, 19, 19, 49, 21, 721, DateTimeKind.Unspecified).AddTicks(3522), new DateTime(2021, 5, 22, 21, 12, 4, 251, DateTimeKind.Unspecified).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT71849-0", 2, new DateTime(2021, 11, 2, 17, 48, 49, 858, DateTimeKind.Unspecified).AddTicks(5833), new DateTime(2021, 7, 2, 6, 17, 35, 828, DateTimeKind.Unspecified).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT82735-1", 4, new DateTime(2021, 12, 12, 11, 1, 6, 179, DateTimeKind.Unspecified).AddTicks(5160), new DateTime(2021, 7, 5, 5, 34, 31, 201, DateTimeKind.Unspecified).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT96442-1", 5, new DateTime(2021, 10, 13, 22, 50, 30, 877, DateTimeKind.Unspecified).AddTicks(473), new DateTime(2021, 5, 27, 8, 20, 0, 544, DateTimeKind.Unspecified).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT27483-1", 2, new DateTime(2021, 11, 14, 1, 10, 59, 724, DateTimeKind.Unspecified).AddTicks(9155), new DateTime(2021, 7, 20, 6, 1, 31, 873, DateTimeKind.Unspecified).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT41248-0", 2, new DateTime(2021, 12, 29, 18, 24, 24, 301, DateTimeKind.Unspecified).AddTicks(1), new DateTime(2021, 7, 27, 8, 17, 29, 870, DateTimeKind.Unspecified).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT81226-0", 5, new DateTime(2021, 12, 15, 12, 38, 50, 228, DateTimeKind.Unspecified).AddTicks(7820), new DateTime(2021, 6, 19, 8, 50, 12, 290, DateTimeKind.Unspecified).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT91175-1", new DateTime(2021, 12, 2, 12, 59, 36, 239, DateTimeKind.Unspecified).AddTicks(9683), new DateTime(2021, 7, 28, 22, 51, 17, 238, DateTimeKind.Unspecified).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT84079-0", 5, new DateTime(2021, 9, 7, 1, 0, 1, 294, DateTimeKind.Unspecified).AddTicks(8113), new DateTime(2021, 7, 18, 7, 30, 1, 391, DateTimeKind.Unspecified).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT14708-0", 2, new DateTime(2021, 10, 26, 0, 16, 23, 595, DateTimeKind.Unspecified).AddTicks(1482), new DateTime(2021, 5, 12, 15, 48, 29, 300, DateTimeKind.Unspecified).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT27685-0", 3, new DateTime(2021, 9, 7, 10, 7, 9, 81, DateTimeKind.Unspecified).AddTicks(2811), new DateTime(2021, 5, 18, 19, 16, 30, 704, DateTimeKind.Unspecified).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT22946-0", new DateTime(2021, 10, 23, 20, 3, 59, 338, DateTimeKind.Unspecified).AddTicks(770), new DateTime(2021, 8, 25, 15, 11, 25, 79, DateTimeKind.Unspecified).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT99846-0", new DateTime(2021, 9, 25, 14, 43, 53, 295, DateTimeKind.Unspecified).AddTicks(9944), new DateTime(2021, 6, 25, 19, 1, 39, 122, DateTimeKind.Unspecified).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT82975-1", 5, new DateTime(2021, 11, 3, 7, 55, 36, 78, DateTimeKind.Unspecified).AddTicks(5453), new DateTime(2021, 6, 22, 18, 31, 33, 591, DateTimeKind.Unspecified).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT81332-1", 5, new DateTime(2021, 11, 13, 6, 13, 23, 827, DateTimeKind.Unspecified).AddTicks(1531), new DateTime(2021, 7, 5, 2, 23, 45, 444, DateTimeKind.Unspecified).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT73834-1", 1, new DateTime(2021, 12, 19, 4, 21, 35, 524, DateTimeKind.Unspecified).AddTicks(8116), new DateTime(2021, 7, 9, 14, 56, 6, 600, DateTimeKind.Unspecified).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT44886-0", 5, new DateTime(2021, 10, 26, 21, 36, 59, 444, DateTimeKind.Unspecified).AddTicks(1636), new DateTime(2021, 6, 7, 4, 17, 6, 460, DateTimeKind.Unspecified).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT60454-0", 1, new DateTime(2021, 10, 19, 11, 35, 43, 180, DateTimeKind.Unspecified).AddTicks(2005), new DateTime(2021, 8, 9, 3, 24, 18, 246, DateTimeKind.Unspecified).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT55585-1", 4, new DateTime(2021, 10, 1, 13, 19, 21, 242, DateTimeKind.Unspecified).AddTicks(9559), new DateTime(2021, 8, 29, 8, 18, 36, 895, DateTimeKind.Unspecified).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT54323-1", 1, new DateTime(2021, 11, 7, 3, 35, 21, 151, DateTimeKind.Unspecified).AddTicks(2447), new DateTime(2021, 8, 10, 6, 3, 50, 706, DateTimeKind.Unspecified).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT32113-1", 4, new DateTime(2021, 12, 25, 23, 9, 48, 270, DateTimeKind.Unspecified).AddTicks(9713), new DateTime(2021, 8, 26, 19, 58, 23, 204, DateTimeKind.Unspecified).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT46671-1", 4, new DateTime(2021, 9, 17, 6, 34, 48, 386, DateTimeKind.Unspecified).AddTicks(5914), new DateTime(2021, 7, 30, 7, 20, 43, 82, DateTimeKind.Unspecified).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT39928-0", 3, new DateTime(2021, 10, 1, 0, 0, 48, 482, DateTimeKind.Unspecified).AddTicks(1752), new DateTime(2021, 8, 17, 9, 14, 25, 494, DateTimeKind.Unspecified).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT42683-0", 4, new DateTime(2021, 11, 8, 8, 33, 49, 337, DateTimeKind.Unspecified).AddTicks(7632), new DateTime(2021, 8, 10, 2, 20, 54, 310, DateTimeKind.Unspecified).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT94287-1", 1, new DateTime(2021, 12, 5, 14, 52, 53, 773, DateTimeKind.Unspecified).AddTicks(2481), new DateTime(2021, 8, 19, 15, 43, 30, 642, DateTimeKind.Unspecified).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT85082-0", 3, new DateTime(2021, 10, 24, 15, 23, 42, 781, DateTimeKind.Unspecified).AddTicks(9284), new DateTime(2021, 6, 5, 5, 9, 38, 899, DateTimeKind.Unspecified).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT74490-1", 1, new DateTime(2021, 9, 25, 20, 41, 33, 935, DateTimeKind.Unspecified).AddTicks(3038), new DateTime(2021, 8, 28, 3, 44, 46, 461, DateTimeKind.Unspecified).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT75322-1", 2, new DateTime(2021, 11, 20, 13, 35, 6, 392, DateTimeKind.Unspecified).AddTicks(2856), new DateTime(2021, 8, 1, 15, 1, 13, 540, DateTimeKind.Unspecified).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT75425-1", 5, new DateTime(2021, 10, 20, 13, 54, 10, 522, DateTimeKind.Unspecified).AddTicks(7531), new DateTime(2021, 7, 15, 18, 21, 39, 252, DateTimeKind.Unspecified).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT84330-1", 1, new DateTime(2021, 10, 11, 2, 58, 7, 426, DateTimeKind.Unspecified).AddTicks(2442), new DateTime(2021, 7, 23, 3, 44, 51, 196, DateTimeKind.Unspecified).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT95416-1", new DateTime(2021, 10, 7, 1, 1, 15, 276, DateTimeKind.Unspecified).AddTicks(6671), new DateTime(2021, 8, 8, 18, 53, 30, 128, DateTimeKind.Unspecified).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT69786-0", new DateTime(2021, 12, 21, 6, 59, 4, 750, DateTimeKind.Unspecified).AddTicks(9719), new DateTime(2021, 8, 6, 2, 43, 47, 554, DateTimeKind.Unspecified).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT15545-0", 3, new DateTime(2021, 12, 25, 7, 1, 53, 697, DateTimeKind.Unspecified).AddTicks(5913), new DateTime(2021, 7, 25, 7, 11, 31, 364, DateTimeKind.Unspecified).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT41414-0", 5, new DateTime(2021, 12, 19, 23, 48, 44, 249, DateTimeKind.Unspecified).AddTicks(1689), new DateTime(2021, 5, 13, 17, 13, 28, 768, DateTimeKind.Unspecified).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT92580-0", new DateTime(2021, 10, 20, 3, 55, 41, 928, DateTimeKind.Unspecified).AddTicks(9327), new DateTime(2021, 7, 3, 8, 27, 44, 395, DateTimeKind.Unspecified).AddTicks(5462) });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 148, 5, "YT92465-1", 4, new DateTime(2021, 10, 31, 22, 32, 51, 947, DateTimeKind.Unspecified).AddTicks(8479), new DateTime(2021, 5, 20, 18, 54, 15, 792, DateTimeKind.Unspecified).AddTicks(8730) },
                    { 128, 4, "YT67762-1", 3, new DateTime(2021, 12, 12, 17, 9, 23, 200, DateTimeKind.Unspecified).AddTicks(8900), new DateTime(2021, 8, 17, 21, 47, 16, 680, DateTimeKind.Unspecified).AddTicks(5263) },
                    { 129, 2, "YT82019-1", 5, new DateTime(2021, 12, 18, 8, 42, 25, 974, DateTimeKind.Unspecified).AddTicks(4301), new DateTime(2021, 7, 4, 15, 3, 47, 61, DateTimeKind.Unspecified).AddTicks(3968) },
                    { 130, 1, "YT24189-0", 3, new DateTime(2021, 9, 22, 17, 42, 32, 144, DateTimeKind.Unspecified).AddTicks(7195), new DateTime(2021, 8, 2, 19, 24, 25, 632, DateTimeKind.Unspecified).AddTicks(6649) },
                    { 131, 5, "YT53455-0", 4, new DateTime(2021, 10, 2, 8, 7, 5, 224, DateTimeKind.Unspecified).AddTicks(8781), new DateTime(2021, 6, 8, 0, 28, 41, 367, DateTimeKind.Unspecified).AddTicks(1677) },
                    { 132, 2, "YT66302-1", 5, new DateTime(2021, 9, 17, 9, 14, 11, 905, DateTimeKind.Unspecified).AddTicks(9962), new DateTime(2021, 7, 27, 9, 40, 56, 380, DateTimeKind.Unspecified).AddTicks(4565) },
                    { 133, 4, "YT13050-0", 5, new DateTime(2021, 10, 30, 18, 6, 53, 269, DateTimeKind.Unspecified).AddTicks(8467), new DateTime(2021, 7, 24, 19, 18, 19, 363, DateTimeKind.Unspecified).AddTicks(1970) },
                    { 134, 3, "YT92219-0", 2, new DateTime(2021, 11, 24, 12, 39, 4, 962, DateTimeKind.Unspecified).AddTicks(1562), new DateTime(2021, 8, 16, 0, 14, 33, 642, DateTimeKind.Unspecified).AddTicks(129) },
                    { 135, 1, "YT93516-0", 3, new DateTime(2021, 9, 11, 17, 21, 27, 340, DateTimeKind.Unspecified).AddTicks(5554), new DateTime(2021, 6, 29, 3, 15, 51, 312, DateTimeKind.Unspecified).AddTicks(8902) },
                    { 136, 1, "YT69908-0", 5, new DateTime(2021, 12, 14, 10, 11, 47, 703, DateTimeKind.Unspecified).AddTicks(1053), new DateTime(2021, 6, 22, 15, 22, 57, 657, DateTimeKind.Unspecified).AddTicks(2083) },
                    { 137, 2, "YT81784-1", 4, new DateTime(2021, 9, 10, 13, 41, 32, 593, DateTimeKind.Unspecified).AddTicks(2890), new DateTime(2021, 5, 18, 7, 45, 5, 717, DateTimeKind.Unspecified).AddTicks(4902) },
                    { 138, 4, "YT91395-1", 1, new DateTime(2021, 9, 2, 5, 46, 50, 671, DateTimeKind.Unspecified).AddTicks(3601), new DateTime(2021, 6, 2, 23, 33, 29, 992, DateTimeKind.Unspecified).AddTicks(2486) },
                    { 139, 5, "YT10987-1", 4, new DateTime(2021, 10, 27, 7, 52, 9, 355, DateTimeKind.Unspecified).AddTicks(6271), new DateTime(2021, 5, 19, 10, 22, 58, 298, DateTimeKind.Unspecified).AddTicks(5027) },
                    { 140, 1, "YT84443-0", 2, new DateTime(2021, 12, 10, 13, 36, 48, 480, DateTimeKind.Unspecified).AddTicks(442), new DateTime(2021, 8, 18, 11, 23, 53, 692, DateTimeKind.Unspecified).AddTicks(7992) },
                    { 141, 5, "YT69958-1", 2, new DateTime(2021, 10, 17, 18, 42, 10, 753, DateTimeKind.Unspecified).AddTicks(7959), new DateTime(2021, 7, 11, 22, 22, 25, 896, DateTimeKind.Unspecified).AddTicks(3650) },
                    { 142, 1, "YT32474-1", 1, new DateTime(2021, 12, 13, 7, 26, 16, 418, DateTimeKind.Unspecified).AddTicks(4048), new DateTime(2021, 8, 10, 4, 54, 28, 150, DateTimeKind.Unspecified).AddTicks(2827) },
                    { 143, 2, "YT84262-1", 1, new DateTime(2021, 10, 7, 6, 20, 57, 248, DateTimeKind.Unspecified).AddTicks(3512), new DateTime(2021, 7, 6, 8, 13, 16, 153, DateTimeKind.Unspecified).AddTicks(5845) },
                    { 144, 3, "YT66583-0", 2, new DateTime(2021, 12, 20, 9, 49, 52, 598, DateTimeKind.Unspecified).AddTicks(1478), new DateTime(2021, 8, 30, 5, 13, 3, 610, DateTimeKind.Unspecified).AddTicks(1351) },
                    { 145, 3, "YT40224-1", 2, new DateTime(2021, 10, 11, 11, 15, 48, 657, DateTimeKind.Unspecified).AddTicks(3691), new DateTime(2021, 6, 13, 2, 36, 20, 301, DateTimeKind.Unspecified).AddTicks(4888) },
                    { 146, 5, "YT68241-1", 5, new DateTime(2021, 10, 27, 16, 4, 38, 544, DateTimeKind.Unspecified).AddTicks(2681), new DateTime(2021, 7, 21, 22, 20, 10, 731, DateTimeKind.Unspecified).AddTicks(3367) },
                    { 147, 4, "YT75285-0", 1, new DateTime(2021, 10, 11, 7, 30, 38, 3, DateTimeKind.Unspecified).AddTicks(5482), new DateTime(2021, 6, 26, 0, 27, 6, 368, DateTimeKind.Unspecified).AddTicks(6486) },
                    { 127, 5, "YT39297-1", 2, new DateTime(2021, 11, 12, 5, 19, 56, 970, DateTimeKind.Unspecified).AddTicks(8383), new DateTime(2021, 8, 25, 2, 1, 42, 273, DateTimeKind.Unspecified).AddTicks(2903) },
                    { 126, 4, "YT72858-0", 5, new DateTime(2021, 9, 12, 14, 16, 14, 320, DateTimeKind.Unspecified).AddTicks(795), new DateTime(2021, 7, 6, 13, 36, 21, 411, DateTimeKind.Unspecified).AddTicks(7541) },
                    { 103, 5, "YT63225-1", 2, new DateTime(2021, 10, 23, 20, 4, 50, 916, DateTimeKind.Unspecified).AddTicks(7552), new DateTime(2021, 8, 3, 5, 30, 28, 824, DateTimeKind.Unspecified).AddTicks(1002) },
                    { 124, 2, "YT43351-1", 2, new DateTime(2021, 10, 30, 7, 53, 34, 27, DateTimeKind.Unspecified).AddTicks(3867), new DateTime(2021, 6, 26, 17, 6, 12, 311, DateTimeKind.Unspecified).AddTicks(6819) },
                    { 102, 5, "YT55212-1", 1, new DateTime(2021, 11, 28, 1, 58, 9, 219, DateTimeKind.Unspecified).AddTicks(2456), new DateTime(2021, 8, 16, 1, 33, 5, 2, DateTimeKind.Unspecified).AddTicks(9018) },
                    { 149, 5, "YT33935-1", 3, new DateTime(2021, 11, 17, 7, 56, 3, 85, DateTimeKind.Unspecified).AddTicks(9225), new DateTime(2021, 7, 1, 6, 41, 20, 450, DateTimeKind.Unspecified).AddTicks(4477) },
                    { 104, 1, "YT97765-0", 1, new DateTime(2021, 10, 2, 11, 24, 19, 398, DateTimeKind.Unspecified).AddTicks(8356), new DateTime(2021, 8, 11, 14, 46, 44, 753, DateTimeKind.Unspecified).AddTicks(4833) },
                    { 105, 4, "YT49961-1", 3, new DateTime(2021, 12, 5, 22, 4, 54, 81, DateTimeKind.Unspecified).AddTicks(7920), new DateTime(2021, 8, 27, 5, 6, 22, 33, DateTimeKind.Unspecified).AddTicks(1942) },
                    { 106, 4, "YT52237-1", 3, new DateTime(2021, 9, 30, 22, 48, 25, 966, DateTimeKind.Unspecified).AddTicks(3991), new DateTime(2021, 7, 20, 13, 49, 40, 587, DateTimeKind.Unspecified).AddTicks(7455) },
                    { 107, 1, "YT65812-0", 5, new DateTime(2021, 12, 11, 14, 27, 46, 899, DateTimeKind.Unspecified).AddTicks(7873), new DateTime(2021, 5, 10, 10, 33, 36, 921, DateTimeKind.Unspecified).AddTicks(3919) },
                    { 108, 1, "YT90484-0", 3, new DateTime(2021, 10, 20, 0, 9, 23, 996, DateTimeKind.Unspecified).AddTicks(4583), new DateTime(2021, 8, 2, 11, 45, 34, 638, DateTimeKind.Unspecified).AddTicks(5497) },
                    { 109, 2, "YT73027-1", 2, new DateTime(2021, 9, 23, 17, 6, 2, 147, DateTimeKind.Unspecified).AddTicks(9470), new DateTime(2021, 5, 17, 19, 22, 13, 365, DateTimeKind.Unspecified).AddTicks(7902) },
                    { 110, 1, "YT32332-0", 4, new DateTime(2021, 11, 18, 7, 28, 38, 971, DateTimeKind.Unspecified).AddTicks(2024), new DateTime(2021, 6, 24, 5, 32, 26, 186, DateTimeKind.Unspecified).AddTicks(5697) },
                    { 111, 2, "YT78706-1", 5, new DateTime(2021, 10, 3, 5, 17, 9, 900, DateTimeKind.Unspecified).AddTicks(8130), new DateTime(2021, 6, 28, 14, 26, 22, 850, DateTimeKind.Unspecified).AddTicks(3538) },
                    { 125, 4, "YT10422-0", 2, new DateTime(2021, 11, 29, 11, 3, 20, 199, DateTimeKind.Unspecified).AddTicks(1875), new DateTime(2021, 6, 30, 18, 33, 35, 23, DateTimeKind.Unspecified).AddTicks(182) },
                    { 112, 5, "YT28121-1", 1, new DateTime(2021, 11, 6, 17, 53, 51, 137, DateTimeKind.Unspecified).AddTicks(7378), new DateTime(2021, 6, 15, 6, 29, 3, 808, DateTimeKind.Unspecified).AddTicks(9792) },
                    { 114, 1, "YT75533-0", 5, new DateTime(2021, 9, 1, 7, 2, 54, 742, DateTimeKind.Unspecified).AddTicks(9251), new DateTime(2021, 5, 18, 18, 49, 58, 721, DateTimeKind.Unspecified).AddTicks(2035) },
                    { 115, 2, "YT58341-0", 3, new DateTime(2021, 9, 30, 16, 32, 17, 186, DateTimeKind.Unspecified).AddTicks(3285), new DateTime(2021, 6, 25, 7, 9, 17, 757, DateTimeKind.Unspecified).AddTicks(4641) },
                    { 116, 2, "YT58860-1", 4, new DateTime(2021, 10, 8, 20, 45, 20, 620, DateTimeKind.Unspecified).AddTicks(7370), new DateTime(2021, 6, 14, 13, 39, 39, 30, DateTimeKind.Unspecified).AddTicks(345) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 117, 2, "YT96902-1", 5, new DateTime(2021, 12, 10, 6, 52, 24, 862, DateTimeKind.Unspecified).AddTicks(926), new DateTime(2021, 8, 26, 4, 51, 34, 721, DateTimeKind.Unspecified).AddTicks(2494) },
                    { 118, 4, "YT46008-1", 4, new DateTime(2021, 9, 25, 5, 22, 35, 539, DateTimeKind.Unspecified).AddTicks(6423), new DateTime(2021, 8, 15, 7, 55, 29, 91, DateTimeKind.Unspecified).AddTicks(9809) },
                    { 119, 2, "YT91594-1", 2, new DateTime(2021, 9, 16, 6, 50, 14, 304, DateTimeKind.Unspecified).AddTicks(1204), new DateTime(2021, 6, 12, 19, 18, 29, 95, DateTimeKind.Unspecified).AddTicks(3510) },
                    { 120, 5, "YT81433-1", 4, new DateTime(2021, 10, 15, 22, 17, 41, 791, DateTimeKind.Unspecified).AddTicks(1668), new DateTime(2021, 7, 30, 19, 13, 49, 342, DateTimeKind.Unspecified).AddTicks(2515) },
                    { 121, 4, "YT77294-1", 3, new DateTime(2021, 12, 1, 0, 12, 48, 792, DateTimeKind.Unspecified).AddTicks(8129), new DateTime(2021, 6, 25, 2, 32, 30, 954, DateTimeKind.Unspecified).AddTicks(5533) },
                    { 122, 5, "YT77987-0", 3, new DateTime(2021, 11, 3, 13, 31, 33, 717, DateTimeKind.Unspecified).AddTicks(2774), new DateTime(2021, 6, 17, 13, 59, 33, 707, DateTimeKind.Unspecified).AddTicks(795) },
                    { 123, 1, "YT47626-0", 2, new DateTime(2021, 10, 13, 21, 59, 46, 960, DateTimeKind.Unspecified).AddTicks(9874), new DateTime(2021, 8, 5, 5, 39, 14, 583, DateTimeKind.Unspecified).AddTicks(9121) },
                    { 113, 2, "YT57534-1", 2, new DateTime(2021, 10, 19, 10, 46, 15, 28, DateTimeKind.Unspecified).AddTicks(829), new DateTime(2021, 5, 25, 16, 21, 56, 781, DateTimeKind.Unspecified).AddTicks(4857) },
                    { 150, 3, "YT65661-0", 4, new DateTime(2021, 12, 11, 1, 45, 13, 131, DateTimeKind.Unspecified).AddTicks(4411), new DateTime(2021, 7, 6, 19, 17, 50, 57, DateTimeKind.Unspecified).AddTicks(8238) },
                    { 174, 2, "YT87971-0", 5, new DateTime(2021, 9, 28, 20, 11, 21, 689, DateTimeKind.Unspecified).AddTicks(8118), new DateTime(2021, 8, 10, 12, 56, 41, 216, DateTimeKind.Unspecified).AddTicks(533) },
                    { 152, 4, "YT92991-1", 5, new DateTime(2021, 10, 27, 13, 35, 46, 830, DateTimeKind.Unspecified).AddTicks(8110), new DateTime(2021, 7, 10, 0, 31, 50, 43, DateTimeKind.Unspecified).AddTicks(9155) },
                    { 180, 5, "YT72579-1", 4, new DateTime(2021, 10, 24, 11, 50, 36, 522, DateTimeKind.Unspecified).AddTicks(5290), new DateTime(2021, 7, 22, 15, 41, 52, 959, DateTimeKind.Unspecified).AddTicks(4395) },
                    { 181, 2, "YT38564-0", 5, new DateTime(2021, 9, 9, 18, 17, 51, 89, DateTimeKind.Unspecified).AddTicks(1315), new DateTime(2021, 8, 21, 7, 17, 35, 948, DateTimeKind.Unspecified).AddTicks(9283) },
                    { 182, 5, "YT10868-0", 3, new DateTime(2021, 12, 19, 16, 21, 37, 61, DateTimeKind.Unspecified).AddTicks(3754), new DateTime(2021, 6, 9, 21, 5, 11, 160, DateTimeKind.Unspecified).AddTicks(454) },
                    { 183, 1, "YT65641-0", 4, new DateTime(2021, 10, 8, 16, 40, 57, 350, DateTimeKind.Unspecified).AddTicks(1941), new DateTime(2021, 7, 16, 12, 42, 52, 156, DateTimeKind.Unspecified).AddTicks(7799) },
                    { 184, 5, "YT68202-0", 4, new DateTime(2021, 11, 2, 5, 56, 13, 880, DateTimeKind.Unspecified).AddTicks(133), new DateTime(2021, 6, 3, 10, 34, 54, 396, DateTimeKind.Unspecified).AddTicks(2081) },
                    { 185, 5, "YT92054-1", 4, new DateTime(2021, 11, 19, 9, 22, 29, 440, DateTimeKind.Unspecified).AddTicks(2119), new DateTime(2021, 6, 8, 9, 6, 51, 650, DateTimeKind.Unspecified).AddTicks(9710) },
                    { 186, 5, "YT97713-0", 1, new DateTime(2021, 9, 23, 1, 56, 15, 276, DateTimeKind.Unspecified).AddTicks(5926), new DateTime(2021, 5, 20, 7, 50, 18, 565, DateTimeKind.Unspecified).AddTicks(3609) },
                    { 187, 3, "YT85412-0", 3, new DateTime(2021, 9, 9, 17, 46, 41, 63, DateTimeKind.Unspecified).AddTicks(8684), new DateTime(2021, 6, 15, 18, 47, 46, 835, DateTimeKind.Unspecified).AddTicks(7389) },
                    { 188, 4, "YT59533-1", 4, new DateTime(2021, 12, 28, 14, 22, 12, 670, DateTimeKind.Unspecified).AddTicks(4192), new DateTime(2021, 7, 20, 6, 38, 12, 222, DateTimeKind.Unspecified).AddTicks(4201) },
                    { 189, 2, "YT39187-1", 2, new DateTime(2021, 10, 4, 0, 12, 11, 330, DateTimeKind.Unspecified).AddTicks(2923), new DateTime(2021, 6, 10, 21, 38, 37, 253, DateTimeKind.Unspecified).AddTicks(2891) },
                    { 190, 3, "YT69081-0", 1, new DateTime(2021, 12, 27, 20, 53, 2, 366, DateTimeKind.Unspecified).AddTicks(2914), new DateTime(2021, 7, 1, 13, 6, 21, 495, DateTimeKind.Unspecified).AddTicks(5454) },
                    { 191, 5, "YT48471-0", 4, new DateTime(2021, 12, 19, 2, 7, 41, 898, DateTimeKind.Unspecified).AddTicks(6180), new DateTime(2021, 8, 25, 1, 40, 26, 943, DateTimeKind.Unspecified).AddTicks(8563) },
                    { 192, 3, "YT87694-1", 2, new DateTime(2021, 9, 27, 16, 53, 30, 895, DateTimeKind.Unspecified).AddTicks(8960), new DateTime(2021, 6, 14, 6, 6, 20, 985, DateTimeKind.Unspecified).AddTicks(8335) },
                    { 193, 4, "YT74499-0", 1, new DateTime(2021, 10, 26, 15, 30, 5, 158, DateTimeKind.Unspecified).AddTicks(78), new DateTime(2021, 6, 8, 1, 43, 23, 39, DateTimeKind.Unspecified).AddTicks(3004) },
                    { 194, 4, "YT88993-0", 2, new DateTime(2021, 11, 29, 11, 13, 27, 445, DateTimeKind.Unspecified).AddTicks(189), new DateTime(2021, 7, 21, 17, 26, 35, 131, DateTimeKind.Unspecified).AddTicks(405) },
                    { 195, 4, "YT46462-1", 1, new DateTime(2021, 11, 13, 20, 30, 8, 174, DateTimeKind.Unspecified).AddTicks(7905), new DateTime(2021, 5, 28, 11, 34, 21, 28, DateTimeKind.Unspecified).AddTicks(9261) },
                    { 196, 4, "YT11007-0", 5, new DateTime(2021, 10, 7, 12, 7, 55, 717, DateTimeKind.Unspecified).AddTicks(2952), new DateTime(2021, 5, 17, 14, 31, 56, 699, DateTimeKind.Unspecified).AddTicks(8406) },
                    { 197, 4, "YT40367-1", 5, new DateTime(2021, 12, 13, 6, 36, 4, 729, DateTimeKind.Unspecified).AddTicks(8909), new DateTime(2021, 8, 10, 11, 55, 5, 583, DateTimeKind.Unspecified).AddTicks(5119) },
                    { 198, 1, "YT68100-1", 2, new DateTime(2021, 9, 20, 6, 0, 46, 692, DateTimeKind.Unspecified).AddTicks(6556), new DateTime(2021, 7, 20, 23, 50, 38, 826, DateTimeKind.Unspecified).AddTicks(973) },
                    { 199, 4, "YT30248-1", 2, new DateTime(2021, 9, 30, 22, 57, 18, 149, DateTimeKind.Unspecified).AddTicks(3104), new DateTime(2021, 7, 14, 15, 19, 9, 270, DateTimeKind.Unspecified).AddTicks(6377) },
                    { 200, 5, "YT70279-1", 2, new DateTime(2021, 10, 11, 9, 42, 31, 862, DateTimeKind.Unspecified).AddTicks(549), new DateTime(2021, 6, 27, 13, 34, 16, 930, DateTimeKind.Unspecified).AddTicks(1520) },
                    { 179, 2, "YT72376-1", 3, new DateTime(2021, 12, 28, 23, 13, 48, 856, DateTimeKind.Unspecified).AddTicks(8722), new DateTime(2021, 6, 25, 12, 32, 41, 198, DateTimeKind.Unspecified).AddTicks(9992) },
                    { 178, 2, "YT79295-1", 3, new DateTime(2021, 9, 7, 5, 2, 9, 122, DateTimeKind.Unspecified).AddTicks(332), new DateTime(2021, 5, 17, 4, 36, 5, 626, DateTimeKind.Unspecified).AddTicks(1879) },
                    { 177, 3, "YT39324-1", 2, new DateTime(2021, 12, 9, 0, 6, 28, 712, DateTimeKind.Unspecified).AddTicks(7982), new DateTime(2021, 7, 14, 3, 0, 53, 398, DateTimeKind.Unspecified).AddTicks(6291) },
                    { 176, 5, "YT27728-0", 5, new DateTime(2021, 11, 18, 4, 36, 5, 336, DateTimeKind.Unspecified).AddTicks(5495), new DateTime(2021, 7, 5, 20, 19, 57, 882, DateTimeKind.Unspecified).AddTicks(9889) },
                    { 153, 5, "YT36495-1", 5, new DateTime(2021, 9, 1, 11, 0, 19, 308, DateTimeKind.Unspecified).AddTicks(5170), new DateTime(2021, 7, 23, 14, 52, 29, 913, DateTimeKind.Unspecified).AddTicks(6712) },
                    { 154, 4, "YT27168-0", 4, new DateTime(2021, 12, 1, 23, 46, 11, 588, DateTimeKind.Unspecified).AddTicks(1582), new DateTime(2021, 5, 25, 17, 39, 42, 776, DateTimeKind.Unspecified).AddTicks(4971) },
                    { 155, 2, "YT80925-1", 2, new DateTime(2021, 11, 8, 17, 12, 3, 973, DateTimeKind.Unspecified).AddTicks(5445), new DateTime(2021, 6, 2, 4, 45, 10, 652, DateTimeKind.Unspecified).AddTicks(9241) },
                    { 156, 1, "YT85610-0", 3, new DateTime(2021, 11, 12, 4, 49, 28, 116, DateTimeKind.Unspecified).AddTicks(218), new DateTime(2021, 7, 5, 15, 1, 28, 123, DateTimeKind.Unspecified).AddTicks(6269) },
                    { 157, 3, "YT77895-0", 4, new DateTime(2021, 9, 15, 23, 1, 21, 97, DateTimeKind.Unspecified).AddTicks(4596), new DateTime(2021, 8, 28, 8, 8, 23, 846, DateTimeKind.Unspecified).AddTicks(9421) },
                    { 158, 1, "YT60347-1", 1, new DateTime(2021, 11, 3, 17, 3, 43, 281, DateTimeKind.Unspecified).AddTicks(5105), new DateTime(2021, 7, 18, 12, 9, 28, 471, DateTimeKind.Unspecified).AddTicks(6503) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 159, 4, "YT83202-1", 3, new DateTime(2021, 9, 11, 1, 35, 59, 235, DateTimeKind.Unspecified).AddTicks(9942), new DateTime(2021, 6, 5, 19, 16, 24, 277, DateTimeKind.Unspecified).AddTicks(4401) },
                    { 160, 5, "YT29547-0", 4, new DateTime(2021, 11, 17, 20, 45, 8, 545, DateTimeKind.Unspecified).AddTicks(5259), new DateTime(2021, 8, 27, 17, 13, 58, 230, DateTimeKind.Unspecified).AddTicks(1366) },
                    { 161, 2, "YT90760-1", 4, new DateTime(2021, 10, 2, 22, 13, 48, 528, DateTimeKind.Unspecified).AddTicks(7827), new DateTime(2021, 8, 18, 11, 26, 54, 471, DateTimeKind.Unspecified).AddTicks(5412) },
                    { 162, 2, "YT94509-0", 3, new DateTime(2021, 11, 1, 15, 35, 24, 505, DateTimeKind.Unspecified).AddTicks(6622), new DateTime(2021, 5, 22, 9, 20, 16, 384, DateTimeKind.Unspecified).AddTicks(4459) },
                    { 151, 4, "YT25611-1", 3, new DateTime(2021, 9, 15, 19, 2, 22, 828, DateTimeKind.Unspecified).AddTicks(5739), new DateTime(2021, 6, 20, 1, 28, 26, 571, DateTimeKind.Unspecified).AddTicks(584) },
                    { 163, 3, "YT44994-1", 3, new DateTime(2021, 11, 14, 23, 2, 34, 392, DateTimeKind.Unspecified).AddTicks(5761), new DateTime(2021, 5, 25, 6, 14, 24, 172, DateTimeKind.Unspecified).AddTicks(3097) },
                    { 165, 3, "YT23545-0", 1, new DateTime(2021, 9, 6, 13, 6, 12, 823, DateTimeKind.Unspecified).AddTicks(7357), new DateTime(2021, 8, 25, 13, 44, 30, 626, DateTimeKind.Unspecified).AddTicks(7632) },
                    { 166, 5, "YT92924-1", 1, new DateTime(2021, 10, 13, 0, 35, 27, 291, DateTimeKind.Unspecified).AddTicks(1782), new DateTime(2021, 7, 27, 17, 50, 14, 460, DateTimeKind.Unspecified).AddTicks(4177) },
                    { 167, 4, "YT41965-0", 4, new DateTime(2021, 10, 31, 4, 28, 48, 162, DateTimeKind.Unspecified).AddTicks(7790), new DateTime(2021, 5, 24, 2, 9, 4, 357, DateTimeKind.Unspecified).AddTicks(8369) },
                    { 168, 5, "YT18178-1", 4, new DateTime(2021, 11, 19, 18, 9, 54, 358, DateTimeKind.Unspecified).AddTicks(9068), new DateTime(2021, 6, 4, 2, 15, 47, 129, DateTimeKind.Unspecified).AddTicks(6617) },
                    { 169, 1, "YT66089-1", 2, new DateTime(2021, 10, 2, 17, 44, 45, 20, DateTimeKind.Unspecified).AddTicks(7641), new DateTime(2021, 5, 15, 8, 36, 42, 689, DateTimeKind.Unspecified).AddTicks(4684) },
                    { 170, 2, "YT58093-0", 1, new DateTime(2021, 11, 21, 17, 24, 36, 372, DateTimeKind.Unspecified).AddTicks(387), new DateTime(2021, 6, 2, 23, 12, 55, 947, DateTimeKind.Unspecified).AddTicks(8452) },
                    { 171, 2, "YT30713-0", 1, new DateTime(2021, 9, 23, 21, 35, 52, 381, DateTimeKind.Unspecified).AddTicks(391), new DateTime(2021, 6, 12, 9, 8, 2, 693, DateTimeKind.Unspecified).AddTicks(9170) },
                    { 172, 1, "YT39178-0", 5, new DateTime(2021, 12, 27, 0, 4, 48, 149, DateTimeKind.Unspecified).AddTicks(306), new DateTime(2021, 5, 24, 0, 29, 35, 832, DateTimeKind.Unspecified).AddTicks(3722) },
                    { 173, 4, "YT97830-0", 3, new DateTime(2021, 12, 18, 6, 47, 46, 556, DateTimeKind.Unspecified).AddTicks(8630), new DateTime(2021, 7, 16, 20, 43, 35, 915, DateTimeKind.Unspecified).AddTicks(8533) },
                    { 175, 5, "YT75876-1", 5, new DateTime(2021, 10, 31, 21, 11, 11, 476, DateTimeKind.Unspecified).AddTicks(8601), new DateTime(2021, 6, 27, 6, 20, 21, 182, DateTimeKind.Unspecified).AddTicks(4032) },
                    { 164, 4, "YT77908-1", 1, new DateTime(2021, 10, 29, 2, 24, 42, 136, DateTimeKind.Unspecified).AddTicks(6172), new DateTime(2021, 7, 2, 2, 38, 59, 500, DateTimeKind.Unspecified).AddTicks(6656) },
                    { 101, 5, "YT49821-1", 2, new DateTime(2021, 10, 12, 16, 21, 52, 410, DateTimeKind.Unspecified).AddTicks(9200), new DateTime(2021, 6, 6, 1, 41, 27, 353, DateTimeKind.Unspecified).AddTicks(7077) }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 101, "5599 Myron Squares", null, "Quinnhaven", null, "U0J7T3", "YT" },
                    { 147, "0253 Ivy Island", null, "East Nathaniel", null, "K1E8Y5", "NU" },
                    { 177, "820 Rempel Path", null, "New Horacioville", null, "V6K8V5", "NB" },
                    { 146, "01745 Vandervort Square", null, "Gusthaven", null, "G0W5N2", "MB" },
                    { 145, "8183 Hackett Crossroad", null, "Lake Haskellville", null, "K7D3O5", "BC" },
                    { 178, "338 Gleason Path", null, "Port Osbaldoside", null, "Z1N1N8", "NT" },
                    { 144, "851 Aaron Forges", null, "Georgiannamouth", null, "D3C2A3", "ON" },
                    { 143, "1248 Waylon Inlet", null, "Khalidside", null, "Q8Q5R7", "PE" },
                    { 179, "944 Donald Estate", null, "New Katrinastad", null, "A8O7G4", "BC" },
                    { 142, "664 Mitchell Park", null, "Port Jarrell", null, "U7B4Z0", "MB" },
                    { 141, "7156 Mathew Pines", null, "Denesikport", null, "P3C8P7", "PE" },
                    { 180, "1279 Alyce Field", null, "East Emilport", null, "Y6P7N5", "QC" },
                    { 148, "445 Jameson Stravenue", null, "Watersborough", null, "Q8J6U6", "QC" },
                    { 140, "18706 Clarissa Court", null, "East Camden", null, "X4M3V6", "NB" },
                    { 181, "53586 Greenfelder Flats", null, "South Deron", null, "J5A9Y0", "ON" },
                    { 138, "47438 Jacobson Crossroad", null, "New Kellen", null, "B4R8I0", "NB" },
                    { 137, "06492 Mayer Port", null, "New Willy", null, "T8D2O2", "NL" },
                    { 182, "20724 Durgan Valleys", null, "Lake Cory", null, "D9K9V7", "NU" },
                    { 136, "300 Ismael Glen", null, "East Howard", null, "L7C4A4", "NU" },
                    { 135, "555 Murazik Pine", null, "North Nathanaelstad", null, "C5V8S1", "NL" },
                    { 183, "707 Friesen Stream", null, "Howardstad", null, "U4R0P7", "NU" },
                    { 133, "24975 Cletus Fork", null, "Victoriafurt", null, "L3I1S9", "AB" },
                    { 184, "435 Lavada Hollow", null, "South Lelahbury", null, "C1G2F4", "AB" },
                    { 132, "99530 Hulda Turnpike", null, "South Rolandoberg", null, "X7F2V2", "BC" },
                    { 131, "99101 Bartell Point", null, "Aarontown", null, "M4R4Q5", "NB" },
                    { 139, "710 Ryder Route", null, "Moenfurt", null, "Y7E5S1", "PE" },
                    { 176, "258 Kirlin Hill", null, "Hilarioview", null, "Z9W4M5", "BC" },
                    { 149, "4939 Simonis Motorway", null, "Jamarcuston", null, "E9A4N5", "YT" },
                    { 150, "369 Tillman Oval", null, "Lonnieside", null, "S4O5K8", "NB" },
                    { 166, "3119 Klocko Street", null, "South Yesenia", null, "F3X1P7", "YT" },
                    { 168, "592 Halvorson Club", null, "Lake Cheyannetown", null, "X2O6T3", "MB" },
                    { 165, "9724 Fritsch Neck", null, "Port Deannabury", null, "C1W6I6", "YT" },
                    { 164, "513 Amy Valley", null, "Lake Dejahhaven", null, "N7I9P3", "PE" },
                    { 169, "54731 Elta Lights", null, "Jasenshire", null, "E5H5Z6", "YT" },
                    { 163, "0455 Kiehn Plaza", null, "Vonview", null, "U9P6R5", "AB" },
                    { 162, "98196 Wintheiser Rapid", null, "Jimmyfort", null, "W9S6V7", "QC" },
                    { 170, "52573 Monserrat Cliffs", null, "Port Ashley", null, "R1S5F7", "NS" },
                    { 161, "4962 Mafalda Road", null, "Carloside", null, "F5L3N2", "NU" },
                    { 160, "2621 Emilio Junctions", null, "East Ramon", null, "J8P0H8", "NS" },
                    { 171, "220 Casper Knolls", null, "West Verlatown", null, "D5J0T2", "NU" },
                    { 159, "830 Jonatan Fords", null, "Langtown", null, "C8E6K3", "NT" },
                    { 158, "356 Alberto Springs", null, "Riceshire", null, "H6Y3W9", "AB" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 172, "78333 Zemlak Bridge", null, "Lake Norbertburgh", null, "A0L1I8", "MB" },
                    { 157, "68840 Judge Flats", null, "South Jodieview", null, "R6O5A2", "NT" },
                    { 156, "6292 Christophe Field", null, "Lake Kierabury", null, "T2Q3F8", "YT" },
                    { 173, "32902 Kihn Lake", null, "Port Edwardoburgh", null, "T7P3N8", "NL" },
                    { 155, "118 Lang Viaduct", null, "Lake Josephine", null, "A3I3E9", "NL" },
                    { 154, "3544 Estefania Dale", null, "South Garrett", null, "U6K6A0", "NT" },
                    { 174, "7415 Lockman Extension", null, "Sporerbury", null, "Q0I5P3", "NL" },
                    { 153, "76054 Jennyfer Spur", null, "Josefinastad", null, "U6T3J0", "MB" },
                    { 152, "047 Gisselle Radial", null, "Jedidiahstad", null, "F1I7K1", "NT" },
                    { 175, "8408 Bill Well", null, "East Sandramouth", null, "Z4R5X2", "PE" },
                    { 151, "46088 Kuhlman Motorway", null, "Port Leannbury", null, "C8Y2Q1", "PE" },
                    { 200, "49790 Vena Springs", null, "New Kendallview", null, "Z1K8O4", "MB" },
                    { 185, "1886 Cruz Heights", null, "Lake Alanistown", null, "S5W2H3", "NL" },
                    { 130, "269 Gerlach Road", null, "East Rahul", null, "E2B5F1", "NL" },
                    { 134, "171 Arnold Fall", null, "Maggieview", null, "V2M0N2", "BC" },
                    { 167, "05886 Mohammed Heights", null, "Port Marta", null, "X4W9C4", "NS" },
                    { 119, "5732 Prosacco Springs", null, "Port Olivermouth", null, "N8O3G4", "NU" },
                    { 106, "5096 Cydney Meadows", null, "West Tyra", null, "H3B8J4", "ON" },
                    { 191, "9721 Thompson Island", null, "Brekkeberg", null, "T3O4F9", "NT" },
                    { 118, "783 Brekke Place", null, "East Quintonport", null, "L2X5L4", "SK" },
                    { 197, "228 Royal Camp", null, "South Chaunceyville", null, "O3Y4B2", "QC" },
                    { 107, "259 VonRueden Prairie", null, "Ericmouth", null, "B6P1P4", "ON" },
                    { 117, "55176 Ara Dale", null, "Trantowstad", null, "T7U0F6", "BC" },
                    { 192, "7151 Roob Crescent", null, "Marisolfort", null, "I4O8S2", "MB" },
                    { 116, "6443 Borer Courts", null, "Wymanport", null, "R5V8F1", "QC" },
                    { 109, "535 Wilton Vista", null, "New Edwardburgh", null, "D7O3S7", "AB" },
                    { 129, "128 Madisyn Inlet", null, "Labadieburgh", null, "C0K8G5", "BC" },
                    { 193, "20552 Kennedi Underpass", null, "New Alannaview", null, "G5Q6T1", "PE" },
                    { 114, "38878 Lynch Stravenue", null, "Elnoraville", null, "E7Y6I7", "AB" },
                    { 108, "799 Brekke Ville", null, "Wintheiserstad", null, "Z0N9K4", "NL" },
                    { 113, "49849 Rohan Turnpike", null, "Julianmouth", null, "F7I8O1", "BC" },
                    { 194, "1890 Ortiz Lodge", null, "South Rigobertoberg", null, "X9U9M1", "ON" },
                    { 112, "6310 Claudine Fords", null, "Blockhaven", null, "Y9Q1M1", "NS" },
                    { 196, "58778 Lindgren Circles", null, "Lake Louvenia", null, "Q9P0O7", "AB" },
                    { 111, "36684 Hettinger Plain", null, "Haleyfurt", null, "E4Q2T7", "PE" },
                    { 195, "6340 Bernadette Trail", null, "Waelchiberg", null, "D2S7X4", "SK" },
                    { 115, "426 Doyle Harbor", null, "East Marlin", null, "Q3F5O1", "PE" },
                    { 190, "92801 Conroy Street", null, "Lake Ardithtown", null, "G5R7P8", "NL" },
                    { 120, "838 Augustus Mountain", null, "Port Romaland", null, "P6C7B1", "NB" },
                    { 125, "267 Augustine Plaza", null, "Annamaeburgh", null, "Y9A7C9", "ON" },
                    { 186, "113 Jeanne Mews", null, "South Kattie", null, "M6H3E7", "BC" },
                    { 128, "88963 Carroll Expressway", null, "Lake Alfonso", null, "E7Y9J4", "NL" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 102, "515 Tromp Park", null, "North Sim", null, "Y4S3K9", "NB" },
                    { 127, "62359 Kemmer Rue", null, "Efrenchester", null, "D1D4A9", "SK" },
                    { 187, "5455 Oberbrunner Roads", null, "Jacobimouth", null, "Z9W1K1", "MB" },
                    { 126, "1060 Amani Wells", null, "Port Precious", null, "Q4P1A2", "AB" },
                    { 199, "18076 Ferry Road", null, "Juddmouth", null, "U9D8D7", "SK" },
                    { 103, "273 Stark Course", null, "East Caleb", null, "S0P0P7", "SK" },
                    { 121, "040 Kamron Flat", null, "Kreigerstad", null, "O3Z0W3", "ON" },
                    { 110, "353 White Road", null, "West Joanneberg", null, "G1B9A4", "AB" },
                    { 189, "51992 Beahan Ville", null, "Dejastad", null, "W1L0Y3", "NS" },
                    { 105, "8432 Clemmie Cove", null, "Reichertside", null, "A8W3L2", "PE" },
                    { 124, "04226 Stoltenberg Throughway", null, "Port Maude", null, "K0C7M5", "NB" },
                    { 104, "9290 Corwin Prairie", null, "Lake Jakaylaborough", null, "Q3C8T2", "NL" },
                    { 123, "62273 Kovacek Lakes", null, "Parismouth", null, "W1J9E2", "NB" },
                    { 188, "314 Amani Lodge", null, "Katlynborough", null, "I3D1W8", "AB" },
                    { 122, "13284 DuBuque Underpass", null, "Port Halieton", null, "G6R1E0", "NT" },
                    { 198, "72203 Nitzsche Parks", null, "New Melisaberg", null, "Q3U8M7", "AB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 170, "126 Abagail Glens", null, "Koelpintown", null, "T1Q2D8", "AB" },
                    { 172, "340 Harris Isle", null, "East Rosaleeview", null, "A5S1K1", "QC" },
                    { 199, "435 Sasha Vista", null, "West Weldonside", null, "W5O4Z3", "NL" },
                    { 198, "0060 Angelica Coves", null, "Hansenmouth", null, "C7B7Q6", "AB" },
                    { 196, "9211 Rae Fork", null, "Lakinberg", null, "Q7G2H9", "NU" },
                    { 168, "1118 Dooley Extensions", null, "Schuppechester", null, "T7A6E4", "SK" },
                    { 171, "7687 Ronaldo Falls", null, "McClurestad", null, "T4X0J0", "NU" },
                    { 169, "96029 Jenifer Camp", null, "East Vernonshire", null, "D1K9S5", "AB" },
                    { 197, "8713 Beatty Ville", null, "Rebaberg", null, "U6S3K7", "MB" },
                    { 192, "71275 Gislason Center", null, "Port Blake", null, "O8R2R1", "MB" },
                    { 173, "4038 Hilda Junction", null, "New Richmond", null, "H2R1J2", "AB" },
                    { 186, "313 Adrain Expressway", null, "Alejandrinstad", null, "E9E9R7", "YT" },
                    { 184, "477 Manley Centers", null, "East Frederikfurt", null, "L0G6Y7", "ON" },
                    { 183, "437 Rodriguez Turnpike", null, "Lake Allison", null, "K6D6B7", "YT" },
                    { 167, "281 D'Amore Brooks", null, "Flatleybury", null, "M6G1F9", "ON" },
                    { 187, "24140 Rusty Oval", null, "Reannafort", null, "Q8W1O3", "BC" },
                    { 182, "9912 Samir Island", null, "West Yvetteberg", null, "I8P2B8", "NB" },
                    { 188, "4524 Schmidt Corners", null, "Aldenchester", null, "D0I2Z2", "AB" },
                    { 181, "38250 Hyatt Ports", null, "Ellismouth", null, "N3R0D1", "NU" },
                    { 180, "31286 Predovic Forge", null, "Vandervortview", null, "A7C5V9", "QC" },
                    { 195, "1285 Kutch Mountain", null, "Roobmouth", null, "V3K6H1", "YT" },
                    { 189, "6824 Tanner Course", null, "West Anabel", null, "K3Z6N4", "YT" },
                    { 190, "79066 Considine Rue", null, "West Krystinahaven", null, "R7T6K1", "QC" },
                    { 178, "0557 Marquardt Court", null, "Mannport", null, "G3U0O5", "NS" },
                    { 191, "69281 Sylvan Causeway", null, "Lake Quinten", null, "E1L3D1", "BC" },
                    { 177, "12027 Corwin Freeway", null, "Giuseppehaven", null, "S4L5A8", "AB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 176, "377 Koelpin Bridge", null, "West Emiliaberg", null, "W4V8J4", "NS" },
                    { 175, "743 Aracely Plains", null, "Cummingsfurt", null, "J3X6T9", "NB" },
                    { 193, "576 Little Radial", null, "Katrineborough", null, "M2N9T8", "NL" },
                    { 174, "6946 Prosacco Pine", null, "Bettytown", null, "N8R3E3", "MB" },
                    { 194, "28465 Nina Parkways", null, "Gilbertview", null, "Q9C8J9", "BC" },
                    { 179, "594 Julianne Walks", null, "Port Gusttown", null, "W4N0G3", "MB" },
                    { 185, "851 Nader Extensions", null, "New Lenora", null, "Q8X2J4", "BC" },
                    { 150, "37436 Sanford Shoal", null, "Tyresehaven", null, "T2Y8J5", "AB" },
                    { 165, "0005 Dock Wall", null, "South Kyleeberg", null, "X9N6J7", "SK" },
                    { 129, "17805 McClure Motorway", null, "Larkinstad", null, "L3T8L8", "ON" },
                    { 128, "2627 Malinda Extension", null, "South Barneyland", null, "U9W8B0", "QC" },
                    { 127, "25269 Lysanne Circle", null, "Emiliaton", null, "S6X9K5", "BC" },
                    { 126, "3651 Damon Extensions", null, "Port Alana", null, "F8L0H0", "ON" },
                    { 125, "760 D'Amore Viaduct", null, "Whitneyshire", null, "X1J8P0", "QC" },
                    { 124, "185 Daryl Glens", null, "New Stefanchester", null, "Y7U9K0", "ON" },
                    { 123, "7624 Gleason Court", null, "Considinefort", null, "O1I4Q0", "PE" },
                    { 122, "457 Lauryn Lodge", null, "Kovacekmouth", null, "F3T3X5", "BC" },
                    { 121, "0030 Jadon Station", null, "Lake Electa", null, "C8J9O2", "NL" },
                    { 120, "34801 Howell Trail", null, "Friesenberg", null, "D4T5U3", "NU" },
                    { 119, "365 Lorena Expressway", null, "Lake Alejandrinmouth", null, "A9U1C9", "NS" },
                    { 118, "2066 Kara Streets", null, "New Vickieland", null, "P4O0J3", "NB" },
                    { 117, "099 Bogisich Flat", null, "Port Era", null, "G7G0N0", "ON" },
                    { 116, "629 Bradtke Pines", null, "West Leonard", null, "P1B6L6", "MB" },
                    { 115, "130 Carissa Courts", null, "West Dejahton", null, "Y0C1U0", "BC" },
                    { 114, "4223 Swaniawski Terrace", null, "South Barryberg", null, "J9A0A7", "PE" },
                    { 113, "481 Aufderhar Falls", null, "East Brain", null, "P3S1V2", "ON" },
                    { 112, "435 Rosalee Gateway", null, "Schummchester", null, "F9E2T9", "SK" },
                    { 111, "1900 Arianna Island", null, "East Napoleonton", null, "A0Y6A9", "NL" },
                    { 110, "259 Tyrell Corner", null, "Kleinstad", null, "W5Z7C6", "AB" },
                    { 109, "78199 Torphy Cove", null, "Malloryborough", null, "R3P2Q2", "NU" },
                    { 108, "32216 Cyril Drives", null, "Haliechester", null, "B6S6I9", "PE" },
                    { 107, "2258 Leuschke Glen", null, "Dinafort", null, "D3U1N6", "SK" },
                    { 106, "93478 Rusty Glen", null, "New Audieton", null, "L8W3N3", "MB" },
                    { 105, "202 Denesik Meadows", null, "Haneborough", null, "C5H0J3", "NB" },
                    { 104, "466 Jonas Brooks", null, "Malliebury", null, "I1I8N2", "SK" },
                    { 103, "38681 Melyssa Meadows", null, "Lake Eudoramouth", null, "Y7S8R9", "NL" },
                    { 102, "063 Megane Falls", null, "Littlechester", null, "H0U4Y9", "ON" },
                    { 101, "46251 Braeden Spur", null, "Port Lyla", null, "X9G2N9", "NL" },
                    { 130, "4223 Makenna Mountain", null, "Romagueratown", null, "J9L5U1", "QC" },
                    { 131, "0943 Cormier Dam", null, "South Clementine", null, "K1M2Q3", "YT" },
                    { 132, "38962 McKenzie Lodge", null, "Wintheiserfort", null, "R3K7F3", "SK" },
                    { 133, "9566 Reagan Springs", null, "Shawnafurt", null, "E7C1V3", "PE" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 164, "235 Claire Ways", null, "Boyerton", null, "E9I8M3", "ON" },
                    { 163, "844 Felicia Oval", null, "New Angelicaborough", null, "G2S4P2", "NB" },
                    { 162, "6427 Zemlak Center", null, "Port Jalenmouth", null, "Z3M1P4", "PE" },
                    { 161, "7912 Noel Flat", null, "Gradystad", null, "L2J5T6", "YT" },
                    { 160, "48153 Frieda Ports", null, "North Johannafurt", null, "L9C8Q1", "QC" },
                    { 159, "513 Asha Groves", null, "Lake Theodoreside", null, "O8O6L0", "NS" },
                    { 158, "2944 Willms Rapids", null, "New Joelfurt", null, "I8B1V3", "YT" },
                    { 157, "69987 Johnson Spur", null, "West Ryderstad", null, "A0R4F2", "NU" },
                    { 156, "7722 Kling Harbor", null, "Hiltonfort", null, "E8P4V8", "SK" },
                    { 155, "5716 Lesch Way", null, "North Salvatorefurt", null, "T0I4T3", "MB" },
                    { 154, "086 Otha Ridges", null, "Macejkovicland", null, "E7I3A4", "NS" },
                    { 153, "80129 Buddy Orchard", null, "Hoegerbury", null, "E9Q3G3", "ON" },
                    { 152, "6244 Jasmin Burg", null, "Amiehaven", null, "W2S9K6", "BC" },
                    { 151, "00722 Quitzon Islands", null, "Lake Roselynchester", null, "W5P4P3", "PE" },
                    { 166, "31884 Ella Plains", null, "Hyattmouth", null, "D1A8V3", "NL" },
                    { 149, "91697 Flossie Curve", null, "Port Kaylabury", null, "U4W2T0", "MB" },
                    { 147, "138 Lynch Mill", null, "Kovacekton", null, "Q5O4V4", "NU" },
                    { 146, "900 Joan Rue", null, "Lake Juston", null, "W0H8V5", "AB" },
                    { 145, "2758 Maggie Trail", null, "Francesland", null, "N7O0N0", "NB" },
                    { 144, "001 Harris Circles", null, "Sauerstad", null, "F6C5M2", "NL" },
                    { 143, "886 Laury Underpass", null, "Wittingville", null, "K5M6G5", "BC" },
                    { 142, "650 Nicolas Underpass", null, "Rohanfurt", null, "D0D2F9", "PE" },
                    { 141, "095 Morissette Centers", null, "Naomieport", null, "X3M4Z2", "NB" },
                    { 140, "4443 O'Hara Stream", null, "North Kali", null, "A4X3M6", "QC" },
                    { 139, "308 Vandervort Fall", null, "South Loganchester", null, "A3P8R8", "MB" },
                    { 138, "04255 O'Hara Dam", null, "Lake Olen", null, "Y7Z3K4", "QC" },
                    { 137, "236 Streich Spring", null, "East Daniela", null, "W5F4X7", "MB" },
                    { 136, "1554 Lazaro Union", null, "North Alexannetown", null, "C1T3W4", "PE" },
                    { 135, "11625 Toni Islands", null, "New Geo", null, "A5G7F2", "NB" },
                    { 134, "54624 Eriberto Fields", null, "Lake Nicolaton", null, "S4A1V5", "NB" },
                    { 148, "138 Milo Square", null, "New Javonte", null, "B7Z0P7", "YT" },
                    { 200, "29071 Gaylord Ramp", null, "Noeside", null, "S1V2Q2", "AB" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 1,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5766 Lorine Extension", "North Amiyaville", "U4I6Z4", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 2,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "245 Schamberger Stravenue", "New Abelardo", "Y9G5P1", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 3,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "814 Jena Junctions", "West Garry", "J1B1D4", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 4,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "12900 Willms Brooks", "East Jamilburgh", "F8F1L4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 5,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2338 Mose Court", "Sengerfort", "Z2H8T1", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 6,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2901 Cruickshank Grove", "East Ryleyshire", "Y5S4F9", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 7,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "236 Dare Brooks", "South Stevie", "L0E0G4", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 8,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1518 Beth Forest", "Port Jaidamouth", "P8F4S5", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 9,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "52149 Gutkowski Spurs", "Sabrynaberg", "H7S8P4" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 10,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "890 Devyn Rest", "New Rachel", "J6I0N9", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 11,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8501 Jerde Ridges", "New Petra", "J8G0G5", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 12,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6817 Mertz Fords", "Lenoreside", "G8N9O1", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 13,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6464 Murray Ports", "Port Axel", "B4W2K0", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 14,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "553 Reilly Springs", "South Emmett", "W7W0B9", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 15,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "37849 Schumm Alley", "Robelbury", "D8V4I8", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 16,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "11603 Domenica Cape", "Bauchview", "I1D8S4", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 17,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "617 Lexie Mountains", "Wellingtonhaven", "R2A8F6", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 18,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "018 Barton Run", "South Cristal", "T9T8U9", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 19,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3815 Jones Wells", "West Christopher", "K8M1W2", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 20,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "37572 Hermina Roads", "Pacochafort", "B9U9I8", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 21,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "41571 Lakin Stravenue", "Lake Salvatore", "X7W0A1" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 22,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "757 Stephon Place", "Kubland", "U0I6P5", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 23,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "59081 Brooke Square", "Destiniton", "X2O1B7", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 24,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "30708 Hodkiewicz River", "East Colton", "K7Y1Z5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 25,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5436 Hegmann Field", "Janetland", "W6M3U4", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 26,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8308 Adriel Vista", "East Elnora", "F4T3F5", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 27,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "53153 Pacocha Curve", "Tannerview", "S4A8N9", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 28,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "420 McCullough Well", "Dooleyland", "H7Q3O8", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 29,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7247 Pollich Spurs", "New Maymieview", "W2C2O3", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 30,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "322 Elenora Falls", "Modestoport", "X1V0I7", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 31,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "042 Kayla Skyway", "Ebertview", "Q3T2F3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 32,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "08972 Hope Mill", "Grimeston", "Y3F7A1", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 33,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "07611 Welch Pass", "Marilyneside", "V0I6I2", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 34,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "416 Brice Manors", "West Carrollshire", "C4Z4O8", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 35,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "60360 Seamus Pass", "Zboncakmouth", "S3D8T4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 36,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "964 Lea Spurs", "Bogisichfort", "U8V0P9", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 37,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6136 Aylin Mill", "Justinachester", "C6B7P1", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 38,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "55122 Wintheiser Ports", "Lelandfurt", "F1G0A3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 39,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9187 Esteban Club", "Predovicton", "X0V1O7", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 40,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "998 Ryan Court", "Bartolettishire", "Z7F6C6", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 41,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "425 Kerluke Ridges", "Generalmouth", "K9R3L4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 42,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0177 Hillary Creek", "Maymieburgh", "H9E8R9", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 43,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "25016 Marquardt Passage", "Reillyfurt", "U5M2W7" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 44,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "83348 Ortiz Road", "North Adrienbury", "D1B7F5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 45,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "00274 Randall Summit", "Ziemeside", "W3H8T8", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 46,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7296 Guadalupe Streets", "South Jonathan", "F7F7W8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 47,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "31004 Monte Knoll", "Sporerville", "I3J7T9", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 48,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "033 Lester Islands", "Kathrynfurt", "L9A5D8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 49,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "48525 Moore Divide", "Port German", "Z8S9G4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 50,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5714 Schmeler Junction", "Port Omerville", "V6G5R5", "NT" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Placeat aut asperiores vel dolorem modi facilis unde minima.", 63, 1544m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia voluptates tempora et cumque eligendi magni.", 57, 1481m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et nemo fuga amet veniam cum qui non facilis aperiam.", 38, 16097m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et ut voluptates quos similique tenetur voluptas.", 31, 9933m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quasi optio cum ex nihil fugit magnam id laboriosam et.", 61, 1868m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et qui odit expedita labore eos sit ut ipsum et.", 97, 1556m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Enim rerum dolore quibusdam distinctio eum ut cum vel.", 96, 9142m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Consequatur fugit rerum tempore sapiente laudantium ex dolore est quibusdam.", 43, 14855m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut voluptatibus nostrum ipsam non est non unde.", 17, 16170m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Est velit fugit dolor aut voluptas.", 20, 7242m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolorem blanditiis accusantium.", 6, 4689m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Totam itaque aperiam voluptatum quo rerum.", 60, 12940m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Iusto et similique.", 46, 17837m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Debitis aut qui labore sequi cupiditate nostrum.", 63, 9874m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Facere praesentium omnis.", 69, 8587m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut commodi aperiam omnis recusandae.", 20, 2273m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quas dolor assumenda quos eveniet exercitationem quia.", 96, 13930m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "In libero fuga totam.", 5, 6462m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Fugiat qui ea voluptatem excepturi.", 31, 1435m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sunt labore molestias sed consectetur sit.", 47, 5272m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur assumenda qui reprehenderit repellendus commodi eos totam temporibus.", 12, 1000m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Illo commodi totam iure tempora rerum reprehenderit quo.", 91, 9101m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et eos inventore velit culpa aperiam provident.", 68, 479m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Impedit labore quo magnam ducimus recusandae consequuntur nemo.", 97, 9024m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Labore nesciunt odio ut.", 49, 6315m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Impedit sit minus quidem culpa beatae nam facilis aspernatur.", 66, 13740m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Omnis officia consequatur cupiditate dolor omnis aspernatur exercitationem.", 24, 3406m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Explicabo illo rerum ea voluptatem consequatur eveniet provident molestias occaecati.", 5, 16210m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ipsa minima sapiente sint est blanditiis rerum eum nemo.", 96, 14912m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nesciunt totam in labore sed sunt.", 29, 11837m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et ipsum ipsa quasi velit ipsum id fugit.", 90, 5864m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et quam quia tempore suscipit distinctio ducimus quae.", 35, 3735m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Fugit voluptas quasi numquam qui repellat.", 11, 5499m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ipsam aut sunt sapiente nulla quam nesciunt enim dolorem.", 79, 13589m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quia dolorum ut id molestiae ab eligendi sit repellendus illo.", 8, 17882m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Accusantium vero excepturi eos commodi ea modi dicta atque sed.", 9, 15356m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolores inventore impedit exercitationem laudantium autem eaque quaerat.", 15, 13555m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Occaecati quasi et laboriosam corrupti.", 83, 7548m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Alias error eveniet sed facere in distinctio sunt.", 6, 12287m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Suscipit repellendus quia sint doloribus mollitia fugiat et numquam.", 57, 1221m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestiae rem cumque placeat voluptates iure.", 74, 8311m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quis vero sit qui sed dolorem ut sapiente ut.", 29, 9258m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempora ad id repellendus.", 97, 10043m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut et voluptates vel ratione ipsum quam et illo facilis.", 74, 13512m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Soluta saepe et est dolor earum officiis consectetur voluptas.", 12, 12057m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Tempora error accusamus hic eos dolor non fuga temporibus quia.", 84, 15775m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Amet dignissimos atque praesentium aut odit est quis.", 6, 7253m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quasi omnis laudantium inventore quod impedit.", 81, 16544m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aperiam ut inventore odit molestias illum commodi aut autem unde.", 20, 13091m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Vel dolorum consectetur molestias autem aut nihil aspernatur.", 66, 11047m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia tempore natus.", 61, 7622m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ab et eos perspiciatis autem rerum maiores debitis.", 27, 8323m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eveniet quia necessitatibus.", 8, 5951m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quas explicabo pariatur sunt.", 71, 5752m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Totam officia incidunt sapiente voluptas.", 97, 2376m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Iusto modi dolores reprehenderit reprehenderit quia eaque tempora laudantium.", 74, 13401m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Id perspiciatis ea aut blanditiis quas a veniam necessitatibus.", 68, 2854m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Magni dicta natus.", 21, 6684m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Consequatur nihil praesentium voluptas magnam omnis labore voluptatem consectetur minus.", 36, 1070m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ipsam molestias dolores ut sequi sit asperiores et.", 96, 14290m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut placeat omnis voluptas quidem est.", 56, 3521m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit quae similique tenetur esse.", 72, 12458m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolore dolorem praesentium nemo voluptatem.", 47, 11645m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Nostrum nam eos non odio a est.", 5, 15597m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Illum et nihil odit voluptas ipsa dolorem sunt iure.", 1, 4864m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ipsam sit et odit et et aut architecto sapiente provident.", 52, 3678m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatibus quae accusamus commodi deleniti aut eius id repudiandae illum.", 66, 6687m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Atque eos ut.", 71, 10352m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et assumenda a maxime minima ipsum molestiae.", 37, 8109m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit enim quidem eum repudiandae aspernatur.", 29, 8276m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem voluptas repudiandae quae quia aut asperiores.", 82, 16351m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Deserunt occaecati ut itaque iusto doloribus velit aut.", 83, 5391m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Modi delectus id perspiciatis.", 28, 5886m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut ut commodi quia.", 54, 12008m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Deserunt quisquam est.", 65, 870m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quo officiis distinctio suscipit eligendi sit et debitis aut quae.", 90, 7807m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Pariatur molestiae porro commodi.", 39, 11470m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quisquam qui incidunt magni atque.", 96, 3577m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Placeat ea fugit eum fugit.", 25, 17652m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui ad fugit labore occaecati.", 15, 16763m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Libero quia at iure et et temporibus.", 93, 18705m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Necessitatibus culpa animi autem minus animi.", 28, 12018m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Libero magni ducimus laboriosam asperiores est facilis error a tempore.", 43, 15976m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Numquam officiis explicabo commodi vero in voluptate impedit.", 64, 7711m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Perferendis perspiciatis et.", 44, 6256m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ipsum et autem voluptas maxime.", 76, 7161m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quia et consequatur iure qui iure voluptates quia ipsam voluptatem.", 81, 8381m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut omnis esse officiis corrupti eaque asperiores commodi totam quae.", 4, 19370m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestiae hic exercitationem animi.", 10, 9216m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Esse ea in sed molestiae voluptas aut aut odio.", 81, 8933m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Id saepe sit debitis ut nisi omnis dicta accusamus explicabo.", 47, 1935m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Saepe qui dignissimos molestiae.", 9, 11960m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Odio et recusandae accusamus eos deserunt voluptates velit vero.", 71, 1274m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Natus veniam inventore sit sed nemo voluptatem.", 35, 1794m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ab omnis aut ut molestiae cupiditate quaerat.", 92, 6232m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Modi minima amet nobis reiciendis ea architecto dolores et temporibus.", 55, 17703m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sit pariatur ut aliquam deserunt ut ipsam.", 54, 10820m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolorem ducimus delectus dolorem est debitis neque odit.", 34, 5162m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "Quantity", "State", "Unit" },
                values: new object[] { "Ut in molestiae quaerat officiis labore molestiae corporis reiciendis molestiae.", 9242m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et id eaque sequi sunt assumenda voluptates ab et fuga.", 38, 4750m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Non excepturi labore quis quia.", 29, 11369m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Praesentium sit amet cupiditate quas.", 7, 1482m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Occaecati vitae sit voluptatem.", 36, 3930m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quidem rem ab minima eligendi porro hic at.", 36, 7340m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Omnis eos harum iusto quisquam cupiditate.", 25, 2995m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolorem voluptas consequuntur voluptas.", 97, 4299m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Facilis quidem qui.", 50, 8162m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eius fuga sunt necessitatibus soluta et voluptatem.", 76, 6438m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quia vitae reprehenderit assumenda repudiandae qui molestiae officia dolorum.", 53, 12777m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur consequuntur ipsa modi eum tempora.", 34, 14389m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolore qui cumque aut.", 34, 132m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Asperiores error dolore ab quos animi.", 94, 11389m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ipsa placeat veniam aliquam adipisci.", 38, 5612m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Non facere assumenda.", 31, 12719m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et illum earum sed placeat voluptate dolore debitis doloribus.", 66, 14598m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Placeat enim sunt et eos dignissimos est est.", 92, 13092m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vel voluptatum esse dolorem nostrum nisi.", 77, 8685m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Repellat officiis aut voluptatem nostrum odio mollitia possimus id.", 51, 17229m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ducimus dolor quia necessitatibus.", 30, 3217m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iusto ea in et corrupti enim et aliquid voluptatibus eos.", 99, 4952m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iusto numquam ea sequi cum.", 98, 12092m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Nulla natus quaerat molestiae id nihil omnis provident.", 92, 18674m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odit dignissimos sed excepturi sit rerum ullam.", 35, 13383m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Rerum fuga eos autem suscipit fuga.", 25, 8565m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut et vel iusto optio delectus illo vero autem.", 26, 14389m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Explicabo temporibus suscipit similique.", 22, 19761m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Distinctio et esse quod mollitia hic corrupti aut quis totam.", 59, 13869m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Id cumque ea corrupti.", 27, 10074m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et et fugiat explicabo dolores quaerat.", 43, 5052m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quidem veniam tempora blanditiis voluptates necessitatibus impedit qui.", 41, 15751m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolores delectus quis maiores.", 24, 14458m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Maiores dicta ex fugit reprehenderit officiis.", 16, 562m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et error voluptatem voluptatum rerum culpa laborum accusantium.", 42, 17413m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nobis sapiente ipsum aut ut illum omnis impedit.", 30, 6450m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Autem dolores quo.", 87, 7313m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Tempora similique est consequatur eaque qui voluptatem numquam cupiditate.", 85, 16997m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et nihil illo rerum laboriosam facere.", 37, 18575m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptas temporibus fugit consectetur quas.", 14, 160m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui cupiditate neque tempora cum quis.", 36, 9938m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Corrupti ea et magni enim.", 36, 12549m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia fuga voluptatum adipisci aliquid ratione accusantium voluptatem.", 71, 16838m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eaque sit saepe porro nam laudantium et et consequatur exercitationem.", 43, 793m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Adipisci vel doloremque.", 83, 15746m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nobis aperiam quia eos rem omnis excepturi impedit deserunt placeat.", 96, 7722m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eos necessitatibus quas dolorem velit voluptas iusto voluptas molestiae aspernatur.", 47, 19342m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quibusdam ratione pariatur veniam quia nobis laboriosam quia a accusantium.", 45, 9872m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem odit omnis.", 90, 9420m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Doloribus sunt magnam.", 5, 3826m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ab porro cum tenetur labore dolor libero non modi occaecati.", 81, 11274m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Doloribus labore rerum architecto eos ab doloribus illum.", 15, 337m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "A quos rerum veniam blanditiis architecto dignissimos accusamus.", 81, 15407m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Error dolore et suscipit saepe sed.", 27, 5721m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ut facilis ut veritatis eveniet distinctio officia.", 96, 1873m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sunt veniam sunt est voluptatem et eius qui.", 42, 1639m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolorem soluta rem earum sunt debitis eligendi ut.", 81, 8664m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut aut veritatis impedit non atque.", 8, 6214m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatum voluptatem delectus ipsa consequatur et quod tempora quam.", 98, 6350m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Placeat beatae natus consectetur.", 29, 2818m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Saepe odit cupiditate quis cumque recusandae ipsum tempora sunt et.", 55, 13346m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia alias similique qui facere veritatis labore magni.", 78, 18843m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptas itaque vitae occaecati sint qui architecto recusandae nulla.", 30, 1135m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Rerum aliquid qui.", 17, 13624m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eos in optio.", 66, 16055m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Vel et non nihil ut sequi perspiciatis.", 41, 2907m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit rerum non nostrum molestias aut animi dolor.", 59, 9791m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nemo quibusdam nobis dolorem sed quia quam a voluptatem.", 77, 4852m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Atque aut nemo magni.", 20, 15802m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Officiis ea exercitationem nulla.", 10, 1094m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Veniam culpa deserunt ex eos.", 9, 6417m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et nihil voluptate non soluta repellendus fugit aut sit.", 92, 14914m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est consequatur quam qui voluptatum commodi voluptas.", 79, 3382m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Mollitia magni rerum maiores.", 91, 13997m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Corrupti totam debitis laborum inventore earum eius.", 55, 18204m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut placeat ab ut laborum laborum inventore asperiores eveniet in.", 45, 12459m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Doloremque adipisci quae dicta aut numquam alias quia nisi ut.", 43, 4125m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Fugit ut aut nemo dolorum.", 9, 7613m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Pariatur dignissimos quisquam.", 83, 1780m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "A consectetur quo ratione praesentium ea quisquam ut et.", 41, 14131m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ducimus rerum veniam iure itaque magni similique id.", 96, 2663m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Assumenda minima doloremque et.", 55, 14260m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Perspiciatis ut est facere officia.", 19, 13027m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eveniet numquam asperiores vitae aut blanditiis saepe ipsa.", 6, 6018m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Laudantium velit hic est.", 65, 11924m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolorem explicabo explicabo enim laborum sit ut sint.", 39, 17024m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Earum omnis velit.", 83, 4510m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Fugit exercitationem earum repellendus.", 65, 6180m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatibus beatae nemo magnam.", 99, 984m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Impedit et eum et fugit eius repudiandae consequatur aliquam.", 38, 3437m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum ea illo quibusdam sequi non corporis harum ut.", 97, 19129m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nulla saepe debitis numquam minus sed fugit corrupti eos laborum.", 88, 3652m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Totam rem repellendus illum magnam.", 100, 18493m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Delectus sed beatae animi molestiae aut voluptatem voluptates rerum.", 30, 10472m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sapiente quo eveniet ut odio et et expedita.", 44, 7302m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui illo ipsa repellat eveniet est eum voluptas nam aperiam.", 81, 17754m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Molestiae esse recusandae quia adipisci ratione vero ut accusantium.", 49, 6140m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia quod dolorem earum eveniet.", 91, 172m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Occaecati saepe officiis ullam cum aut.", 59, 2124m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Hic in quaerat nostrum omnis quis sint perferendis.", 29, 13824m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quos nostrum quisquam quos voluptates voluptatem.", 90, 19109m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ullam ad iste eos sit sed et ut.", 23, 15631m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Est dolores quisquam nisi necessitatibus fugiat quia ut voluptates velit.", 29, 16188m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Error nam impedit inventore molestiae id doloribus corrupti.", 100, 14635m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eum sed rerum ut hic consequatur.", 31, 16914m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Illo ut quam reprehenderit.", 48, 17210m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit laboriosam sed et dolorem esse corporis.", 99, 13123m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nisi cumque pariatur impedit non perspiciatis iusto voluptatum voluptas hic.", 58, 5222m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Amet animi et maiores dolor voluptatem ut.", 9, 4448m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Provident molestias consectetur.", 93, 2549m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Est similique nobis sit sed eaque magnam qui.", 7, 4916m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quo fugit illo sit.", 64, 79m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut fuga excepturi odio ut ut.", 95, 11546m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nostrum non dolorum sint ullam.", 2, 15626m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sapiente perferendis est itaque optio reprehenderit dolores aut nemo velit.", 17, 12148m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Illum omnis dolores.", 43, 5669m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Tenetur officiis et dolores eos quisquam modi autem dolorum commodi.", 61, 10068m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quia in dignissimos quo rerum quo qui.", 86, 398m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit alias qui quo iste fugiat.", 7, 1445m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Asperiores iure dicta eaque maiores voluptates nam sint qui accusantium.", 71, 5204m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quos incidunt tempora at qui rerum veniam labore.", 90, 4079m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut sed voluptatem iusto quam soluta ducimus voluptas iste tempore.", 11, 14830m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Qui possimus architecto voluptatem aperiam pariatur.", 55, 6860m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aliquam impedit voluptatem aut nam aspernatur eum porro.", 1, 18180m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Accusantium aliquid eum recusandae iste atque quod.", 89, 842m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ullam accusamus corrupti aut libero eligendi.", 78, 9574m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quia tempore aut facilis qui eum doloremque corrupti.", 57, 8931m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Laudantium voluptate quis inventore rem id omnis eum.", 37, 7235m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Laborum et modi non animi minus animi laborum quia voluptatem.", 2, 10908m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Reprehenderit laboriosam excepturi id debitis aut quidem quaerat.", 75, 8137m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptates vel ut facilis quam fugiat est repellendus ut.", 84, 18378m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quaerat ratione quod.", 95, 4368m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem molestiae et ut sunt reiciendis.", 11, 19658m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui cumque reprehenderit accusantium ut quam dolor.", 13, 17713m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et atque qui autem.", 21, 2263m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Asperiores voluptatum autem enim.", 75, 320m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Qui vel deleniti ut distinctio autem accusamus quia voluptas.", 7, 15958m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Animi maxime est et ea.", 15, 12063m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Laboriosam id modi mollitia quo rerum aliquid.", 9, 8726m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Optio quidem qui ex quas asperiores qui.", 17, 8090m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Adipisci error nostrum quia.", 94, 7712m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sint non molestiae voluptatem enim voluptate a ducimus voluptas ut.", 99, 18127m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ipsa alias aspernatur.", 51, 17554m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Minus veritatis ea ratione.", 6, 11867m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur cumque dolor impedit.", 24, 17922m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "A ipsum adipisci aspernatur occaecati quia sint sed neque.", 6, 7638m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quis facere adipisci sunt accusamus quaerat.", 80, 7281m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ad quis ut vel ratione et et exercitationem praesentium.", 99, 10855m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit harum reprehenderit voluptatibus libero consequatur explicabo.", 41, 7765m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Fugit commodi quia et expedita eum consequuntur laboriosam.", 25, 4933m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Culpa tempora omnis.", 100, 10368m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Omnis tempore et aut voluptatem quia aliquam.", 100, 13244m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dignissimos nobis quas ut a rerum.", 30, 19855m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum sunt delectus dicta qui.", 44, 6622m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui error est optio.", 26, 10584m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ea molestiae iure qui sunt saepe est autem.", 1, 11206m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aliquam qui dolore ea aliquid.", 34, 698m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Qui ut corporis quia illum enim molestiae.", 99, 10986m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aliquid asperiores quia qui consectetur eos sed enim qui ea.", 31, 5543m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequuntur maiores tempora sed ut nisi.", 17, 7310m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptates cupiditate magni molestiae enim non est quia ipsa.", 96, 5018m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Autem impedit aut ab a nihil illum cupiditate qui.", 51, 6037m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Officia maiores veritatis perferendis quia.", 2, 8408m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Magni ut tempora.", 21, 19652m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eum reprehenderit omnis.", 89, 12726m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Tenetur eum cumque eum et voluptas voluptatem eum minus.", 22, 1155m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vero dolor non dicta sint laborum.", 28, 3945m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sed consequuntur iure quo tenetur qui.", 28, 3499m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Enim ut nesciunt consequatur adipisci nulla dolore.", 69, 3806m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Provident est odit ipsum delectus officia est sed odit vitae.", 64, 8549m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolor voluptas perferendis in iste a nostrum rem.", 56, 3603m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui dicta laborum porro nisi.", 95, 3330m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quia modi et ut praesentium incidunt et.", 43, 16620m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eos asperiores quis quidem alias et.", 25, 6032m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Exercitationem provident voluptatem rem.", 48, 14243m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Recusandae assumenda consequatur dolor non est eum et.", 83, 5177m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sed modi et molestiae.", 61, 14167m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Enim autem ab sit vel iusto possimus non nulla aliquam.", 54, 10316m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odit nihil reprehenderit esse.", 16, 1208m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Fugit esse quibusdam at.", 31, 5662m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Perferendis praesentium perferendis.", 80, 2593m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ab dolore similique rem minus qui.", 33, 2646m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Adipisci culpa magnam nesciunt sed eos numquam qui quidem.", 58, 18103m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ea occaecati harum ipsum.", 60, 19565m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolorum et voluptatem quo eum fugiat libero.", 28, 8439m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestias voluptas ullam.", 39, 16284m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "In quia cum dolorum voluptatem quis veritatis et quaerat.", 18, 6861m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Harum aliquam dolor.", 57, 2978m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Delectus exercitationem voluptate aspernatur at facere.", 72, 6626m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut repellat dolores tempora.", 2, 8015m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Neque dolorum vel commodi.", 14, 18774m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sed unde fugiat repellendus explicabo nesciunt vel numquam.", 31, 3250m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Harum dolorem reiciendis et alias dolores doloremque omnis optio illum.", 33, 15917m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ipsa nesciunt aliquid dolorum quis quisquam deserunt dolor commodi atque.", 85, 18112m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolores praesentium repellat aliquam maiores.", 4, 4281m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Description", "Quantity", "State" },
                values: new object[] { "Perferendis vero quam minus eaque reiciendis est vel laudantium ipsum.", 45m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eaque doloribus laborum nihil.", 19, 1940m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia suscipit consequatur et ea cumque.", 85, 13119m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et ipsum ducimus quia quas.", 39, 2669m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptas assumenda fugit architecto hic.", 62, 4516m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum ut perferendis voluptate.", 71, 14044m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Excepturi officiis voluptatem veritatis laborum voluptatem et ut nostrum.", 28, 18324m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sed repellat error eligendi asperiores voluptate voluptatum.", 45, 17636m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Mollitia nesciunt eaque dolorum suscipit molestiae.", 51, 1340m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nihil quas facere.", 49, 1684m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sint accusantium eligendi eveniet velit dolores.", 5, 9495m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ea debitis quidem dolorem est impedit et libero.", 22, 11598m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nihil doloribus eos.", 33, 3834m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Qui alias molestias quam ut quaerat.", 87, 12598m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit officiis illo.", 34, 2596m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sit vel fugit et impedit quo.", 42, 12541m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rem quisquam quos ut sed.", 76, 17487m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Officiis sit porro qui consectetur at.", 87, 3881m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Non hic est qui nihil aspernatur et culpa ad.", 21, 1376m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ullam quo rerum sint.", 59, 5110m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Enim harum qui vitae sint voluptatibus et ut iste corrupti.", 78, 8523m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum omnis voluptas ipsum perspiciatis vel distinctio aut.", 90, 2794m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolores id pariatur enim consequatur voluptatem ullam.", 2, 19015m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptas non et quisquam voluptatem maiores cupiditate.", 69, 19102m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Esse nam unde est expedita aliquam molestias.", 88, 12488m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quidem sequi aliquam facere qui cumque occaecati omnis quae similique.", 1, 14058m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Deserunt consequatur veritatis error ducimus consequuntur ut vero nisi rem.", 6, 12982m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Harum sapiente quia cumque dicta repellat minus assumenda.", 17, 7408m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nulla a optio rerum voluptate enim repudiandae.", 32, 5103m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ea exercitationem repudiandae minima recusandae voluptate totam aliquam iure.", 74, 18707m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Doloribus eos mollitia eligendi.", 42, 5548m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum omnis consequatur.", 60, 17748m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et nesciunt officiis soluta cumque qui quos iusto.", 47, 17624m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eius delectus suscipit labore minima illo expedita non aperiam soluta.", 29, 8292m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Non occaecati nobis distinctio voluptatibus sed dicta.", 49, 11414m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odit aliquam qui.", 49, 11584m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur tempore est quas.", 52, 10797m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Praesentium earum esse nostrum maiores molestias.", 81, 7228m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Magni qui ut facere asperiores perferendis unde a.", 47, 12790m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur optio aliquam accusamus.", 24, 3636m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Explicabo ut perspiciatis accusamus placeat sed.", 57, 15006m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui doloremque velit assumenda eveniet.", 20, 10160m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Autem asperiores nobis incidunt et nostrum magnam quos fugiat soluta.", 66, 19303m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia quia voluptatem molestiae quia id ut ipsam reiciendis temporibus.", 49, 6790m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Mollitia eaque quia dolores quisquam reiciendis eos rerum.", 51, 16572m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Totam ipsam autem quis aut quo est eum.", 36, 5247m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Soluta nihil odio culpa aut voluptas sint nesciunt dicta.", 17, 18521m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Nisi atque iusto animi nihil veritatis consequatur nulla nam esse.", 65, 19392m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sit enim voluptas consequuntur rerum.", 20, 5937m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Id accusantium similique eum iure deleniti quia non rerum.", 83, 6927m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Enim accusantium fugiat ipsa accusantium laborum quo sed.", 76, 4664m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aperiam optio expedita amet.", 78, 5740m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Labore laudantium ad.", 65, 18723m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Reprehenderit quas aut fugit illum eos laudantium fugit ipsum harum.", 80, 19685m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Minus ut quia eum tempora nesciunt laborum rerum.", 28, 7748m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Assumenda sunt at consectetur ex.", 25, 5925m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eius quo adipisci.", 56, 1467m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Labore ut eum ut officia.", 54, 11742m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et porro iusto sed beatae explicabo ut beatae dolor.", 50, 15871m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit suscipit tenetur asperiores aperiam dicta.", 60, 9935m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et ut incidunt.", 38, 10075m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nihil vel fugiat culpa soluta possimus aspernatur.", 78, 14557m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Description", "Quantity", "State", "Unit" },
                values: new object[] { "Quod quia dignissimos.", 7098m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eligendi minima dolor consequuntur aut dolores quo.", 58, 11134m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ducimus voluptatibus excepturi consequatur aliquid possimus.", 94, 5494m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Enim officia et corporis sint explicabo.", 64, 17490m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolorem nihil mollitia impedit voluptatum.", 55, 3676m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aliquam qui rerum possimus consequatur odio.", 36, 73m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Suscipit qui rem sed eos adipisci sint.", 33, 9255m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolores sequi sunt voluptate facilis minima sunt enim reprehenderit.", 6, 14920m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Perspiciatis odit expedita accusamus possimus ad a.", 61, 14838m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et doloribus consequatur beatae.", 37, 7401m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Id quisquam doloremque ea numquam ut minima.", 82, 3536m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aliquam et vel consequatur quis similique est.", 67, 18190m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Rem nam aut nemo ipsam.", 69, 7520m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Itaque iure fuga.", 1, 10211m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut repellendus quo facilis ea suscipit consectetur.", 57, 5410m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut itaque ut placeat necessitatibus unde neque aut eos.", 73, 4262m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quo nihil sit eos.", 24, 499m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Optio similique dolorem nemo voluptas fugit quae autem ullam.", 100, 18584m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Debitis dolorum asperiores nulla.", 69, 14117m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptate quia fuga assumenda dicta eos perspiciatis nesciunt in minima.", 18, 3509m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui eos illum quo.", 75, 13041m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Enim nemo labore doloremque facere cupiditate consequuntur architecto.", 42, 17250m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nisi a labore possimus.", 72, 15390m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Optio natus placeat ducimus nulla rerum at.", 67, 3682m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolores omnis ut excepturi voluptate ab sequi aspernatur tempore mollitia.", 26, 12878m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Animi eveniet accusantium fugiat qui rerum et est soluta.", 68, 5638m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cum reprehenderit possimus inventore.", 18, 4650m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Commodi et iste est.", 92, 18871m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sit accusantium aliquam quis.", 60, 3320m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolorem eius incidunt aut quis sint debitis asperiores quia.", 3, 17726m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quaerat et nam ut eveniet neque impedit molestias.", 11, 15333m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut reprehenderit modi non.", 1, 9331m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Perferendis voluptatem quos.", 95, 12780m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Cupiditate quia nam.", 64, 6937m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Optio eos dolores distinctio qui iste asperiores accusantium nihil.", 99, 18146m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Vel nam libero qui quidem ea voluptatum.", 77, 5142m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem recusandae nobis et reiciendis facere quisquam quasi.", 88, 15421m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Praesentium ut totam recusandae earum nisi repudiandae quasi.", 1, 18129m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Alias aut eum odio unde quis quae quo ea.", 84, 1172m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem rerum nulla laudantium autem voluptatem rem quia dolores.", 38, 200m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Libero et sunt soluta amet consequuntur facere dolorum.", 80, 13731m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tenetur illo non quia aspernatur.", 66, 204m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eveniet quia ea.", 97, 7574m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia tenetur nisi.", 49, 924m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut aspernatur rerum sed excepturi nam exercitationem aut.", 93, 10385m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Commodi molestiae ab atque.", 48, 3673m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Molestiae et ipsam numquam fuga unde sapiente voluptates.", 47, 17872m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui aut voluptatibus perspiciatis.", 35, 4611m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ipsa corrupti necessitatibus consequatur accusantium exercitationem error reiciendis.", 83, 16182m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Doloribus necessitatibus ullam eaque.", 62, 14934m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quam dolor nesciunt provident.", 64, 783m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Deleniti rerum eius est dolorem quia illum.", 35, 10385m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Minima fuga ratione modi voluptatem explicabo dolore consectetur dolorem ullam.", 85, 4963m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et dolores aliquam.", 37, 1228m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ipsum tenetur eum veritatis aut.", 39, 4464m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quis qui sequi perferendis enim.", 39, 381m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolor rerum id voluptas omnis numquam.", 41, 3308m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Omnis expedita minima aut ut quidem aperiam.", 94, 5515m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ipsum natus et tenetur quidem amet labore expedita hic odit.", 54, 4558m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ullam omnis inventore sed reiciendis voluptatibus id.", 88, 14666m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Description", "Quantity", "State", "Unit" },
                values: new object[] { "Vel quis fugit.", 5745m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sed quo quaerat non quo ipsum et.", 43, 12478m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ab sit minus sint voluptates minus.", 44, 18753m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Beatae mollitia qui vero veniam quo.", 90, 16412m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Esse laudantium quas non consequatur aut aliquid aut.", 77, 5786m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi rerum mollitia autem quisquam voluptas expedita dolores vel in.", 70, 3595m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Repellendus fuga expedita numquam natus.", 27, 8074m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Consequatur dolores est quia sed eum.", 16, 6242m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Labore dignissimos ab sunt modi excepturi aperiam et.", 68, 6455m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptas nam in.", 59, 11030m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui repellat ex adipisci aut.", 2, 16227m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Perspiciatis qui cumque perspiciatis dolor id facilis laboriosam necessitatibus sunt.", 79, 4083m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum repellat accusamus voluptatibus omnis tenetur natus id.", 45, 5465m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Numquam cumque consectetur ab blanditiis.", 67, 13212m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Atque autem voluptates cumque optio amet dolorem saepe numquam.", 37, 13232m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aperiam odit maiores voluptatibus vitae molestiae necessitatibus minus et ut.", 38, 2518m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quia natus aut suscipit.", 19, 4348m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et omnis odit voluptas incidunt.", 85, 729m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Perferendis ut cum voluptatem.", 90, 11736m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Rerum in molestias consequatur aut expedita explicabo aut in aperiam.", 85, 11937m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sed non quia consequuntur et accusamus dignissimos minima.", 15, 6011m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit iure praesentium voluptas harum ullam.", 36, 4272m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Odit eos recusandae.", 30, 4927m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Explicabo earum aperiam inventore.", 26, 11090m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Exercitationem non est accusamus.", 70, 15393m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Enim tenetur unde ipsa inventore voluptas repellendus.", 37, 4505m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Rem aut cupiditate aut.", 38, 15878m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Error vel veniam sit vel qui explicabo tempora suscipit quos.", 24, 4909m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolorum illo rerum enim enim voluptas maxime necessitatibus.", 83, 1670m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Saepe aut ratione.", 68, 6262m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut voluptatem cum dolorum est repellat nobis.", 15, 17373m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Pariatur ex quod et odit inventore in illum quos velit.", 95, 502m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ea ut recusandae velit error.", 36, 6288m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et qui sit inventore.", 86, 429m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ad ut ut non.", 10, 4114m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quasi asperiores quia.", 67, 13483m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Possimus earum libero tempore maxime alias impedit.", 48, 8174m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Totam aut ipsum delectus minus eligendi autem consequuntur qui.", 47, 14535m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Veniam eaque dicta.", 67, 19538m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quidem voluptates et sed provident ut non.", 33, 2384m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et ut dolorem nesciunt.", 88, 18821m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Doloremque perspiciatis sed dolore est porro tempore quia.", 58, 9590m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolorem voluptatem quae adipisci neque aliquam animi cumque reiciendis architecto.", 41, 12260m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Non aperiam voluptas quibusdam.", 61, 10785m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nostrum consequatur qui at quibusdam enim quo minima.", 10, 2150m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Maxime eos et.", 6, 11972m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Hic voluptatem optio praesentium reprehenderit dignissimos assumenda.", 17, 15586m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptas et ex et maxime et impedit ea suscipit consectetur.", 66, 15183m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptatibus dolor earum et iste.", 34, 18014m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui ea dolorem.", 63, 18947m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Libero repellendus voluptas molestias amet at explicabo.", 26, 6900m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Omnis consequatur in sequi repellendus animi ut.", 100, 7337m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et nemo aliquid et aut velit fugiat.", 38, 11295m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ducimus voluptatum asperiores.", 22, 1736m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Culpa non nisi qui eum tempore neque eveniet vitae.", 68, 2228m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum debitis quas mollitia laudantium.", 20, 13873m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum perspiciatis nihil enim est blanditiis.", 20, 13218m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Recusandae sapiente voluptas tempore quia magnam recusandae deleniti ipsum quo.", 18, 6099m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui aut maxime.", 39, 2004m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Description", "Quantity", "State" },
                values: new object[] { "Possimus veniam ut pariatur nostrum et qui maxime voluptatum aliquam.", 5792m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aliquam odio corrupti quo aut error cupiditate explicabo non deleniti.", 55, 9899m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut id quis.", 39, 381m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Facilis at quisquam sunt eum adipisci.", 20, 17696m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quos expedita sapiente libero.", 24, 10811m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Consequatur autem possimus ut cumque vel.", 43, 7453m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Provident sit eaque voluptas eos reprehenderit rem optio.", 36, 17982m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ea iste odio.", 75, 18362m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Velit quibusdam aperiam pariatur aspernatur illum reprehenderit ducimus qui.", 31, 3954m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatum dolorum quia consequatur voluptatem et ut nostrum.", 50, 15913m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ratione itaque blanditiis facere cum quaerat ut.", 1, 6686m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sunt vitae dolore architecto ducimus et repellat non nihil.", 80, 1592m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Minus tempora voluptates alias voluptatem aliquid autem.", 51, 5543m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Accusantium ipsa dolores quia quaerat et.", 58, 2651m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Numquam ut ea et quibusdam.", 12, 16752m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vitae cupiditate quod molestiae numquam voluptatibus quidem iure.", 74, 5903m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Fuga tenetur autem.", 21, 7624m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit voluptates recusandae.", 67, 13870m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odio dolor reprehenderit impedit illum rerum occaecati.", 5, 7856m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Expedita veniam doloribus iste molestias ut.", 1, 14724m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Repudiandae asperiores unde veritatis.", 74, 12335m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Repellendus consequatur vero expedita ut.", 68, 19976m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Description", "Quantity", "State", "Unit" },
                values: new object[] { "Atque omnis sunt dolorem quam minus.", 18363m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nemo in voluptatibus recusandae voluptatum quo ut rerum ut qui.", 32, 3263m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestiae sit non molestias nesciunt inventore aut id ut.", 83, 9348m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Optio et perspiciatis magnam qui.", 88, 9561m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT92071-0", 2, new DateTime(2021, 10, 9, 18, 29, 5, 379, DateTimeKind.Unspecified).AddTicks(6205), new DateTime(2021, 7, 6, 18, 55, 4, 880, DateTimeKind.Unspecified).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT81414-0", new DateTime(2021, 11, 14, 3, 41, 0, 133, DateTimeKind.Unspecified).AddTicks(6750), new DateTime(2021, 6, 14, 5, 6, 5, 438, DateTimeKind.Unspecified).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT96331-0", 2, new DateTime(2021, 9, 5, 4, 27, 49, 638, DateTimeKind.Unspecified).AddTicks(914), new DateTime(2021, 8, 6, 23, 28, 6, 814, DateTimeKind.Unspecified).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT83959-0", 1, new DateTime(2021, 10, 12, 23, 5, 2, 723, DateTimeKind.Unspecified).AddTicks(3749), new DateTime(2021, 8, 23, 17, 19, 28, 544, DateTimeKind.Unspecified).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT28893-1", 1, new DateTime(2021, 9, 17, 15, 36, 39, 646, DateTimeKind.Unspecified).AddTicks(9566), new DateTime(2021, 7, 24, 0, 45, 27, 653, DateTimeKind.Unspecified).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT53085-1", 3, new DateTime(2021, 12, 19, 20, 44, 25, 571, DateTimeKind.Unspecified).AddTicks(2267), new DateTime(2021, 6, 3, 2, 5, 11, 303, DateTimeKind.Unspecified).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT22059-1", 2, new DateTime(2021, 9, 8, 5, 20, 9, 218, DateTimeKind.Unspecified).AddTicks(3277), new DateTime(2021, 7, 7, 7, 9, 47, 937, DateTimeKind.Unspecified).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT13917-1", new DateTime(2021, 9, 22, 12, 31, 5, 84, DateTimeKind.Unspecified).AddTicks(9358), new DateTime(2021, 5, 31, 11, 30, 13, 182, DateTimeKind.Unspecified).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT80414-0", new DateTime(2021, 9, 2, 7, 3, 57, 792, DateTimeKind.Unspecified).AddTicks(3920), new DateTime(2021, 6, 17, 23, 52, 18, 75, DateTimeKind.Unspecified).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT83792-1", 1, new DateTime(2021, 12, 5, 14, 44, 20, 318, DateTimeKind.Unspecified).AddTicks(3382), new DateTime(2021, 7, 11, 6, 34, 28, 375, DateTimeKind.Unspecified).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT24779-0", new DateTime(2021, 11, 11, 6, 6, 4, 93, DateTimeKind.Unspecified).AddTicks(8310), new DateTime(2021, 5, 30, 2, 4, 16, 380, DateTimeKind.Unspecified).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT24489-1", 1, new DateTime(2021, 12, 15, 15, 14, 4, 529, DateTimeKind.Unspecified).AddTicks(9449), new DateTime(2021, 5, 24, 23, 4, 55, 678, DateTimeKind.Unspecified).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT72482-1", 5, new DateTime(2021, 10, 16, 19, 57, 37, 568, DateTimeKind.Unspecified).AddTicks(9546), new DateTime(2021, 6, 18, 22, 25, 53, 114, DateTimeKind.Unspecified).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT54859-1", 3, new DateTime(2021, 10, 15, 18, 25, 52, 937, DateTimeKind.Unspecified).AddTicks(2927), new DateTime(2021, 8, 7, 20, 19, 3, 0, DateTimeKind.Unspecified).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT99759-1", 2, new DateTime(2021, 11, 27, 11, 55, 46, 593, DateTimeKind.Unspecified).AddTicks(3478), new DateTime(2021, 6, 28, 0, 54, 40, 366, DateTimeKind.Unspecified).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT84270-0", new DateTime(2021, 10, 8, 17, 41, 47, 966, DateTimeKind.Unspecified).AddTicks(8461), new DateTime(2021, 8, 25, 8, 27, 45, 655, DateTimeKind.Unspecified).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT69353-1", 2, new DateTime(2021, 11, 1, 13, 7, 35, 392, DateTimeKind.Unspecified).AddTicks(5094), new DateTime(2021, 5, 17, 23, 28, 22, 695, DateTimeKind.Unspecified).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT13355-0", 1, new DateTime(2021, 11, 18, 15, 3, 54, 474, DateTimeKind.Unspecified).AddTicks(4726), new DateTime(2021, 5, 11, 0, 34, 20, 385, DateTimeKind.Unspecified).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT28863-1", new DateTime(2021, 11, 12, 4, 56, 40, 778, DateTimeKind.Unspecified).AddTicks(1290), new DateTime(2021, 6, 18, 1, 37, 15, 895, DateTimeKind.Unspecified).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT33820-0", 3, new DateTime(2021, 10, 23, 11, 57, 46, 447, DateTimeKind.Unspecified).AddTicks(4151), new DateTime(2021, 5, 21, 4, 15, 10, 167, DateTimeKind.Unspecified).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT28957-1", 2, new DateTime(2021, 12, 15, 3, 42, 1, 177, DateTimeKind.Unspecified).AddTicks(1178), new DateTime(2021, 7, 7, 19, 8, 57, 794, DateTimeKind.Unspecified).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT56243-0", 4, new DateTime(2021, 10, 23, 9, 31, 54, 551, DateTimeKind.Unspecified).AddTicks(73), new DateTime(2021, 6, 16, 20, 18, 19, 688, DateTimeKind.Unspecified).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT11160-0", 5, new DateTime(2021, 10, 15, 19, 2, 4, 504, DateTimeKind.Unspecified).AddTicks(3120), new DateTime(2021, 8, 24, 5, 18, 29, 680, DateTimeKind.Unspecified).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT29585-1", 4, new DateTime(2021, 11, 16, 5, 6, 31, 491, DateTimeKind.Unspecified).AddTicks(8032), new DateTime(2021, 6, 3, 15, 4, 50, 208, DateTimeKind.Unspecified).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT62563-0", 5, new DateTime(2021, 12, 2, 13, 34, 39, 218, DateTimeKind.Unspecified).AddTicks(7859), new DateTime(2021, 6, 9, 19, 55, 10, 696, DateTimeKind.Unspecified).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT90828-1", 5, new DateTime(2021, 10, 15, 9, 30, 2, 279, DateTimeKind.Unspecified).AddTicks(7997), new DateTime(2021, 5, 13, 14, 46, 37, 544, DateTimeKind.Unspecified).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT33125-1", 5, new DateTime(2021, 12, 16, 17, 53, 16, 337, DateTimeKind.Unspecified).AddTicks(7254), new DateTime(2021, 8, 2, 15, 30, 13, 587, DateTimeKind.Unspecified).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT90464-1", 3, new DateTime(2021, 9, 15, 7, 5, 46, 676, DateTimeKind.Unspecified).AddTicks(8950), new DateTime(2021, 7, 26, 11, 22, 21, 126, DateTimeKind.Unspecified).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT74921-0", 2, new DateTime(2021, 10, 17, 12, 39, 0, 882, DateTimeKind.Unspecified).AddTicks(3553), new DateTime(2021, 8, 9, 10, 47, 39, 436, DateTimeKind.Unspecified).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT73178-0", 3, new DateTime(2021, 10, 20, 7, 8, 52, 551, DateTimeKind.Unspecified).AddTicks(2440), new DateTime(2021, 8, 11, 20, 16, 10, 432, DateTimeKind.Unspecified).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT95293-1", new DateTime(2021, 11, 26, 18, 51, 11, 191, DateTimeKind.Unspecified).AddTicks(1383), new DateTime(2021, 7, 14, 23, 32, 34, 112, DateTimeKind.Unspecified).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT65440-0", new DateTime(2021, 10, 9, 20, 53, 42, 962, DateTimeKind.Unspecified).AddTicks(8123), new DateTime(2021, 8, 3, 9, 24, 53, 546, DateTimeKind.Unspecified).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT52335-1", 5, new DateTime(2021, 11, 1, 20, 29, 25, 830, DateTimeKind.Unspecified).AddTicks(2606), new DateTime(2021, 8, 11, 22, 51, 40, 76, DateTimeKind.Unspecified).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT24615-1", new DateTime(2021, 9, 5, 13, 26, 38, 306, DateTimeKind.Unspecified).AddTicks(5279), new DateTime(2021, 5, 12, 17, 26, 4, 372, DateTimeKind.Unspecified).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT56815-1", new DateTime(2021, 11, 8, 13, 25, 42, 156, DateTimeKind.Unspecified).AddTicks(2390), new DateTime(2021, 6, 3, 10, 52, 44, 813, DateTimeKind.Unspecified).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT89074-1", 4, new DateTime(2021, 9, 1, 6, 0, 54, 384, DateTimeKind.Unspecified).AddTicks(3057), new DateTime(2021, 6, 15, 14, 18, 29, 990, DateTimeKind.Unspecified).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT12121-1", 1, new DateTime(2021, 11, 13, 20, 0, 41, 19, DateTimeKind.Unspecified).AddTicks(6595), new DateTime(2021, 5, 18, 8, 30, 29, 414, DateTimeKind.Unspecified).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT93521-0", new DateTime(2021, 12, 16, 6, 36, 7, 226, DateTimeKind.Unspecified).AddTicks(2764), new DateTime(2021, 7, 12, 22, 2, 47, 744, DateTimeKind.Unspecified).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT46711-1", 4, new DateTime(2021, 12, 25, 14, 35, 5, 704, DateTimeKind.Unspecified).AddTicks(1264), new DateTime(2021, 6, 29, 20, 5, 24, 776, DateTimeKind.Unspecified).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT97951-0", new DateTime(2021, 11, 29, 3, 13, 35, 267, DateTimeKind.Unspecified).AddTicks(8022), new DateTime(2021, 7, 1, 2, 49, 18, 187, DateTimeKind.Unspecified).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT91053-0", new DateTime(2021, 9, 16, 2, 31, 31, 551, DateTimeKind.Unspecified).AddTicks(2142), new DateTime(2021, 7, 19, 10, 28, 57, 868, DateTimeKind.Unspecified).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT58138-1", new DateTime(2021, 12, 22, 15, 51, 48, 95, DateTimeKind.Unspecified).AddTicks(6606), new DateTime(2021, 8, 11, 0, 6, 35, 452, DateTimeKind.Unspecified).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT44376-0", new DateTime(2021, 12, 10, 5, 11, 50, 25, DateTimeKind.Unspecified).AddTicks(2999), new DateTime(2021, 8, 16, 15, 29, 49, 547, DateTimeKind.Unspecified).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT59484-1", 2, new DateTime(2021, 10, 16, 16, 57, 48, 434, DateTimeKind.Unspecified).AddTicks(285), new DateTime(2021, 5, 10, 19, 54, 55, 82, DateTimeKind.Unspecified).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT92687-1", 1, new DateTime(2021, 9, 24, 2, 59, 34, 803, DateTimeKind.Unspecified).AddTicks(3201), new DateTime(2021, 7, 6, 5, 46, 46, 435, DateTimeKind.Unspecified).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT36261-0", 3, new DateTime(2021, 12, 19, 16, 36, 14, 181, DateTimeKind.Unspecified).AddTicks(2612), new DateTime(2021, 8, 13, 16, 59, 39, 752, DateTimeKind.Unspecified).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT78341-0", 3, new DateTime(2021, 11, 12, 0, 25, 45, 734, DateTimeKind.Unspecified).AddTicks(5657), new DateTime(2021, 6, 21, 16, 52, 6, 360, DateTimeKind.Unspecified).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT35166-0", 1, new DateTime(2021, 9, 6, 17, 18, 43, 221, DateTimeKind.Unspecified).AddTicks(9122), new DateTime(2021, 7, 15, 10, 37, 33, 760, DateTimeKind.Unspecified).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT25073-0", 2, new DateTime(2021, 12, 15, 18, 6, 2, 743, DateTimeKind.Unspecified).AddTicks(5064), new DateTime(2021, 6, 8, 4, 15, 15, 644, DateTimeKind.Unspecified).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT50982-1", 1, new DateTime(2021, 11, 28, 3, 16, 49, 104, DateTimeKind.Unspecified).AddTicks(70), new DateTime(2021, 7, 28, 1, 9, 57, 704, DateTimeKind.Unspecified).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT95427-1", new DateTime(2021, 11, 15, 10, 37, 29, 851, DateTimeKind.Unspecified).AddTicks(2089), new DateTime(2021, 7, 25, 12, 23, 18, 984, DateTimeKind.Unspecified).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT54854-1", 3, new DateTime(2021, 11, 9, 1, 16, 38, 823, DateTimeKind.Unspecified).AddTicks(3379), new DateTime(2021, 5, 14, 23, 21, 41, 946, DateTimeKind.Unspecified).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT32073-0", 2, new DateTime(2021, 11, 11, 12, 59, 58, 421, DateTimeKind.Unspecified).AddTicks(7027), new DateTime(2021, 7, 22, 18, 2, 54, 160, DateTimeKind.Unspecified).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT41642-0", 2, new DateTime(2021, 10, 14, 7, 17, 12, 391, DateTimeKind.Unspecified).AddTicks(7839), new DateTime(2021, 7, 23, 7, 9, 26, 971, DateTimeKind.Unspecified).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT92960-0", new DateTime(2021, 12, 17, 8, 57, 38, 251, DateTimeKind.Unspecified).AddTicks(2365), new DateTime(2021, 8, 23, 18, 42, 26, 118, DateTimeKind.Unspecified).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT77289-0", 3, new DateTime(2021, 11, 22, 20, 38, 46, 168, DateTimeKind.Unspecified).AddTicks(7223), new DateTime(2021, 6, 24, 14, 9, 55, 916, DateTimeKind.Unspecified).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT21907-1", 4, new DateTime(2021, 11, 13, 7, 8, 40, 635, DateTimeKind.Unspecified).AddTicks(5572), new DateTime(2021, 6, 2, 2, 45, 21, 662, DateTimeKind.Unspecified).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT53627-0", 1, new DateTime(2021, 9, 11, 4, 48, 10, 427, DateTimeKind.Unspecified).AddTicks(2056), new DateTime(2021, 7, 20, 5, 30, 37, 595, DateTimeKind.Unspecified).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT69952-1", 2, new DateTime(2021, 10, 31, 20, 6, 5, 517, DateTimeKind.Unspecified).AddTicks(7587), new DateTime(2021, 5, 21, 23, 24, 50, 78, DateTimeKind.Unspecified).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT47986-1", 1, new DateTime(2021, 10, 4, 0, 45, 19, 755, DateTimeKind.Unspecified).AddTicks(2753), new DateTime(2021, 7, 2, 20, 45, 11, 722, DateTimeKind.Unspecified).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT72277-1", 1, new DateTime(2021, 12, 3, 16, 51, 52, 882, DateTimeKind.Unspecified).AddTicks(8689), new DateTime(2021, 5, 23, 9, 10, 2, 222, DateTimeKind.Unspecified).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT97386-0", 4, new DateTime(2021, 12, 5, 4, 26, 54, 296, DateTimeKind.Unspecified).AddTicks(6092), new DateTime(2021, 7, 10, 16, 26, 51, 857, DateTimeKind.Unspecified).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT85658-1", 5, new DateTime(2021, 10, 16, 15, 57, 25, 488, DateTimeKind.Unspecified).AddTicks(2785), new DateTime(2021, 7, 21, 0, 21, 43, 546, DateTimeKind.Unspecified).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT33513-0", 4, new DateTime(2021, 9, 21, 7, 42, 51, 777, DateTimeKind.Unspecified).AddTicks(6011), new DateTime(2021, 8, 18, 15, 28, 17, 869, DateTimeKind.Unspecified).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT62545-0", 1, new DateTime(2021, 11, 11, 18, 3, 21, 673, DateTimeKind.Unspecified).AddTicks(9716), new DateTime(2021, 6, 26, 17, 42, 22, 68, DateTimeKind.Unspecified).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT67990-0", 2, new DateTime(2021, 10, 4, 17, 21, 41, 302, DateTimeKind.Unspecified).AddTicks(9822), new DateTime(2021, 7, 28, 17, 31, 49, 759, DateTimeKind.Unspecified).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT59823-1", 1, new DateTime(2021, 9, 30, 18, 40, 4, 844, DateTimeKind.Unspecified).AddTicks(8831), new DateTime(2021, 7, 30, 16, 22, 27, 852, DateTimeKind.Unspecified).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT38018-0", 2, new DateTime(2021, 9, 21, 21, 15, 38, 626, DateTimeKind.Unspecified).AddTicks(7691), new DateTime(2021, 7, 30, 14, 28, 50, 542, DateTimeKind.Unspecified).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT56727-1", 1, new DateTime(2021, 10, 2, 18, 40, 40, 813, DateTimeKind.Unspecified).AddTicks(7888), new DateTime(2021, 8, 13, 0, 42, 25, 676, DateTimeKind.Unspecified).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT55000-1", 1, new DateTime(2021, 12, 25, 9, 38, 49, 272, DateTimeKind.Unspecified).AddTicks(1135), new DateTime(2021, 5, 18, 12, 0, 22, 787, DateTimeKind.Unspecified).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT64872-1", 5, new DateTime(2021, 11, 3, 16, 52, 31, 897, DateTimeKind.Unspecified).AddTicks(206), new DateTime(2021, 8, 17, 1, 18, 46, 392, DateTimeKind.Unspecified).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT46034-0", 2, new DateTime(2021, 12, 10, 21, 57, 51, 430, DateTimeKind.Unspecified).AddTicks(2923), new DateTime(2021, 5, 24, 21, 38, 31, 864, DateTimeKind.Unspecified).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT30257-1", new DateTime(2021, 11, 30, 16, 32, 11, 203, DateTimeKind.Unspecified).AddTicks(9429), new DateTime(2021, 7, 8, 15, 6, 38, 459, DateTimeKind.Unspecified).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT95721-0", 3, new DateTime(2021, 11, 26, 0, 43, 0, 266, DateTimeKind.Unspecified).AddTicks(5529), new DateTime(2021, 7, 13, 10, 32, 35, 750, DateTimeKind.Unspecified).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT47419-1", 1, new DateTime(2021, 12, 14, 18, 45, 0, 840, DateTimeKind.Unspecified).AddTicks(9442), new DateTime(2021, 8, 28, 10, 12, 35, 552, DateTimeKind.Unspecified).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT30842-1", 4, new DateTime(2021, 12, 13, 6, 57, 55, 543, DateTimeKind.Unspecified).AddTicks(9443), new DateTime(2021, 7, 28, 22, 33, 41, 566, DateTimeKind.Unspecified).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT35912-0", new DateTime(2021, 10, 15, 0, 55, 14, 990, DateTimeKind.Unspecified).AddTicks(7917), new DateTime(2021, 5, 21, 9, 33, 13, 391, DateTimeKind.Unspecified).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT94095-1", new DateTime(2021, 12, 19, 11, 12, 41, 359, DateTimeKind.Unspecified).AddTicks(890), new DateTime(2021, 6, 27, 8, 49, 45, 271, DateTimeKind.Unspecified).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT79043-1", 2, new DateTime(2021, 9, 3, 22, 42, 6, 693, DateTimeKind.Unspecified).AddTicks(2600), new DateTime(2021, 8, 23, 3, 40, 24, 246, DateTimeKind.Unspecified).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT55062-1", 2, new DateTime(2021, 12, 18, 14, 15, 5, 272, DateTimeKind.Unspecified).AddTicks(5763), new DateTime(2021, 8, 3, 21, 14, 2, 43, DateTimeKind.Unspecified).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT40860-0", 2, new DateTime(2021, 10, 28, 18, 58, 57, 489, DateTimeKind.Unspecified).AddTicks(3134), new DateTime(2021, 7, 1, 10, 18, 39, 801, DateTimeKind.Unspecified).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT20414-0", 2, new DateTime(2021, 10, 19, 22, 53, 26, 938, DateTimeKind.Unspecified).AddTicks(6955), new DateTime(2021, 6, 4, 11, 32, 50, 607, DateTimeKind.Unspecified).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT53664-0", 5, new DateTime(2021, 12, 2, 8, 58, 6, 39, DateTimeKind.Unspecified).AddTicks(1365), new DateTime(2021, 5, 14, 15, 15, 57, 412, DateTimeKind.Unspecified).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT22280-0", 3, new DateTime(2021, 9, 1, 13, 2, 50, 479, DateTimeKind.Unspecified).AddTicks(9126), new DateTime(2021, 6, 17, 23, 55, 34, 367, DateTimeKind.Unspecified).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT60141-1", 4, new DateTime(2021, 9, 12, 11, 40, 10, 392, DateTimeKind.Unspecified).AddTicks(3904), new DateTime(2021, 7, 27, 6, 8, 14, 31, DateTimeKind.Unspecified).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT60160-0", 2, new DateTime(2021, 12, 11, 14, 42, 7, 691, DateTimeKind.Unspecified).AddTicks(6989), new DateTime(2021, 6, 16, 19, 16, 45, 739, DateTimeKind.Unspecified).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT98068-1", 2, new DateTime(2021, 10, 20, 18, 54, 58, 498, DateTimeKind.Unspecified).AddTicks(6160), new DateTime(2021, 6, 3, 3, 53, 37, 459, DateTimeKind.Unspecified).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT71034-0", 4, new DateTime(2021, 11, 20, 20, 46, 30, 379, DateTimeKind.Unspecified).AddTicks(1195), new DateTime(2021, 8, 9, 10, 23, 17, 623, DateTimeKind.Unspecified).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT16650-0", 3, new DateTime(2021, 11, 23, 16, 34, 42, 162, DateTimeKind.Unspecified).AddTicks(9713), new DateTime(2021, 5, 20, 17, 38, 9, 787, DateTimeKind.Unspecified).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT41876-0", 5, new DateTime(2021, 11, 5, 6, 15, 9, 705, DateTimeKind.Unspecified).AddTicks(2753), new DateTime(2021, 8, 9, 17, 44, 33, 996, DateTimeKind.Unspecified).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT76601-0", 2, new DateTime(2021, 9, 24, 23, 40, 41, 382, DateTimeKind.Unspecified).AddTicks(4657), new DateTime(2021, 5, 17, 17, 13, 34, 184, DateTimeKind.Unspecified).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT13371-0", 5, new DateTime(2021, 10, 30, 23, 7, 41, 401, DateTimeKind.Unspecified).AddTicks(4924), new DateTime(2021, 5, 20, 17, 6, 49, 165, DateTimeKind.Unspecified).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT48016-0", 5, new DateTime(2021, 9, 28, 23, 21, 17, 797, DateTimeKind.Unspecified).AddTicks(9497), new DateTime(2021, 7, 16, 2, 0, 47, 9, DateTimeKind.Unspecified).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT34330-1", 1, new DateTime(2021, 10, 5, 15, 17, 33, 55, DateTimeKind.Unspecified).AddTicks(9111), new DateTime(2021, 7, 18, 7, 21, 12, 769, DateTimeKind.Unspecified).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT58153-0", 5, new DateTime(2021, 10, 5, 3, 15, 28, 256, DateTimeKind.Unspecified).AddTicks(2862), new DateTime(2021, 5, 9, 10, 59, 8, 899, DateTimeKind.Unspecified).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT92758-1", new DateTime(2021, 12, 7, 11, 50, 0, 374, DateTimeKind.Unspecified).AddTicks(3042), new DateTime(2021, 6, 18, 1, 4, 43, 404, DateTimeKind.Unspecified).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT17455-1", new DateTime(2021, 11, 23, 23, 49, 15, 114, DateTimeKind.Unspecified).AddTicks(2198), new DateTime(2021, 8, 15, 16, 20, 57, 876, DateTimeKind.Unspecified).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT77587-1", 2, new DateTime(2021, 9, 9, 14, 48, 36, 264, DateTimeKind.Unspecified).AddTicks(4053), new DateTime(2021, 5, 20, 16, 54, 49, 446, DateTimeKind.Unspecified).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT86194-0", 3, new DateTime(2021, 9, 20, 15, 9, 29, 564, DateTimeKind.Unspecified).AddTicks(9908), new DateTime(2021, 5, 20, 17, 13, 14, 319, DateTimeKind.Unspecified).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT47606-1", new DateTime(2021, 9, 8, 6, 22, 28, 241, DateTimeKind.Unspecified).AddTicks(6617), new DateTime(2021, 7, 15, 14, 30, 16, 845, DateTimeKind.Unspecified).AddTicks(1016) });
        }
    }
}
