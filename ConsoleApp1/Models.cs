using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp1
{
    public class RV
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int RVNumber { get; set; }
        public RentalType? RentalType { get; set; }
        public RVType? RVType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
        public double? Length { get; set; }
        public int? Guests { get; set; }
        public int? Slideouts { get; set; }
        public string InsuranceProvide { get; set; }
        public RVLocation Location { get; set; }
        [GeoPoint]
        public Point Point
        {
            get
            {
                if (Location != null && Location.Latitude.HasValue && Location.Longitude.HasValue)
                {
                    return new Point { lat = Location.Latitude.Value, lon = Location.Longitude.Value };
                }
                else
                {
                    return new Point();
                }
            }
        }
        public double Distance { get; set; }

        //Details
        public string RVName { get; set; }
        public string RVDescription { get; set; }

        //Details for Mobile type
        public double? Weight { get; set; }
        public double? HitchWeight { get; set; }
        public string HitchSize { get; set; }

        //Pricing
        public double? SecurityDeposit { get; set; }
        public double? CleaningFee { get; set; }
        public double? HighSeasonNight { get; set; }
        public double? HighSeasonWeek { get; set; }
        public double? HighSeasonMonth { get; set; }
        public double? LowSeasonNight { get; set; }
        public double? LowSeasonWeek { get; set; }
        public double? LowSeasonMonth { get; set; }

        public bool? IsRegisteredCollection { get; set; }

        /// <summary>
        /// HST
        /// </summary>
        public string TaxAccountNumber { get; set; }
        public bool HSTValidated { get; set; }
        public bool IsHSTCorrect { get; set; }

        public string TaxAccountQSTNumber { get; set; }
        public bool QSTValidated { get; set; }
        public bool IsQSTCorrect { get; set; }

        public string TaxAccountPSTNumber { get; set; }
        public bool PSTValidated { get; set; }
        public bool IsPSTCorrect { get; set; }

        public string TaxAccountGSTNumber { get; set; }
        public bool GSTValidated { get; set; }
        public bool IsGSTCorrect { get; set; }

        public DateTime? HSStartDate { get; set; }
        public DateTime? HSEndDate { get; set; }

        public bool? IsChargeMileage { get; set; }
        public double? DailyKMAllowed { get; set; }
        public double? SurchargePerExtraKM { get; set; }

        public bool? IsGenerator { get; set; }
        public double? FreeHoursPerDay { get; set; }
        public double? ChargePerHourOver { get; set; }

        public double Score { get; set; }

        //Photos
        public List<Photo> Photos { get; set; }

        public int OwnerId { get; set; }

        public bool IsDraft { get; set; }
        public bool IsPublish { get; set; }
        public bool IsVerified { get; set; }
        public int? VerifiedBy { get; set; }

        //status of insured
        public bool? Insured { get; set; }
        public InsuranceProfile InsuranceProfile { get; set; }

        [Nested]
        public List<Calendar> Calendars { get; set; }

        //Alias name
        public string AliasName { get; set; }
        public int SuffixCount { get; set; }

        public int MinimumRentalDay { get; set; }
        public bool IsDeleted { get; set; }
        public bool InsuranceProfileAdded { get; set; }

        //List add-on
        [Nested]
        public List<AddOn> ListAddOns { get; set; }
        public DateTime CreatedDate { get; set; }

        //modified date
        public DateTime ModifiedDate { get; set; }

        //Status of RV that registerd in a personal name or not
        public bool IsRegisteredInAPersonalName { get; set; }

        //Status changed on
        public DateTime? StatusChangedOn { get; set; }
    }

    public class RVLocation
    {
        public int Id { get; set; }

        public Guid RVId { get; set; }
        [JsonIgnore]
        public RV RV { get; set; }

        public string ParkName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }

    public class Photo
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public int Order { get; set; }

        public Guid RVId { get; set; }
        [JsonIgnore]
        public RV RV { get; set; }
    }

    public class InsuranceProfile
    {
        public Guid RVId { get; set; }

        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string CountryOfIssue { get; set; }
        public string ProvinceStateOfIssue { get; set; }
        public string ClassOfLicense { get; set; }
        public bool HadMoreThanEightYearFullDriverLicense { get; set; }

        //turn from less to more
        public bool HadMoreThanThreeFaultAccidentsLastSixYears { get; set; }
        //turn from didnot to did
        public bool DidHaveAnySeriousConvictions { get; set; }
        //turn from less to more
        public bool HadMoreThanThreeMinorDrivingConvictionsLastThreeYears { get; set; }
        //turn from less to more
        public bool HadMoreThanThreePersonalAutomobileInsuranceBeenCanceled { get; set; }
        public bool RegistedInAPersonalName { get; set; }
        public bool UsedPrimarilyForPersonUse { get; set; }


        public string FrontPicOfDriverLicense { get; set; }
        public string BackPicOfDriverLicense { get; set; }

        public bool CurrentInsurancePolicyInPlace { get; set; }
        public string Provider { get; set; }
        public string MakeOfRV { get; set; }
        public string ModelOfRV { get; set; }
        public string TypeOfRV { get; set; }
        public int YearOfManufacturer { get; set; }
        public string VINNumber { get; set; }
        public string LicensePlate { get; set; }
        public double CurrentValueOfRV { get; set; }
        public double Length { get; set; }
        public bool FactoryBuiltAndCSAApproved { get; set; }

        public InsuranceProfileState Status { get; set; }
        public string ReferralAttribution { get; set; }
    }

    public class AddOn
    {
        public int Id { get; set; }

        public int? AllowedAddOnId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool IsDaily { get; set; }
        public double PricePerItem { get; set; }
    }

    public class Calendar
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int OwnerId { get; set; }
        public Guid RVId { get; set; }
        public int? BookingId { get; set; }
    }

    public class Point
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public enum InsuranceProfileState
    {
        InProcessByRVezyTeam,
        Approved,
        NotApproved,
        VerificationNotRequired
    }

    public enum RentalType
    {
        [Description("RV Cottage")]
        RVCottage,
        [Description("Travel Trailer")]
        TravelTrailer,
        [Description("Motor Home")]
        MotorHome
    }

    public enum RVType
    {
        [Description("Fifth Wheel")]
        FifthWheel,
        [Description("Tent Trailer")]
        TentTrailer,
        [Description("Travel Trailer")]
        TravelTrailer,
        [Description("Vintage Trailer")]
        VintageTrailer,
        [Description("Hybrid")]
        Hybrid,
        [Description("Toy Hauler")]
        ToyHauler,
        [Description("Class A")]
        ClassA,
        [Description("Class B")]
        ClassB,
        [Description("Class C")]
        ClassC,
        [Description("Vintage Motor Home")]
        VintageMotorHome,
        [Description("Trailer")]
        Trailer,
        [Description("Motor Home")]
        MotorHome
    }
}
