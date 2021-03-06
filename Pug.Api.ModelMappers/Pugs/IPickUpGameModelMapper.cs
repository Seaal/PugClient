﻿using Pug.Api.ViewModels.Pugs;
using Pug.Data.Models.Pugs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pug.Api.ModelMappers.Pugs
{
    public interface IPickUpGameModelMapper
    {
        PickUpGameViewModel ToViewModel(PickUpGame pug);
    }
}
