using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulac.Service.Rsc.Tags
{
    public class ConfigKey
    {
        /// <summary>
        /// Thu muc local chua file cap nhat phan mem
        /// </summary>
        public const string CurrentDirectory = "CurrentDirectory";

        /// <summary>
        /// Trang thai lien ket server
        /// </summary>
        public const string LinkedServer = "LinkedServer";
    }

    public class TableNames
    {
        public const string Task_QuantityInDay = "Task_QuantityInDay";

        public const string Task_DoctorExamInDay = "Task_DoctorExamInDay";

        public const string MdcFile_TaskCareOfPnt = "MdcFile_TaskCareOfPnt";

        public const string Dm_MdnItems = "Dm_MdnItems";

        public const string Dm_MdnItemsPriceCost = "Dm_MdnItemsPriceCost";

        public const string Enum_PttSubTypes = "Enum_PttSubTypes";

        public const string Dm_Depts = "Dm_Depts";

        public const string VchPTTPntHeader = "VchPTTPntHeader";

        public const string VchPTTPntLine = "VchPTTPntLine";

        public const string VchDrugPntHeader = "VchDrugPntHeader";

        public const string VchDrugPntLine = "VchDrugPntLine";

        public const string Dm_HospitalExamSchedule = "Dm_HospitalExamSchedule";

        public const string Login_ExamSchedule = "Login_ExamSchedule";
    }

    public class ViewNames
    {
        public const string View_GetListFuncExam = "View_GetListFuncExam";
    }

    public class StoredProcedure
    {
        public class OrderExam
        {
            /// <summary>
            /// Xu ly lay thong tin tai khoan cong BHXH don vi
            /// </summary>
            public const string SP_GetAccountSocialInsurance = "SP_GetAccountSocialInsurance";

            /// <summary>
            /// Xu ly dat lich kham
            /// </summary>
            public const string SP_RegExamFrombDoctor = "SP_RegExamFrombDoctor";

            /// <summary>
            /// Xu ly huy dat lich kham
            /// </summary>
            public const string SP_CancelExamFrombDoctor = "SP_CancelExamFrombDoctor";

            /// <summary>
            /// Xu ly kiem tra trang thai dat lich tai don vi
            /// </summary>
            public const string SP_GetStatusExamOfPntbDoctor = "SP_GetStatusExamOfPntbDoctor";

            /// <summary>
            /// Xu ly lay thong tin so luong dat lich trong ngay theo cac moc thoi gian
            /// </summary>
            public const string SP_GetQuantityPntInDay = "SP_GetQuantityPntInDay";

            /// <summary>
            /// Xu ly lay thong tin bac sy kham trong ngay
            /// </summary>
            public const string SP_GetDoctorExamInDay = "SP_GetDoctorExamInDay";
        }

        public class CodeCard
        {
            /// <summary>
            /// Xu ly lay thong tin the RFID
            /// </summary>
            public const string SP_GetRFID = "SP_GetRFID";

            /// <summary>
            /// Xu ly lay thong tin the RFID 2
            /// </summary>
            public const string SP_GetRFID2 = "SP_GetRFID2";

            /// <summary>
            /// Xu ly du lieu lay danh sach khoa phong thuc hien
            /// </summary>
            public const string SP_GetListDeptPfmService = "SP_GetListDeptPfmService";

            /// <summary>
            /// Xu ly lay thong tin danh sach bac sy thuc hien dich vu
            /// </summary>
            public const string SP_GetListDoctorPfmService = "SP_GetListDoctorPfmService";

            /// <summary>
            /// Xu ly lay thong tin dich vu theo bac sy thuc hien
            /// </summary>
            public const string SP_GetListServiceOfDoctorPfm = "SP_GetListServiceOfDoctorPfm";

            /// <summary>
            /// Xu ly lay thong tin nguoi thuc hien dich vu
            /// </summary>
            public const string SP_GetListPntPfmService = "SP_GetListPntPfmService";

            /// <summary>
            /// Xu ly du lieu thuc hien dich vu
            /// </summary>
            public const string SP_SetServicePfmOfPnt = "SP_SetServicePfmOfPnt";

            /// <summary>
            /// Xu ly du lieu bat dau thuc hien dich vu
            /// </summary>
            public const string SP_SetServiceReqOfPnt = "SP_SetServiceReqOfPnt";

            /// <summary>
            /// Xu ly du lieu bat dau huy bo dich vu
            /// </summary>
            public const string SP_CancelServicePfmOfPnt = "SP_CancelServicePfmOfPnt";

            /// <summary>
            /// Danh sach giuong/buong theo khoa/phong
            /// </summary>
            public const string SP_GetListBedNumOfDept = "SP_GetListBedNumOfDept";

        }

        public class CureExam
        {
            public const string SP_GetListPntCureOfBedNum = "SP_GetListPntCureOfBedNum";

            public const string SP_GetListVchOfElectronic = "SP_GetListVchOfElectronic";

            public const string SP_GetInfoPntCureInDept = "SP_GetInfoPntCureInDept";
            public const string SP_GetListBedNumOfDept = "SP_GetListBedNumOfDept";
        }

        public class TaskCareOfPnt
        {
            public const string SP_GetListTaskCareOfPnt = "SP_GetListTaskCareOfPnt";

            public const string SP_GetInfoTaskCareOfPntInDay = "SP_GetInfoTaskCareOfPntInDay";

            public const string SP_GetInfoTaskCareOfPnt = "SP_GetInfoTaskCareOfPnt";

            /// <summary>
            /// Danh sach Phieu cham soc/To dieu tri
            /// </summary>
            public const string SP_GetListTaskCareTreatmentOfPnt = "SP_GetListTaskCareTreatmentOfPnt";

            /// <summary>
            /// Chi tiet Phieu cham soc/To dieu tri
            /// </summary>
            public const string SP_GetInfoTaskCareTreatmentOfPnt = "SP_GetInfoTaskCareTreatmentOfPnt";

            /// <summary>
            /// Luu thong tin Phieu cham soc/To dieu tri
            /// </summary>
            public const string SP_SetTaskCareTreatmentOfPnt = "SP_SetTaskCareTreatmentOfPnt";

            /// <summary>
            /// Xoa thong tin Phieu cham soc/To dieu tri
            /// </summary>
            public const string SP_DeleteTaskCareTreatmentOfPnt = "SP_DeleteTaskCareTreatmentOfPnt";

            /// <summary>
            /// Lay Thong tin dich vu chi dinh
            /// </summary>
            public const string SP_GetMdnItems = "SP_GetMdnItems";

            /// <summary>
            /// Lay Thong tin Loai dich vu chi dinh
            /// </summary>
            public const string SP_GetItemSubType = "SP_GetItemSubType";


            /// <summary>
            /// Lay Thong tin Khoa thuc hien dich vu cls
            /// </summary>
            public const string SP_GetListDeptPfmCls = "SP_GetListDeptPfmCls";

        }

        public class PayOutOnline
        {
            public const string SP_GetInfoPayoutOnline = "SP_GetInfoPayoutOnline";
        }

        public class HISFunction
        {
            public const string SP_GetListPntInDeptCureService = "SP_GetListPntInDeptCureService";
        }

        public class PayOutExam
        {
            /// <summary>
            /// Lay thong tin thanh toan kham, chua benh
            /// </summary>
            public const string SP_GetDetailPayOutExamOfPnt = "SP_GetDetailPayOutExamOfPnt";
            /// <summary>
            /// Lay danh sach cac dich vu thanh toan kham, chua benh
            /// </summary>
            public const string SP_GetDetailExpExamOfPnt = "SP_GetDetailExpExamOfPnt";
        }

        public class FuncExam
        {
            public const string SP_GetListFuncExam = "SP_GetListFuncExam";
        }

        public class DeptPfm
        {
            public const string SP_GetListDeptPfmService = "SP_GetListDeptPfmService";
        }

        public class DoctorPfm
        {
            public const string SP_GetListDoctorPfmService = "SP_GetListDoctorPfmService";
        }

        public class MdnItems
        {
            public const string SP_GetMdnItems = "SP_GetMdnItems";
        }
        public class ItemsSubType
        {
            public const string SP_GetItemSubType = "SP_GetItemSubType";
        }
        public class HspExamSchedule
        {
            public const string SP_RegisterExamSchedule = "SP_RegisterExamSchedule";

            public const string SP_GetHospitalExamSchedule = "SP_GetHospitalExamSchedule";

            public const string SP_LoginExamSchedule = "SP_LoginExamSchedule";
        }

        public class RegExam
        {
            public const string SP_RegExamFrombDoctor = "SP_RegExamFrombDoctor";
            public const string SP_GetDoctorExamInDay = "SP_GetDoctorExamInDay";
            public const string SP_GetQuantityPntInDay = "SP_GetQuantityPntInDay";
        }
        public class TownWard
        {
            public const string SP_GetListTownWard = "SP_GetListTownWard";
        }

        public class District
        {
            public const string SP_GetDistrict = "SP_GetDistrict";
        }

        public class ServiceOfDoctorPfm
        {
            public const string SP_GetListServiceOfDoctorPfm = "SP_GetListServiceOfDoctorPfm";
        }
    }

    public class tagUpdateVersion
    {
        public const string DirectoryUpdate = "Update";

        public const string FullFileNameUpdate = "AulacEmsUpdate.zip";
    }

    public class tagOrderExam
    {
        public class QuantityPntInDay
        {
            public const string DateTimeReg = "DateTimeReg";

            public const string TimeRegExam = "TimeRegExam";

            public const string Quantity = "Quantity";

            public const string QuantityMax = "QuantityMax";

            public class Table
            {
                public static List<string> ListFields = new List<string>() { DateTimeReg, TimeRegExam, Quantity, QuantityMax };
                public const string Task_QuantityInDay = TableNames.Task_QuantityInDay;
                public const string SP_GetQuantityPntInDay = StoredProcedure.OrderExam.SP_GetQuantityPntInDay;
            }
        }

        public class DoctorExamInDay
        {
            public const string DateRegExam = "DateRegExam";

            public const string DoctorPrkID = "DoctorPrkID";

            public const string DoctorID = "DoctorID";

            public const string DoctorName = "DoctorName";

            public class Table
            {
                public static List<string> ListFields = new List<string>() { DateRegExam, DoctorID, DoctorName };
                public const string Task_DoctorExamInDay = TableNames.Task_DoctorExamInDay;
                public const string SP_GetDoctorExamInDay = StoredProcedure.OrderExam.SP_GetDoctorExamInDay;
            }
        }

        public class CodeCard
        {
            /// <summary>
            /// Ten Bang
            /// </summary>
            public const string TableName = "TableName";

            /// <summary>
            /// Ma dich vu
            /// </summary>
            public const string ItemID = "ItemID";

            /// <summary>
            /// Ten dich vu 
            /// </summary>
            public const string ItemName = "ItemName";

            /// <summary>
            /// Ma the benh nhan
            /// </summary>
            public const string CardCode = "CardCode";

            /// <summary>
            /// Ten benh nhan
            /// </summary>
            public const string PntName = "PntName";

            /// <summary>
            /// Ngay sinh
            /// </summary>
            public const string PntBirthDay = "PntBirthDay";

            /// <summary>
            /// Trang thai
            /// </summary>
            public const string StatusName = "StatusName";

            /// <summary>
            /// Trang thai ID
            /// </summary>
            public const string StatusID = "StatusID";

            /// <summary>
            /// Ma khoa phong
            /// </summary>
            public const string DeptID = "DeptID";

            /// <summary>
            /// Ten khoa phong
            /// </summary>
            public const string DeptName = "DeptName";
        }
    }

    public class tagMdcFiles
    {
        public class CureMng
        {
            public const string MdcFilePrkID = "MdcFilePrkID";

            //public const string PntName = "PntName";

            //public const string PntAge = "PntAge";

            //public const string PntUnitAgeID = "PntUnitAgeID";

            //public const string PntSexID = "PntSexID";

            //public const string PntAddr = "PntAddr";

            //public const string PntAddrCurrent = "PntAddrCurrent";

            //public const string PntBirthday = "PntBirthday";

            public const string DateInCure = "DateInCure";

            public const string PntExamNo = "PntExamNo";

            public const string ClassNum = "ClassNum";

            public const string BedNum = "BedNum";

            public const string DeptCureID = "DeptCureID";

            public const string DeptCureName = "DeptCureName";

            public const string ModeTrmtID = "ModeTrmtID";

            public const string Diagnostic = "Diagnostic";

        }

        public class VchType
        {
            public const string VchTypeID = "VchTypeID";

            public const string VchName = "VchName";
        }

        public class TaskCareOfPnt
        {
            public const string TaskCareOfPntPrkID = "TaskCareOfPntPrkID";

            public const string VchTypeID = "VchTypeID";

            public const string MdcFilePrkID = "MdcFilePrkID";

            public const string PersonName = "PersonName";

            public const string DatePfm = "DatePfm";

            public const string TimePfm = "TimePfm";

            public const string EvolutionOfPnt = "EvolutionOfPnt";

            public const string PfmMedicalInstruction = "PfmMedicalInstruction";

            public const string PersonWriteID = "PersonWriteID";

            public const string PersonWriteName = "PersonWriteName";

            public const string PntPulse = "PntPulse";

            public const string PntInspire = "PntInspire";

            public const string PntWeightKg = "PntWeightKg";

            public const string PntTemperature = "PntTemperature";

            public const string PntBloodPressure = "PntBloodPressure";

            public const string PntHeightCm = "PntHeightCm";

            public const string SummaryPathologicalProcess = "SummaryPathologicalProcess";

            public const string SummaryCLS = "SummaryCLS";

            public const string SummaryTreatment = "SummaryTreatment";

            public const string SummaryConditionEndExam = "SummaryConditionEndExam";

            public const string SummaryTreatmentDirection = "SummaryTreatmentDirection";

            public const string PsnPfmPrkID = "PsnPfmPrkID";

            public const string PsnPfmID = "PsnPfmID";

            public const string PsnPfmName = "PsnPfmName";

            public const string DoctorPfmPrkID = "DoctorPfmPrkID";

            public const string DoctorPfmID = "DoctorPfmID";

            public const string DoctorPfmName = "DoctorPfmName";

            public const string DeptCurePrkID = "DeptCurePrkID";

            public const string DeptCureID = "DeptCureID";

            public const string DeptCureName = "DeptCureName";

            public const string DrugRequest = "DrugRequest";

            public const string CLSRequest = "CLSRequest";

            public const string PTTRequest = "PTTRequest";

            public const string CountPack = "CountPack";

            public const string DateTreatment = "DateTreatment";

            public class Table
            {
                public static List<string> ListFields = new List<string>() { };
                public const string MdcFile_TaskCareOfPnt = TableNames.MdcFile_TaskCareOfPnt;
            }
        }

        public class PntExam
        {
            /// <summary>
            /// Ma ho so benh an
            /// </summary>
            public const string MdcFilePrkID = "MdcFilePrkID";
            /// <summary>
            /// Ngay chung tu
            /// </summary>
            public const string VchDate = "VchDate";
            /// <summary>
            /// Ma khoa chinh thong tin benh nhan
            /// </summary>
            public const string PntPrkID = "PntPrkID";
            /// <summary>
            /// Ma thong tin benh nhan
            /// </summary>
            public const string PntID = "PntID";
            /// <summary>
            /// Ten benh nhan
            /// </summary>
            public const string PntName = "PntName";
            /// <summary>
            /// Ngay sinh benh nhan
            /// </summary>
            public const string PntBirthday = "PntBirthday";
            /// <summary>
            /// Nam sinh benh nhan
            /// </summary>
            public const string PntBirthYear = "PntBirthYear";
            /// <summary>
            /// Tuoi benh nhan
            /// </summary>
            public const string PntAge = "PntAge";
            /// <summary>
            /// Don vi tinh tuoi benh nhan
            /// </summary>
            public const string PntUnitAgeID = "PntUnitAgeID";
            /// <summary>
            /// Dia chi benh nhan
            /// </summary>
            public const string PntAddr = "PntAddr";
            /// <summary>
            /// Ma dan toc
            /// </summary>
            public const string PntRacePrkID = "PntRacePrkID";
            /// <summary>
            /// Ma gioi tinh
            /// </summary>
            public const string PntSexID = "PntSexID";
            /// <summary>
            /// Ma xa
            /// </summary>
            public const string PntTownWardPrkID = "PntTownWardPrkID";
            /// <summary>
            /// Ten xa
            /// </summary>
            public const string PntTownWardName = "PntTownWardName";
            /// <summary>
            /// Ma huyen
            /// </summary>
            public const string PntDistrictPrkID = "PntDistrictPrkID";
            /// <summary>
            /// Ten huyen
            /// </summary>
            public const string PntDistrictName = "PntDistrictName";
            /// <summary>
            /// Ma tinh/tp
            /// </summary>
            public const string PntProvincePrkID = "PntProvincePrkID";
            /// <summary>
            /// Ten tinh/tp
            /// </summary>
            public const string PntProvinceName = "PntProvinceName";
            /// <summary>
            /// Ma quoc gia
            /// </summary>
            public const string PntCountryPrkID = "PntCountryPrkID";
            /// <summary>
            /// Ten quoc gia
            /// </summary>
            public const string PntCountryName = "PntCountryName";
            /// <summary>
            /// Ma nhom cong viec
            /// </summary>
            public const string PntJobGrpPrkID = "PntJobGrpPrkID";
            /// <summary>
            /// Ten nhom cong viec
            /// </summary>
            public const string PntJobGrpName = "PntJobGrpName";
            /// <summary>
            /// Noi lam viec
            /// </summary>
            public const string PntPlaceWork = "PntPlaceWork";
            /// <summary>
            /// So dien thoai
            /// </summary>
            public const string PntPhone = "PntPhone";
            /// <summary>
            /// Dia chi lien lac
            /// </summary>
            public const string PntContactAdd = "PntContactAdd";
            /// <summary>
            /// Ten nguoi nha lien lac
            /// </summary>
            public const string PntContact = "PntContact";
            /// <summary>
            /// Moi quan he nguoi nha
            /// </summary>
            public const string ContactTitle = "ContactTitle";
            /// <summary>
            /// Ma Icd noi chuyen den
            /// </summary>
            public const string IcdPrsntID = "IcdPrsntID";
            /// <summary>
            /// Ten Icd noi chuyen den
            /// </summary>
            public const string IcdPrsntName = "IcdPrsntName";
            /// <summary>
            /// 
            /// </summary>
            public const string TotalCure = "TotalCure";
            /// <summary>
            /// Ma khoa vao kham benh
            /// </summary>
            public const string DeptInPrkID = "DeptInPrkID";
            /// <summary>
            /// Ma khoa ra vien
            /// </summary>
            public const string DeptOutPrkID = "DeptOutPrkID";
            /// <summary>
            /// Thoi gian vao vien
            /// </summary>
            public const string DateTimeIn = "DateTimeIn";
            /// <summary>
            /// Thoi gian ra vien
            /// </summary>
            public const string DateTimeOut = "DateTimeOut";
            /// <summary>
            /// Thoi gian kham benh
            /// </summary>
            public const string DateTimeExam = "DateTimeExam";
            /// <summary>
            /// Ma loai benh vien chuyen den
            /// </summary>
            public const string TranFromHspTypeID = "TranFromHspTypeID";
            /// <summary>
            /// Ten benh vien chuyen den
            /// </summary>
            public const string TranFromOfficeName = "TranFromOfficeName";
            /// <summary>
            /// Ma BHYT benh vien chuyen den
            /// </summary>
            public const string TranFromOfficeCode = "TranFromOfficeCode";
            /// <summary>
            /// Ma khoa chinh benh vien chuyen den
            /// </summary>
            public const string TranFromOfficePrkID = "TranFromOfficePrkID";
            /// <summary>
            /// Trang thai hoat dong
            /// </summary>
            public const string IsActive = "IsActive";
            /// <summary>
            /// Chuan doan khi chuyen den kham benh
            /// </summary>
            public const string ReasonExam = "ReasonExam";
            /// <summary>
            /// 
            /// </summary>
            public const string DgnsFrom = "DgnsFrom";
            /// <summary>
            /// Xac dinh KCB dung tuyen
            /// </summary>
            public const string IsKcbDgTuyen = "IsKcbDgTuyen";
            /// <summary>
            /// Xac dinh cap cuu
            /// </summary>
            public const string IsPntEmergency = "IsPntEmergency";
            /// <summary>
            /// Loai phi
            /// </summary>
            public const string FncStylePntPrkID = "FncStylePntPrkID";
            /// <summary>
            /// So vao benh vien
            /// </summary>
            public const string HspInNum = "HspInNum";
            /// <summary>
            /// 
            /// </summary>
            public const string AcdntTypeID = "AcdntTypeID";
            /// <summary>
            /// 
            /// </summary>
            public const string IsAcdntIns = "IsAcdntIns";
            /// <summary>
            /// Thoi gian dang ky kham benh
            /// </summary>
            public const string DateRegExam = "DateRegExam";
            /// <summary>
            /// 
            /// </summary>
            public const string IsReCalcPricePnt = "IsReCalcPricePnt";
            /// <summary>
            /// Ma cap bac quan doi
            /// </summary>
            public const string PntMitaryRanksPrkID = "PntMitaryRanksPrkID";
            /// <summary>
            /// Ma don vi quan doi
            /// </summary>
            public const string PntWorkPlacePrkID = "PntWorkPlacePrkID";
            /// <summary>
            /// Noi chuyen
            /// </summary>
            public const string PntObjExamTypeID = "PntObjExamTypeID";
            /// <summary>
            /// So chung minh nhan dan cua nguoi benh
            /// </summary>
            public const string SoCMND = "SoCMND";
            /// <summary>
            /// So CMND cua nguoi bao ho
            /// </summary>
            public const string SoCMNDContact = "SoCMNDContact";
            /// <summary>
            /// Dia chi thuong tru
            /// </summary>
            public const string PntAddrCurrent = "PntAddrCurrent";
            /// <summary>
            /// Dat lich kham qua trang bDoctor
            /// </summary>
            public const string IsRegExambDoctor = "IsRegExambDoctor";
            /// <summary>
            /// So phieu chuyen tuyen
            /// </summary>
            public const string VchNoIntroduce = "VchNoIntroduce";
            /// <summary>
            /// Ngay chuyen tuyen
            /// </summary>
            public const string VchDateTranHspFrom = "VchDateTranHspFrom";
            /// <summary>
            /// Ma loai moi quan he
            /// </summary>
            public const string ContactTitleID = "ContactTitleID";
            /// <summary>
            /// Ma the ID
            /// </summary>
            public const string CardCode = "CardCode";

            public class Table
            {
                public static List<string> ListFields = new List<string>() { MdcFilePrkID, VchDate, PntPrkID, PntID, PntName, PntBirthday, PntBirthYear, PntAge, PntUnitAgeID, PntAddr, PntRacePrkID, PntSexID, PntTownWardPrkID, PntTownWardName, PntDistrictPrkID, PntDistrictName, PntProvincePrkID, PntProvinceName, PntCountryPrkID, PntCountryName, PntJobGrpPrkID, PntJobGrpName, PntPlaceWork, PntPhone, PntContactAdd, PntContact, ContactTitle, IcdPrsntID, IcdPrsntName, TotalCure, DeptInPrkID, DeptOutPrkID, DateTimeIn, DateTimeOut, DateTimeExam, TranFromHspTypeID, TranFromOfficeName, TranFromOfficeCode, TranFromOfficePrkID, IsActive, ReasonExam, DgnsFrom, IsKcbDgTuyen, IsPntEmergency, FncStylePntPrkID, HspInNum, AcdntTypeID, IsAcdntIns, DateRegExam, IsReCalcPricePnt, PntMitaryRanksPrkID, PntWorkPlacePrkID, PntObjExamTypeID, SoCMND, SoCMNDContact, PntAddrCurrent, IsRegExambDoctor, VchNoIntroduce, VchDateTranHspFrom, ContactTitleID, CardCode };
            }
        }

        /// <summary>
        /// Thong tin vao khoa dieu tri
        /// </summary>
        public class PntCure
        {
            /// <summary>
            /// Ma ho so benh an
            /// </summary>
            public const string MdcFilePrkID = "MdcFilePrkID";
            /// <summary>
            /// Ma benh nhan vao khoa
            /// </summary>
            public const string PntCurePrkID = "PntCurePrkID";
            /// <summary>
            /// Ma dang ki vao khoa
            /// </summary>
            public const string RegCurePrkID = "RegCurePrkID";
            /// <summary>
            /// So vao vien
            /// </summary>
            public const string HspInNum = "HspInNum";
            /// <summary>
            /// Ngay vao khoa dieu tri
            /// </summary>
            public const string DateInCure = "DateInCure";
            /// <summary>
            /// Thoi gian vao khoa dieu tri
            /// </summary>
            public const string TimeInCure = "TimeInCure";
            /// <summary>
            /// Ma loai ho so benh an
            /// </summary>
            public const string MdcFileTypePrkID = "MdcFileTypePrkID";
            /// <summary>
            /// So KCB
            /// </summary>
            public const string PntExamNo = "PntExamNo";
            /// <summary>
            /// Ma hinh thuc dieu tri
            /// </summary>
            public const string ModeTrmtID = "ModeTrmtID";
            /// <summary>
            /// Ma Icd10 vao khoa dieu tri
            /// </summary>
            public const string Icd10InCureID = "Icd10InCureID";
            /// <summary>
            /// Ten benh vao khoa dieu tri
            /// </summary>
            public const string DgnInCureName = "DgnInCureName";
            /// <summary>
            /// Ly do vao khoa dieu tri
            /// </summary>
            public const string ReasonInCure = "ReasonInCure";
            /// <summary>
            /// Trang thai kham chua benh
            /// </summary>
            public const string PntStatusExam = "PntStatusExam";
            /// <summary>
            /// Ma khoa dieu tri
            /// </summary>
            public const string DeptCurePrkID = "DeptCurePrkID";
            /// <summary>
            /// Ma bac si dieu tri
            /// </summary>
            public const string DoctorCurePrkID = "DoctorCurePrkID";
            /// <summary>
            /// Trang thai mo
            /// </summary>
            public const string IsOpen = "IsOpen";
            /// <summary>
            /// Trang thai hoat dong
            /// </summary>
            public const string IsActive = "IsActive";
            /// <summary>
            /// Mau benh an dien tu
            /// </summary>
            public const string ElectricProfileTypeID = "ElectricProfileTypeID";

            public class Table
            {
                public static List<string> ListFields = new List<string>() { MdcFilePrkID, PntCurePrkID, RegCurePrkID, HspInNum, DateInCure, TimeInCure, MdcFileTypePrkID, PntExamNo, ModeTrmtID, Icd10InCureID, DgnInCureName, ReasonInCure, PntStatusExam, DeptCurePrkID, DoctorCurePrkID, IsOpen, IsActive, ElectricProfileTypeID };
            }
        }

        /// <summary>
        /// Thong tin qua trinh nhap vien dieu tri
        /// </summary>
        public class PntCureInDept
        {
            /// <summary>
            /// Ma khoa vao khoa dieu tri
            /// </summary>
            public const string PntInDeptPrkID = "PntInDeptPrkID";
            /// <summary>
            /// Ma ho so benh an
            /// </summary>
            public const string MdcFilePrkID = "MdcFilePrkID";
            /// <summary>
            /// Ma vao khoa dieu tri
            /// </summary>
            public const string PntCurePrkID = "PntCurePrkID";
            /// <summary>
            /// So vao vien
            /// </summary>
            public const string HspInNum = "HspInNum";
            /// <summary>
            /// Ma khoa benh nhan
            /// </summary>
            public const string PntLogPrkID = "PntLogPrkID";
            /// <summary>
            /// Ngay vao khoa dieu tri
            /// </summary>
            public const string DateInDept = "DateInDept";
            /// <summary>
            /// Thoi gian vao khoa dieu tri
            /// </summary>
            public const string TimeInDept = "TimeInDept";
            /// <summary>
            /// Ngay ra khoa dieu tri
            /// </summary>
            public const string DateOutDept = "DateOutDept";
            /// <summary>
            /// Thoi gian ra khoa dieu tri
            /// </summary>
            public const string TimeOutDept = "TimeOutDept";
            /// <summary>
            /// Ma khoa dieu tri
            /// </summary>
            public const string DeptCurePrkID = "DeptCurePrkID";
            /// <summary>
            /// Ten khoa dieu tri
            /// </summary>
            public const string DeptCureName = "DeptCureName";

            /// <summary>
            /// Ma khoa dieu tri
            /// </summary>
            public const string DeptCureID = "DeptCureID";
            /// <summary>
            /// Ma bac si khoa dieu tri
            /// </summary>
            public const string DoctorCurePrkID = "DoctorCurePrkID";
            /// <summary>
            /// Ma chung tu goc(cha)
            /// </summary>
            public const string VchOrgID = "VchOrgID";
            /// <summary>
            /// Ma loai chung tu goc(cha)
            /// </summary>
            public const string VchOrgTypeID = "VchOrgTypeID";
            /// <summary>
            /// Ghi chu
            /// </summary>
            public const string Note = "Note";
            /// <summary>
            /// So phong
            /// </summary>
            public const string ClassNum = "ClassNum";
            /// <summary>
            /// So giuong
            /// </summary>
            public const string BedNum = "BedNum";
            /// <summary>
            /// Loai giuong
            /// </summary>
            public const string BedTypeID = "BedTypeID";
            /// <summary>
            /// Trang thai kham chua benh
            /// </summary>
            public const string PntStatusExam = "PntStatusExam";
            /// <summary>
            /// Trang thai yeu cau
            /// </summary>
            public const string StatusReq = "StatusReq";
            /// <summary>
            /// Ma chi phi ngay giuong
            /// </summary>
            public const string ItemFeeBedPrkID = "ItemFeeBedPrkID";
            /// <summary>
            /// Xac dinh chi phi ngay giuong
            /// </summary>
            public const string IsWriteBedFee = "IsWriteBedFee";
            /// <summary>
            /// Ngay dieu tri
            /// </summary>
            public const string DayCount = "DayCount";
            /// <summary>
            /// Ma chuyen khoa
            /// </summary>
            public const string TranDeptPrkID = "TranDeptPrkID";
            /// <summary>
            /// Trang thai hoat dong
            /// </summary>
            public const string IsActive = "IsActive";
            /// <summary>
            /// Lich su su dung giuong
            /// </summary>
            public const string ListBedBU = "ListBedBU";

            public class Table
            {
                public static List<string> ListFields = new List<string>() { PntInDeptPrkID, MdcFilePrkID, PntCurePrkID, HspInNum, PntLogPrkID, DateInDept, TimeInDept, DateOutDept, TimeOutDept, DeptCurePrkID, DoctorCurePrkID, VchOrgID, VchOrgTypeID, Note, ClassNum, BedNum, BedTypeID, PntStatusExam, StatusReq, ItemFeeBedPrkID, IsWriteBedFee, DayCount, TranDeptPrkID, IsActive, ListBedBU };
            }
        }

        /// <summary>
        /// Thong tin benh tat
        /// </summary>
        public class DgnExam
        {
            public class Header
            {
                public const string DgnPrkID = tagMdcFiles.DgnExam.DgnPrkID;
                public const string MdcFilePrkID = tagMdcFiles.DgnExam.MdcFilePrkID;
                public const string VchTypeID = tagMdcFiles.DgnExam.VchTypeID;
                public const string VchNo = tagMdcFiles.DgnExam.VchNo;
                public const string VchDate = tagMdcFiles.DgnExam.VchDate;
                public const string DgnTypeID = tagMdcFiles.DgnExam.DgnTypeID;
                public const string HspInNum = tagMdcFiles.DgnExam.HspInNum;
                public const string DgnTime = tagMdcFiles.DgnExam.DgnTime;
                public const string DeptExamPrkID = tagMdcFiles.DgnExam.DeptExamPrkID;
                public const string DoctorExamPrkID = tagMdcFiles.DgnExam.DoctorExamPrkID;
                public const string VchOrgID = tagMdcFiles.DgnExam.VchOrgID;
                public const string VchOrgTypeID = tagMdcFiles.DgnExam.VchOrgTypeID;
                public const string Note = tagMdcFiles.DgnExam.Note;
                public const string IsActive = tagMdcFiles.DgnExam.IsActive;
                public const string Diagnostic = tagMdcFiles.DgnExam.Diagnostic;
                public const string IsDgnResult = tagMdcFiles.DgnExam.IsDgnResult;
                public const string IsDie = tagMdcFiles.DgnExam.IsDie;
                public const string IsPainID = tagMdcFiles.DgnExam.IsPainID;

                public class Table
                {
                    public List<string> ListDgnH = new List<string>() { DgnPrkID, MdcFilePrkID, VchTypeID, VchNo, VchDate, DgnTypeID, HspInNum, DgnTime, DeptExamPrkID, DoctorExamPrkID, VchOrgID, VchOrgTypeID, Note, IsActive, Diagnostic, IsDgnResult, IsDie, IsPainID };
                    public List<string> ListDgnL = new List<string>() { DgnPrkID, ItemLine, Icd10ID, IcdName, PainID, PainName, NoteLine, PainTypeID };
                }
            }

            public class Line
            {
                public const string DgnPrkID = tagMdcFiles.DgnExam.DgnPrkID;
                public const string ItemLine = tagMdcFiles.DgnExam.ItemLine;
                public const string Icd10ID = tagMdcFiles.DgnExam.Icd10ID;
                public const string IcdName = tagMdcFiles.DgnExam.IcdName;
                public const string PainID = tagMdcFiles.DgnExam.PainID;
                public const string PainName = tagMdcFiles.DgnExam.PainName;
                public const string NoteLine = tagMdcFiles.DgnExam.NoteLine;
                public const string PainTypeID = tagMdcFiles.DgnExam.PainTypeID;
            }
            public class View
            {
                public const string StrIcd10ID = "StrIcd10ID";
                public const string StrIcdName = "StrIcdName";

                public const string ListIcdOtherID = "ListIcdOtherID";
                public const string ListIcdOtherName = "ListIcdOtherName";

            }

            /// <summary>
            /// Ma khoa benh
            /// </summary>
            public const string DgnPrkID = "DgnPrkID";
            /// <summary>
            /// Ma ho so benh an
            /// </summary>
            public const string MdcFilePrkID = "MdcFilePrkID";
            /// <summary>
            /// Ma loai phieu
            /// </summary>
            public const string VchTypeID = "VchTypeID";
            /// <summary>
            /// So phieu
            /// </summary>
            public const string VchNo = "VchNo";
            /// <summary>
            /// Ngay chung tu
            /// </summary>
            public const string VchDate = "VchDate";
            /// <summary>
            /// Ma loai benh
            /// </summary>
            public const string DgnTypeID = "DgnTypeID";
            /// <summary>
            /// So vao benh vien
            /// </summary>
            public const string HspInNum = "HspInNum";
            /// <summary>
            /// Thoi gian benh
            /// </summary>
            public const string DgnTime = "DgnTime";
            /// <summary>
            /// Ma khoa dieu tri
            /// </summary>
            public const string DeptExamPrkID = "DeptExamPrkID";
            /// <summary>
            /// Ma bac si dieu tri
            /// </summary>
            public const string DoctorExamPrkID = "DoctorExamPrkID";
            /// <summary>
            /// Ma chung tu goc(cha)
            /// </summary>
            public const string VchOrgID = "VchOrgID";
            /// <summary>
            /// Ma loai chung tu goc(cha)
            /// </summary>
            public const string VchOrgTypeID = "VchOrgTypeID";
            /// <summary>
            /// Ghi chu
            /// </summary>
            public const string Note = "Note";
            /// <summary>
            /// Trang thai hoat dong
            /// </summary>
            public const string IsActive = "IsActive";
            /// <summary>
            /// Chan doan so bo
            /// </summary>
            public const string Diagnostic = "Diagnostic";
            /// <summary>
            /// Xac dinh ket qua benh
            /// </summary>
            public const string IsDgnResult = "IsDgnResult";
            /// <summary>
            /// Xac dinh tu vong
            /// </summary>
            public const string IsDie = "IsDie";
            /// <summary>
            /// Ma loai benh
            /// </summary>
            public const string IsPainID = "IsPainID";
            /// <summary>
            /// So dong
            /// </summary>
            public const string ItemLine = "ItemLine";
            /// <summary>
            /// Ma Icd10
            /// </summary>
            public const string Icd10ID = "Icd10ID";
            /// <summary>
            /// Ten Icd10
            /// </summary>
            public const string IcdName = "IcdName";
            /// <summary>
            /// Ma benh
            /// </summary>
            public const string PainID = "PainID";
            /// <summary>
            /// Ten benh
            /// </summary>
            public const string PainName = "PainName";
            /// <summary>
            /// Ghi chu
            /// </summary>
            public const string NoteLine = "NoteLine";
            /// <summary>
            /// Ma loai benh
            /// </summary>
            public const string PainTypeID = "PainTypeID";
            /// <summary>
            /// Ten loai benh
            /// </summary>
            public const string PainTypeName = "PainTypeName";
            /// <summary>
            /// Xac dinh 
            /// </summary>
            public const string IsPainName = "IsPainName";
            /// <summary>
            /// Ten bac si kham
            /// </summary>
            public const string DoctorExamName = "DoctorExamName";
            /// <summary>
            /// Ten khoa kham benh
            /// </summary>
            public const string DeptExamName = "DeptExamName";

            /// <summary>
            /// Can nang BN tinh bang Kg
            /// </summary>
            public const string PntWeightKg = "PntWeightKg";

            /// <summary>
            /// Chieu cao BN tinh bang cm
            /// </summary>
            public const string PntHeightCm = "PntHeightCm";

            /// <summary>
            /// Nhip tho nguoi benh (lan/phut)
            /// </summary>
            public const string PntInspire = "PntInspire";

            /// <summary>
            /// Mach dap bn: (lan/phut)
            /// </summary>
            public const string PntPulse = "PntPulse";

            /// <summary>
            /// Nhiet do BN (do C)
            /// </summary>
            public const string PntTemperature = "PntTemperature";

            /// <summary>
            /// Huyet ap BN
            /// </summary>
            public const string PntBloodPressure = "PntBloodPressure";

            /// <summary>
            /// Qua trinh benh ly
            /// </summary>
            public const string PathologicalProcess = "PathologicalProcess";

            /// <summary>
            /// Tieu su ban than
            /// </summary>
            public const string StoryOfPnt = "StoryOfPnt";

            /// <summary>
            /// Tieu su gia dinh
            /// </summary>
            public const string StoryOfFamily = "StoryOfFamily";

            /// <summary>
            /// Kham toan than
            /// </summary>
            public const string ExamBody = "ExamBody";

            /// <summary>
            /// Kham bo phan
            /// </summary>
            public const string ExamBodyPart = "ExamBodyPart";

            /// <summary>
            /// Tom tat ket qua can lam sang
            /// </summary>
            public const string SummaryCLS = "SummaryCLS";

            /// <summary>
            /// Da xu ly khi kham
            /// </summary>
            public const string ExamProcessing = "ExamProcessing";

            public class Table
            {
                public static List<string> ListFieldsH = new List<string> { DgnPrkID, MdcFilePrkID, VchTypeID, VchNo, VchDate, DgnTypeID, HspInNum, DgnTime, DeptExamPrkID, DoctorExamPrkID, VchOrgID, VchOrgTypeID, Note, IsActive, IsDgnResult, IsDie, Diagnostic, IsPainID, PntBloodPressure, PntHeightCm, PntInspire, PntPulse, PntTemperature, PntWeightKg, PathologicalProcess, StoryOfPnt, StoryOfFamily, ExamBody, ExamBodyPart, SummaryCLS, ExamProcessing };
                public static List<string> ListFieldsL = new List<string> { DgnPrkID, ItemLine, Icd10ID, IcdName, PainID, PainName, NoteLine, PainTypeID };
            }
        }

        public class PayoutOnline
        {
            public const string PayOutOnlinePrkID = "PayOutOnlinePrkID";

            public const string PntPhone = "PntPhone";

            public const string PntName = "PntName";

            public const string PntBirthday = "PntBirthday";

            public const string InsNum = "InsNum";

            public const string DateExam = "DateExam";

            public const string DateEndExam = "DateEndExam";

            public const string AmtTltToPay = "AmtTltToPay";

            public const string StatusReq = "StatusReq";

            public const string IsActive = "IsActive";

            public const string LinkPdfOnline = "LinkPdfOnline";

        }

        public class PayOutExam
        {
            #region Thong tin thanh toan benh nhan
            public const string MdcFilePrkID = "MdcFilePrkID";
            public const string QRCode = "QRCode";
            public const string HspName = "HspName";
            public const string OfficeMngName = "OfficeMngName";
            public const string SexName = "SexName";
            public const string PntName = "PntName";
            public const string PntAddr = "PntAddr";
            public const string PntAge = "PntAge";
            public const string PntBirthday = "PntBirthday";
            public const string PntBirthYear = "PntBirthYear";
            public const string DateTimeIn = "DateTimeIn";
            public const string DateTimeOut = "DateTimeOut";
            public const string PntPlaceWork = "PntPlaceWork";
            public const string PntJobGrpName = "PntJobGrpName";
            public const string IsPntEmergency = "IsPntEmergency";
            public const string IsKcbDgTuyen = "IsKcbDgTuyen";
            public const string PntUnitAgeID = "PntUnitAgeID";
            public const string PntPhone = "PntPhone";
            public const string PntObjExamTypeID = "PntObjExamTypeID";
            public const string PntEmergencyName = "PntEmergencyName";
            public const string KcbDgTuyenName = "KcbDgTuyenName";
            public const string IsKcbTranffic = "IsKcbTranffic";
            public const string KcbTrTuyenName = "KcbTrTuyenName";
            public const string RdcObjID = "RdcObjID";
            public const string DateInsStart = "DateInsStart";
            public const string DateInsEnd = "DateInsEnd";
            public const string InsNum = "InsNum";
            public const string InsRegExamName = "InsRegExamName";
            public const string InsOfiFullRegCode = "InsOfiFullRegCode";
            public const string TranFromOfficeCode = "TranFromOfficeCode";
            public const string Diagnostic = "Diagnostic";
            public const string HspInNum = "HspInNum";
            public const string Icd10ID = "Icd10ID";
            public const string IcdName = "IcdName";
            public const string PainTypeID = "PainTypeID";
            public const string RaceName = "RaceName";
            public const string TimeExam = "TimeExam";
            //public const string VchNo = "VchNo";
            public const string AmtTtlRecTmpPntInExc = "AmtTtlRecTmpPntInExc";
            public const string AmtTtlAdditionPntInExc = "AmtTtlAdditionPntInExc";
            public const string AmtTtlTurnBackPntInExc = "AmtTtlTurnBackPntInExc";
            public const string AmtTltRvnPntInExc = "AmtTltRvnPntInExc";
            public const string AmtTtlRvnInsPntInExc = "AmtTtlRvnInsPntInExc";
            public const string AmtTltRdcInsPntInExc = "AmtTltRdcInsPntInExc";
            public const string AmtTtlToPayInsPntInExc = "AmtTtlToPayInsPntInExc";
            public const string AmtTltRdcDaPntInExc = "AmtTltRdcDaPntInExc";
            public const string AmtTtlRvnDaPntInExc = "AmtTtlRvnDaPntInExc";
            public const string AmtTtlToPaySvcPntInExc = "AmtTtlToPaySvcPntInExc";
            public const string AmtTtlToPayPntInExc = "AmtTtlToPayPntInExc";
            public const string VchDate = "VchDate";
            public const string TimePayOut = "TimePayOut";
            public const string Discount = "Discount";
            public const string BuyerLegalName = "BuyerLegalName";
            public const string BuyerTaxCode = "BuyerTaxCode";
            public const string BuyerAddressLine = "BuyerAddressLine";
            public const string DeptExamName = "DeptExamName";
            public const string DeptExamID = "DeptExamID";
            public const string PntExamNo = "PntExamNo";
            public const string VchDatePayOut = "VchDatePayOut";
            //public const string HspInNum = "HspInNum";
            public const string DeptExamPrkID = "DeptExamPrkID";
            public const string DateExam = "DateExam";
            public const string DateEndExam = "DateEndExam";
            public const string TimeEndExam = "TimeEndExam";
            public const string GuideTrmntID = "GuideTrmntID";
            public const string GuideTrmntName = "GuideTrmntName";
            public const string GuideTrmtID = "GuideTrmtID";
            public const string TranHspID = "TranHspID";
            public const string TranHspName = "TranHspName";
            public const string ModeTrmtID = "ModeTrmtID";
            public const string ModeTrmtName = "ModeTrmtName";
            public const string VchName = "VchName";
            public const string TimeInCure = "TimeInCure";
            public const string KqdtID = "KqdtID";
            public const string StateOutID = "StateOutID";
            public const string CountDayExam = "CountDayExam";
            public const string Advised = "Advised";
            public const string Treatments = "Treatments";
            public const string StateOut = "StateOut";
            public const string PntAttitude = "PntAttitude";
            public const string GuideNote = "GuideNote";
            public const string DeptName = "DeptName";
            public const string DeptQd5084ID = "DeptQd5084ID";
            public const string DoctorExamName = "DoctorExamName";
            public const string ClassNum = "ClassNum";
            public const string BedNum = "BedNum";

            #endregion

            #region Danh sach cac dich vu thuc hien
            public const string ItemFeeTypeName = "ItemFeeTypeName";

            public const string ItemFeeTypeID = "ItemFeeTypeID";

            public const string VchTypeID = "VchTypeID";

            public const string ItemPrkID = "ItemPrkID";

            public const string ItemID = "ItemID";

            public const string ItemName = "ItemName";

            public const string Unit = "Unit";

            public const string SvcInsTypeID = "SvcInsTypeID";

            public const string RdcObjRate = "RdcObjRate";

            public const string PayByPercent = "PayByPercent";

            public const string PriceSellCalcInsInExc = "PriceSellCalcInsInExc";

            public const string IsPntMustPayOverPercent = "IsPntMustPayOverPercent";

            public const string PntRdcObjPrkID = "PntRdcObjPrkID";

            //public const string InsNum = "InsNum";

            //public const string DateInsStart = "DateInsStart";

            //public const string DateInsEnd = "DateInsEnd";

            //public const string DateStartExam = "DateStartExam";

            //public const string DateEndExam = "DateEndExam";

            public const string Quantity = "Quantity";

            public const string PriceSellInExc = "PriceSellInExc";

            public const string AmtLineInExc = "AmtLineInExc";

            public const string AmtRdcLineInExc = "AmtRdcLineInExc";

            public const string AmtToPayLineInExc = "AmtToPayLineInExc";

            public const string AmtSvcLineInExc = "AmtSvcLineInExc";

            public const string AmtOverLineInExc = "AmtOverLineInExc";
            #endregion

            public class Table
            {
                public const string MdcFile_PayOutExam = "MdcFile_PayOutExam";
            }
        }
    }

    public class tagItems
    {
        // Danh muc chung Items
        #region MdnItems
        /// <summary>
        /// Danh muc chung item
        /// </summary>
        public class MdnItems
        {
            /// <summary>
            /// Khoa chinh
            /// </summary>
            public const string ItemPrkID = "ItemPrkID";
            /// <summary>
            /// 
            /// </summary>
            public const string ItemPubPrkID = "ItemPubPrkID";
            /// <summary>
            /// Ma item
            /// </summary>
            public const string ItemID = "ItemID";
            /// <summary>
            /// Ma nhom item cu
            /// </summary>
            public const string ItemOldGrpID = "ItemOldGrpID";
            /// <summary>
            /// Ma nhom item
            /// </summary>
            public const string ItemGrpID = "ItemGrpID";
            /// <summary>
            /// Ten item
            /// </summary>
            public const string ItemName = "ItemName";
            /// <summary>
            /// Don vi tinh
            /// </summary>
            public const string Unit = "Unit";
            /// <summary>
            /// 
            /// </summary>
            public const string ItemSncPrkID = "ItemSncPrkID";
            /// <summary>
            /// Ma nuoc san xuat
            /// </summary>
            public const string CntPrdctPrkID = "CntPrdctPrkID";
            /// <summary>
            /// Quoc gia san xuat
            /// </summary>
            public const string CntPrdctName = "CntPrdctName";
            /// <summary>
            /// Gia dau nhap kho
            /// </summary>
            public const string PriceBuyInExc = "PriceBuyInExc";
            /// <summary>
            /// Don gia ban
            /// </summary>
            public const string PriceSellInExc = "PriceSellInExc";
            /// <summary>
            /// Gia theo dich vu
            /// </summary>
            public const string PriceSvcInExc = "PriceSvcInExc";
            /// <summary>
            /// Cong thuc tinh tien don gia
            /// </summary>
            public const string FmlrPriceSell = "FmlrPriceSell";
            /// <summary>
            /// Cong thuc tinh tien theo Svc
            /// </summary>
            public const string FmlrPriceSvc = "FmlrPriceSvc";
            /// <summary>
            /// Xac dinh hang hoa
            /// </summary>
            public const string IsItemInStock = "IsItemInStock";
            /// <summary>
            /// Ngay cap nhat
            /// </summary>
            public const string DateUpdate = "DateUpdate";
            /// <summary>
            /// Xac dinh ngoai quoc
            /// </summary>
            public const string IsForeign = "IsForeign";
            /// <summary>
            /// Ma loai Svc
            /// </summary>
            public const string SvcInsTypeID = "SvcInsTypeID";
            /// <summary>
            /// Ty le thanh toan
            /// </summary>
            public const string SellRate = "SellRate";
            /// <summary>
            /// Xac dinh thuoc
            /// </summary>
            public const string IsDrug = "IsDrug";
            /// <summary>
            /// Ty le Svc
            /// </summary>
            public const string SvcRate = "SvcRate";
            /// <summary>
            /// Ma che do kham chua benh
            /// </summary>
            public const string ItemFncStylePrkID = "ItemFncStylePrkID";
            /// <summary>
            /// Loai thuoc
            /// </summary>
            public const string DrugTypeID = "DrugTypeID";
            /// <summary>
            /// Ghi chu
            /// </summary>
            public const string Note = "Note";
            /// <summary>
            /// Trang thai hoat dong
            /// </summary>
            public const string IsActive = "IsActive";
            /// <summary>
            /// Ten Rpt yeu cau
            /// </summary>
            public const string RptNameReq = "RptNameReq";
            /// <summary>
            /// Ten Rpt thuc hien
            /// </summary>
            public const string RptNamePfm = "RptNamePfm";
            /// <summary>
            /// Thu muc Rpt yeu cau
            /// </summary>
            public const string FileRptVchReq = "FileRptVchReq";
            /// <summary>
            /// Thu muc Rpt thuc hien
            /// </summary>
            public const string FileRptVchPfm = "FileRptVchPfm";
            ///// <summary>
            ///// Gia thanh toan Exc 4
            ///// </summary>
            //public const string PriceSellInExc_4 = "PriceSellInExc_4";
            ///// <summary>
            ///// Gia ban YTX
            ///// </summary>
            //public const string PriceSellInExc_YTX = "PriceSellInExc_YTX";
            /// <summary>
            /// Ham luong thuoc
            /// </summary>
            public const string DrugWeightOfMaterial = "DrugWeightOfMaterial";
            /// <summary>
            /// Dong goi thuoc
            /// </summary>
            public const string DrugTypeOfMaterial = "DrugTypeOfMaterial";
            /// <summary>
            /// 
            /// </summary>
            public const string RslFormType = "RslFormType";
            /// <summary>
            /// Ma BHYT item
            /// </summary>
            public const string ItemInsPrkID = "ItemInsPrkID";
            /// <summary>
            /// Ma BHYT mac dinh item
            /// </summary>
            public const string ItemInsDefaultPrkID = "ItemInsDefaultPrkID";
            /// <summary>
            /// Chi muc thong tu 37
            /// </summary>
            public const string ItemTt37Index = "ItemTt37Index";
            /// <summary>
            /// So dang ky
            /// </summary>
            public const string DrugRegNum = "DrugRegNum";
            /// <summary>
            /// Quy cach
            /// </summary>
            public const string DrugStyleDesign = "DrugStyleDesign";
            /// <summary>
            /// Ma Qd5084
            /// </summary>
            public const string ItemQd5084ID = "ItemQd5084ID";
            /// <summary>
            /// Gia thanh toan thang 3
            /// </summary>
            public const string PriceSellItemT32016InExc = "PriceSellItemT32016InExc";
            /// <summary>
            /// Gia thanh toan thang 7
            /// </summary>
            public const string PriceSellItemT72016InExc = "PriceSellItemT72016InExc";
            /// <summary>
            /// 
            /// </summary>
            public const string FlgOpenFormResult = "FlgOpenFormResult";
            /// <summary>
            /// Gia thanh toan Exc
            /// </summary>
            public const string PriceSellItemInExc = "PriceSellItemInExc";
            /// <summary>
            /// 
            /// </summary>
            public const string ItemCommercialName = "ItemCommercialName";
            /// <summary>
            /// 
            /// </summary>
            public const string MaterialID = "MaterialID";
            /// <summary>
            /// Nha san xuat
            /// </summary>
            public const string CompMadeName = "CompMadeName";
            /// <summary>
            /// Ten duong dung
            /// </summary>
            public const string WayUseName = "WayUseName";
            /// <summary>
            /// 
            /// </summary>
            public const string WayExptID = "WayExptID";
            /// <summary>
            /// 
            /// </summary>
            public const string ListDeptPfmPrkID = "ListDeptPfmPrkID";
            /// <summary>
            /// Ma loai phi BHYT
            /// </summary>
            public const string ItemFeeTypeInsID = "ItemFeeTypeInsID";
            /// <summary>
            /// Phan tram chi tra
            /// </summary>
            public const string PayByPercent = "PayByPercent";
            /// <summary>
            /// 
            /// </summary>
            public const string ItemSubFeeTypeID = "ItemSubFeeTypeID";
            /// <summary>
            /// Ma chuyen khoa
            /// </summary>
            public const string SpecialtiesPrkID = "SpecialtiesPrkID";
            /// <summary>
            /// Ma phuong phap thu thuat
            /// </summary>
            public const string PPTTID = "PPTTID";
            /// <summary>
            /// Anh xa ma loai tuong duong
            /// </summary>
            public const string ItemSubFeeTypeIDMapp = "ItemSubFeeTypeIDMapp";
            /// <summary>
            /// Ma don vi tinh lieu dung
            /// </summary>
            public const string UnitUseWayPrkID = "UnitUseWayPrkID";
            /// <summary>
            /// Ten don vi tinh lieu dung
            /// </summary>
            public const string UnitUseWayName = "UnitUseWayName";
            /// <summary>
            /// So luong toi da ke khai trong mot don thuoc
            /// </summary>
            public const string QuantityMaxOfDrug = "QuantityMaxOfDrug";
            /// <summary>
            /// Dich vu ky thuat cao
            /// </summary>
            public const string IsDVKTHight = "IsDVKTHight";
            /// <summary>
            /// Ky thuat thuc hien dich vu
            /// </summary>
            public const string Technology = "Technology";
            /// <summary>
            /// Mo ta ket qua thuc hien dich vu
            /// </summary>
            public const string Describe = "Describe";
            /// <summary>
            /// Ma card code
            /// </summary>
            public const string ItemCardCode = "ItemCardCode";
            /// <summary>
            /// Gia tran toi da BHYT thanh toan
            /// </summary>
            public const string PriceSellMaxInsInExc = "PriceSellMaxInsInExc";
            /// <summary>
            /// Đi kem goi dich vu PTTT
            /// </summary>
            public const string IsVtytInPttt = "IsVtytInPttt";
            /// <summary>
            /// Loai VTYT tinh toan rieng
            /// </summary>
            public const string IsVtytSpecial = "IsVtytSpecial";
            /// <summary>
            /// Xac dinh canh bao
            /// </summary>
            public const string IsWarning = "IsWarning";
            /// <summary>
            /// Ghi chu canh bao
            /// </summary>
            public const string NoteWarning = "NoteWarning";
            /// <summary>
            /// So ngay canh bao
            /// </summary>
            public const string ConditionCheck = "ConditionCheck";
            /// <summary>
            /// Xac dinh so luong dich vu
            /// </summary>
            public const string IsQuantity = "IsQuantity";
            /// <summary>
            /// Loại KQ
            /// </summary>
            public const string ResultsTypeID = "ResultsTypeID";
            /// Vật tư y tế tiêu hao 
            /// </summary>
            public const string VTYTTH = "VTYTTH";
            /// <summary>
            /// Xac dinh xet nghiem covid
            /// </summary>
            public const string IsCovid = "IsCovid";
            /// <summary>
            /// So phut hoan thanh dich vu
            /// </summary>
            public const string CompletedMinute = "CompletedMinute";
            /// <summary>
            /// Xac dinh dich vu phau thuat
            /// </summary>
            public const string IsPhauThuat = "IsPhauThuat";
            /// <summary>
            /// May thuc hien CLS
            /// </summary>
            public const string ListDevicePfm = "ListDevicePfm";
            /// <summary>
            /// Ten viet tat
            /// </summary>
            public const string ItemInitials = "ItemInitials";

            public class Table
            {
                public static List<string> ListFields = new List<string>() { ItemPrkID, ItemPubPrkID, ItemID, ItemOldGrpID, ItemGrpID, ItemName, Unit, ItemSncPrkID, CntPrdctPrkID, CntPrdctName, PriceBuyInExc, PriceSellInExc, PriceSvcInExc, FmlrPriceSell, FmlrPriceSvc, IsItemInStock, DateUpdate, IsForeign, SvcInsTypeID, SellRate, IsDrug, SvcRate, ItemFncStylePrkID, DrugTypeID, Note, IsActive, RptNameReq, RptNamePfm, FileRptVchReq, FileRptVchPfm, DrugWeightOfMaterial, DrugTypeOfMaterial, RslFormType, ItemInsPrkID, ItemInsDefaultPrkID, ItemTt37Index, DrugRegNum, DrugStyleDesign, ItemQd5084ID, PriceSellItemT32016InExc, PriceSellItemT72016InExc, FlgOpenFormResult, PriceSellItemInExc, ItemCommercialName, MaterialID, CompMadeName, WayUseName, WayExptID, ListDeptPfmPrkID, ItemFeeTypeInsID, PayByPercent, ItemSubFeeTypeID, SpecialtiesPrkID, UnitUseWayPrkID, UnitUseWayName, QuantityMaxOfDrug, IsDVKTHight, Technology, Describe, PriceSellMaxInsInExc, IsVtytInPttt, IsVtytSpecial, IsWarning, NoteWarning, ItemSubFeeTypeIDMapp/*, ConditionCheck*/, IsQuantity, ResultsTypeID, VTYTTH, IsCovid, CompletedMinute, IsPhauThuat, ListDevicePfm, ItemInitials };
                public const string Dm_MdnItems = TableNames.Dm_MdnItems;
            }
        }

        /// <summary>
        /// Dm gia
        /// </summary>
        public class MdnItemsPriceCost
        {
            public const string ItemPrkID = tagItems.MdnItems.ItemPrkID;
            public const string DateUpdatePriceCost = "DateUpdatePriceCost";
            public const string PriceCostTypePrkID = "PriceCostTypePrkID";
            public const string PriceBuyInExc = "PriceBuyInExc";
            public const string PriceSellInExc = "PriceSellInExc";
            public const string IsPriceSellAllTaxVat = "IsPriceSellAllTaxVat";
            public const string PriceSellRate = "PriceSellRate";
            public const string PriceSvcSellInExc = "PriceSvcSellInExc";
            public const string IsPriceSellEqualBuy = "IsPriceSellEqualBuy";
            public const string ItemPriceCostIsActive = "ItemPriceCostIsActive";
            public const string ListRdcObjPrkID = "ListRdcObjPrkID";
            /// <summary>
            /// Gia theo hang BV
            /// </summary>
            public const string RankHspPrice = "RankHspPrice";
            public class Table
            {
                public static List<string> ListFields = new List<string>() { ItemPrkID, DateUpdatePriceCost, PriceCostTypePrkID, PriceBuyInExc, PriceSellInExc, IsPriceSellAllTaxVat, PriceSellRate, PriceSvcSellInExc, IsPriceSellEqualBuy, ItemPriceCostIsActive, ListRdcObjPrkID, RankHspPrice };
                public const string Dm_MdnItemsPriceCost = TableNames.Dm_MdnItemsPriceCost;
            }
        }
        #endregion
        public class Psn
        {
            /// <summary>
            /// Ma khoa nhan vien
            /// </summary>
            public const string PsnPrkID = "PsnPrkID";
            /// <summary>
            /// Ma nhan vien
            /// </summary>
            public const string PsnID = "PsnID";
            /// <summary>
            /// Ten nhan vien
            /// </summary>
            public const string PsnName = "PsnName";
            /// <summary>
            /// Ngay sinh nhan vien
            /// </summary>
            public const string PsnBirthday = "PsnBirthday";
            /// <summary>
            /// Gioi tinh nhan vien
            /// </summary>
            public const string PsnSexID = "PsnSexID";
            /// <summary>
            /// Noi o nhan vien
            /// </summary>
            public const string PsnPlace = "PsnPlace";
            /// <summary>
            /// Ma dan toc nhan vien
            /// </summary>
            public const string PsnRaceID = "PsnRaceID";
            /// <summary>
            /// Ma khoa dan toc nhan vien
            /// </summary>
            public const string PsnRacePrkID = "PsnRacePrkID";
            /// <summary>
            /// Dia chi nhan vien
            /// </summary>
            public const string PsnAddr = "PsnAddr";
            /// <summary>
            /// Ma quoc gia nhan vien
            /// </summary>
            public const string PsnCountryID = "PsnCountryID";
            /// <summary>
            /// Ma khoa quoc gia nhan vien
            /// </summary>
            public const string PsnCountryPrkID = "PsnCountryPrkID";
            /// <summary>
            /// Chuc nang nhan vien
            /// </summary>
            public const string PsnFunction = "PsnFunction";
            /// <summary>
            /// So dien thoai nhan vien
            /// </summary>
            public const string PsnPhone = "PsnPhone";
            /// <summary>
            /// Email nhan viên
            /// </summary>
            public const string PsnEmail = "PsnEmail";
            /// <summary>
            /// Loai nhan vien
            /// </summary>
            public const string PsnTypeID = "PsnTypeID";
            /// <summary>
            /// Ma khoa khoa lam viec
            /// </summary>
            public const string DeptPrkID = "DeptPrkID";
            /// <summary>
            /// Ki hieu loai nhan vien
            /// </summary>
            public const string PsnTypeEnum = "PsnTypeEnum";
            /// <summary>
            /// Ten loai nhan vien
            /// </summary>
            public const string PsnTypeName = "PsnTypeName";
            /// <summary>
            /// Ngay bat dau cong viec
            /// </summary>
            public const string DateStartWork = "DateStartWork";
            /// <summary>
            /// Ngay ket thuc cong viec
            /// </summary>
            public const string DateStopWork = "DateStopWork";
            /// <summary>
            /// Ghi chu
            /// </summary>
            public const string Note = "Note";
            /// <summary>
            /// Trang thai
            /// </summary>
            public const string IsActive = "IsActive";
            /// <summary>
            /// Chuc vu
            /// </summary>
            public const string Chucvu = "Chucvu";
            /// <summary>
            /// Ngay vao dang
            /// </summary>
            public const string NgayVaoDang = "NgayVaoDang";
            /// <summary>
            /// Chuyen mon
            /// </summary>
            public const string ChuyenMon = "ChuyenMon";
            /// <summary>
            /// Chuyen nganh
            /// </summary>
            public const string ChuyenNganh = "ChuyenNganh";
            /// <summary>
            /// Giay phep hanh nghe
            /// </summary>
            public const string DocJobRegNum = "DocJobRegNum";
            /// <summary>
            /// Ma quan ly nhan vien
            /// </summary>
            public const string PsnCardID = "PsnCardID";
            /// <summary>
            /// Ma chuc nang
            /// </summary>
            public const string PsnFunctionCardID = "PsnFunctionCardID";
        }

        public class Age
        {
            public const string UnitAgeID = "UnitAgeID";

            public const string UnitAgeName = "UnitAgeName";
        }

        public class Dept
        {
            /// <summary>
            /// Khoa chinh khoa phong
            /// </summary>
            public const string DeptPrkID = "DeptPrkID";
            /// <summary>
            /// 
            /// </summary>
            public const string DeptPubPrkID = "DeptPubPrkID";
            /// <summary>
            /// Ma khoa phong
            /// </summary>
            public const string DeptID = "DeptID";
            /// <summary>
            /// Ten khoa phong
            /// </summary>
            public const string DeptName = "DeptName";
            /// <summary>
            /// Chuc nang khoa phong
            /// </summary>
            public const string DeptFunc = "DeptFunc";
            /// <summary>
            /// Loai khoa phong
            /// </summary>
            public const string DeptTypeID = "DeptTypeID";
            /// <summary>
            /// Ghi chu
            /// </summary>
            public const string Note = "Note";
            /// <summary>
            /// Trang thai hoat dong
            /// </summary>
            public const string IsActive = "IsActive";
            /// <summary>
            /// Ki hieu khoa phong
            /// </summary>
            public const string DeptSign = "DeptSign";
            /// <summary>
            /// Trang thai he thong
            /// </summary>
            public const string IsSystem = "IsSystem";
            /// <summary>
            /// ID che do KCB ap dung cho Khoa thuc hien
            /// </summary>
            public const string DeptFncStylePrkID = "DeptFncStylePrkID";
            /// <summary>
            /// ID che do KCB ap dung cho khoa
            /// </summary>
            public const string DeptExmStylePrkID = "DeptExmStylePrkID";
            /// <summary>
            /// Trang thai hien thi ghi chu
            /// </summary>
            public const string IsShowNoteVchDrug = "IsShowNoteVchDrug";
            /// <summary>
            /// Ma khoa phong QD5084
            /// </summary>
            public const string DeptQd5084ID = "DeptQd5084ID";
            /// <summary>
            /// Ma chuc nang kham chuyen khoa
            /// </summary>
            public const string DeptFuncExamID = "DeptFuncExamID";
            /// <summary>
            /// Danh sach chi phi khoa phong
            /// </summary>
            public const string ListItemFeePrkID = "ListItemFeePrkID";
            /// <summary>
            /// Ma loai chuc nang kham
            /// </summary>
            public const string FuncExamTypeID = "FuncExamTypeID";

            public const string CollectionDeptType = "CollectionDeptType";

            public const string ListBedH = "ListBedH";

            public const string ListBedT = "ListBedT";

            public const string ListBedC = "ListBedC";

            public const string ListBedK = "ListBedK";

            public const string ListFeeTypePfmID = "ListFeeTypePfmID";

            public const string ID = "ID";

            public const string Data = "Data";

            public class Table
            {
                public static List<string> ListFields = new List<string>() { };
                public const string Dm_Depts = TableNames.Dm_Depts;
            }
        }

        public class FuncExam
        {
            /// <summary>
            /// Ma chuc nang kham
            /// </summary>
            public const string FuncExamID = "FuncExamID";
            /// <summary>
            /// Ten chuc nang kham
            /// </summary>
            public const string FuncExamName = "FuncExamName";
            /// <summary>
            /// Loai chuc nang kham
            /// </summary>
            public const string FuncExamTypeID = "FuncExamTypeID";
            /// <summary>
            /// Chi phi mac dinh
            /// </summary>
            public const string ItemFeeDefaultPrkID = "ItemFeeDefaultPrkID";
            /// <summary>
            /// Chuyen mon
            /// </summary>
            public const string SpecialistPrkID = "SpecialistPrkID";
            /// <summary>
            /// Trang thai hoat dong
            /// </summary>
            public const string IsActive = "IsActive";
        }

        public class ItemSubType
        {
            public const string ItemSubTypeID = "ItemSubTypeID";

            public const string ItemSubTypeName = "ItemSubTypeName";

            public class Table
            {
                public static List<string> ListFields = new List<string>() { ItemSubTypeID, ItemSubTypeName };
                public const string Enum_PttSubTypes = TableNames.Enum_PttSubTypes;
            }
        }

        public class HISFunction
        {
            public const string SL = "SL";
            public const string CountExamInDept = "CountExamInDept";
        }
    }

    public class tagUploadFile
    {
        public const string Image = "Image";
        public const string CLSPntPrkID = "CLSPntPrkID";
        public const string FolderName = "FolderName";
        public const string FileName = "FileName";
    }

    public class tagVch
    {
        // Thong tin phau thu thuat
        #region PTTPnt
        public class PTTPnt
        {
            /// <summary>
            /// Khoa chinh 
            /// </summary>
            public const string VchPTTPntPrkID = "VchPTTPntPrkID";
            /// <summary>
            /// Ngay lap phieu
            /// </summary>
            public const string VchDate = "VchDate";
            /// <summary>
            /// Ma loai phieu
            /// </summary>
            public const string VchTypeID = "VchTypeID";
            /// <summary>
            /// Ten loai phieu
            /// </summary>
            public const string VchName = "VchName";
            /// <summary>
            /// So phieu
            /// </summary>
            public const string VchNo = "VchNo";
            /// <summary>
            /// Ma ho so benh an
            /// </summary>
            public const string MdcFilePrkID = "MdcFilePrkID";
            /// <summary>
            /// So vao benh vien
            /// </summary>
            public const string HspInNum = "HspInNum";
            /// <summary>
            /// Ma khoa yeu cau
            /// </summary>
            public const string DeptReqPrkID = "DeptReqPrkID";
            /// <summary>
            /// Ma bac si yeu cau
            /// </summary>
            public const string DoctorReqPrkID = "DoctorReqPrkID";
            /// <summary>
            /// Ma bac s thuc hien
            /// </summary>
            public const string DoctorPfmPrkID = "DoctorPfmPrkID";
            /// <summary>
            /// Trang thai thuc hien
            /// </summary>
            public const string StatusReq = "StatusReq";
            /// <summary>
            /// Ma hinh thuc dieu tri
            /// </summary>
            public const string ModeTrmtID = "ModeTrmtID";
            /// <summary>
            /// Ma chung tu goc (cha)
            /// </summary>
            public const string VchOrgID = "VchOrgID";
            /// <summary>
            /// Ma loai chung tu goc (cha)
            /// </summary>
            public const string VchOrgTypeID = "VchOrgTypeID";
            /// <summary>
            /// Noi dung yeu cau
            /// </summary>
            public const string ContentReq = "ContentReq";
            /// <summary>
            /// Ma khoa thuc hien
            /// </summary>
            public const string DeptPfmPrkID = "DeptPfmPrkID";
            /// <summary>
            /// Ma khoa ho so benh an
            /// </summary>
            public const string PntLogPrkID = "PntLogPrkID";
            /// <summary>
            /// Ten phieu in yeu cau
            /// </summary>
            public const string RptNameReq = "RptNameReq";
            /// <summary>
            /// Ten phieu in ket qua
            /// </summary>
            public const string RptNamePfm = "RptNamePfm";
            /// <summary>
            /// Thoi gian thuc hien
            /// </summary>
            public const string DateTimePfm = "DateTimePfm";
            /// <summary>
            /// Ma cap do PTT
            /// </summary>
            public const string LevelPrkID = "LevelPrkID";
            /// <summary>
            /// Ma doi tuong KCB
            /// </summary>
            public const string PntRdcObjPrkID = "PntRdcObjPrkID";
            /// <summary>
            /// Ma loai chi dinh phau thu thuat
            /// </summary>
            public const string PttSubTypeID = "PttSubTypeID";
            /// <summary>
            /// Gio phut yeu cau
            /// </summary>
            public const string TimeReq = "TimeReq";
            /// <summary>
            /// Ma chan doan
            /// </summary>
            public const string DgnPrkID = "DgnPrkID";
            /// <summary>
            /// Thoi gian hoan thanh
            /// </summary>
            public const string DateTimeEndPfm = "DateTimeEndPfm";
            /// <summary>
            /// Ma nhom PTT
            /// </summary>
            public const string PttPntGrpPrkID = "PttPntGrpPrkID";
            /// <summary>
            /// Ma ly do khong thuc hien PTT
            /// </summary>
            public const string StateCancelPfmID = "StateCancelPfmID";
            /// <summary>
            /// Chan doan
            /// </summary>
            public const string Diagnostic = "Diagnostic";
            /// <summary>
            /// THoi gian yeu cau
            /// </summary>
            public const string DateTimeReq = "DateTimeReq";
            /// <summary>
            /// Ma loai vo cam
            /// </summary>
            public const string VCID = "VCID";
            /// <summary>
            /// Ma loai phuong phap thu thuat 
            /// </summary>
            public const string PPTTID = "PPTTID";
            /// <summary>
            /// Ma chuyen khoa
            /// </summary>
            public const string SpecialtiesPrkID = "SpecialtiesPrkID";
            /// <summary>
            /// So ngay thuc hien
            /// </summary>
            public const string CountDayPfm = "CountDayPfm";
            /// <summary>
            /// So TT dong
            /// </summary>
            public const string ItemLine = "ItemLine";
            /// <summary>
            /// Ma phau thu thuat
            /// </summary>
            public const string ItemPrkID = "ItemPrkID";
            /// <summary>
            /// So luong
            /// </summary>
            public const string Quantity = "Quantity";
            /// <summary>
            /// Don gia phau thu thuat
            /// </summary>
            public const string PriceSellInExc = "PriceSellInExc";
            /// <summary>
            /// Tong tien
            /// </summary>
            public const string AmtLineInExc = "AmtLineInExc";
            /// <summary>
            /// Ghi chu
            /// </summary>
            public const string NoteLine = "NoteLine";
            /// <summary>
            /// Loai phi dich vu
            /// </summary>
            public const string SvcInsTypeID = "SvcInsTypeID";
            /// <summary>
            /// Trang thai phau thu thuat
            /// </summary>
            public const string StatusReqLine = "StatusReqLine";
            /// <summary>
            /// Ket qua
            /// </summary>
            public const string Result = "Result";

            /// <summary>
            /// Dien bien cua BN
            /// </summary>
            public const string ProgressionOfPnt = "ProgressionOfPnt";
            /// <summary>
            /// Mo ta phau thuat
            /// </summary>
            public const string DescribedSurgery = "DescribedSurgery";
            #region Fields Out Table
            public const string DeptReqName = "DeptReqName";

            public const string PntPrkID = "PntPrkID";

            public const string DoctorReqID = "DoctorReqID";

            public const string DoctorReqName = "DoctorReqName";

            public const string DoctorPfmID = "DoctorPfmID";

            public const string DoctorPfmName = "DoctorPfmName";

            public const string DoctorPfmPhone = "DoctorPfmPhone";

            public const string StatusReqName = "StatusReqName";

            public const string DeptPfmName = "DeptPfmName";

            public const string TagStoreTypeID = "TagStoreTypeID";

            public const string DeptReqID = "DeptReqID";

            public const string DeptPfmID = "DeptPfmID";

            public const string ItemFeeTypeID = "ItemFeeTypeID";


            public const string ListItemPrkID = "ListItemPrkID";
            #endregion

            public const string PayByPercent = "PayByPercent";

            public const string CardCode = "CardCode";

            public const string PPPTT = "PPPTT";
            /// <summary>
            /// Khoa chinh Bac si gay te, gay me
            /// </summary>
            public const string PsnAnesthesiaPrkID = "PsnAnesthesiaPrkID";
            /// <summary>
            /// Ten Bac si gay te, gay me
            /// </summary>
            public const string PsnAnesthesiaName = "PsnAnesthesiaName";
            /// <summary>
            /// Khoa chinh PTT vien phu
            /// </summary>
            public const string PsnPTTSubPrkID = "PsnPTTSubPrkID";
            /// <summary>
            /// Ten PTT vien phu
            /// </summary>
            public const string PsnPTTSubName = "PsnPTTSubName";
            /// <summary>
            /// Khoa chinh Bac si gay te, gay me phu
            /// </summary>
            public const string PsnAnesthesiaSubPrkID = "PsnAnesthesiaSubPrkID";
            /// <summary>
            /// Ten Bac si gay te, gay me phu
            /// </summary>
            public const string PsnAnesthesiaSubName = "PsnAnesthesiaSubName";
            /// <summary>
            /// Khoa chinh PTT chinh
            /// </summary>
            public const string PsnPTTMainPrkID = "PsnPTTMainPrkID";
            /// <summary>
            /// Ten PTT chinh
            /// </summary>
            public const string PsnPTTMainName = "PsnPTTMainName";
            /// <summary>
            /// Khoa chinh Nguoi phu mo
            /// </summary>
            public const string PsnSurgeryPrkID = "PsnSurgeryPrkID";
            /// <summary>
            /// Ten Nguoi phu mo
            /// </summary>
            public const string PsnSurgeryName = "PsnSurgeryName";
            /// <summary>
            /// Khoa chinh Nguoi giup viec
            /// </summary>
            public const string PsnHelperPrkID = "PsnHelperPrkID";
            /// <summary>
            /// Ten Nguoi giup viec
            /// </summary>
            public const string PsnHelperName = "PsnHelperName";

            public const string ItemIndex = "ItemIndex";

            public const string DateTimeUpdate = "DateTimeUpdate";
            public const string ComputerName = "ComputerName";
            public const string ComputerIP = "ComputerIP";
            public const string UserWriteID = "UserWriteID";
            public const string Method = "Method";
            public const string IndexPrkID = "IndexPrkID";
            public const string ItemPrkIDUpdate = "ItemPrkIDUpdate";
            public const string QuantityUpdate = "QuantityUpdate";
            public const string CountPfmMinu = "CountPfmMinu";

            public class Table
            {
                public static List<string> FieldsH = new List<string> { VchPTTPntPrkID, VchDate, VchTypeID, VchName, VchNo, MdcFilePrkID, HspInNum, DeptReqPrkID, DoctorReqPrkID, DoctorPfmPrkID, StatusReq, ModeTrmtID, VchOrgID, VchOrgTypeID, ContentReq, DeptPfmPrkID, PntLogPrkID, RptNameReq, RptNamePfm, DateTimePfm, LevelPrkID, PntRdcObjPrkID, PttSubTypeID, TimeReq, DgnPrkID, DateTimeEndPfm, PttPntGrpPrkID, StateCancelPfmID, Diagnostic, DateTimeReq, VCID, ProgressionOfPnt, DescribedSurgery, CardCode, PPPTT, PsnAnesthesiaPrkID, PsnAnesthesiaName, PsnPTTSubPrkID, PsnPTTSubName, PsnAnesthesiaSubPrkID, PsnPTTMainPrkID, PsnSurgeryPrkID, PsnHelperPrkID };
                public static List<string> FieldsL = new List<string> { VchPTTPntPrkID, ItemLine, ItemPrkID, Quantity, PriceSellInExc, AmtLineInExc, NoteLine, SvcInsTypeID, PntRdcObjPrkID, StatusReqLine, Result, PayByPercent };
                public static List<string> FieldsHLog = new List<string> { VchPTTPntPrkID, VchDate, VchTypeID, VchName, VchNo, MdcFilePrkID, HspInNum, DeptReqPrkID, DoctorReqPrkID, DoctorPfmPrkID, StatusReq, ModeTrmtID, VchOrgID, VchOrgTypeID, ContentReq, DeptPfmPrkID, PntLogPrkID, RptNameReq, RptNamePfm, DateTimePfm, LevelPrkID, PntRdcObjPrkID, PttSubTypeID, TimeReq, DgnPrkID, DateTimeEndPfm, PttPntGrpPrkID, StateCancelPfmID, Diagnostic, DateTimeReq, VCID, ProgressionOfPnt, DescribedSurgery, CardCode, PPPTT, PsnAnesthesiaPrkID, PsnAnesthesiaName, PsnPTTSubPrkID, PsnPTTSubName, PsnAnesthesiaSubPrkID, PsnPTTMainPrkID, PsnSurgeryPrkID, PsnHelperPrkID, DateTimeUpdate, ComputerName, ComputerIP, UserWriteID, Method };
                public static List<string> FieldsLLog = new List<string> { IndexPrkID, VchPTTPntPrkID, ItemLine, ItemPrkID, Quantity, PriceSellInExc, AmtLineInExc, NoteLine, SvcInsTypeID, PntRdcObjPrkID, StatusReqLine, Result, PayByPercent, ItemPrkIDUpdate, QuantityUpdate };
                public const string VchPTTPntHeader = TableNames.VchPTTPntHeader;
                public const string VchPTTPntLine = TableNames.VchPTTPntLine;
            }

            public class Header
            {
                public const string VchPTTPntPrkID = "VchPTTPntPrkID";
                public const string VchDate = "VchDate";
                public const string VchTypeID = "VchTypeID";
                public const string VchName = "VchName";
                public const string VchNo = "VchNo";
                public const string MdcFilePrkID = "MdcFilePrkID";
                public const string HspInNum = "HspInNum";
                public const string DeptReqPrkID = "DeptReqPrkID";
                public const string DoctorReqPrkID = "DoctorReqPrkID";
                public const string DoctorPfmPrkID = "DoctorPfmPrkID";
                public const string StatusReq = "StatusReq";
                public const string ModeTrmtID = "ModeTrmtID";
                public const string VchOrgID = "VchOrgID";
                public const string VchOrgTypeID = "VchOrgTypeID";
                public const string ContentReq = "ContentReq";
                public const string DeptPfmPrkID = "DeptPfmPrkID";
                public const string PntLogPrkID = "PntLogPrkID";
                public const string LevelPrkID = "LevelPrkID";
                public const string RptNameReq = "RptNameReq";
                public const string RptNamePfm = "RptNamePfm";
                public const string DatetimePfm = "DatetimePfm";
                public const string PntRdcObjPrkID = "PntRdcObjPrkID";
                public const string PttSubTypeID = "PttSubTypeID";
                public const string TimeReq = "TimeReq";
                public const string DgnPrkID = "DgnPrkID";
                public const string DateTimeEndPfm = "DateTimeEndPfm";
                public const string PttPntGrpPrkID = "PttPntGrpPrkID";
                public const string StateCancelPfmID = "StateCancelPfmID";
                public const string Diagnostic = "Diagnostic";
                public const string DateTimeReq = "DateTimeReq";
                public const string SpecialtiesPrkID = "SpecialtiesPrkID";
                public const string PPTTID = "PPTTID";
                public const string VCID = "VCID";
                public const string ProgressionOfPnt = "ProgressionOfPnt";
                public const string DescribedSurgery = "DescribedSurgery";
                public const string PsnAnesthesiaPrkID = "PsnAnesthesiaPrkID";
                public const string PsnPTTSubPrkID = "PsnPTTSubPrkID";
                public const string DateTimeScanCard = "DateTimeScanCard";
            }

            public class Line
            {
                public const string VchPTTPntPrkID = PTTPnt.VchPTTPntPrkID;
                public const string ItemLine = PTTPnt.ItemLine;
                public const string ItemPrkID = PTTPnt.ItemPrkID;
                public const string Quantity = PTTPnt.Quantity;
                public const string PriceSellInExc = PTTPnt.PriceSellInExc;
                public const string AmtLineInExc = PTTPnt.AmtLineInExc;
                public const string NoteLine = PTTPnt.NoteLine;
                public const string SvcInsTypeID = PTTPnt.SvcInsTypeID;
                public const string StatusReqLine = PTTPnt.StatusReqLine;
                public const string PntRdcObjItemPrkID = "PntRdcObjItemPrkID";
                public const string Result = PTTPnt.Result;

            }
        }

        #endregion

        #region DrugPnt
        public class DrugPnt
        {
            public const string VchDrugPntPrkID = "VchDrugPntPrkID";
            public const string VchDate = "VchDate";

            /// <summary>
            /// Ngay chung tu cu
            /// </summary>
            public const string VchDateOld = "VchDateOld";

            public const string VchTypeID = "VchTypeID";
            public const string VchName = "VchName";
            public const string VchNo = "VchNo";
            public const string DeptReqPrkID = "DeptReqPrkID";
            public const string DeptTypeReqID = "DeptTypeReqID";

            /// <summary>
            /// Khoa yeu cau truoc khi sua doi
            /// </summary>
            public const string DeptOldReqPrkID = "DeptOldReqPrkID";

            public const string DeptReqName = "DeptReqName";
            public const string DeptReqID = "DeptReqID";
            public const string IsDrugHome = "IsDrugHome";
            public const string PntPrkID = "PntPrkID";
            public const string SvcInsTypeID = "SvcInsTypeID";

            public const string MdcFilePrkID = "MdcFilePrkID";
            public const string PntLogPrkID = "PntLogPrkID";
            public const string HspInNum = "HspInNum";
            public const string DoctorReqPrkID = "DoctorReqPrkID";
            public const string DoctorReqName = "DoctorReqName";
            public const string DoctorPfmPrkID = "DoctorPfmPrkID";
            public const string DoctorPfmName = "DoctorPfmName";
            public const string PsnRecName = "PsnRecName";

            public const string PsnRecID = "PsnRecID";

            /// <summary>
            /// Nguoi nhan
            /// </summary>
            public const string PsnRecPrkID = "PsnRecPrkID";

            /// <summary>
            /// Xac dinh phieu cap thuoc dong y hay tay y
            /// </summary>
            public const string IsPharmacy = "IsPharmacy";
            /// <summary>
            /// Nguoi giao
            /// </summary>
            public const string PsnRelsPrkID = "PsnRelsPrkID";
            /// <summary>
            /// Nguoi giao
            /// </summary>
            public const string PsnRelsName = "PsnRelsName";

            /// <summary>
            /// Nguoi giao
            /// </summary>
            public const string PsnRelsID = "PsnRelsID";

            public const string ContentReq = "ContentReq";
            public const string StatusReq = "StatusReq";
            public const string StatusReqName = "StatusReqName";

            public const string ModeTrmtID = "ModeTrmtID";
            public const string TagStoreTypeID = "TagStoreTypeID";
            public const string ItemLine = "ItemLine";
            public const string ItemPrkID = "ItemPrkID";

            public const string PntRdcObjPrkID = "PntRdcObjPrkID";

            /// <summary>
            /// ID Khoa thuc hien
            /// </summary>
            public const string DeptPfmPrkID = "DeptPfmPrkID";

            /// <summary>
            /// Khoa thuc hien truoc khi sua doi
            /// </summary>
            public const string DeptOldPfmPrkID = "DeptOldPfmPrkID";

            public const string DeptPfmName = "DeptPfmName";

            /// <summary>
            /// Id che do KCB ap dung cho Kho y te
            /// </summary>
            public const string StoreFncStylePrkID = "StoreFncStylePrkID";

            /// <summary>
            /// Che do Kcb ap dung kho khoa thuc hien
            /// </summary>
            public const string DeptFncStylePrkID = tagItems.Dept.DeptFncStylePrkID;

            /// <summary>
            /// ID che do KCB ap dung cho ma dich vu dang su dung
            /// </summary>
            public const string ItemFncStylePrkID = tagItems.MdnItems.ItemFncStylePrkID;

            /// <summary>
            /// Loai mat hang co ton kho hay ko
            /// </summary>
            public const string IsItemInstock = tagItems.MdnItems.IsItemInStock;

            /// <summary>
            /// So luong
            /// </summary>
            public const string Quantity = "Quantity";
            /// <summary>
            /// Don gia
            /// </summary>
            public const string PriceSellInExc = "PriceSellInExc";

            public const string PrimeCostInExc = "PrimeCostInExc";

            /// <summary>
            /// Thanh Tien
            /// </summary>
            public const string AmtLineInExc = "AmtLineInExc";
            /// <summary>
            /// Tổng cộng
            /// </summary>
            public const string AmtTtlLineInExc = "AmtTtlLineInExc";


            /// <summary>
            /// Ghi chú
            /// </summary>
            public const string NoteLine = "NoteLine";
            /// <summary>
            /// Nhom
            /// </summary>
            public const string ItemGrpID = tagItems.MdnItems.ItemGrpID;
            /// <summary>
            /// Ma y te
            /// </summary>
            public const string ItemID = tagItems.MdnItems.ItemID;
            /// <summary>
            /// Ten y te
            /// </summary>
            public const string ItemName = tagItems.MdnItems.ItemName;
            /// <summary>
            /// Don vi tinh
            /// </summary>
            public const string Unit = tagItems.MdnItems.Unit;

            public const string StorePrkID = "StorePrkID";

            /// <summary>
            /// Kho struoc khi sua doi
            /// </summary>
            public const string StoreOldPrkID = "StoreOldPrkID";

            public const string VchOrgID = "VchOrgID";
            public const string VchOrgTypeID = "VchOrgTypeID";
            public const string DateTimePfm = "DateTimePfm";

            /// <summary>
            /// Loai don nhan thuoc vat tu
            /// </summary>
            public const string VchMdnSubTypeID = "VchMdnSubTypeID";

            /// <summary>
            /// Loai don nhan thuoc vat tu truoc khi sua doi
            /// </summary>
            public const string VchOldMdnSubTypeID = "VchOldMdnSubTypeID";

            /// <summary>
            /// Don gia dich vu
            /// </summary>
            public const string PriceSvcInExc = "PriceSvcInExc";

            /// <summary>
            /// Thanh tien dich vu
            /// </summary>
            public const string AmtLineSvcInExc = "AmtLineSvcInExc";

            public const string CountPack = "CountPack";
            public const string QtyInPack = "QtyInPack";
            public const string CountPackLine = "CountPackLine";
            public const string Agree = "Agree";
            public const string DateUseDrug = "DateUseDrug";


            public const string JrnVchDrugPrkID = "JrnVchDrugPrkID";
            public const string EditTypeID = "EditTypeID";
            public const string VchDateEdit = "VchDateEdit";
            public const string DeptReqEditPrkID = "DeptReqEditPrkID";
            public const string Verb = "Verb";
            public const string Noun = "Noun";

            public const string VchOrgNo = "VchOrgNo";

            public const string TagStore = "TagStore";

            /// <summary>
            /// Xac dinh co kiem tra tinh hop le cua phieu khong
            /// </summary>
            public const string IsSyncData = "IsSyncData";


            public const string Useway = "Useway";
            public const string Morning = "Morning";
            public const string Noon = "Noon";
            public const string Afternoon = "Afternoon";
            public const string Evening = "Evening";

            public const string IsSyncVchDrug = "IsSyncVchDrug";

            /// <summary>
            /// Id chung tu cu
            /// </summary>
            public const string VchOldID = "VchOldID";

            /// <summary>
            /// Loai chung tu cu
            /// </summary>
            public const string VchOldTypeID = "VchOldTypeID";

            /// <summary>
            /// Xac dinh chung tu cu co phai loai chi phi tieu hao khong
            /// </summary>
            public const string IsOldVchExpDrug = "IsOldVchExpDrug";

            /// <summary>
            /// Xac dinh co phai loai chi phi tieu hao ko
            /// </summary>
            public const string IsExpDrug = "IsExpDrug";

            /// <summary>
            /// Xac dinh kiem tra dulieu truoc khi del. False : bo qua khong kiem tra
            /// </summary>
            public const string IsCheckValidBeforDel = "IsCheckValidBeforDel";

            public const string DeptPfmID = "DeptPfmID";

            public const string VchOrgDate = "VchOrgDate";

            public const string QuantityReader = "QuantityReader";

            public const string DgnPrkID = "DgnPrkID";

            /// <summary>
            /// Ngay yeu cau
            /// </summary>
            public const string DateTimeReq = "DateTimeReq";

            /// <summary>
            /// Thoi gian dung buoi sang
            /// </summary>
            public const string HourMorning = "HourMorning";

            /// <summary>
            /// Thoi gian dung buoi trua
            /// </summary>
            public const string HourNoon = "HourNoon";

            /// <summary>
            /// Thoi gian dung buoi chieu
            /// </summary>
            public const string HourAfterNoon = "HourAfterNoon";

            /// <summary>
            /// Thoi gian dung buoi toi
            /// </summary>
            public const string HourEverning = "HourEverning";

            /// <summary>
            /// Xac dinh don gia ban sua doi khong bang gia ton
            /// </summary>
            public const string IsEditPriceSell = "IsEditPriceSell";

            public const string TimeReq = "TimeReq";

            /// <summary>
            /// So lan su dung trong ngay
            /// </summary>
            public const string CountTimesUseInday = "CountTimesUseInday";

            /// <summary>
            /// So luong su dung trong ngay
            /// </summary>
            public const string QtyUseInday = "QtyUseInday";

            public const string DateTime = "DateTime";
            /// <summary>
            /// MA thuoc Gay te dung trong PTT Gay te
            /// </summary>
            public const string MA_THUOC_GT = "MA_THUOC_GT";
            /// <summary>
            /// Ngay dung thuoc thu
            /// </summary>
            public const string DateUseDrugLine = "DateUseDrugLine";
            /// <summary>
            /// List VchDrugPntPrkID
            /// </summary>
            public const string ListVchDrugPntPrkID = "ListVchDrugPntPrkID";
            /// <summary>
            /// Trang thai don thuoc duoc ke o to dieu tri
            /// NULL: khong ke o to dieu tri
            /// 0: ke o to dieu tri
            /// 1: duoc tong hop o don le
            /// </summary>
            public const string IsTreatmentDrug = "IsTreatmentDrug";
            public class Table
            {
                /*Chu y:
                 * Trong Db co Field ModeTrmtID nhung ko dung Field nay.
                 * 
                 */
                public static List<string> ListFieldH = new List<string> {VchDrugPntPrkID, VchDate, VchTypeID, VchName, VchNo, MdcFilePrkID, HspInNum, DeptReqPrkID, DeptPfmPrkID, DoctorReqPrkID, DoctorPfmPrkID,
                      StatusReq, TagStoreTypeID, StorePrkID, VchOrgID, VchOrgTypeID, ContentReq, PsnRelsPrkID, PntLogPrkID, CountPack, IsPharmacy, VchMdnSubTypeID, PsnRecPrkID,
                       DateUseDrug, IsDrugHome, TagStore, DateTimePfm,  DgnPrkID, DateTimeReq, PntRdcObjPrkID, ModeTrmtID, IsTreatmentDrug };

                public static List<string> ListFieldL = new List<string> { VchDrugPntPrkID, ItemLine, ItemPrkID, SvcInsTypeID, Quantity, PriceSellInExc, PrimeCostInExc, AmtLineInExc, PriceSvcInExc, AmtLineSvcInExc, NoteLine,
                      QtyInPack, CountPackLine, Useway, Morning, Noon, Afternoon, Evening, HourMorning,  HourNoon,  HourAfterNoon, HourEverning, MA_THUOC_GT, DateUseDrugLine};

                public const string VchDrugPntHeader = TableNames.VchDrugPntHeader;
                public const string VchDrugPntLine = TableNames.VchDrugPntLine;
            }

            public class View
            {
                /// <summary>
                /// Ngay dung thuoc tu
                /// </summary>
                public const string DateUseFrom = "DateUseFrom";

                /// <summary>
                /// Ngay dung thuoc den
                /// </summary>
                public const string DateUseTo = "DateUseTo";

                public const string QtyReader = "QtyReader";

                public const string AmtTltReader = "AmtTltReader";

                public const string VchID = "VchID";

                /// <summary>
                /// Xac dinh co phai toa thuoc cua so len thuoc khong
                /// </summary>
                public const string IsToaOfVchDrugInDept = "IsToaOfVchDrugInDept";

            }

            public class Header
            {
                public const string VchDrugPntPrkID = DrugPnt.VchDrugPntPrkID;
                public const string VchDate = DrugPnt.VchDate;
                public const string VchTypeID = DrugPnt.VchTypeID;
                public const string VchName = DrugPnt.VchName;
                public const string VchNo = DrugPnt.VchNo;
                public const string MdcFilePrkID = DrugPnt.MdcFilePrkID;
                public const string HspInNum = DrugPnt.HspInNum;
                public const string DeptReqPrkID = DrugPnt.DeptReqPrkID;
                public const string DeptPfmPrkID = DrugPnt.DeptPfmPrkID;
                public const string DoctorReqPrkID = DrugPnt.DoctorReqPrkID;
                public const string DoctorPfmPrkID = DrugPnt.DoctorPfmPrkID;
                public const string StatusReq = DrugPnt.StatusReq;
                public const string TagStoreTypeID = DrugPnt.TagStoreTypeID;
                public const string StorePrkID = DrugPnt.StorePrkID;
                public const string VchOrgID = DrugPnt.VchOrgID;
                public const string VchOrgTypeID = DrugPnt.VchOrgTypeID;
                public const string ContentReq = DrugPnt.ContentReq;
                public const string PsnRelsPrkID = DrugPnt.PsnRelsPrkID;
                public const string PntLogPrkID = DrugPnt.PntLogPrkID;
                public const string CountPack = DrugPnt.CountPack;
                public const string IsPharmacy = DrugPnt.IsPharmacy;
                public const string VchMdnSubTypeID = DrugPnt.VchMdnSubTypeID;
                public const string PsnRecPrkID = DrugPnt.PsnRecPrkID;
                public const string DateUseDrug = DrugPnt.DateUseDrug;
                public const string IsDrugHome = DrugPnt.IsDrugHome;
                public const string TagStore = DrugPnt.TagStore;
                public const string DateTimePfm = DrugPnt.DateTimePfm;
                public const string PntRdcObjPrkID = DrugPnt.PntRdcObjPrkID;
                public const string TimeReq = DrugPnt.TimeReq;
                public const string DgnPrkID = DrugPnt.DgnPrkID;
                public const string DateTimeReq = DrugPnt.DateTimeReq;

            }
            public class Line
            {
                public const string VchDrugPntPrkID = DrugPnt.VchDrugPntPrkID;
                public const string ItemLine = DrugPnt.ItemLine;
                public const string ItemPrkID = DrugPnt.ItemPrkID;
                public const string SvcInsTypeID = DrugPnt.SvcInsTypeID;
                public const string Quantity = DrugPnt.Quantity;
                public const string PriceSellInExc = DrugPnt.PriceSellInExc;
                public const string PrimeCostInExc = DrugPnt.PrimeCostInExc;
                public const string AmtLineInExc = DrugPnt.AmtLineInExc;
                public const string PriceSvcInExc = DrugPnt.PriceSvcInExc;
                public const string AmtLineSvcInExc = DrugPnt.AmtLineSvcInExc;
                public const string NoteLine = DrugPnt.NoteLine;
                public const string QtyInPack = DrugPnt.QtyInPack;
                public const string CountPackLine = DrugPnt.CountPackLine;
                public const string Useway = DrugPnt.Useway;
                public const string Morning = DrugPnt.Morning;
                public const string Noon = DrugPnt.Noon;
                public const string Afternoon = DrugPnt.Afternoon;
                public const string Evening = DrugPnt.Evening;
                //public const string HourMorning = DrugPnt.HourMorning;
                //public const string HourNoon = DrugPnt.HourNoon;
                //public const string HourAferNoon = DrugPnt.HourAferNoon;
                //public const string HourEverning = DrugPnt.HourEverning;
                public const string HourMorning = DrugPnt.HourMorning;
                //public const string HourMorningTo = DrugPnt.HourMorningTo;
                public const string HourNoon = DrugPnt.HourNoon;
                //public const string HourNoonTo = DrugPnt.HourNoonTo;
                public const string HourAfterNoon = DrugPnt.HourAfterNoon;
                //public const string HourAfterNoonTo = DrugPnt.HourAfterNoonTo;
                public const string HourEverning = DrugPnt.HourEverning;
                //public const string HourEverningTo = DrugPnt.HourEverningTo;
                public const string IsEditPriceSell = DrugPnt.IsEditPriceSell;
                public const string MA_THUOC_GT = DrugPnt.MA_THUOC_GT;
                public const string DateUseDrugLine = DrugPnt.DateUseDrugLine;

            }
        }
        #endregion
    }

    public class HspExamSchedule
    {
        public class LoginRequest
        {
            public const string UserExamID = "UserExamID";
            public const string UserExamPass = "UserExamPass";
        }
        public class RegisterESRequest
        {
            public const string UserExamID  = "UserExamID";
            public const string UserExamPass  = "UserExamPass";
            public const string UserExamName  = "UserExamName";
            public const string UserExamEmail  = "UserExamEmail";
            public const string UserExamPhone  = "UserExamPhone";
        }
    }

    public class RFID
    {
        public const string StatusCode = "StatusCode";
        public const string Data = "Data";
        public const string DeviceID = "DeviceID";
        public const string ID ="ID";
    }

    public class tagRegExam
    {
        public const string StatusCode = "StatusCode";
        public const string DoctorID = "DoctorID";
        public const string FullName = "FullName";
        public const string Phone = "Phone";
        public const string Gender = "Gender";
        public const string Birthday = "Birthday";
        public const string Email = "Email";
        public const string Address = "Address";
        public const string InsuranceNumber = "";
        public const string DateInsStart = "InsuranceNumber";
        public const string DateInsEnd = "DateInsEnd";
        public const string MaKCBBD = "MaKCBBD";
        public const string Date = "Date";
        public const string Time = "Time";
        public const string HspInsID = "HspInsID";
        public const string TextArea = "TextArea";
        public const string Order = "Order";
        public const string NameBook = "NameBook";
        public const string AddressBook = "AddressBook";
        public const string TownWardBook = "TownWardBook";
        public const string DistrictBook = "DistrictBook";
        public const string ProvinceBook = "ProvinceBook";
        public const string Service = "Service";
        public const string Price = "Price";
        public const string Data = "Data";
    }
}
