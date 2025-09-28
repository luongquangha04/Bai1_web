using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    public class Cham_Ngon
    {

        private static readonly Dictionary<char, string> proverbs = new Dictionary<char, string>()
        {
            { 'A', "Ai mang chữ A thường khởi đầu mạnh mẽ." },
            { 'B', "Chữ B tượng trưng cho bản lĩnh và bình an." },
            { 'C', "Người mang chữ C luôn có sự cân bằng trong cuộc sống." },
            { 'D', "Chữ D đi cùng với sự dũng cảm và quyết đoán." },
            { 'E', "Người có chữ E thường dễ dàng lan tỏa năng lượng tích cực." },
            { 'H', "Người mang chữ H thường hiền hòa nhưng kiên định." },
            { 'L', "Chữ L gắn liền với lòng trung thành và lạc quan." },
            { 'M', "Người có chữ M trong tên thường mạnh mẽ và mơ mộng." },
            { 'N', "Chữ N tượng trưng cho nghị lực và niềm tin." },
            { 'T', "Người mang chữ T thường tinh tế và thông minh." },
            { 'V', "Người mang chữ V thường có tâm hồn sáng tạo." },
        };

        /// <summary>
        /// Trả về châm ngôn dựa vào ký tự đầu tiên của tên
        /// </summary>
        public static string GetProverb(string name)
        {
            if (name == null || name.Trim().Length == 0)
                return "Tên không hợp lệ. ";

            char firstChar = char.ToUpper(name[0]);

            if (proverbs.ContainsKey(firstChar))
                return proverbs[firstChar] + " O_O ";
            else
                return $"Người mang chữ {firstChar} mang trong mình một nét riêng bí ẩn. ";
        }
    }
}
