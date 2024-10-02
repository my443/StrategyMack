using Microsoft.JSInterop;
using StrategyMack.Data;
using StrategyMack.Models;
using System;

namespace StrategyMack.Components.Pages.InitiativePages
{
    public partial class Index
    {
        private StrategyMackContext context = default!;
        private List<string> _districts = new List<string> { "North", "South", "East", "West", "Central", "Central East", "Saskatchewan" };
        private string _fiscal_year = "2024-2025";

        protected override void OnInitialized()
        {
            context = DbFactory.CreateDbContext();
        }

        private async Task LogToConsole()
        {
            await JS.InvokeVoidAsync("console.log", "Hello from Blazor!");
        }

        private void UpdateAllAttributes()
        {
            List<Initiative> initiatives = context.Initiative.ToList();
            IQueryable<InitiativeAttribute> attributes = context.InitiativeAttribute
                                                        .Where(attribute => attribute.HasMultipleDetails == false);

            IQueryable<InitiativeAttribute> attributesMultiple = context.InitiativeAttribute
                                            .Where(attribute => attribute.HasMultipleDetails == true);

            foreach (Initiative initiative in initiatives)
            {
                // First Get all the AttributeDetails that are already added for the Initiative. 
                IQueryable<InitiativeAttribute> initiativeAttribesWithNoDetails = GetAttributeDetails(initiative, attributes);
                IQueryable<InitiativeAttribute> initiativeAttributesMultipleWithNoDetails = GetAttributeMultipleDetails(initiative, attributesMultiple);

                // Turn it into a list.
                var missingInitiativeDetails = initiativeAttribesWithNoDetails.ToList();
                var missingInitiativeMultipleDetails = initiativeAttributesMultipleWithNoDetails.ToList();

                // For each of the attributes that aren't added yet for the Initiative - add it.
                foreach (InitiativeAttribute initiativeAttribute in missingInitiativeDetails)
                {
                    AddNewInitiativeAttribute(initiative, initiativeAttribute);
                }

                foreach (var initiativeAttributeMultipe in missingInitiativeMultipleDetails) { 
                    AddNewMultipleInititiveAttributes(initiative, initiativeAttributeMultipe);
                }
            }

        }

        private void AddNewInitiativeAttribute(Initiative initiative, InitiativeAttribute initiativeAttribute)
        {
            AttributeDetail attributeDetail =
                            new AttributeDetail
                            {
                                InitiativeId = initiative.Id,
                                InitiativeAttributeId = initiativeAttribute.Id,
                                Detail = ""
                            };
            // Add the instance to the DbSet
            context.AttributeDetail.Add(attributeDetail);

            // Save changes to the database
            context.SaveChanges();
        }

        private void AddNewMultipleInititiveAttributes(Initiative initiative, InitiativeAttribute initiativeAttribute)
        {
            foreach (string district in _districts)
            {
                AttributeDetailMultiple attributeDetailMultiple = new AttributeDetailMultiple
                {
                    InitiativeAttributeId = initiativeAttribute.Id,
                    InitiativeId = initiative.Id,
                    FiscalYear = _fiscal_year,
                    District = district                    
                };

                context.AttributeDetailMultiple.Add(attributeDetailMultiple);

                // Save changes to the database
                context.SaveChanges();
            }       

        }

        private IQueryable<InitiativeAttribute> GetAttributeDetails(Initiative initiative, IQueryable<InitiativeAttribute> initiativeAttributes)
        {
            var initiativeAttributeDetails = from initiativeAttributeDetail in context.AttributeDetail
                                             where initiativeAttributeDetail.InitiativeId == initiative.Id
                                             select initiativeAttributeDetail;

            // The do an outer-join to see which attributes are not added for the Initiative yet.
            var initiativeAttribesWithNoDetails =
                     from initiativeAttribute in initiativeAttributes
                     join attributeDetail in initiativeAttributeDetails
                                            on initiativeAttribute.Id equals attributeDetail.InitiativeAttributeId
                                            into attributeDetailsGroup

                     from subAttribute in attributeDetailsGroup.DefaultIfEmpty() // Left outer join
                     where
                       subAttribute == null
                     //&& subAttribute.InitiativeId == initiative.Id
                     select initiativeAttribute;

            return initiativeAttribesWithNoDetails;
        }

        private IQueryable<InitiativeAttribute> GetAttributeMultipleDetails(Initiative initiative, IQueryable<InitiativeAttribute> initiativeAttributesMultiple)
        {
            var initiativeAttributeDetails = from initiativeAttributeDetail in context.AttributeDetailMultiple
                                             where initiativeAttributeDetail.InitiativeId == initiative.Id
                                                    && initiativeAttributeDetail.FiscalYear == _fiscal_year
                                             select initiativeAttributeDetail;

            // The do an outer-join to see which attributes are not added for the Initiative yet.
            IQueryable<InitiativeAttribute> initiativeAttribesWithNoDetails =
                     from initiativeAttribute in initiativeAttributesMultiple
                     join attributeDetail in initiativeAttributeDetails
                                            on initiativeAttribute.Id equals attributeDetail.InitiativeAttributeId                                            
                                            into attributeDetailsGroup                     

            // Filter out the districts that already exist.
            from subAttribute in attributeDetailsGroup
                                //.Where(district => !_districts.Contains(district.District))
                                .DefaultIfEmpty() // Left outer join
                     where
                       subAttribute == null                       
                     //&& subAttribute.InitiativeId == initiative.Id
                     select initiativeAttribute;

            return initiativeAttribesWithNoDetails;
        }

        public async ValueTask DisposeAsync() => await context.DisposeAsync();
    }


}
