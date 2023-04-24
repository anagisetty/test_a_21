using System;

namespace Test_a_21
{
    public class RenewalDataService
    {
        private readonly RenewalDataRepository _renewalDataRepository;

        public RenewalDataService(RenewalDataRepository renewalDataRepository)
        {
            _renewalDataRepository = renewalDataRepository;
        }

        public void CreateRenewalData(RenewalData data)
        {
            _renewalDataRepository.Create(data);
        }

        public RenewalData GetRenewalData(int id)
        {
            return _renewalDataRepository.Read(id);
        }

        public void UpdateRenewalData(RenewalData data)
        {
            _renewalDataRepository.Update(data);
        }

        public void DeleteRenewalData(RenewalData data)
        {
            _renewalDataRepository.Delete(data);
        }

        public IEnumerable<RenewalData> GetAllRenewalDataBefore1stJan2020()
        {
            return _renewalDataRepository.GetAllBefore1stJan2020();
        }
    }
}