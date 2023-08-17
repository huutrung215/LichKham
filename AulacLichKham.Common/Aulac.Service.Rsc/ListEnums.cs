namespace Aulac.Service.Rsc
{
    public enum Status
    {
        /// <summary>
        /// Loi
        /// </summary>
        Error = 0,
        /// <summary>
        /// Thanh cong
        /// </summary>
        Success = 1,
        /// <summary>
        /// Canh bao
        /// </summary>
        Warning = 2
    }

    /// <summary>
    /// Loai nhap vien
    /// </summary>
    public enum ObjExamTypes
    {
        /// <summary>
        /// Khong xac dinh
        /// </summary>
        None = 0,

        /// <summary>
        /// Kcb dung tuyen
        /// </summary>
        KcbDgTuyen = 1,

        /// <summary>
        /// Cap cuu
        /// </summary>
        CapCuu = 2,

        /// <summary>
        /// Trai Tuyen
        /// </summary>
        TraiTuyen = 3,

        /// <summary>
        ///Thong tuyen
        /// </summary>
        ThongTuyen = 4,

        /// <summary>
        /// Benh nhan Chuyen tuyen KCB co giay chuyen tuyen
        /// </summary>
        ChuyenTuyen = 5,

        /// <summary>
        /// Vien Phi
        /// </summary>
        VienPhi = 6,

        /// <summary>
        /// Linh thuoc ngoai vien do truong hop bat kha khang (Benh Lao)
        /// </summary>
        ChuongtrinhDa = 7,
        /// <summary>
        /// Hen tai kham
        /// </summary>
        Hentaikham = 8
    }
}