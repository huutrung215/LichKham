using System.ComponentModel.DataAnnotations;

namespace AulacLichKham.Attributes
{
    public class RequiredCustomAttribute : RequiredAttribute
    {
        public RequiredCustomAttribute() : base()
        {
            ErrorMessage = "{0} là bắt buộc";
        }
    }
}
