using System.Text.Json.Serialization;

namespace UK_Postcode.Models
{
    public class Postcode
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("result")]
        public Result Result { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        [JsonPropertyName("quality")]
        public int Quality { get; set; }

        [JsonPropertyName("eastings")]
        public int Eastings { get; set; }

        [JsonPropertyName("northings")]
        public int Northings { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("nhs_ha")]
        public string NhsHa { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("european_electoral_region")]
        public string EuropeanElectoralRegion { get; set; }

        [JsonPropertyName("primary_care_trust")]
        public string PrimaryCareTrust { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("lsoa")]
        public string Lsoa { get; set; }

        [JsonPropertyName("msoa")]
        public string Msoa { get; set; }

        [JsonPropertyName("incode")]
        public string Incode { get; set; }

        [JsonPropertyName("outcode")]
        public string Outcode { get; set; }

        [JsonPropertyName("parliamentary_constituency")]
        public string ParliamentaryConstituency { get; set; }

        [JsonPropertyName("admin_district")]
        public string AdminDistrict { get; set; }

        [JsonPropertyName("parish")]
        public string Parish { get; set; }

        [JsonPropertyName("admin_county")]
        public string AdminCounty { get; set; }

        [JsonPropertyName("admin_ward")]
        public string AdminWard { get; set; }

        [JsonPropertyName("ced")]
        public string Ced { get; set; }

        [JsonPropertyName("ccg")]
        public string Ccg { get; set; }

        [JsonPropertyName("nuts")]
        public string Nuts { get; set; }

        [JsonPropertyName("codes")]
        public Codes Codes { get; set; }
    }

    public class Codes
    {
        [JsonPropertyName("admin_district")]
        public string AdminDistrict { get; set; }

        [JsonPropertyName("admin_county")]
        public string AdminCounty { get; set; }

        [JsonPropertyName("admin_ward")]
        public string AdminWard { get; set; }

        [JsonPropertyName("parish")]
        public string Parish { get; set; }

        [JsonPropertyName("parliamentary_constituency")]
        public string ParliamentaryConstituency { get; set; }

        [JsonPropertyName("ccg")]
        public string Ccg { get; set; }

        [JsonPropertyName("ccg_id")]
        public string CcgId { get; set; }

        [JsonPropertyName("ced")]
        public string Ced { get; set; }

        [JsonPropertyName("nuts")]
        public string Nuts { get; set; }

        [JsonPropertyName("lsoa")]
        public string Lsoa { get; set; }

        [JsonPropertyName("msoa")]
        public string Msoa { get; set; }

        [JsonPropertyName("lau2")]
        public string Lau2 { get; set; }
    }
}
