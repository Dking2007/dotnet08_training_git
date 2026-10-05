using System.Text.Json;

NhanVien nv = new NhanVien();

Console.WriteLine($@"{JsonSerializer.Serialize(nv)}");

Console.WriteLine($@"anh Thanh thêm");