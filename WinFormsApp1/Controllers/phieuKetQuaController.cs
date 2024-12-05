using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextFont = iTextSharp.text.Font;
using System.Data;
namespace WinFormsApp1.Controllers
{
    public class phieuKetQuaController
    {
        public string _connectionString;
        
        public phieuKetQuaController(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Models.PhieuKetQua> LayDanhSachPhieuKetQua()
        {
            return Models.PhieuKetQua.LayDanhSachPhieuKetQua(_connectionString);
        }
        public bool CapNhatKetQuaPhieuTraHang(int maPhieuKetQua)
        {
            return Models.PhieuKetQua.CapNhatKetQuaPhieuTraHang(_connectionString, maPhieuKetQua);
        }
        //lấy danh sách mẫu quan trắc, mượn hàm từ Models.MauQuanTrac
        public List<Models.MauQuanTrac> LayDanhSachMauQuanTrac()
        {
            return Models.MauQuanTrac.LayDanhSachMauQuanTrac(_connectionString);
        }
        //tạo phiếu kết quả cho tất cả mẫu quan trắc và kiểm tra trùng lặp phiếu kết quả
        public void TaoPhieuKetQuaChoTatCaMauQuanTrac(List<MauQuanTrac> danhSachMauQuanTrac)
        {
            foreach (var mauQuanTrac in danhSachMauQuanTrac)
            {
                // Kiểm tra nếu phiếu kết quả đã tồn tại thì bỏ qua
                if (mauQuanTrac.MaMau != null && !PhieuKetQua.KiemTraPhieuKetQuaTonTai(_connectionString, mauQuanTrac.MaMau))
                {
                    // Nếu chưa tồn tại, tạo mới phiếu kết quả
                    PhieuKetQua.ThemPhieuKetQuaTuMauQuanTrac(_connectionString, mauQuanTrac);
                }
            }
        }
        //
        public bool KiemTraThuocTinhDaTonTai(int maPhieuKetQua, string thongSo)
        {
            return PhieuKetQua.KiemTraThuocTinhDaTonTai(_connectionString, maPhieuKetQua, thongSo);
        }
        //
        public bool ThemChiTietThongSo(
        int maPhieuKetQua,
        string thongSo,
        string donVi,
        string phuongPhap,
        string ketQuaPTN,
        string ketQuaHT,
        string quyChuanSoSanh)
        {
            // Gọi hàm từ Model với đầy đủ các tham số
            return PhieuKetQua.ThemChiTietThongSo(
                _connectionString,
                maPhieuKetQua,
                thongSo,
                donVi,
                phuongPhap,
                ketQuaPTN,
                ketQuaHT,
                quyChuanSoSanh
            );
        }
        //
        public bool CapNhatChiTietThongSo(
        int maPhieuKetQua,
        string thongSo,
        string donVi,
        string phuongPhap,
        string ketQuaPTN,
        string ketQuaHT,
        string quyChuanSoSanh)
        {
            return PhieuKetQua.CapNhatChiTietThongSo(
                _connectionString,
                maPhieuKetQua,
                thongSo,
                donVi,
                phuongPhap,
                ketQuaPTN,
                ketQuaHT,
                quyChuanSoSanh
            );
        }


        //kiểm tra hợp lý đơn vị của thuộc tính
        public bool KiemTraDonViHopLe(string thongSo, string donVi)
        {
            return PhieuKetQua.KiemTraDonViHopLe(thongSo, donVi);
        }

        // Lấy thông tin phiếu kết quả từ database
        public DataTable GetPhieuKetQua(int maPhieuKetQua)
        {
            return Models.PhieuKetQua.GetPhieuKetQua(maPhieuKetQua, _connectionString);
        }

        // Lấy chi tiết thông số cho phiếu kết quả
        public DataTable GetChiTietThongSo(int maPhieuKetQua)
        {
            return Models.PhieuKetQua.GetChiTietThongSo(maPhieuKetQua, _connectionString);
        }

        public DataTable LayChiTietThongSo(int maPhieuKetQua)
        {
            return Models.PhieuKetQua.LayChiTietThongSo(_connectionString, maPhieuKetQua);
        }

        //các hàm xuất phiếu kết quả
        // Hàm xuất phiếu trả hàng ra file PDF
        public void ExportPhieuKetQuaToPdf(int maPhieuKetQua, string filePath)
        {
            // Lấy dữ liệu từ database
            var phieuData = GetPhieuKetQua(maPhieuKetQua);
            var chiTietThongSo = GetChiTietThongSo(maPhieuKetQua);

            if (phieuData.Rows.Count == 0)
                throw new Exception("Không tìm thấy phiếu kết quả!");

            var row = phieuData.Rows[0];

            // Đường dẫn tới font
            string fontPath = Path.Combine(Application.StartupPath, "Resources/Fronts/times.ttf");

            // Tạo file PDF
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);

                pdfDoc.Open();

                // Font chữ hỗ trợ Unicode
                BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);

                // Header
                PdfPTable headerTable = new PdfPTable(2);
                headerTable.WidthPercentage = 100;
                headerTable.SetWidths(new float[] { 0.2f, 0.8f }); // Chia đôi bảng 

                // Nội dung bên trái
                PdfPCell leftCell = new PdfPCell();
                leftCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                leftCell.Padding = 0;
                leftCell.HorizontalAlignment = Element.ALIGN_LEFT; // Căn giữa theo chiều ngang
                leftCell.VerticalAlignment = Element.ALIGN_MIDDLE;   // Căn giữa theo chiều dọc
                //leftCell.AddElement(new Paragraph("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM", boldFont) { Alignment = Element.ALIGN_CENTER });
                //leftCell.AddElement(new Paragraph("Độc lập - Tự do - Hạnh phúc", normalFont) { Alignment = Element.ALIGN_CENTER });
                
                // thêm ảnh góc trái
                // Đường dẫn hình ảnh từ Resource
                string imagePath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logokxoa.jpg");

                // Kiểm tra nếu file ảnh tồn tại
                if (File.Exists(imagePath2))
                {
                    // Load hình ảnh
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath2);

                    // Thiết lập vị trí và kích thước cho hình ảnh
                    img.ScaleToFit(100f, 100f); // Đặt kích thước (thay đổi theo yêu cầu)
                    img.Alignment = Element.ALIGN_CENTER; // Căn giữa theo chiều ngang
                    // Thêm hình ảnh vào Ô
                    leftCell.AddElement(img);
                }
                else
                {
                    throw new Exception("Hình ảnh không tồn tại!");
                }
                headerTable.AddCell(leftCell);

                // Nội dung bên phải
                PdfPCell rightCell = new PdfPCell();
                rightCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                leftCell.Padding = 0;
                leftCell.HorizontalAlignment = Element.ALIGN_LEFT; // Căn giữa theo chiều ngang
                leftCell.VerticalAlignment = Element.ALIGN_MIDDLE;   // Căn giữa theo chiều dọc
                rightCell.AddElement(new Paragraph("TRUNG TÂM MÔI TRƯỜNG VÀ KHOÁNG SẢN", normalFont) { Alignment = Element.ALIGN_CENTER });
                rightCell.AddElement(new Paragraph("PHÒNG PHÂN TÍCH CHẤT LƯỢNG MÔI TRƯỜNG", boldFont) { Alignment = Element.ALIGN_CENTER });
                rightCell.AddElement(new Paragraph("Đ/c: LK123, Khu đất dịch vụ Yên Lộ, P. Yên Nghĩa, Q. Hà Đông, TP. Hà Nội", normalFont) { Alignment = Element.ALIGN_CENTER });
                rightCell.AddElement(new Paragraph("Tel: 024.32007660 - Hotline: 0775.034034", normalFont) { Alignment = Element.ALIGN_CENTER });
                headerTable.AddCell(rightCell);

                pdfDoc.Add(headerTable);

                pdfDoc.Add(new Paragraph("\n"));

                // Tiêu đề chính
                Paragraph title = new Paragraph("PHIẾU KẾT QUẢ PHÂN TÍCH", headerFont);
                title.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(title);

                pdfDoc.Add(new Paragraph("\n"));

                // Thông tin phiếu
                // Nội dung chính của phiếu kết quả phân tích
                PdfPTable contentTable = new PdfPTable(2); // Tạo bảng 2 cột
                contentTable.WidthPercentage = 100; // Chiếm 100% chiều ngang trang
                contentTable.SetWidths(new float[] { 2, 8 }); // Định nghĩa tỷ lệ cột (cột trái nhỏ hơn cột phải)

                // Hàm tạo ô nội dung với căn lề trái
                PdfPCell CreateAlignedCell(string text, iTextFont font, int alignment = Element.ALIGN_LEFT)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(text, font));
                    cell.Border = iTextSharp.text.Rectangle.NO_BORDER; // Không có viền
                    cell.HorizontalAlignment = alignment; // Căn lề trái hoặc phải
                    return cell;
                }

                // Thêm các dòng nội dung vào bảng
                contentTable.AddCell(CreateAlignedCell("Tên khách hàng: ", normalFont, Element.ALIGN_LEFT));
                contentTable.AddCell(CreateAlignedCell(row["Tencongty"].ToString(), normalFont, Element.ALIGN_LEFT));

                contentTable.AddCell(CreateAlignedCell("Người đại diện: ", normalFont, Element.ALIGN_LEFT));
                contentTable.AddCell(CreateAlignedCell(row["Nguoidaidien"].ToString(), normalFont, Element.ALIGN_LEFT));

                contentTable.AddCell(CreateAlignedCell("Địa chỉ: ", normalFont, Element.ALIGN_LEFT));
                contentTable.AddCell(CreateAlignedCell(row["Diachi"].ToString(), normalFont, Element.ALIGN_LEFT));

                contentTable.AddCell(CreateAlignedCell("Tên mẫu: ", normalFont, Element.ALIGN_LEFT));
                contentTable.AddCell(CreateAlignedCell(row["Tenmau"].ToString(), normalFont, Element.ALIGN_LEFT));

                contentTable.AddCell(CreateAlignedCell("Mã mẫu: ", normalFont, Element.ALIGN_LEFT));
                contentTable.AddCell(CreateAlignedCell(row["Mamauthu"].ToString(), normalFont, Element.ALIGN_LEFT));

                contentTable.AddCell(CreateAlignedCell("Ngày lấy mẫu: ", normalFont, Element.ALIGN_LEFT));
                contentTable.AddCell(CreateAlignedCell(Convert.ToDateTime(row["Ngaylaymau"]).ToString("dd/MM/yyyy"), normalFont, Element.ALIGN_LEFT));

                contentTable.AddCell(CreateAlignedCell("Ngày hoàn thành: ", normalFont, Element.ALIGN_LEFT));
                contentTable.AddCell(CreateAlignedCell(Convert.ToDateTime(row["Ngaytraketqua"]).ToString("dd/MM/yyyy"), normalFont, Element.ALIGN_LEFT));

                // Thêm bảng vào tài liệu PDF
                pdfDoc.Add(contentTable);



                pdfDoc.Add(new Paragraph("\n"));

                // Bảng kết quả kiểm nghiệm
                PdfContentByte canvas = writer.DirectContentUnder;
                // Lấy đường dẫn logo từ thư mục Resource
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logokxoa.jpg");

                // Load hình ảnh từ file
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagePath);
                // Thiết lập kích thước và vị trí của logo
                logo.ScaleToFit(330, 330); // Kích thước logo
                iTextSharp.text.Rectangle pageSize = pdfDoc.PageSize;

                // Tính toán tọa độ trung tâm
                float centerX = (pageSize.Width - logo.ScaledWidth) / 2;
                float centerY = (pageSize.Height - logo.ScaledHeight) / 2;
                // Đặt vị trí logo
                logo.SetAbsolutePosition(centerX, centerY);
                logo.Alignment = Element.ALIGN_CENTER;

                // Đặt độ trong suốt
                PdfGState gState = new PdfGState();
                gState.FillOpacity = 0.2f; // Độ mờ của logo
                canvas.SetGState(gState);

                // Thêm hình ảnh vào nội dung
                canvas.AddImage(logo);

                Paragraph title2 = new Paragraph("BẢNG KẾT QUẢ PHÂN TÍCH", headerFont);
                title2.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(title2);

                pdfDoc.Add(new Paragraph("\n"));
                PdfPTable table = new PdfPTable(7); // Tổng cộng 7 cột: STT, Thông số, Đơn vị, Phương pháp phân tích, PTN, HT, Quy chuẩn so sánh
                table.WidthPercentage = 100; // Chiếm 100% chiều ngang trang
                table.SetWidths(new float[] { 1, 2, 2, 4, 2, 2, 4 }); // Tỷ lệ các cột

                // Tạo header chính
                PdfPCell headerSTT = new PdfPCell(new Phrase("STT", boldFont)) { Rowspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };
                PdfPCell headerThongSo = new PdfPCell(new Phrase("Thông số", boldFont)) { Rowspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };
                PdfPCell headerDonVi = new PdfPCell(new Phrase("Đơn vị", boldFont)) { Rowspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };
                PdfPCell headerPhuongPhap = new PdfPCell(new Phrase("Phương pháp phân tích", boldFont)) { Rowspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };
                PdfPCell headerKetQuaPhanTich = new PdfPCell(new Phrase("Kết quả phân tích", boldFont)) { Colspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };
                PdfPCell headerQuyChuan = new PdfPCell(new Phrase("Quy chuẩn so sánh", boldFont)) { Rowspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };

                // Thêm các ô header chính vào bảng
                table.AddCell(headerSTT);
                table.AddCell(headerThongSo);
                table.AddCell(headerDonVi);
                table.AddCell(headerPhuongPhap);
                table.AddCell(headerKetQuaPhanTich);
                table.AddCell(headerQuyChuan);

                // Tạo header phụ cho cột "Kết quả phân tích"
                PdfPCell headerPTN = new PdfPCell(new Phrase("PTN", boldFont)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };
                PdfPCell headerHT = new PdfPCell(new Phrase("HT", boldFont)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };

                // Thêm các ô header phụ vào bảng
                table.AddCell(headerPTN);
                table.AddCell(headerHT);

                // Thêm dữ liệu bảng
                for (int i = 0; i < chiTietThongSo.Rows.Count; i++)
                {
                    var detailRow = chiTietThongSo.Rows[i];
                    table.AddCell(new PdfPCell(new Phrase((i + 1).ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(detailRow["Thongso"].ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(detailRow["Donvi"].ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(detailRow["Phuongphapphantich"].ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(detailRow["KetquaPTN"].ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(detailRow["KetquaHT"].ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(detailRow["Quychuansosanh"].ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                }

                // Thêm bảng vào tài liệu PDF
                pdfDoc.Add(table);



                pdfDoc.Add(new Paragraph("\n"));

                // Vị trí lấy mẫu
                //string viTriLayMau = row["Ketqua"].ToString() == "PTN" ? "Phòng thí nghiệm" : "Hiện trường";
                pdfDoc.Add(new Paragraph($"Vị trí lấy mẫu: Phòng thí nghiệm (PTN), Hiện trượng (HT) ", normalFont));

                // Chú thích
                string chuThich = "{}";
                string maMau = row["Mamauthu"].ToString();
                if (maMau.StartsWith("KK")) chuThich = "KK: Không khí";
                else if (maMau.StartsWith("NT")) chuThich = "NT: Nước thải";
                else if (maMau.StartsWith("NM")) chuThich = "NM: Nước mặt";
                else if (maMau.StartsWith("D")) chuThich = "D: Đất";

                pdfDoc.Add(new Paragraph($"Chú thích: {chuThich}", normalFont));

                pdfDoc.Add(new Paragraph("\n"));

                // Footer
                PdfPTable footerTable = new PdfPTable(2);
                footerTable.WidthPercentage = 100;
                footerTable.SetWidths(new float[] { 1, 1.2f }); // Chia đều bảng thành 2 cột

                // Cột bên trái - "TM. PHÒNG PHÂN TÍCH"
                PdfPCell leftFooterCell = new PdfPCell();
                leftFooterCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                leftFooterCell.HorizontalAlignment = Element.ALIGN_CENTER; // Căn giữa theo chiều ngang
                leftFooterCell.VerticalAlignment = Element.ALIGN_MIDDLE;   // Căn giữa theo chiều dọc
                leftFooterCell.AddElement(new Paragraph("TM. PHÒNG PHÂN TÍCH", boldFont));
                footerTable.AddCell(leftFooterCell);

                // Cột bên phải - "Thành phố HCM, ngày ... năm" và "GIÁM ĐỐC"
                PdfPCell rightFooterCell = new PdfPCell();
                rightFooterCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                rightFooterCell.HorizontalAlignment = Element.ALIGN_CENTER; // Căn giữa theo chiều ngang
                rightFooterCell.VerticalAlignment = Element.ALIGN_MIDDLE;   // Căn giữa theo chiều dọc
                                                                            // Lấy giá trị ngày trả kết quả từ dữ liệu
                DateTime ngayTraKetQua = Convert.ToDateTime(row["Ngaytraketqua"]);
                rightFooterCell.AddElement(new Paragraph($"Thành phố Hồ Chí Minh, ngày {ngayTraKetQua.Day:D2} tháng {ngayTraKetQua.Month:D2} năm {ngayTraKetQua.Year}", normalFont) { Alignment = Element.ALIGN_CENTER });
                rightFooterCell.AddElement(new Paragraph("GIÁM ĐỐC", boldFont) { Alignment = Element.ALIGN_CENTER });
                footerTable.AddCell(rightFooterCell);

                // Thêm bảng footer vào tài liệu
                pdfDoc.Add(footerTable);
                pdfDoc.Close();

            }
        }

        //hàm bổ trợ
        private PdfPCell CreateContentCell(string content, iTextFont font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(content, font));
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER; // Không có viền
            cell.Padding = 2; // Thêm khoảng cách bên trong ô
            return cell;
        }
        private PdfPCell CreateCenteredCell(string content, iTextFont font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(content, font));
            cell.HorizontalAlignment = Element.ALIGN_CENTER; // Căn giữa theo chiều ngang
            cell.VerticalAlignment = Element.ALIGN_MIDDLE; // Căn giữa theo chiều dọc
            cell.Padding = 5; // Khoảng cách nội dung bên trong ô
            return cell;
        }









    }
}
