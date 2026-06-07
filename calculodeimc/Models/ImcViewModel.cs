using System.ComponentModel.DataAnnotations;

namespace calculodeimc.Models
{
    public class ImcViewModel
    {
        [Required(ErrorMessage = "O peso é obrigatório.")]
        [Range(10, 500, ErrorMessage = "Insira um peso válido.")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "A altura é obrigatória.")]
        [Range(0.5, 3.0, ErrorMessage = "Insira uma altura válida.")]
        public double Altura { get; set; }

        // Propriedades apenas para exibição do resultado
        public double? ResultadoImc { get; set; }
        public string Classificacao { get; set; } = string.Empty;
    }
}