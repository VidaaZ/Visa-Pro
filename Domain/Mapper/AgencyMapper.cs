using Domain.Dto;
using Domain.Entity;
using Domain.ViewModel.Agency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Mapper
{
    public static class AgencyMapper
    {
        public static Agency ToEntity(AgencyRequestDto d)
        {
            if (d is null) throw new ArgumentNullException(nameof(d));

            var now = DateTime.UtcNow;
            bool hasCreated = d.CreatedOn != default;   

            return new Agency
            {
                Name = d.Name,
                NameEn = d.NameEn,
                LegalCode = d.LegalCode,
                RegistrationNo = d.RegistrationNo,
                Address = d.Address,
                City = d.City,
                Province = d.Province,
                PostalCode = d.PostalCode,
                PhoneNumber = d.PhoneNumber,
                Email = d.Email,
                Website = d.Website,
                ContactPersonName = d.ContactPersonName,
                ContactPersonRole = d.ContactPersonRole,
                ContactPersonPhone = d.ContactPersonPhone,
                ContactPersonEmail = d.ContactPersonEmail,
                EstablishedDate = d.EstablishedDate,
                IsActive = d.IsActive,
                CountryId = d.CountryId,
                CreatedOn = hasCreated ? d.CreatedOn : now,
                UpdatedOn = hasCreated ? now : null
            };
        }

        public static AgencyResponseDto ToResponseDto(Agency e) => new()
        {

            Name = e.Name,
            NameEn = e.NameEn,
            LegalCode = e.LegalCode,
            RegistrationNo = e.RegistrationNo,
            Address = e.Address,
            City = e.City,
            Province = e.Province,
            PostalCode = e.PostalCode,
            PhoneNumber = e.PhoneNumber,
            Email = e.Email,
            Website = e.Website,
            ContactPersonName = e.ContactPersonName,
            ContactPersonRole = e.ContactPersonRole,
            ContactPersonPhone = e.ContactPersonPhone,
            ContactPersonEmail = e.ContactPersonEmail,
            EstablishedDate = e.EstablishedDate,
            IsActive = e.IsActive,
            CreatedOn = e.CreatedOn,
            UpdatedOn = e.UpdatedOn,
            CountryId = e.CountryId
        };

        public static IEnumerable<AgencyResponseDto> ToResponseDto(IEnumerable<Agency> list)
            => list.Select(ToResponseDto);

        public static AgencyRequestDto ToDto(this AgencyRequestViewModel viewModel)
        {
            return new AgencyRequestDto
            {
                Name = viewModel.Name,
                NameEn = viewModel.NameEn,
                LegalCode = viewModel.LegalCode,
                RegistrationNo = viewModel.RegistrationNo,
                Address = viewModel.Address,
                City = viewModel.City,
                Province = viewModel.Province,
                PostalCode = viewModel.PostalCode,
                PhoneNumber = viewModel.PhoneNumber,
                Email = viewModel.Email,
                Website = viewModel.Website,
                ContactPersonName = viewModel.ContactPersonName,
                ContactPersonRole = viewModel.ContactPersonRole,
                ContactPersonPhone = viewModel.ContactPersonPhone,
                ContactPersonEmail = viewModel.ContactPersonEmail,
                EstablishedDate = viewModel.EstablishedDate,
                IsActive = viewModel.IsActive,
                CreatedOn = viewModel.CreatedOn,
                UpdatedOn = viewModel.UpdatedOn,
                CountryId = viewModel.CountryId
            };
        }
    }


}
