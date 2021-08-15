using Business.Contract;
using Entities;
using Repository.Contract;
using System;

namespace Business
{
    public class SeedBusiness : ISeedBusiness
    {
        ISeedOption seedOption { get; } 

        public SeedBusiness(ISeedOption _seedOption)
        {
            seedOption = _seedOption;
        }

        public void AddDicoInDB()
        {
            seedOption.AddDicoInDB();
        }
    }
}
