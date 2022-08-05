using System.ComponentModel.DataAnnotations;

namespace Neighborfood.Validaciones
{
    public class PesoImagenValidacion: ValidationAttribute
    {
        private readonly int pesoMaximoEnMegaBytes;

        public PesoImagenValidacion(int pesoMaximoEnMegaBytes)
        {
            this.pesoMaximoEnMegaBytes = pesoMaximoEnMegaBytes;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value == null)
            {
                return ValidationResult.Success;
            }

            IFormFile formFlie = value as FormFile;

            if(formFlie == null)
            {
                return ValidationResult.Success;
            }

            if(formFlie.Length > pesoMaximoEnMegaBytes * 1024 * 1024)
            {
                return new ValidationResult($"El peso del archivo no de ser mayor a {pesoMaximoEnMegaBytes}mb");
            }

            return ValidationResult.Success;
        }
    }
}
