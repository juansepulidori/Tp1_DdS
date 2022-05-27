using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Trabajo_Practico_1
{
    internal class PeticionValidations: AbstractValidator<Peticion>
    {
        public PeticionValidations()
        {
            RuleFor(x => x.dadoresNecesarios).NotEmpty();
            RuleFor(x=>x.fecha).NotEmpty().Must(VerificarFecha);
            RuleFor(x=>x.horario).NotEmpty().Must(VerificarHorario);
            RuleFor(x => x.grupoSan).NotEmpty().Must(ValidarGrupoSanguineo);
        }

        private bool VerificarFecha(DateOnly date)
        {
            if (date < DateOnly.FromDateTime(DateTime.Now)) return false;
            return true;
        }
        private bool VerificarHorario(TimeOnly time)
        {
            if(time < TimeOnly.Parse("6:00:00") || time > TimeOnly.Parse("20:00:00")) return false;
            return true;
        }
        private bool ValidarGrupoSanguineo(string grp)
        {
            if (grp == "A" || grp == "B" || grp == "AB" || grp == "0") return true;
            return false;
        }
    }
}
