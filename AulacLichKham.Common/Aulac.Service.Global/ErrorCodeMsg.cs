namespace Aulac.Service.Global
{
    public class ErrorCodeMsg
    {
        /// <summary>
        /// Thanh cong
        /// </summary>
        public const string R000 = "000";

        /// <summary>
        /// The BHYT do bo quoc phong quan ly
        /// The do BHXH Bo Quoc Phong quan ly, de nghi kiem tra the va thong tin giay to tuy than
        /// </summary>
        public const string R001 = "001";

        /// <summary>
        /// The BHYT do bo cong an quan ly
        /// The do BHXH Bo Cong An quan ly, de nghi kiem tra the va thong tin giay to tuy than
        /// </summary>
        public const string R002 = "002";

        /// <summary>
        /// The cu het gia tri su dung nhung da duoc cap the moi
        /// </summary>
        public const string R003 = "003";

        /// <summary>
        /// The cu con gia tri su dung nhung da duoc cap the moi
        /// </summary>
        public const string R004 = "004";

        /// <summary>
        /// Thieu thong tin
        /// </summary>
        public const string R005 = "005";

        /// <summary>
        /// Thong tin dat lich kham gan nhat chua kham tai benh vien! Vui long kiem tra lai danh sach dat lich
        /// </summary>
        public const string R006 = "006";

        /// <summary>
        /// Thong tin dat lich chua hoan tat kham tai benh vien! Lien he quan tri vien de biet them chi tiet
        /// </summary>
        public const string R007 = "007";

        /// <summary>
        /// Ngay dat lich khong nam trong thoi han the BHXH
        /// </summary>
        public const string R008 = "008";

        /// <summary>
        /// Thong tin dat lich khong ton tai
        /// </summary>
        public const string R009 = "009";

        /// <summary>
        /// The het han su dung
        /// </summary>
        public const string R010 = "010";

        /// <summary>
        /// Ban da thuc hien kham benh tai don vi khong the huy lich kham
        /// </summary>
        public const string R011 = "011";

        /// <summary>
        /// Lich dat dang cho xac nhan
        /// </summary>
        public const string R012 = "012";

        /// <summary>
        /// Lich dat da duoc xac nhan
        /// </summary>
        public const string R013 = "013";

        /// <summary>
        /// Lich dat da duoc huy
        /// </summary>
        public const string R014 = "014";

        /// <summary>
        /// So nguoi dat lich da het vui long chon thoi gian khac
        /// </summary>
        public const string R015 = "015";

        /// <summary>
        /// Ma the khong dung
        /// </summary>
        public const string R051 = "051";

        /// <summary>
        /// Ma tinh cap the (Ky tu 4,5 cua the) khong dung
        /// </summary>
        public const string R052 = "052";

        /// <summary>
        /// Ma quyen loi (Ky tu 3, cua the) khong dung
        /// </summary>
        public const string R053 = "053";

        /// <summary>
        /// Khong tim thay thong tin the BHYT
        /// </summary>
        public const string R050 = "050";

        /// <summary>
        /// The sai ho ten
        /// </summary>
        public const string R060 = "060";

        /// <summary>
        /// The sai ho ten (dung ky tu dau)
        /// </summary>
        public const string R061 = "061";

        /// <summary>
        /// The sai ngay sinh
        /// </summary>
        public const string R070 = "070";

        /// <summary>
        /// The sai gioi tinh
        /// </summary>
        public const string R080 = "080";

        /// <summary>
        /// The sai noi dang ky KCB ban dau
        /// </summary>
        public const string R090 = "090";

        /// <summary>
        /// Loi sai du lieu the
        /// </summary>
        public const string R100 = "100";

        /// <summary>
        /// Loi server
        /// </summary>
        public const string R101 = "101";

        /// <summary>
        /// The da thu hoi
        /// </summary>
        public const string R110 = "110";

        /// <summary>
        /// The da bao giam
        /// </summary>
        public const string R120 = "120";

        /// <summary>
        /// The da bao giam. Giam chuyen ngoai tinh
        /// </summary>
        public const string R121 = "121";

        /// <summary>
        /// The da bao giam. Giam chuyen noi tinh
        /// </summary>
        public const string R122 = "122";

        /// <summary>
        /// The da bao giam. Thu hoi do tang laij cung don vi
        /// </summary>
        public const string R123 = "123";

        /// <summary>
        /// The da bao giam. Ngung tham gia
        /// </summary>
        public const string R124 = "124";

        /// <summary>
        /// Tre em khong xuat trinh the
        /// </summary>
        public const string R130 = "130";

        /// <summary>
        /// Loi sai dinh dang tham so truyen vao
        /// </summary>
        public const string R205 = "205";

        /// <summary>
        /// Thanh cong truyen du lieu
        /// </summary>
        public const string R200 = "200";

        /// <summary>
        /// Loi xac thuc tai khoan
        /// </summary>
        public const string R401 = "401";

        /// <summary>
        /// Tai khoan va mat khau don vi khong trung khop
        /// </summary>
        public const string R402 = "R402";

        /// <summary>
        /// Khong tim thay thong tin tim kiem
        /// </summary>
        public const string R403 = "R403";

        /// <summary>
        /// Chuc nang bao tri
        /// </summary>
        public const string R500 = "500";

        public static string GetMsg(string pMsgCode)
        {
            return listMsg[pMsgCode];
        }

        private static Dictionary<string, string> listMsg = new Dictionary<string, string>
        {
            {
                R000,
                "Thành công!"
            },

            {
                R001,
                "Thẻ do BHXH do Bộ Quốc Phòng quản lý! Hiện tại hệ thống không thực hiện đặt lịch cho các loại thẻ này!"
            },

            {
                R002,
                "Thẻ do BHXH Bộ Công An quản lý! Hiện tại hệ thống không thực hiện đặt lịch cho các loại thẻ này!"
            },

            {
                R003,
                "Thẻ cũ hết giá trị sử dụng nhưng đã được cấp thẻ mới!"
            },

            {
                R004,
                "Thẻ cũ còn giá trị sử dụng nhưng đã được cấp thẻ mới!"
            },

            {
                R005,
                "Thông tin thẻ bảo BHYT chưa chính xác. Bạn phải kiểm tra: Thông tin họ tên, năm sinh, giới tính, mã thẻ trên thẻ BHYT phải trùng với thông tin đăng ký!"
            },

            {
                R006,
                "Thông tin đặt lịch khám gần nhất chưa khám tại bệnh viện! Vui lòng kiểm tra lại danh sách đặt lịch!"
            },

            {
                R007,
                "Thông tin đặt lịch chưa hoàn tất khám tại bệnh viện! Liên hệ quản trị viên để biết thêm chi tiết!"
            },

            {
                R008,
                "Hạn thẻ BHYT của bạn có hiệu lực từ ngày [{0}] đến ngày [{1}]. Ngày đăng ký khám của bạn phải nằm trong khoảng thời gian này!"
            },

            {
                R009,
                "Thông tin đặt lịch không tồn tại!"
            },

            {
                R010,
                "Thẻ hết hạn sử dụng!"
            },

            {
                R011,
                "Bạn đã thực hiện khám bệnh tại đơn vị không thể hủy lịch khám!"
            },

            {
                R012,
                "Đặt lịch chưa được xác nhận tại bệnh viện hẹn khám!"
            },

            {
                R013,
                "Đặt lịch đã được xác nhận tại bệnh viện hẹn khám!"
            },

            {
                R014,
                "Thông tin đặt lịch khám đã hủy!"
            },

            {
                R015,
                "Số người đặt lịch đã hết, vui lòng chọn thời gian đặt lịch khác!"
            },

            {
                R051,
                "Thông tin thẻ bảo BHYT chưa chính xác. Bạn phải kiểm tra: Mã thẻ trên thẻ BHYT phải trùng với thông tin đăng ký!"
            },

            {
                R052,
                "Mã tỉnh cấp thẻ (Ký tự 4,5 của mã thẻ) không đúng!"
            },

            {
                R053,
                "Mã quyền lợi thẻ (Ký tự thứ 3 của thẻ) không đúng!"
            },

            {
                R050,
                "Thông tin thẻ bảo BHYT chưa chính xác. Bạn phải kiểm tra: Thông tin họ tên, năm sinh, giới tính, mã thẻ, trên thẻ BHYT phải trùng với thông tin đăng ký!"
            },

            {
                R060,
                "Thông tin thẻ bảo BHYT chưa chính xác. Bạn phải kiểm tra: Thông tin họ tên trên thẻ BHYT phải trùng với thông tin đăng ký!"
            },

            {
                R061,
                "Thông tin thẻ bảo BHYT chưa chính xác. Bạn phải kiểm tra: Thông tin họ tên(đúng ký tự đầu) trên thẻ BHYT phải trùng với thông tin đăng ký!"
            },

            {
                R070,
                "Thông tin thẻ bảo BHYT chưa chính xác. Bạn phải kiểm tra: Thông tin ngày sinh trên thẻ BHYT phải trùng với thông tin đăng ký!"
            },

            {
                R080,
                "Thông tin thẻ bảo BHYT chưa chính xác. Bạn phải kiểm tra: Thông tin giới tính trên thẻ BHYT phải trùng với thông tin đăng ký!"
            },

            {
                R090,
                "Thẻ sai nơi đăng ký KCB ban đầu!"
            },

            {
                R100,
                "Lỗi khi lấy dữ liệu số thẻ!"
            },

            {
                R101,
                "Có nhiều truy cập cùng thời điểm! Vui lòng đặt lịch khám lại!"//"Lỗi cổng BHXH, vui lòng truy cập cổng Bảo hiểm Xã hội Việt Nam để tiếp tục tra cứu hoặc liên hệ với Trung tâm hỗ trợ khách hàng của BHXH Việt Nam theo số điện thoại: 1900969668 để được hỗ trợ, hoặc tắt chức năng tự động kiểm tra thẻ trên cổng BHXH!"
			},

            {
                R110,
                "Thẻ đã thu hồi!"
            },

            {
                R120,
                "Thẻ đã báo giảm!"
            },

            {
                R121,
                "Thẻ báo giảm! Giảm chuyển ngoại tỉnh!"
            },

            {
                R122,
                "Thẻ báo giảm! Giảm chuyển nội tỉnh!"
            },

            {
                R123,
                "Thẻ báo giảm! Thu hồi do tăng lại cùng đơn vị!"
            },

            {
                R124,
                "Thẻ báo giảm! Ngừng tham gia!"
            },

            {
                R130,
                "Trẻ em không xuất trình thẻ! Hiện tại hệ thống không thực hiện đặt lịch cho các loại thẻ này!"
            },

            {
                R200,
                "Thành công lấy dữ liệu!"
            },

            {
                R205,
                "Lỗi sai định dạng tham số truyền vào!"
            },

            {
                R401,
                "Lỗi xác thực tài khoản!"
            },

            {
                R402,
                "Tài khoản và mã cơ sở khám chữa bệnh không trùng khớp!"
            },

            {
                R500,
                "Hệ thống đang trong giai đoạn thử nghiệm! Bạn vui lòng quay lại sau!"
            }
        };
    }
}