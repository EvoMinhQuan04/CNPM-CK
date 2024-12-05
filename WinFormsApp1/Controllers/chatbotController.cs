using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
namespace WinFormsApp1.Controllers
{
    public class chatbotController
    {
        private readonly ChatbotModel _chatbotModel;

        public chatbotController(string connectionString)
        {
            _chatbotModel = new ChatbotModel(connectionString);
        }

        public string HandleRequest(string userInput)
        {
            string normalizedInput = userInput.ToLower().Trim();

            if (normalizedInput.Contains("hợp đồng") && (normalizedInput.Contains("trễ hạn") || normalizedInput.Contains("sắp tới hạn")))
            {
                var contracts = _chatbotModel.GetContractsDueSoon();

                if (contracts.Count > 0)
                {
                    return string.Join("\n", contracts).Trim(); // Chuẩn hóa kết quả
                }
                return "Không có hợp đồng nào sắp trễ hạn trong tuần này.";
            }
            return "Xin lỗi, tôi không hiểu câu hỏi của bạn.";
        }


    }
}
