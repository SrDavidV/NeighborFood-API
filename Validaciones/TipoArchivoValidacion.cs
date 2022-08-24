using System.ComponentModel.DataAnnotations;

namespace Neighborfood.Validaciones
{
    public class TipoArchivoValidacion: ValidationAttribute
    {
        private readonly string[] tiposValidos;

        public TipoArchivoValidacion(string[] tiposValido)
        {
            this.tiposValidos = tiposValido;
        }

        public TipoArchivoValidacion(GrupoTipoArchivo grupoTipoArchivo)
        {
            if(grupoTipoArchivo == GrupoTipoArchivo.Imagen)
            {
                tiposValidos = new string[] {"image/jpeg", "image/png", "image/gif", "image/webp"};
            }
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            IFormFile formFlie = value as FormFile;

            if (formFlie == null)
            {
                return ValidationResult.Success;
            }

            if (!tiposValidos.Contains(formFlie.ContentType))
            {
                return new ValidationResult($"El tipo del archivo debe ser uno de los siguientes: {string.Join(", " , tiposValidos)}");
            }

            return ValidationResult.Success;
        }
    }
}
