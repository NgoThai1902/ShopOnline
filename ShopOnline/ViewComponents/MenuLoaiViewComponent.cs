﻿using Microsoft.AspNetCore.Mvc;
using ShopOnline.Data;
using ShopOnline.ViewModels;

namespace ShopOnline.ViewComponents
{
    public class MenuLoaiViewComponent: ViewComponent
    {

        private readonly Hshop2023Context db;

        public MenuLoaiViewComponent(Hshop2023Context context) => db = context;
        
        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVM
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            }).OrderBy(p => p.TenLoai);

            return View(data);
        }
    }
}
