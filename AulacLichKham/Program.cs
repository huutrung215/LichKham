using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using AulacLichKham.Modules.Repositories;
using AulacLichKham.Modules.Services;
using AulacLichKham.Swagger.Operation;
using AutoMapper;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Them cac Repository va Service de tu scrope du lieu
builder.Services.AddScoped<IFuncExamRepository, FuncExamRepository>();
builder.Services.AddScoped<IFuncExamService, FuncExamService>();
builder.Services.AddScoped<IDeptPfmRepository, DeptPfmRepository>();
builder.Services.AddScoped<IDeptPfmService, DeptPfmService>();
builder.Services.AddScoped<ICureExamRepository, CureExamRepository>();
builder.Services.AddScoped<ICureExamService,CureExamService>();
builder.Services.AddScoped<IDoctorPfmRepository, DoctorPfmRepository>();
builder.Services.AddScoped<IDoctorPfmService, DoctorPfmService>();
builder.Services.AddScoped<ITaskCareOfPntRepository, TaskCareOfPntRepository>();
builder.Services.AddScoped<ITaskCareOfPntService, TaskCareOfPntService>();
builder.Services.AddScoped<IPayOutExamRepository, PayOutExamRepository>();
builder.Services.AddScoped<IPayOutExamService, PayOutExamService>();
builder.Services.AddScoped<IHospitalExamScheduleRepository, HospitalExamScheduleRepository>();
builder.Services.AddScoped<IHospitalExamScheduleService, HospitalExamScheduleService>();
//TownWard
builder.Services.AddScoped<ITownWardRepository, TownWardRepository>();
builder.Services.AddScoped<ITownWardService, TownWardService>();
//SexTypes
builder.Services.AddScoped<ISexTypesRepository, SexTypesRepository>();
builder.Services.AddScoped<ISexTypesService, SexTypesService>();
//RegExamFrombDoctor
builder.Services.AddScoped<IRegExamRepository, RegExamRepository>();
builder.Services.AddScoped<IRegExamService, RegExamService>();
//CacelExamFrombDoctor
builder.Services.AddScoped<ICacelExamFrombDoctorRepository, CacelExamFrombDoctorRepository>();
builder.Services.AddScoped<ICacelExamFrombDoctorService, CacelExamFrombDoctorService>();
//GetStatusExamOfPntbDoctor
builder.Services.AddScoped<IGetStatusExamOfPntbDoctorRepository, GetStatusExamOfPntbDoctorRepository>();
builder.Services.AddScoped<IGetStatusExamOfPntbDoctorService, GetStatusExamOfPntbDoctorService>();
//GetRFID
builder.Services.AddScoped<IGetRFIDRepository, GetRFIDRepository>();
builder.Services.AddScoped<IGetRFIDService, GetRFIDService>();
//GetRFID2
builder.Services.AddScoped<IGetRFID2Repository, GetRFID2Repository>();
builder.Services.AddScoped<IGetRFID2Service, GetRFID2Service>();
//TestCard
builder.Services.AddScoped<IGetQuantityPntInDayReopsitory, GetQuantityPntInDayRepsitory>();
builder.Services.AddScoped<IGetQuantityPntInDayService, GetQuantityPntInDayService>();
//GetRFID
builder.Services.AddScoped<IGetDoctorExamInDayRepository, GetDoctorExamInDayRepository>();
builder.Services.AddScoped<IGetDoctorExamInDayService, GetDoctorExamInDayService>();
//TestCard
builder.Services.AddScoped<ITestCardRepository, TestCardRepository>();
builder.Services.AddScoped<ITestCardService, TestCardService>();
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
builder.Services.AddScoped<IProvinceService, ProvinceService>();

builder.Services.AddScoped<IDistrictRepository, DistrictRepository>();
builder.Services.AddScoped<IDistrictService, DistrictService>();

builder.Services.AddScoped<IServiceOfDoctorPfmRepository, ServiceOfDoctorPfmRepository>();
builder.Services.AddScoped<IServiceOfDoctorPfmService, ServiceOfDoctorPfmService>();

builder.Services.AddScoped<IServicePfmOfPntRepository, ServicePfmOfPntRepository>();
builder.Services.AddScoped<IServicePfmOfPntService, ServicePfmOfPntService>();

builder.Services.AddScoped<IServiceReqOfPntRepository, ServiceReqOfPntRepository>();
builder.Services.AddScoped<IServiceReqOfPntService, ServiceReqOfPntService>();

builder.Services.AddScoped<IVchOfElectronicRepository, VchOfElectronicRepository>();
builder.Services.AddScoped<IVchOfElectronicService, VchOfElectronicService>();

builder.Services.AddScoped<IInfoPntCureInDeptRepository, InfoPntCureInDeptRepository>();
builder.Services.AddScoped<IInfoPntCureInDeptService, InfoPntCureInDeptService>();

builder.Services.AddScoped<IInfoPayoutOnlineRepository, InfoPayoutOnlineRepository>();
builder.Services.AddScoped<IInfoPayoutOnlineService, InfoPayoutOnlineService>();

builder.Services.AddScoped<IServicePfmOfPntRepository, ServicePfmOfPntRepository>();
builder.Services.AddScoped<IServicePfmOfPntService, ServicePfmOfPntService>();

builder.Services.AddScoped<IRegExamFromMachineRepository, RegExamFromMachineRepository>();
builder.Services.AddScoped<IRegExamFromMachineService, RegExamFromMachineService>();

builder.Services.AddScoped<IInsCardFastMachineRepository, InsCardFastMachineRepository>();
builder.Services.AddScoped<IInsCardFastMachineService, InsCardFastMachineSevice>();
#endregion

const string CORS_POLICY = "CorsPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(CORS_POLICY, builder =>
    {
        //builder.WithOrigins("").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        //builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
        //builder.SetIsOriginAllowed(origin => true);
    });
});

builder.Services.AddOptions();

builder.Services.AddTransient<IDbConnection>(db => new SqlConnection(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddSwaggerGen(options => options.OperationFilter<RequiredOperationFilter>());

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors(CORS_POLICY);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
