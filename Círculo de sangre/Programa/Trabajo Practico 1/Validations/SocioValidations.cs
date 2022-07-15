using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Trabajo_Practico_1
{
    internal class SocioValidations: AbstractValidator<Socio>
    {
        public SocioValidations()
        {
            RuleFor(x => x.dni).NotEmpty().MaximumLength(8);
            RuleFor(x =>x.nombreApellido).NotEmpty();
            RuleFor(x=>x.fechaNacimiento).NotEmpty().Must(ValidarFechaNacimiento);
            RuleFor(x =>x.domicilio).NotEmpty();
            RuleFor(x =>x.localidad).NotEmpty();
            RuleFor(x =>x.telefono).NotEmpty();
            RuleFor(x =>x.email).NotEmpty().EmailAddress();
            RuleFor(x =>x.grupoSanguineo).NotEmpty().Must(ValidarGrupoSanguineo);
            RuleFor(x =>x.contrasena).NotEmpty().NotEqual("Cancelar");
        }

        private bool ValidarFechaNacimiento(DateTime time)
        {
            if (time.Year > 1900 && time.Year < DateTime.Now.Year) return true;
            return false;
        }
        private bool ValidarGrupoSanguineo(string grp)
        {
            if(grp =="A"||grp=="B"||grp=="AB"||grp=="0") return true;
            return false;
        }
    }
}
