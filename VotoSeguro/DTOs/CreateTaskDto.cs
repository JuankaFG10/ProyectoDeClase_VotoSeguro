using System.ComponentModel.DataAnnotations;

namespace VotoSeguro.DTOs;

public class CreateTaskDto
{
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(100, ErrorMessage = "El campo no puede exceder los 1000 caracteres")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(1000, ErrorMessage = "El campo descripcion no puede quedar vacio")]
    public string Description { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    public string AssignedIdToUser { get; set; }
    public DateTime? DueDate { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [RegularExpression(pattern:"(low|medium|high)$", ErrorMessage = "Prioridad Invalida")]
    public string Priority { get; set; }