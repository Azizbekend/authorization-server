namespace AuthorisationServerDW.DTOs
{
    public class UserAuthorisationResponseDTO
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Adress { get; set; }
        public int BaseRoleId { get; set; }
        public int CompanyId { get; set; }
    }
}
