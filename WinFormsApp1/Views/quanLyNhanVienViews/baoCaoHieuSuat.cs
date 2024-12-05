using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;
using System.Windows.Forms.DataVisualization.Charting;
namespace WinFormsApp1
{
    public partial class baoCaoHieuSuat : Form
    {
        private readonly nhanVienController nhanVienController;
        public baoCaoHieuSuat(nhanVienController nhanVienController)
        {
            InitializeComponent();
            this.nhanVienController = nhanVienController;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hiển thị tổng số hợp đồng của công ty (toàn bộ dữ liệu)
            txtTongSoHopDongCty.Text = nhanVienController.TinhTongHopDongCongTy().ToString();

            string maNhanVien = txtMaNhanVien.Text.Trim();
            if (string.IsNullOrEmpty(maNhanVien))
            {
                lblThongBao.Text = "Bạn chưa nhập mã hoặc tên nhân viên!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            if (!int.TryParse(txtNam.Text.Trim(), out int nam) || nam <= 0)
            {
                lblThongBao.Text = "Vui lòng nhập năm hợp lệ!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            if (!int.TryParse(cmbQuy.SelectedItem?.ToString(), out int quy) || quy < 1 || quy > 4)
            {
                lblThongBao.Text = "Vui lòng chọn quý hợp lệ (1-4)!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            lblThongBao.Text = "";

            var tuKhoa = nhanVienController.TimKiemNhanVienTheoMaHoacTen(maNhanVien);
            if (tuKhoa == null)
            {
                lblThongBao.Text = "Không tìm thấy nhân viên!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }
            string maNhanVienTimKiem = tuKhoa.MaNhanVien;
            // Lấy dữ liệu thống kê của nhân viên theo quý
            var thongKe = nhanVienController.LayThongKeTheoQuy(maNhanVienTimKiem, quy, nam);

            // Lấy tổng số hợp đồng của công ty trong quý
            int tongSoHopDongTrongQuyCuaCty = nhanVienController.TinhTongHopDongTrongQuyCuaCongTy(quy, nam);

            // Kiểm tra nếu không có hợp đồng nào của nhân viên trong quý
            if (thongKe.Count == 0)
            {
                lblThongBao.Text = "Không có hợp đồng nào trong phạm vi tìm kiếm!";
                lblThongBao.ForeColor = Color.Red;

                // Hiển thị giá trị mặc định
                txtTongSoHopDongTrongQuyCuaCty.Text = "0";
                txtTongHopDongTrongQuyCuaNv.Text = "0";
                txtTongSoHopDongCty.Text = "0";
                txtTongSoHopDongTrongQuyCuaCty.Text = tongSoHopDongTrongQuyCuaCty.ToString();

                // Xóa biểu đồ nếu không có dữ liệu
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel2.Controls.Clear();
                panel3.Controls.Clear();
                return;
            }

            // Tính tổng số hợp đồng của nhân viên trong quý
            int tongSoHopDongTrongQuyCuaNhanVien = thongKe.Sum(tk => tk.SoHoanThanh + tk.SoDangHoatDong + tk.SoTreHan);


            // Hiển thị kết quả vào TextBox
            txtTongHopDongTrongQuyCuaNv.Text = tongSoHopDongTrongQuyCuaNhanVien.ToString();
            txtTongSoHopDongTrongQuyCuaCty.Text = tongSoHopDongTrongQuyCuaCty.ToString();


            VeBieuDo(thongKe, maNhanVienTimKiem, tongSoHopDongTrongQuyCuaNhanVien, tongSoHopDongTrongQuyCuaCty);
            // Kiểm tra nếu nhân viên không có hợp đồng nào trong quý
            if (tongSoHopDongTrongQuyCuaNhanVien == 0)
            {
                lblThongBao.Text = "Nhân viên không có hợp đồng nào trong quý!";
                lblThongBao.ForeColor = Color.Red;
                panel3.Controls.Clear();
                txtTongHopDongTrongQuyCuaNv.Text = "0";
                txtTongSoHopDongCty.Text = "0";
                txtTongSoHopDongTrongQuyCuaCty.Text = "0";
                return;
            }
            //phần vẽ biểu đồ thứ 3
            // Lấy dữ liệu số lượng hợp đồng của nhân viên trong quý
            var thongKeNhanVien = nhanVienController.LayThongKeTheoQuy(maNhanVienTimKiem, quy, nam);
            int soHoanThanhNhanVien = thongKeNhanVien.Sum(tk => tk.SoHoanThanh);
            int soDangHoatDongNhanVien = thongKeNhanVien.Sum(tk => tk.SoDangHoatDong);
            int soTreHanNhanVien = thongKeNhanVien.Sum(tk => tk.SoTreHan);

            // Lấy dữ liệu tổng số lượng hợp đồng của công ty trong quý
            var thongKeCongTy = nhanVienController.LayThongKeCtyTheoQuy(quy, nam);
            int soHoanThanhCongTy = thongKeCongTy.Sum(tk => tk.SoHoanThanh);
            int soDangHoatDongCongTy = thongKeCongTy.Sum(tk => tk.SoDangHoatDong);
            int soTreHanCongTy = thongKeCongTy.Sum(tk => tk.SoTreHan);

            // Kiểm tra nếu không có dữ liệu
            if (soHoanThanhNhanVien + soDangHoatDongNhanVien + soTreHanNhanVien == 0)
            {
                lblThongBao.Text = "Nhân viên không có hợp đồng nào trong quý!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            if (soHoanThanhCongTy + soDangHoatDongCongTy + soTreHanCongTy == 0)
            {
                lblThongBao.Text = "Không có hợp đồng nào của công ty trong quý!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            // Vẽ biểu đồ so sánh
            VeBieuDoSoSanhTheoLoaiHopDong(
                panel3, // Panel chứa biểu đồ
                soHoanThanhNhanVien,
                soDangHoatDongNhanVien,
                soTreHanNhanVien,
                soHoanThanhCongTy,
                soDangHoatDongCongTy,
                soTreHanCongTy
            );
        }

        private void VeBieuDo(List<(int Thang, int SoHoanThanh, int SoDangHoatDong, int SoTreHan)> thongKe, string maNhanVien, int tongHopDongNhanVien, int tongHopDongCty)
        {
            // Tạo biểu đồ
            var chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            var chartArea = new ChartArea("ThongKe")
            {
                AxisX =
                {
                    Title = "Các Tháng Trong Qúy",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold), // Làm đậm tiêu đề trục X
                    LabelStyle = { Font = new Font("Arial", 10, FontStyle.Bold) } // Làm đậm nhãn trục X
                },
                AxisY =
                {
                    Title = "Số lượng hợp đồng",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold), // Làm đậm tiêu đề trục Y
                    LabelStyle = { Font = new Font("Arial", 10, FontStyle.Bold) } // Làm đậm nhãn trục Y
                }
            };                      
            chart.ChartAreas.Add(chartArea);

            var legend = new Legend
            {
                Docking = Docking.Top,
                Alignment = StringAlignment.Center,
                Title = "Chú thích trạng thái hợp đồng",
                TitleFont = new Font("Arial", 12, FontStyle.Bold),
                IsDockedInsideChartArea = false,
                LegendStyle = LegendStyle.Table
            };
            chart.Legends.Add(legend);

            // Thêm series cho từng trạng thái hợp đồng
            var seriesHoanThanh = new Series("Đã hoàn thành") { ChartType = SeriesChartType.Column, Color = Color.Green };
            var seriesDangHoatDong = new Series("Đang hoạt động") { ChartType = SeriesChartType.Column, Color = Color.Yellow };
            var seriesTreHan = new Series("Đã quá hạn") { ChartType = SeriesChartType.Column, Color = Color.Red };

            // Thêm dữ liệu vào series
            foreach (var tk in thongKe)
            {
                seriesHoanThanh.Points.AddXY($"Tháng {tk.Thang}", tk.SoHoanThanh);
                seriesDangHoatDong.Points.AddXY($"Tháng {tk.Thang}", tk.SoDangHoatDong);
                seriesTreHan.Points.AddXY($"Tháng {tk.Thang}", tk.SoTreHan);
            }

            // Thêm series vào biểu đồ
            chart.Series.Add(seriesHoanThanh);
            chart.Series.Add(seriesDangHoatDong);
            chart.Series.Add(seriesTreHan);

            // Xóa biểu đồ cũ và thêm biểu đồ mới
            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel1.Controls.Add(chart);

            //vẽ biểu đồ tròn
            var chart2 = new Chart
            {
                Dock = DockStyle.Fill
            };
            var chartArea2 = new ChartArea("ChartArea2");
            chart2.ChartAreas.Add(chartArea2);

            // Tính phần còn lại của công ty
            int phanConLai = tongHopDongCty - tongHopDongNhanVien;

            var seriesPie = new Series
            {
                ChartType = SeriesChartType.Pie
            };
            // Thêm dữ liệu và thiết lập nhãn phần trăm hiển thị
            seriesPie.Points.AddXY("Nhân viên", tongHopDongNhanVien);
            seriesPie.Points.AddXY("Công ty", phanConLai);

            // Hiển thị phần trăm trên từng phần của biểu đồ
            seriesPie.Points[0].Label = $"{(double)tongHopDongNhanVien / tongHopDongCty:P1}";
            seriesPie.Points[1].Label = $"{(double)phanConLai / tongHopDongCty:P1}";

            // Tùy chỉnh màu sắc của từng phần
            seriesPie.Points[0].Color = Color.DarkOrange; // Màu cam cho nhân viên
            seriesPie.Points[1].Color = Color.Gray; // Màu xám cho phần còn lại

            chart2.Series.Add(seriesPie);

            // **Thêm chú thích cho biểu đồ tròn**
            var legendPie = new Legend("LegendPie")
            {
                Docking = Docking.Top, // Vị trí: phía trên
                Alignment = StringAlignment.Center, // Canh giữa
                Title = "Chú thích hiệu suất nhân viên", // Tiêu đề
                TitleFont = new Font("Arial", 12, FontStyle.Bold),
                Font = new Font("Arial", 10) // Font chữ cho các chú thích
            };

            chart2.Legends.Add(legendPie);
            seriesPie.IsVisibleInLegend = true;
            seriesPie.LegendText = "#AXISLABEL";
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(chart2);
        }

        //vẽ biểu đồ thứ 3
        private void VeBieuDoSoSanhTheoLoaiHopDong(Panel panel, int soHoanThanhNhanVien, int soDangHoatDongNhanVien, int soTreHanNhanVien, int soHoanThanhCongTy, int soDangHoatDongCongTy, int soTreHanCongTy)
        {
            // Tạo đối tượng Chart
            var chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            var chartArea = new ChartArea("ChartArea1")
            {
                AxisX =
                {
                    Title = "Loại hợp đồng",
                    Interval = 1,
                    TitleFont = new Font("Arial", 12, FontStyle.Bold), // Làm đậm tiêu đề trục X
                    LabelStyle = { Font = new Font("Arial", 10, FontStyle.Bold) } // Làm đậm nhãn trục X
                },
                AxisY =
                {
                    Title = "Số lượng hợp đồng",
                    Interval = 1,
                    Minimum = 0,
                    TitleFont = new Font("Arial", 12, FontStyle.Bold), // Làm đậm tiêu đề trục Y
                    LabelStyle = { Font = new Font("Arial", 10, FontStyle.Bold) } // Làm đậm nhãn trục Y
                }

            };
            chart.ChartAreas.Add(chartArea);

            // Tạo series cho nhân viên
            var seriesNhanVien = new Series("Nhân viên")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue 
            };
            seriesNhanVien.Points.AddXY("Hoàn thành", soHoanThanhNhanVien);
            seriesNhanVien.Points.AddXY("Đang hoạt động", soDangHoatDongNhanVien);
            seriesNhanVien.Points.AddXY("Trễ hạn", soTreHanNhanVien);

            // Tạo series cho công ty
            var seriesCongTy = new Series("Công ty")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Gray
            };
            seriesCongTy.Points.AddXY("Hoàn thành", soHoanThanhCongTy);
            seriesCongTy.Points.AddXY("Đang hoạt động", soDangHoatDongCongTy);
            seriesCongTy.Points.AddXY("Trễ hạn", soTreHanCongTy);

            // Thêm các series vào biểu đồ
            chart.Series.Add(seriesNhanVien);
            chart.Series.Add(seriesCongTy);

            // Thêm chú thích (Legend)
            var legend = new Legend("Legend")
            {
                Docking = Docking.Top, // Đặt chú thích ở trên biểu đồ
                Alignment = StringAlignment.Center,
                Title = "So sánh hiệu suất hợp đồng",
                TitleFont = new Font("Arial", 12, FontStyle.Bold),
                Font = new Font("Arial", 10)
            };
            chart.Legends.Add(legend);

            // Xóa nội dung cũ trong panel và thêm biểu đồ mới
            panel3.Controls.Clear();
            panel3.Controls.Add(chart);
        }


        private void baoCaoHieuSuat_Load(object sender, EventArgs e)
        {
            var danhSachNhanVien = nhanVienController.LayDanhSachNhanVien();

            dataMau.Rows.Clear();
            foreach (var nv in danhSachNhanVien)
            {
                dataMau.Rows.Add(
                    nv.MaNhanVien,     
                    nv.HoVaTen,      
                    nv.Email,         
                    nv.SoDienThoai,    
                    nv.NgaySinh?.ToString("dd/MM/yyyy"), 
                    nv.ChucVu         
                );
            }
        }
    }
}
