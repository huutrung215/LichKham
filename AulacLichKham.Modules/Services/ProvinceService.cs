﻿using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Services
{
    public class ProvinceService : BaseService<Province>, IProvinceService
    {
        private readonly IProvinceRepository _repo;
        public ProvinceService(IProvinceRepository repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
