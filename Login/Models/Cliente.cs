using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Cliente
    {
        [Display(Name  = "Código", Description = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome complete", Description = "Nome e Sobrenome")]
        [Required(ErrorMessage = "O nome completo é obrigatorio")]
        public string Name { get; set; }
        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "A data é obrigatorio")]
        public DateTime Nascimento { get; set; }
        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O nome completo é obrigatorio")]
        [StringLength(1, ErrorMessage = "Deve conter 1 caracter")]
        public string Sexo { get; set; }
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
        [Display(Name = "Situação")]
        [Required(ErrorMessage = "A situação é obrigatorio")]
        public string Situacao { get; set; }
    }
}
