﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourDulich.Model;
using TourDulich.View.AdminManagerView;

namespace TourDulich.ViewModel
{
    class DoanDuLichViewModel:BaseViewModel
    {
        public int MaDoan { get; set; }
        public string TenDoan { get; set; }
        public long DoanhThu { get; set; }
        public string NoiDung { get; set; }
        public DateTime? NgayDi { get; set; }
        public DateTime? NgayVe { get; set; }


        //private TourDuLichDTO _SelectedTour;
        //public TourDuLichDTO SelectedTour
        //{
        //    get => _SelectedTour;
        //    set
        //    {
        //        _SelectedTour = value;

        //    }
        //}

        //private List<NhanVienDTO> _Nhanvien;
        //public List<NhanVienDTO> NhanVien
        //{
        //    get => _Nhanvien;
        //    set
        //    {
        //        _Nhanvien = value;

        //    }
        //}

        //private DoanDuLichDTO _SelectedItem;
        //public DoanDuLichDTO SelectedItem
        //{
        //    get => _SelectedItem;
        //    set
        //    {
        //        _SelectedItem = value;
        //        if(SelectedItem != null)
        //        {
        //            MaDoan = SelectedItem.MaDoan;
        //            TenDoan = SelectedItem.TenDoan;
        //            NgayDi = SelectedItem.NgayKhoiHanh;
        //            NgayVe = SelectedItem.NgayKetThuc;
        //            DoanhThu = SelectedItem.DoanhThu;

        //            //NoiDung = SelectedItem.NoiDung;
        //            //SelectedTour = SelectedItem.T;
        //            //NhanVien = SelectedItem.NhanVien;
        //        }
        //    }
        //}

        public ObservableCollection<DoanDuLich> ListGroup { get; set; }



        //private ObservableCollection<TourDuLichDTO> _Tour;
        //public ObservableCollection<TourDuLichDTO> Tour { get => _Tour; set { _Tour = value; } }

        public ICommand AddCommand { get; set; }
        public ICommand ShowCommand { get; set; }
        public ICommand DoanThemNV { get; set; }
        public ICommand DoanThemKH { get; set; }
        public ICommand DoanThemCP { get; set; }
        public ICommand Close_DoanThem { get; set; }
        public ICommand Close_DoanThemNV { get; set; }
        public ICommand Close_DoanThemKH { get; set; }
        public ICommand Close_DoanThemCP { get; set; }
        public ICommand Close_DoanChiTiet { get; set; }
        public DoanDuLichViewModel() {
            ListGroup = new ObservableCollection<DoanDuLich> { 
            new DoanDuLich{ name="asdf"},
            new DoanDuLich{ name="as2f"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="111df"},
            new DoanDuLich{ name="a"}
            };

            //Tour = new ObservableCollection<TourDuLichDTO>();


            #region Commands
            AddCommand = new RelayCommand<object>(p => { return true; }, p => { Add(); });
            ShowCommand = new RelayCommand<object>(p => { return true; }, p => { Show(); });
            DoanThemNV = new RelayCommand<object>(p => { return true; }, p => { ShowThemNV(); });
            DoanThemKH = new RelayCommand<object>(p => { return true; }, p => { ShowThemKH(); });
            DoanThemCP = new RelayCommand<object>(p => { return true; }, p => { ShowThemCP(); });
            

            Close_DoanThem = new RelayCommand<object>(p =>      { return true; }, p => { CloseThem(p); });
            Close_DoanThemNV = new RelayCommand<object>(p =>    { return true; }, p => { CloseThemNV(p); });
            Close_DoanThemKH = new RelayCommand<object>(p => { return true; }, p => { CloseThemKH(p); });
            Close_DoanThemCP = new RelayCommand<object>(p => { return true; }, p => { CloseThemCP(p); });
            Close_DoanChiTiet = new RelayCommand<object>(p => { return true; }, p => { CloseChiTiet(p); });
            #endregion
        }
        private void Add() { DoanDuLich_Them x = new DoanDuLich_Them(); x.ShowDialog(); }
        private void CloseThem(object obj) { DoanDuLich_Them x = obj as DoanDuLich_Them; x.Close();  }


        private void Show() { DoanDuLich_ChiTiet x = new DoanDuLich_ChiTiet(); x.ShowDialog(); }
        private void CloseChiTiet(object obj) { DoanDuLich_ChiTiet x = obj as DoanDuLich_ChiTiet; x.Close();  }


        private void ShowThemNV() { DoanDuLich_ThemNhanVien x = new DoanDuLich_ThemNhanVien(); x.ShowDialog();  }
        private void CloseThemNV(object obj) { DoanDuLich_ThemNhanVien x = obj as DoanDuLich_ThemNhanVien; x.Close();  }

        private void ShowThemKH() { DoanDuLich_ThemKhachHang x = new DoanDuLich_ThemKhachHang(); x.ShowDialog(); }
        private void CloseThemKH(object obj) { DoanDuLich_ThemKhachHang x = obj as DoanDuLich_ThemKhachHang; x.Close();  }

        private void ShowThemCP() { DoanDuLich_ThemChiPhi x = new DoanDuLich_ThemChiPhi(); x.ShowDialog(); }
        private void CloseThemCP(object obj) { DoanDuLich_ThemChiPhi x = obj as DoanDuLich_ThemChiPhi; x.Close();  }
    }

    class DoanDuLich
    {
        public string name { get; set; }
    }

}
