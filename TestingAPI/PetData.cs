using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAPI
{
    public class Attributes
    {
        public string activityLevel { get; set; }
        public DateTime adoptedDate { get; set; }
        public string adoptionFeeString { get; set; }
        public bool isAdoptionPending { get; set; }
        public string adultSexesOk { get; set; }
        public string ageGroup { get; set; }
        public string ageString { get; set; }
        public DateTime availableDate { get; set; }
        public DateTime birthDate { get; set; }
        public bool isBirthDateExact { get; set; }
        public string breedString { get; set; }
        public string breedPrimary { get; set; }
        public int breedPrimaryId { get; set; }
        public bool isBreedMixed { get; set; }
        public bool isCatsOk { get; set; }
        public string coatLength { get; set; }
        public string colorDetails { get; set; }
        public bool isCourtesyListing { get; set; }
        public bool isCurrentVaccinations { get; set; }
        public bool isDeclawed { get; set; }
        public string descriptionHtml { get; set; }
        public string descriptionText { get; set; }
        public bool isDogsOk { get; set; }
        public string earType { get; set; }
        public string energyLevel { get; set; }
        public string exerciseNeeds { get; set; }
        public string eyeColor { get; set; }
        public string fenceNeeds { get; set; }
        public bool isNeedingFoster { get; set; }
        public bool isFound { get; set; }
        public string groomingNeeds { get; set; }
        public int priority { get; set; }
        public bool isHousetrained { get; set; }
        public string housetrainedReasonNot { get; set; }
        public string indoorOutdoor { get; set; }
        public bool isKidsOk { get; set; }
        public string name { get; set; }
        public string newPeopleReaction { get; set; }
        public string obedienceTraining { get; set; }
        public string ownerExperience { get; set; }
        public int pictureCount { get; set; }
        public string pictureThumbnailUrl { get; set; }
        public List<string> qualities { get; set; }
        public string rescueId { get; set; }
        public string searchString { get; set; }
        public string sex { get; set; }
        public string sheddingLevel { get; set; }
        public double sizeCurrent { get; set; }
        public string sizeGroup { get; set; }
        public int sizePotential { get; set; }
        public string sizeUOM { get; set; }
        public string slug { get; set; }
        public bool isSpecialNeeds { get; set; }
        public bool isSponsorable { get; set; }
        public string tailType { get; set; }
        public string trackerimageUrl { get; set; }
        public int videoCount { get; set; }
        public int videoUrlCount { get; set; }
        public string vocalLevel { get; set; }
        public bool isYardRequired { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public string summary { get; set; }
        public string breedSecondary { get; set; }
        public int? breedSecondaryId { get; set; }
        public string url { get; set; }
        public string killReason { get; set; }
        public string specialNeedsDetails { get; set; }
        public string sponsorshipMinimum { get; set; }
        public string singular { get; set; }
        public string plural { get; set; }
        public string youngSingular { get; set; }
        public string youngPlural { get; set; }
        public string description { get; set; }
        public string fullname { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string citystate { get; set; }
        public string postalcode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public double? lat { get; set; }
        public double? lon { get; set; }
        public string coordinates { get; set; }
        public string email { get; set; }
        public string facebookUrl { get; set; }
        public string services { get; set; }
        public string type { get; set; }
        public Original original { get; set; }
        public Large large { get; set; }
        public Small small { get; set; }
        public int? order { get; set; }
        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
        public string street { get; set; }
        public string adoptionUrl { get; set; }
        public string donationUrl { get; set; }
        public string sponsorshipUrl { get; set; }
        public string adoptionProcess { get; set; }
        public string about { get; set; }
    }

    public class Breeds
    {
        public List<Datum> data { get; set; }
    }

    public class Colors
    {
        public List<Datum> data { get; set; }
    }

    public class Datum
    {
        public string type { get; set; }
        public string id { get; set; }
        public Attributes attributes { get; set; }
        public Relationships relationships { get; set; }
    }

    public class Fosters
    {
        public List<Datum> data { get; set; }
    }

    public class Included
    {
        public string type { get; set; }
        public string id { get; set; }
        public Attributes attributes { get; set; }
        public Links links { get; set; }
    }

    public class Large
    {
        public int filesize { get; set; }
        public int resolutionX { get; set; }
        public int resolutionY { get; set; }
        public string url { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
    }

    public class Locations
    {
        public List<Datum> data { get; set; }
    }

    public class Meta
    {
        public int count { get; set; }
        public int countReturned { get; set; }
        public int pageReturned { get; set; }
        public int limit { get; set; }
        public int pages { get; set; }
        public string transactionId { get; set; }
    }

    public class Orgs
    {
        public List<Datum> data { get; set; }
    }

    public class Original
    {
        public int filesize { get; set; }
        public int resolutionX { get; set; }
        public int resolutionY { get; set; }
        public string url { get; set; }
    }

    public class Patterns
    {
        public List<Datum> data { get; set; }
    }

    public class Pictures
    {
        public List<Datum> data { get; set; }
    }

    public class Relationships
    {
        public Breeds breeds { get; set; }
        public Colors colors { get; set; }
        public Patterns patterns { get; set; }
        public Species species { get; set; }
        public Statuses statuses { get; set; }
        public Fosters fosters { get; set; }
        public Locations locations { get; set; }
        public Orgs orgs { get; set; }
        public Pictures pictures { get; set; }
        public Videourls videourls { get; set; }
        public Videos videos { get; set; }
    }

    public class Root
    {
        public Meta meta { get; set; }
        public List<Datum> data { get; set; }
        public List<Included> included { get; set; }
    }

    public class Small
    {
        public int filesize { get; set; }
        public int resolutionX { get; set; }
        public int resolutionY { get; set; }
        public string url { get; set; }
    }

    public class Species
    {
        public List<Datum> data { get; set; }
    }

    public class Statuses
    {
        public List<Datum> data { get; set; }
    }

    public class Videos
    {
        public List<Datum> data { get; set; }
    }

    public class Videourls
    {
        public List<Datum> data { get; set; }
    }



}
