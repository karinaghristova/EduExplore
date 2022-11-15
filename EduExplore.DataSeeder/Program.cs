
using EduExplore.DataSeeder;
using EduExplore.DataSeeder.InputModels;
using EduExplore.Infrastructure.Data.DbModels;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text;

var context = new AppDbContext();
var jsonString = Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\net6.0", "") + "\\Dataset\\institutions.json";

ImportEducationalInstitutions(context, jsonString);

static void ImportEducationalInstitutions(AppDbContext context, string jsonString)
{
    var sb = new StringBuilder();
    var kindergartensAndSchoolsDto = JsonConvert.DeserializeObject<IEnumerable<InstitutionInputModel>>(File.ReadAllText(jsonString));

    var districts = new HashSet<string>();
    var municipalities = new HashSet<string>();
    var inhabitedAreas = new HashSet<string>();
    var regions = new HashSet<string>();
    var institutionTypes = new HashSet<string>();
    var detailedInstitutionTypes = new HashSet<string>();
    var financialInstituionTypes = new HashSet<string>();

    foreach (var currInstitution in kindergartensAndSchoolsDto)
    {
        //Validate object first
        if (!IsValid(currInstitution))
        {
            sb.AppendLine("Institution could not be added.");
            continue;
        }

        if (!districts.Contains(currInstitution.District))
        {
            districts.Add(currInstitution.District);
            var district = new District { Name = currInstitution.District};
            //Add to db
            context.Districts.Add(district);
            context.SaveChanges();
            sb.AppendLine("District added successfully.");
        }
        if (!municipalities.Contains(currInstitution.Municipality))
        {
            municipalities.Add(currInstitution.Municipality);
            var municipality = new Municipality { Name = currInstitution.Municipality };
            //Add to db
            context.Municipalities.Add(municipality);
            context.SaveChanges();
            sb.AppendLine("Municipality added successfully.");
        }
        if (!inhabitedAreas.Contains(currInstitution.InhabitedArea))
        {
            inhabitedAreas.Add(currInstitution.InhabitedArea);
            var inhabitedArea = new InhabitedArea { Name = currInstitution.InhabitedArea };
            //Add to db
            context.InhabitedAreas.Add(inhabitedArea);
            context.SaveChanges();
            sb.AppendLine("Inhabited area added successfully.");
        }
        if (!regions.Contains(currInstitution.Region))
        {
            regions.Add(currInstitution.Region);
            var region = new Region { Name = currInstitution.Region };
            //Add to db
            context.Regions.Add(region);
            context.SaveChanges();
            sb.AppendLine("Region added successfully.");
        }
        if (!institutionTypes.Contains(currInstitution.InstitutionType.ToLower()))
        {
            institutionTypes.Add(currInstitution.InstitutionType.ToLower());
            var institutionType = new InstitutionType { Name = currInstitution.InstitutionType.ToLower() };
            //Add to db
            context.InstitutionTypes.Add(institutionType);
            context.SaveChanges();
            sb.AppendLine("Institution type added successfully.");
        }
        if (!detailedInstitutionTypes.Contains(currInstitution.DetailedInstitutionType.ToLower()))
        {
            detailedInstitutionTypes.Add(currInstitution.DetailedInstitutionType.ToLower());
            var detailedInstitutionType = new DetailedInstitutionType { Name = currInstitution.DetailedInstitutionType.ToLower() };
            //Add to db
            context.DetailedInstitutionTypes.Add(detailedInstitutionType);
            context.SaveChanges();
            sb.AppendLine("Detailed institution type added successfully.");
        }
        if (!financialInstituionTypes.Contains(currInstitution.FinancialType.ToLower()))
        {
            financialInstituionTypes.Add(currInstitution.FinancialType.ToLower());
            var financialInstituionType = new FinancialType { Name = currInstitution.FinancialType.ToLower() };
            //Add to db
            context.FinancialTypes.Add(financialInstituionType);
            context.SaveChanges();
            sb.AppendLine("Financial institution type added successfully.");
        }

        var instDistrict = context.Districts.Where(d => d.Name == currInstitution.District).FirstOrDefault();
        var instMunicipality = context.Municipalities.Where(m => m.Name == currInstitution.Municipality).FirstOrDefault();
        var instInhabitedArea = context.InhabitedAreas.Where(ih => ih.Name == currInstitution.InhabitedArea).FirstOrDefault();
        var instRegion = context.Regions.Where(r => r.Name == currInstitution.Region).FirstOrDefault();
        var instInstitutionType = context.InstitutionTypes.Where(it => it.Name == currInstitution.InstitutionType.ToLower()).FirstOrDefault();
        var instDetailedInstitutionType = context.DetailedInstitutionTypes.Where(dit => dit.Name == currInstitution.DetailedInstitutionType.ToLower()).FirstOrDefault();
        var instFinancialType = context.FinancialTypes.Where(ft => ft.Name == currInstitution.FinancialType.ToLower()).FirstOrDefault();

        if (instDistrict != null && instMunicipality != null && instInhabitedArea != null 
            && instRegion != null && instInstitutionType != null && instDetailedInstitutionType != null
            && instFinancialType != null)
        {
            var institution = new Institution
            {
                Name = currInstitution.Name,
                District = instDistrict,
                Municipality = instMunicipality,
                InhabitedArea = instInhabitedArea,
                Region = instRegion,
                InstitutionType = instInstitutionType,
                DetailedInstitutionType = instDetailedInstitutionType,
                FinancialType = instFinancialType
            };

            context.Institutions.Add(institution);
            context.SaveChanges();
            sb.AppendLine("Institution successfully added");
        }
        else
        {
            sb.AppendLine("Institution could not be added due to missing data.");
        }

    }

    Console.WriteLine(sb.ToString());

}


static bool IsValid(object dto)
{
    var validationContext = new ValidationContext(dto);
    var validationResult = new List<ValidationResult>();

    return Validator.TryValidateObject(dto, validationContext, validationResult, true);
}

