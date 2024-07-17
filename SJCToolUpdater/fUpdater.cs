using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJCToolUpdater
{
    public partial class fUpdater : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public fUpdater()
        {
            InitializeComponent();
        }

        public static async Task DownloadZipFileAsync(string url, string destinationPath)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(url, destinationPath);
            }
        }

        public static void ExtractZipFile(string zipFilePath)
        {
            try
            {
                // Kiểm tra xem file ZIP có tồn tại không
                if (!File.Exists(zipFilePath))
                {
                    Console.WriteLine("File ZIP không tồn tại.");
                    return;
                }

                // Lấy thư mục chứa file ZIP
                string directoryPath = Path.GetDirectoryName(zipFilePath);

                // Giải nén file ZIP vào thư mục chứa file ZIP
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        // Tạo đường dẫn đầy đủ cho file giải nén
                        string destinationPath = Path.Combine(directoryPath, entry.FullName);

                        // Nếu file là thư mục, tạo thư mục tương ứng
                        if (string.IsNullOrEmpty(entry.Name))
                        {
                            Directory.CreateDirectory(destinationPath);
                        }
                        else
                        {
                            // Nếu file đã tồn tại, ghi đè lên file đó
                            if (File.Exists(destinationPath))
                            {
                                File.Delete(destinationPath);
                            }

                            // Giải nén file
                            entry.ExtractToFile(destinationPath);
                        }
                    }
                }

                // Xóa file ZIP sau khi giải nén
                File.Delete(zipFilePath);

                MessageBox.Show("File ZIP đã được giải nén và xóa thành công.");

                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        async void GetUpdate()
        {
            string url = "https://thanhdinhbao.id.vn/tool-sjc.zip"; // Thay bằng URL của file ZIP bạn muốn tải
            string destinationPath = "tool-sjc.zip"; // Đường dẫn nơi bạn muốn lưu file ZIP

            await DownloadZipFileAsync(url, destinationPath);
           // ExtractZipFile("tool-sjc.zip");

        }

        private void fUpdater_Load(object sender, EventArgs e)
        {
            GetUpdate();
        }
    }
}
