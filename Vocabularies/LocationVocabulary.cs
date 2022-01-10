using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace Jat.Common.Vocabularies
{
	public class LocationVocabulary : SimpleVocabulary
    {
        public LocationVocabulary()
        {
            VocabularyName = "Jat Location";
            KeyPrefix = "jat.location";
            KeySeparator = ".";
            Grouping = EntityType.Location;

            AddGroup("Jat Location Details", group =>
            {
                Status = group.Add(new VocabularyKey("Status", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Status"));
                Date = group.Add(new VocabularyKey("date", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("date"));
                YearBuilt = group.Add(new VocabularyKey("YearBuilt", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("YearBuilt"));
                Buyer = group.Add(new VocabularyKey("Buyer", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Buyer"));
                Seller = group.Add(new VocabularyKey("Seller", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Seller"));
                Comments = group.Add(new VocabularyKey("Comments", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("comments"));
                EnergyLabel = group.Add(new VocabularyKey("EnergyLabel", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("EnergyLabel"));
                EnergyIndex = group.Add(new VocabularyKey("EnergyIndex", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("EnergyIndex"));
                RentalIncome = group.Add(new VocabularyKey("RentalIncome", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("RentalIncome"));
                MarketRent = group.Add(new VocabularyKey("MarketRent", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("MarketRent"));
                Price = group.Add(new VocabularyKey("Price", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Price"));
                Currency = group.Add(new VocabularyKey("Currency", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Currency"));
                Owner = group.Add(new VocabularyKey("Owner", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Owner"));
                RemainingLease = group.Add(new VocabularyKey("RemainingLease", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("RemainingLease"));
            });
        }

        public VocabularyKey Status { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey YearBuilt { get; private set; }
        public VocabularyKey Buyer { get; private set; }
        public VocabularyKey Seller { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey EnergyLabel { get; private set; }
        public VocabularyKey EnergyIndex { get; private set; }
        public VocabularyKey RentalIncome { get; private set; }
        public VocabularyKey MarketRent { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey Owner { get; private set; }
        public VocabularyKey RemainingLease { get; private set; }
    }
}
