﻿using FluentValidation;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilities
{
    public static class ValidationTool
    {


        public static void Validate<T>(IValidator<T> validator, T entity)
        {

            
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {


                throw new FluentValidation.ValidationException(result.Errors);


            }



        }


    }
}
