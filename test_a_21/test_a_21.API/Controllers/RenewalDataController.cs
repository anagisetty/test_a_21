using System;
using System.Collections.Generic;
using Test_a_21.DTO;
using Test_a_21.Service;
using Microsoft.AspNetCore.Mvc;

namespace Test_a_21.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenewalDataController : ControllerBase
    {
        private readonly RenewalDataService _renewalDataService;

        public RenewalDataController(RenewalDataService renewalDataService)
        {
            _renewalDataService = renewalDataService;
        }

        [HttpPost]
        public void CreateRenewalData(RenewalData data)
        {
            _renewalDataService.CreateRenewalData(data);
        }

        [HttpGet("{id}")]
        public RenewalData GetRenewalData(int id)
        {
            return _renewalDataService.GetRenewalData(id);
        }

        [HttpPut]
        public void UpdateRenewalData(RenewalData data)
        {
            _renewalDataService.UpdateRenewalData(data);
        }

        [HttpDelete]
        public void DeleteRenewalData(RenewalData data)
        {
            _renewalDataService.DeleteRenewalData(data);
        }

        [HttpGet]
        public IEnumerable<RenewalData> GetAllRenewalDataBefore1stJan2020()
        {
            return _renewalDataService.GetAllRenewalDataBefore1stJan2020();
        }
    }
}