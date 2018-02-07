namespace FurnitureManufacturer.Engine
{
    public class Constants
    {
        // Error messages
        internal virtual string InvalidCommandErrorMessage => "Invalid command name: {0}";
        internal virtual string CompanyExistsErrorMessage => "Company {0} already exists";
        internal virtual string CompanyNotFoundErrorMessage => "Company {0} not found";
        internal virtual string FurnitureNotFoundErrorMessage => "Furniture {0} not found";
        internal virtual string FurnitureExistsErrorMessage => "Furniture {0} already exists";
        internal virtual string InvalidChairTypeErrorMessage => "Invalid chair type: {0}";
        internal virtual string FurnitureIsNotAdjustableChairErrorMessage => "{0} is not adjustable chair";
        internal virtual string FurnitureIsNotConvertibleChairErrorMessage => "{0} is not convertible chair";

        // Success messages
        internal virtual string CompanyCreatedSuccessMessage => "Company {0} created";
        internal virtual string FurnitureAddedSuccessMessage => "Furniture {0} added to company {1}";
        internal virtual string FurnitureRemovedSuccessMessage => "Furniture {0} removed from company {1}";
        internal virtual string TableCreatedSuccessMessage => "Table {0} created";
        internal virtual string ChairCreatedSuccessMessage => "Chair {0} created";
        internal virtual string ChairHeightAdjustedSuccessMessage => "Chair {0} adjusted to height {1}";
        internal virtual string ChairStateConvertedSuccessMessage => "Chair {0} converted";        
    }
}
