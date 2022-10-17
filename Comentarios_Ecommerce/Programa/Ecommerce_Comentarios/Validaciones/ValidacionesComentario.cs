using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Word = Microsoft.Office.Interop.Word;

namespace Ecommerce_Comentarios
{
    internal class ValidacionesComentario: AbstractValidator<Comentario>
    {
        public ValidacionesComentario() { 
            RuleFor(x => x.calificacion).NotNull().NotEmpty();
            RuleFor(x => x.opinion).Must(VerificarGramatica).WithMessage("Hay errores gramaticales").
                                    Must(VerificarOrtografia).WithMessage("Hay errores de ortografía").
                                    MinimumLength(4).WithMessage("La cantidad minima de digitos es 4").
                                    MaximumLength(250).WithMessage("Se ha exedido el limite de caracteres").
                                    NotEmpty().WithMessage("No debe estar vacio");
        }

        private bool VerificarOrtografia(string opinion)
        {
            Word.Application application = new Word.Application();
            bool verificado = application.CheckSpelling(opinion);
            return verificado;
        }

        private bool VerificarGramatica(string opinion)
        {
            Word.Application application = new Word.Application();
            bool gramatica = application.CheckGrammar(opinion);
            return gramatica;
        }
    }
}
