using AutoMapper;
using ShopOnline.Data;
using ShopOnline.ViewModels;

namespace ShopOnline.Helpers
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterVM, KhachHang>();
        }
    }
}
