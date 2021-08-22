using IotaOmicron.Framework.Validations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IotaOmicron.Framework.Data.Models;
using FluentValidation;

namespace IotaOmicron.Framework.Validations.Classes
{
    public class ApplicationValidation : AbstractValidator<Application>, IApplicationValidation
    {
        public ApplicationValidation()
        {
            RuleFor(x => x.ApplicationName).NotNull();
            RuleFor(x => x.CreatedBy).NotNull();
        }
    }
}
