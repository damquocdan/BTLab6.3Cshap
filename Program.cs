using System.Collections;

namespace BTLab6._3Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo một Hashtable để lưu danh sách các ngày trong tuần
            Hashtable weekDays=new Hashtable();

            // thêm các ngày vào Hashtable với key từ 1 đến 7
            weekDays.Add(1, "Monday");
            weekDays.Add(2, "Tuesday");
            weekDays.Add(3, "Wednesday");
            weekDays.Add(4, "Thursday");
            weekDays.Add(5, "Friday");
            weekDays.Add(6, "Saturday");
            weekDays.Add(7, "Sunday");

            // TÌm kiếm và in ra thông báo nếu tìm thấy "Tuesday"
            string tueDay = "Tuesday";
            if(weekDays.ContainsKey(tueDay))
            {
                Console.WriteLine("Ngày'{tueday}'  được tìm thấy trong tuần.");
            }
            else
            {
                Console.WriteLine("không tìm đưọc");
            }

            // In ra danh danh sách các ngày trong tuần bao gồm cả key và value
            Console.WriteLine("Danh sách các ngày trong tuần:");
            foreach (DictionaryEntry entry in weekDays)
            {
                Console.WriteLine(entry);
            }
        }
    }
}