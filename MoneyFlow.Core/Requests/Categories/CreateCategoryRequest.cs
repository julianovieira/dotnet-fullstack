using System.ComponentModel.DataAnnotations;

namespace MoneyFlow.Core.Requests.Categories;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "T�tulo inv�lido")]
    [MaxLength ( 80, ErrorMessage = "O t�tulo deve conter no m�ximo 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required ( ErrorMessage = "Descri��o inv�lida")]
    public string Description { get; set; } = string.Empty;

}