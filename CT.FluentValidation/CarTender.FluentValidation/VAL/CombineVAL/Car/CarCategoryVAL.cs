﻿using CarTender.FluentValidation.DTO.CombineDTO.Car;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.CombineVAL.Car
{
    public class CarCategoryVAL : AbstractValidator<CombineCarCategoryDTO>
    {
        public CarCategoryVAL()
        {
            #region CategoryModel

            RuleFor(x => x.CategoryName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen aracın kategorisini giriniz.")
                .MinimumLength(2).WithMessage("Girmeniz gerekenden az karakter girdiniz.")
                .MaximumLength(50).WithMessage("Girmeniz gerekenden fazla karakter girdiniz.");

            #endregion
        }
    }
}
