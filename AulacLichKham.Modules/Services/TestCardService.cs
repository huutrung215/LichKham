using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Services
{
    public class TestCardService : ITestCardService
    {
        private readonly ITestCardRepository _testCardRepository;

        public TestCardService(ITestCardRepository testCardRepository)
        {
            _testCardRepository = testCardRepository;
        }

        public void TestCard(string deviceID, string id)
        {
            _testCardRepository.TestCard(deviceID, id);
        }
    }
}
