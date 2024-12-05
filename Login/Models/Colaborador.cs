using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Colaborador
    {
        [Display(Name = "Código", Description = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome complete", Description = "Nome e Sobrenome")]
        [Required(ErrorMessage = "O nome completo é obrigatorio")]
        public string Name { get; set; }
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatorio")]
        public string CPF { get; set; }
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O Celular é obrigatorio")]
        public string Telefone { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "O Email Não é valido")]
        [RegularExpression(".//@.+//..+", ErrorMessage = "Informe um emial valido...")]
        public string Email { get; set; }
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A senha é obrigatoria")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 10 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "O Tipo é obrigatorio")]
        public string Típo { get; set; }


    }
}
