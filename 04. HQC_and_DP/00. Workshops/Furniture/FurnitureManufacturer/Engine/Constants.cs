namespace FurnitureManufacturer.Engine
{
    public class Constants
    {
        // Error messages
        internal string InvalidCommandErrorMessage => "Invalid command name: {0}";
        internal string CompanyExistsErrorMessage => "Company {0} already exists";
        internal string CompanyNotFoundErrorMessage => "Company {0} not found";
        internal string FurnitureNotFoundErrorMessage => "Furniture {0} not found";
        internal string FurnitureExistsErrorMessage => "Furniture {0} already exists";
        internal string InvalidChairTypeErrorMessage => "Invalid chair type: {0}";
        internal string FurnitureIsNotAdjustableChairErrorMessage => "{0} is not adjustable chair";
        internal string FurnitureIsNotConvertibleChairErrorMessage => "{0} is not convertible chair";

        // Success messages
        internal string CompanyCreatedSuccessMessage => "Company {0} created";
        internal string FurnitureAddedSuccessMessage => "Furniture {0} added to company {1}";
        internal string FurnitureRemovedSuccessMessage => "Furniture {0} removed from company {1}";
        internal string TableCreatedSuccessMessage => "Table {0} created";
        internal string ChairCreatedSuccessMessage => "Chair {0} created";
        internal string ChairHeightAdjustedSuccessMessage => "Chair {0} adjusted to height {1}";
        internal string ChairStateConvertedSuccessMessage => "Chair {0} converted";        
    }
}
