using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jobs.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        [DisplayName("Nome")]
        [StringLength(32)]
        public string FirstName { get; set; }

        [DisplayName("Sobrenome")]
        [StringLength(32)]
        public string LastName { get; set; }

        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Por favor, insira um endereço de Email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Telefone")]
        [StringLength(9)]
        public string Phone { get; set; }

        [DisplayName("Biografia")]
        [StringLength(500)]
        public string UserBio { get; set; }

        [DisplayName("Endereço")]
        [StringLength(64)]
        public string AddressLine { get; set; }

        [DisplayName("Complemento")]
        public string AdditionalAddress { get; set; }

        [DisplayName("CEP")]
        [StringLength(8)]
        public string ZipCode { get; set; }

        [DisplayName("Cidade")]
        [StringLength(32)]
        public string City { get; set; }

        [DisplayName("Estado")]
        [StringLength(32)]
        public string Estate { get; set; }

        [DisplayName("DDD")]
        [StringLength(3)]
        public string AreaCode { get; set; }

        public bool IsLockedOut { get; set; }
    }
}
