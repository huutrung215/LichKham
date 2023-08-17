using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface ICureExamRepository:IBaseRepository<CureExam>
    {
        public IEnumerable<CureExam> Gets_PntCureOfBedNum(CureExamRequest request);
        public IEnumerable<BedNumOfDept> Gets_BedNumOfDept(BedNumOfDeptRequest request);
    }
}
