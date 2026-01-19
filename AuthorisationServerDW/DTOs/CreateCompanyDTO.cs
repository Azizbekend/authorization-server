namespace AuthorisationServerDW.DTOs
{
    public class CreateCompanyDTO
    {
        public string? CompanyName { get; set; }
        public string? ShortName { get; set; }
        public string KPP { get; set; }
        public string? JuridicalAddress { get; set; }
        public string? DirectorName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? OGRN { get; set; }
        public string? INN { get; set; }
        public string? FactAdress { get; set; }
    }
}
