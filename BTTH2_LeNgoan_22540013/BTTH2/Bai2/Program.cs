
Console.Write("Vui lòng nhập đường dẫn thư mục: ");
string path = Console.ReadLine();

ListFilesAndDirectories(path);


static void ListFilesAndDirectories(string path)
{
    try
    {
        // Lấy danh sách các tệp và thư mục trong đường dẫn đã cho
        var entries = Directory.GetFileSystemEntries(path);

        Console.WriteLine($"Nội dung trong thư mục '{path}':");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine("Thư mục không tồn tại. Vui lòng kiểm tra lại đường dẫn.");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("Không có quyền truy cập vào thư mục này.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Có lỗi xảy ra: {ex.Message}");
    }
}