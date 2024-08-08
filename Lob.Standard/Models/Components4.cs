// <copyright file="Components4.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Lob.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Lob.Standard;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Components4.
    /// </summary>
    public class Components4
    {
        private double? latitude;
        private double? longitude;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "latitude", false },
            { "longitude", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Components4"/> class.
        /// </summary>
        public Components4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Components4"/> class.
        /// </summary>
        /// <param name="primaryNumber">primary_number.</param>
        /// <param name="streetPredirection">street_predirection.</param>
        /// <param name="streetName">street_name.</param>
        /// <param name="streetSuffix">street_suffix.</param>
        /// <param name="streetPostdirection">street_postdirection.</param>
        /// <param name="secondaryDesignator">secondary_designator.</param>
        /// <param name="secondaryNumber">secondary_number.</param>
        /// <param name="pmbDesignator">pmb_designator.</param>
        /// <param name="pmbNumber">pmb_number.</param>
        /// <param name="extraSecondaryDesignator">extra_secondary_designator.</param>
        /// <param name="extraSecondaryNumber">extra_secondary_number.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="zipCodePlus4">zip_code_plus_4.</param>
        /// <param name="zipCodeType">zip_code_type.</param>
        /// <param name="deliveryPointBarcode">delivery_point_barcode.</param>
        /// <param name="addressType">address_type.</param>
        /// <param name="recordType">record_type.</param>
        /// <param name="defaultBuildingAddress">default_building_address.</param>
        /// <param name="county">county.</param>
        /// <param name="countyFips">county_fips.</param>
        /// <param name="carrierRoute">carrier_route.</param>
        /// <param name="carrierRouteType">carrier_route_type.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public Components4(
            string primaryNumber,
            Models.StreetPredirectionEnum streetPredirection,
            string streetName,
            string streetSuffix,
            Models.StreetPostdirectionEnum streetPostdirection,
            string secondaryDesignator,
            string secondaryNumber,
            string pmbDesignator,
            string pmbNumber,
            string extraSecondaryDesignator,
            string extraSecondaryNumber,
            string city,
            string state,
            string zipCode,
            string zipCodePlus4,
            Models.ZipCodeTypeEnum zipCodeType,
            string deliveryPointBarcode,
            Models.AddressTypeEnum addressType,
            Models.RecordTypeEnum recordType,
            bool defaultBuildingAddress,
            string county,
            string countyFips,
            string carrierRoute,
            Models.CarrierRouteTypeEnum carrierRouteType,
            double? latitude = null,
            double? longitude = null)
        {
            this.PrimaryNumber = primaryNumber;
            this.StreetPredirection = streetPredirection;
            this.StreetName = streetName;
            this.StreetSuffix = streetSuffix;
            this.StreetPostdirection = streetPostdirection;
            this.SecondaryDesignator = secondaryDesignator;
            this.SecondaryNumber = secondaryNumber;
            this.PmbDesignator = pmbDesignator;
            this.PmbNumber = pmbNumber;
            this.ExtraSecondaryDesignator = extraSecondaryDesignator;
            this.ExtraSecondaryNumber = extraSecondaryNumber;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.ZipCodePlus4 = zipCodePlus4;
            this.ZipCodeType = zipCodeType;
            this.DeliveryPointBarcode = deliveryPointBarcode;
            this.AddressType = addressType;
            this.RecordType = recordType;
            this.DefaultBuildingAddress = defaultBuildingAddress;
            this.County = county;
            this.CountyFips = countyFips;
            this.CarrierRoute = carrierRoute;
            this.CarrierRouteType = carrierRouteType;
            if (latitude != null)
            {
                this.Latitude = latitude;
            }

            if (longitude != null)
            {
                this.Longitude = longitude;
            }

        }

        /// <summary>
        /// The numeric or alphanumeric part of an address preceding the street name. Often the house, building, or PO Box number.
        /// </summary>
        [JsonProperty("primary_number")]
        public string PrimaryNumber { get; set; }

        /// <summary>
        /// Gets or sets StreetPredirection.
        /// </summary>
        [JsonProperty("street_predirection")]
        public Models.StreetPredirectionEnum StreetPredirection { get; set; }

        /// <summary>
        /// The name of the street.
        /// </summary>
        [JsonProperty("street_name")]
        public string StreetName { get; set; }

        /// <summary>
        /// The standard USPS abbreviation for the street suffix (`ST`, `AVE`, `BLVD`, etc).
        /// </summary>
        [JsonProperty("street_suffix")]
        public string StreetSuffix { get; set; }

        /// <summary>
        /// Gets or sets StreetPostdirection.
        /// </summary>
        [JsonProperty("street_postdirection")]
        public Models.StreetPostdirectionEnum StreetPostdirection { get; set; }

        /// <summary>
        /// The standard USPS abbreviation describing the `components[secondary_number]` (`STE`, `APT`, `BLDG`, etc).
        /// </summary>
        [JsonProperty("secondary_designator")]
        public string SecondaryDesignator { get; set; }

        /// <summary>
        /// Number of the apartment/unit/etc.
        /// </summary>
        [JsonProperty("secondary_number")]
        public string SecondaryNumber { get; set; }

        /// <summary>
        /// Designator of a <a href="https://en.wikipedia.org/wiki/Commercial_mail_receiving_agency" target="_blank">CMRA-authorized</a> private mailbox.
        /// </summary>
        [JsonProperty("pmb_designator")]
        public string PmbDesignator { get; set; }

        /// <summary>
        /// Number of a <a href="https://en.wikipedia.org/wiki/Commercial_mail_receiving_agency" target="_blank">CMRA-authorized</a> private mailbox.
        /// </summary>
        [JsonProperty("pmb_number")]
        public string PmbNumber { get; set; }

        /// <summary>
        /// An extra (often unnecessary) secondary designator provided with the input address.
        /// </summary>
        [JsonProperty("extra_secondary_designator")]
        public string ExtraSecondaryDesignator { get; set; }

        /// <summary>
        /// An extra (often unnecessary) secondary number provided with the input address.
        /// </summary>
        [JsonProperty("extra_secondary_number")]
        public string ExtraSecondaryNumber { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The <a href="https://en.wikipedia.org/wiki/ISO_3166-2" target="_blank">ISO 3166-2</a> two letter code for the state.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The 5-digit ZIP code
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets ZipCodePlus4.
        /// </summary>
        [JsonProperty("zip_code_plus_4")]
        public string ZipCodePlus4 { get; set; }

        /// <summary>
        /// Gets or sets ZipCodeType.
        /// </summary>
        [JsonProperty("zip_code_type")]
        public Models.ZipCodeTypeEnum ZipCodeType { get; set; }

        /// <summary>
        /// A 12-digit identifier that uniquely identifies a delivery point (location where mail can be sent and received). It consists of the 5-digit ZIP code (`zip_code`), 4-digit ZIP+4 add-on (`zip_code_plus_4`), 2-digit delivery point, and 1-digit delivery point check digit.
        /// </summary>
        [JsonProperty("delivery_point_barcode")]
        public string DeliveryPointBarcode { get; set; }

        /// <summary>
        /// Gets or sets AddressType.
        /// </summary>
        [JsonProperty("address_type")]
        public Models.AddressTypeEnum AddressType { get; set; }

        /// <summary>
        /// Gets or sets RecordType.
        /// </summary>
        [JsonProperty("record_type")]
        public Models.RecordTypeEnum RecordType { get; set; }

        /// <summary>
        /// Designates whether or not the address is the default address for a building containing multiple delivery points.
        /// </summary>
        [JsonProperty("default_building_address")]
        public bool DefaultBuildingAddress { get; set; }

        /// <summary>
        /// County name of the address city.
        /// </summary>
        [JsonProperty("county")]
        public string County { get; set; }

        /// <summary>
        /// A 5-digit <a href="https://en.wikipedia.org/wiki/FIPS_county_code" target="_blank">FIPS county code</a> which uniquely identifies `components[county]`. It consists of a 2-digit state code and a 3-digit county code.
        /// </summary>
        [JsonProperty("county_fips")]
        public string CountyFips { get; set; }

        /// <summary>
        /// A 4-character code assigned to a mail delivery route within a ZIP code.
        /// </summary>
        [JsonProperty("carrier_route")]
        public string CarrierRoute { get; set; }

        /// <summary>
        /// Gets or sets CarrierRouteType.
        /// </summary>
        [JsonProperty("carrier_route_type")]
        public Models.CarrierRouteTypeEnum CarrierRouteType { get; set; }

        /// <summary>
        /// A positive or negative decimal indicating the geographic latitude of the address, specifying the north-to-south position of a location. This should be used with `longitude` to pinpoint locations on a map. Will not be returned for undeliverable addresses or military addresses (state is `AA`, `AE`, or `AP`).
        /// </summary>
        [JsonProperty("latitude")]
        public double? Latitude
        {
            get
            {
                return this.latitude;
            }

            set
            {
                this.shouldSerialize["latitude"] = true;
                this.latitude = value;
            }
        }

        /// <summary>
        /// A positive or negative decimal indicating the geographic longitude of the address, specifying the north-to-south position of a location. This should be used with `latitude` to pinpoint locations on a map. Will not be returned for undeliverable addresses or military addresses (state is `AA`, `AE`, or `AP`).
        /// </summary>
        [JsonProperty("longitude")]
        public double? Longitude
        {
            get
            {
                return this.longitude;
            }

            set
            {
                this.shouldSerialize["longitude"] = true;
                this.longitude = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Components4 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLatitude()
        {
            this.shouldSerialize["latitude"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLongitude()
        {
            this.shouldSerialize["longitude"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLatitude()
        {
            return this.shouldSerialize["latitude"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLongitude()
        {
            return this.shouldSerialize["longitude"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Components4 other &&                ((this.PrimaryNumber == null && other.PrimaryNumber == null) || (this.PrimaryNumber?.Equals(other.PrimaryNumber) == true)) &&
                this.StreetPredirection.Equals(other.StreetPredirection) &&
                ((this.StreetName == null && other.StreetName == null) || (this.StreetName?.Equals(other.StreetName) == true)) &&
                ((this.StreetSuffix == null && other.StreetSuffix == null) || (this.StreetSuffix?.Equals(other.StreetSuffix) == true)) &&
                this.StreetPostdirection.Equals(other.StreetPostdirection) &&
                ((this.SecondaryDesignator == null && other.SecondaryDesignator == null) || (this.SecondaryDesignator?.Equals(other.SecondaryDesignator) == true)) &&
                ((this.SecondaryNumber == null && other.SecondaryNumber == null) || (this.SecondaryNumber?.Equals(other.SecondaryNumber) == true)) &&
                ((this.PmbDesignator == null && other.PmbDesignator == null) || (this.PmbDesignator?.Equals(other.PmbDesignator) == true)) &&
                ((this.PmbNumber == null && other.PmbNumber == null) || (this.PmbNumber?.Equals(other.PmbNumber) == true)) &&
                ((this.ExtraSecondaryDesignator == null && other.ExtraSecondaryDesignator == null) || (this.ExtraSecondaryDesignator?.Equals(other.ExtraSecondaryDesignator) == true)) &&
                ((this.ExtraSecondaryNumber == null && other.ExtraSecondaryNumber == null) || (this.ExtraSecondaryNumber?.Equals(other.ExtraSecondaryNumber) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.ZipCodePlus4 == null && other.ZipCodePlus4 == null) || (this.ZipCodePlus4?.Equals(other.ZipCodePlus4) == true)) &&
                this.ZipCodeType.Equals(other.ZipCodeType) &&
                ((this.DeliveryPointBarcode == null && other.DeliveryPointBarcode == null) || (this.DeliveryPointBarcode?.Equals(other.DeliveryPointBarcode) == true)) &&
                this.AddressType.Equals(other.AddressType) &&
                this.RecordType.Equals(other.RecordType) &&
                this.DefaultBuildingAddress.Equals(other.DefaultBuildingAddress) &&
                ((this.County == null && other.County == null) || (this.County?.Equals(other.County) == true)) &&
                ((this.CountyFips == null && other.CountyFips == null) || (this.CountyFips?.Equals(other.CountyFips) == true)) &&
                ((this.CarrierRoute == null && other.CarrierRoute == null) || (this.CarrierRoute?.Equals(other.CarrierRoute) == true)) &&
                this.CarrierRouteType.Equals(other.CarrierRouteType) &&
                ((this.Latitude == null && other.Latitude == null) || (this.Latitude?.Equals(other.Latitude) == true)) &&
                ((this.Longitude == null && other.Longitude == null) || (this.Longitude?.Equals(other.Longitude) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrimaryNumber = {(this.PrimaryNumber == null ? "null" : this.PrimaryNumber)}");
            toStringOutput.Add($"this.StreetPredirection = {this.StreetPredirection}");
            toStringOutput.Add($"this.StreetName = {(this.StreetName == null ? "null" : this.StreetName)}");
            toStringOutput.Add($"this.StreetSuffix = {(this.StreetSuffix == null ? "null" : this.StreetSuffix)}");
            toStringOutput.Add($"this.StreetPostdirection = {this.StreetPostdirection}");
            toStringOutput.Add($"this.SecondaryDesignator = {(this.SecondaryDesignator == null ? "null" : this.SecondaryDesignator)}");
            toStringOutput.Add($"this.SecondaryNumber = {(this.SecondaryNumber == null ? "null" : this.SecondaryNumber)}");
            toStringOutput.Add($"this.PmbDesignator = {(this.PmbDesignator == null ? "null" : this.PmbDesignator)}");
            toStringOutput.Add($"this.PmbNumber = {(this.PmbNumber == null ? "null" : this.PmbNumber)}");
            toStringOutput.Add($"this.ExtraSecondaryDesignator = {(this.ExtraSecondaryDesignator == null ? "null" : this.ExtraSecondaryDesignator)}");
            toStringOutput.Add($"this.ExtraSecondaryNumber = {(this.ExtraSecondaryNumber == null ? "null" : this.ExtraSecondaryNumber)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
            toStringOutput.Add($"this.ZipCodePlus4 = {(this.ZipCodePlus4 == null ? "null" : this.ZipCodePlus4)}");
            toStringOutput.Add($"this.ZipCodeType = {this.ZipCodeType}");
            toStringOutput.Add($"this.DeliveryPointBarcode = {(this.DeliveryPointBarcode == null ? "null" : this.DeliveryPointBarcode)}");
            toStringOutput.Add($"this.AddressType = {this.AddressType}");
            toStringOutput.Add($"this.RecordType = {this.RecordType}");
            toStringOutput.Add($"this.DefaultBuildingAddress = {this.DefaultBuildingAddress}");
            toStringOutput.Add($"this.County = {(this.County == null ? "null" : this.County)}");
            toStringOutput.Add($"this.CountyFips = {(this.CountyFips == null ? "null" : this.CountyFips)}");
            toStringOutput.Add($"this.CarrierRoute = {(this.CarrierRoute == null ? "null" : this.CarrierRoute)}");
            toStringOutput.Add($"this.CarrierRouteType = {this.CarrierRouteType}");
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude.ToString())}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude.ToString())}");
        }
    }
}