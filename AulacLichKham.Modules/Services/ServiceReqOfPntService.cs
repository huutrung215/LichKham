using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;


namespace AulacLichKham.Modules.Services
{
    public class ServiceReqOfPntService : BaseService<ServiceReqOfPnt>, IServiceReqOfPntService
    {
        private readonly IServiceReqOfPntRepository _repo;

        public ServiceReqOfPntService(IServiceReqOfPntRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public string? ServiceReqOfPntFrombService(ServiceReqOfPnt entity)
        {
            return _repo.Execute(entity);
        }
    }
}
