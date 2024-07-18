using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RestSharp;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBuySJC
{
    public partial class fMain : Form
    {
        private System.Threading.Timer timer;
        public string opt_value;
        public string sl_max;

        public static int borderWidth;
        public static int borderHeight;
        public static double scale;

        private CancellationTokenSource _cancellationTokenSource;
        public fMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                process.Kill();
            }
            try
            {
                CheckLicense();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy thông tin key!");
            }
            btnOpenAccount.Enabled = false;
            btnStart.Enabled = false;
            btnHenGio.Enabled = false;
            numDelay.Enabled = false;
            numRepeat.Enabled = false;
        }

        #region License
        private string RunCMD(string cmd)
        {
            Process cmdProcess;
            cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.Arguments = "/c " + cmd;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.Verb = "runas";
            cmdProcess.Start();
            string output = cmdProcess.StandardOutput.ReadToEnd();
            cmdProcess.WaitForExit();
            if (String.IsNullOrEmpty(output))
                return "";
            return output;
        }

        void CheckLicense()
        {
            string output = RunCMD("wmic diskdrive get serialNumber"); // check số serial ổ cứng
            using (StreamWriter HDD = new StreamWriter("HDD.txt", true))
            {
                HDD.WriteLine(output);
                HDD.Close();
            }
            string[] lines = File.ReadAllLines("HDD.txt");
            File.Delete("HDD.txt");
            string str = Regex.Replace(lines[2], @"\s", ""); // lấy serial đầu tiên

            string outputs = RunCMD("wmic bios get serialnumber"); // check số serial bios
            using (StreamWriter BIOS = new StreamWriter("bios.txt", true))
            {
                BIOS.WriteLine(outputs);
                BIOS.Close();
            }
            string[] liness = File.ReadAllLines("bios.txt");
            File.Delete("bios.txt");
            string strs = Regex.Replace(liness[2], @"\s", ""); // lấy serial đầu tiên

            string keys = string.Concat(strs, str);

            HttpClient httpClient = new HttpClient();
            string text2 = keys;
            string requestUri2 = "https://docs.google.com/spreadsheets/d/1TZsjvP0wXNBJ8wxH78-fv4y3jnLlUvTR3WLS9eDC1mw/edit?usp=sharing";
            string text3 = httpClient.GetAsync(requestUri2).Result.Content.ReadAsStringAsync().Result.ToString();
            Match match2 = Regex.Match(text3.ToString(), text2 + ".*?(?=ok)");
            bool flag2 = match2 != Match.Empty;
            if (flag2)
            {
                string[] array = match2.ToString().Split(new char[]
                {
                            '|'
                });
                //string siteurlold = "https://mmosorfware.com/time.php";
                //ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //string htmlold = new System.Net.WebClient().DownloadString(siteurlold);
                //string[] arrayn = htmlold.ToString().Split(new char[]
                //{
                //             '/'
                //});
                //int dayn = Int32.Parse(arrayn[0]);
                //int monthn = Int32.Parse(arrayn[1]);
                //int yearn = Int32.Parse(arrayn[2]);

                DateTime time = DateTime.Now;
                int dayn = time.Day;
                int monthn = time.Month;
                int yearn = time.Year;

                string[] arrays = array[1].ToString().Split(new char[]
               {
                            '/'
               });

                int dayt = Int32.Parse(arrays[0]);
                int montht = Int32.Parse(arrays[1]);
                int yeart = Int32.Parse(arrays[2]);

                System.DateTime now = new System.DateTime(yearn, monthn, dayn);
                System.DateTime then = new System.DateTime(yeart, montht, dayt);
                System.TimeSpan diff1 = then.Subtract(now);


                int days = (int)Math.Ceiling(diff1.TotalDays);

                bool flag3 = days <= 0;
                if (flag3)
                {
                    MessageBox.Show("Vui lòng liên hệ admin để gia hạn.", "Phần mềm hết hạn" + days, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thành Công !", "Còn lại: " + days + " ngày!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            else
            {
                MessageBox.Show(string.Format("Bạn chưa mua bản quyền tool, vui lòng bấm Ctrl + C và gửi mã \"{0}\" cho chúng tôi để kích hoạt tool, bấm OK để sao chép key!", keys), "Thông báo active bản quyền!", MessageBoxButtons.OK);
                Clipboard.SetText(keys);
                //Environment.Exit(Environment.ExitCode);
                Application.Exit();
            }
        }

        #endregion

        #region Processing
        private void ScheduleRunAt(DateTime targetTime)
        {
            // Tính thời gian còn lại từ bây giờ đến targetTime
            TimeSpan delayTime = targetTime - DateTime.Now;

            // Nếu targetTime đã qua, không thực hiện gì
            if (delayTime.TotalMilliseconds <= 0)
            {
                MessageBox.Show("Thời gian đã qua!");
                return;
            }
            else
            {
                // Khởi tạo Timer
                timer = new System.Threading.Timer((state) =>
                {
                    button1_Click(null, null);

                }, null, (int)delayTime.TotalMilliseconds, Timeout.Infinite);
                MessageBox.Show("Đã đặt hẹn giờ chạy chương trình đến " + targetTime.ToString());
            }

        }

        private void LoadDataFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    DataTable table = new DataTable();

                    // Thêm các tiêu đề cột cố định
                    table.Columns.Add("Name");
                    table.Columns.Add("CCCD");
                    table.Columns.Add("Khuvuc");
                    table.Columns.Add("Chinhanh");
                    table.Columns.Add("Phuongthuc");
                    table.Columns.Add("Trạng thái");

                    // Thêm các hàng dữ liệu từ file
                    foreach (string line in lines)
                    {
                        string[] data = line.Split('|');
                        table.Rows.Add(data);
                    }

                    dgvAccount.DataSource = table;
                    lblNumAccount.Text = (dgvAccount.Rows.Count).ToString();
                    dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public string ExtractSJCToken(string pageSource)
        {
            string pattern = @"SJCToken:'(?<token>[a-f0-9\-]+)'";
            Match match = Regex.Match(pageSource, pattern);
            if (match.Success)
            {
                string sjcToken = match.Groups["token"].Value;
                return sjcToken;
            }

            return null; 
        }

        private async Task GetCookieAsync(int winWidth, int winHeight, int x, int y, string name, string cccd, string makv, string mach, string pt, DataGridViewRow row, CancellationToken token)
        {
            ChromeDriver driver = null;
            string tokenValue = "";
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                ChromeOptions opt = new ChromeOptions();
                opt.AddArguments($"--window-size={winWidth},{winHeight}");
                opt.AddArguments($"--window-position={x},{y}");
                ChromeDriverService cService = ChromeDriverService.CreateDefaultService();
                cService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(cService, opt);

                // Navigate to Url
                driver.Navigate().GoToUrl("https://tructuyen.sjc.com.vn/dang-nhap");

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

                //Login
                var name_box = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name")));
                name_box.SendKeys(name);

                var cccd_box = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("cccd")));
                cccd_box.SendKeys(cccd);

                var submit_btn = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("sign_in_submit")));
                submit_btn.Click();

                //Kiem tra dang nhap hơp le
                try
                {
                    var wait_msg = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                    var msg = wait_msg.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]")));
                    if (msg.Text.Contains("Thông tin đăng nhập không đúng"))
                    {
                        Invoke(new Action(() => row.Cells["Trạng thái"].Value = "Thông tin đăng nhập không đúng hoặc bị lock acc!"));
                        return;
                    }
                }
                catch
                {

                }

                token.ThrowIfCancellationRequested();
                while (true)
                {
                    try
                    {
                        var wait_kv = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                        wait_kv.Until(ExpectedConditions.ElementIsVisible(By.Id("id_area")));
                        break;
                    }
                    catch (WebDriverTimeoutException)
                    {
                        driver.Navigate().Refresh();
                        await Task.Delay(500);
                        token.ThrowIfCancellationRequested();
                    }
                }

                // Get VeriToken
                while (true)
                {
                    try
                    {
                        tokenValue = (string)driver.ExecuteScript("return $('input[name=\"__RequestVerificationToken\"]').val();");
                        break;
                    }
                    catch (WebDriverException ex)
                    {
                        if (ex.Message.Contains("ERR_HTTP2_SERVER_REFUSED_STREAM"))
                        {
                            driver.Navigate().Refresh();
                            await Task.Delay(500);
                            token.ThrowIfCancellationRequested();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }

                //Get SJCToken update v1.7
                string pageSource = driver.PageSource;

                string sjc_token = ExtractSJCToken(pageSource);

                //Get All Cookie
                var cookies = driver.Manage().Cookies.AllCookies;

                string ck = string.Empty;
                foreach (var cookie in cookies)
                {
                    ck += cookie.Name + "=" + cookie.Value + ";";
                }



                token.ThrowIfCancellationRequested();

                // Check cả hai
                if (cbReload.Checked && cbSpam.Checked)
                {
                    // Tạo các tác vụ song song
                    var reloadTask = Task.Run(async () =>
                    {
                        // Thực hiện chức năng Reload
                        string date_gd = string.Empty;
                        try
                        {
                            date_gd = driver.FindElement(By.XPath("//*[@id='kt_app_content_container']/div/div/div/div/div[1]/div/h2/span")).Text;
                        }
                        catch
                        {

                        }
                        string tommorrow = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");

                        while (date_gd != tommorrow)
                        {
                            // Thực hiện làm mới trang (F5)
                            driver.Navigate().Refresh();

                            // Lấy lại giá trị của date_gd sau khi trang đã làm mới
                            date_gd = driver.FindElement(By.XPath("//*[@id='kt_app_content_container']/div/div/div/div/div[1]/div/h2/span")).Text;

                            // Nếu date_gd bằng tommorrow, gọi hàm Request
                            if (date_gd == tommorrow)
                            {
                                this.Invoke(new Action(() => Request(tokenValue, ck, mach, "1", date, pt, sjc_token, row)));
                            }

                            token.ThrowIfCancellationRequested();

                            await Task.Delay(500);
                        }
                    }, token);

                    var spamTask = Task.Run(async () =>
                    {
                        // Thực hiện chức năng Spam
                        for (int i = 0; i < numSpam.Value; i++)
                        {
                            this.Invoke(new Action(() => Request(tokenValue, ck, mach, "1", date, pt, sjc_token, row)));
                            token.ThrowIfCancellationRequested();
                            await Task.Delay(1000);
                        }
                    }, token);

                    await Task.WhenAll(reloadTask, spamTask);
                }
                else if (cbReload.Checked)
                {
                    // Thực hiện chức năng Reload
                    string date_gd = string.Empty;
                    try
                    {
                        date_gd = driver.FindElement(By.XPath("//*[@id='kt_app_content_container']/div/div/div/div/div[1]/div/h2/span")).Text;
                    }
                    catch
                    {

                    }
                    string tommorrow = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");

                    while (date_gd != tommorrow)
                    {
                        // Thực hiện làm mới trang (F5)
                        driver.Navigate().Refresh();

                        // Lấy lại giá trị của date_gd sau khi trang đã làm mới
                        date_gd = driver.FindElement(By.XPath("//*[@id='kt_app_content_container']/div/div/div/div/div[1]/div/h2/span")).Text;

                        // Nếu date_gd bằng tommorrow, gọi hàm Request
                        if (date_gd == tommorrow)
                        {
                            this.Invoke(new Action(() => Request(tokenValue, ck, mach, "1", date, pt, sjc_token, row)));
                        }

                        token.ThrowIfCancellationRequested();

                        await Task.Delay(500);
                    }
                }
                else if (cbSpam.Checked)
                {
                    // Thực hiện chức năng Spam
                    for (int i = 0; i < numSpam.Value; i++)
                    {
                        this.Invoke(new Action(() => Request(tokenValue, ck, mach, "1", date, pt, sjc_token, row)));
                        token.ThrowIfCancellationRequested();
                        await Task.Delay(1000);
                    }
                }
                else if (cbReloadRegion.Checked)
                {
                    bool optionFound = false;

                    while (!optionFound)
                    {
                        try
                        {
                            while (true)
                            {
                                try
                                {
                                    var wait_kv = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                                    wait_kv.Until(ExpectedConditions.ElementIsVisible(By.Id("id_area")));
                                    break; // Thoát khỏi vòng lặp khi phần tử được tìm thấy
                                }
                                catch (WebDriverTimeoutException)
                                {
                                    driver.Navigate().Refresh();
                                    await Task.Delay(500);
                                    token.ThrowIfCancellationRequested();
                                }
                            }

                            var select_kv = new SelectElement(driver.FindElement(By.Id("id_area")));
                            foreach (var option in select_kv.Options)
                            {
                                if (option.GetAttribute("value") == makv)
                                {
                                    optionFound = true;
                                    break;
                                }
                            }

                            if (!optionFound)
                            {
                                driver.Navigate().Refresh();
                                await Task.Delay(500);
                                token.ThrowIfCancellationRequested();
                            }
                            else
                            {

                                bool cn_open = false;
                                while (!cn_open)
                                {
                                    try
                                    {
                                        var select_kv1 = new SelectElement(driver.FindElement(By.Id("id_area")));
                                        select_kv1.SelectByValue(makv);
                                        wait.Until(ExpectedConditions.ElementIsVisible(By.Id("id_store")));
                                        var select_cn = new SelectElement(driver.FindElement(By.Id("id_store")));
                                        foreach (var option in select_cn.Options)
                                        {
                                            if (option.GetAttribute("value") == mach)
                                            {
                                                select_cn.SelectByValue(mach);
                                                cn_open = true;
                                                break;
                                            }
                                        }

                                        if (!cn_open)
                                        {
                                            driver.Navigate().Refresh();
                                            await Task.Delay(1000);
                                            token.ThrowIfCancellationRequested();
                                        }
                                        else
                                        {
                                            this.Invoke(new Action(() => Request(tokenValue, ck, mach, "1", date, pt, sjc_token, row)));
                                        }
                                    }
                                    catch (NoSuchElementException)
                                    {
                                        driver.Navigate().Refresh();
                                        await Task.Delay(1000);
                                        token.ThrowIfCancellationRequested();
                                    }
                                }
                            }
                        }
                        catch (NoSuchElementException)
                        {
                            driver.Navigate().Refresh();
                            await Task.Delay(1000);
                            token.ThrowIfCancellationRequested();
                        }
                    }
                }
                else
                {
                    Request(tokenValue, ck, mach, "1", date, pt, sjc_token, row);
                }
            }
            catch (OperationCanceledException)
            {
                // Handle the task cancellation here if needed
                Invoke(new Action(() => row.Cells["Trạng thái"].Value = "Tác vụ đã bị hủy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
            finally
            {
                if (driver != null)
                {
                    driver.Close();
                    driver.Quit();
                }
            }
        }

        async void Request(string token, string ck, string ch, string sl, string ngaygd, string pt, string sjctoken, DataGridViewRow row)
        {
            var options = new RestClientOptions()
            {
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36",
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://tructuyen.sjc.com.vn/Home/LayPhieuMuaHang", Method.Post);
            request.AddHeader("accept", "*/*");
            request.AddHeader("accept-language", "en-US,en;q=0.9,vi;q=0.8,ar;q=0.7,de;q=0.6");
            request.AddHeader("content-type", "application/x-www-form-urlencoded; charset=UTF-8");
            request.AddHeader("cookie", ck);
            request.AddHeader("origin", "https://tructuyen.sjc.com.vn");
            request.AddHeader("priority", "u=1, i");
            request.AddHeader("referer", "https://tructuyen.sjc.com.vn/");
            request.AddHeader("sec-ch-ua", "\"Not/A)Brand\";v=\"8\", \"Chromium\";v=\"126\", \"Google Chrome\";v=\"126\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("sec-fetch-dest", "empty");
            request.AddHeader("sec-fetch-mode", "cors");
            request.AddHeader("sec-fetch-site", "same-origin");
            request.AddHeader("x-requested-with", "XMLHttpRequest");
            var body = string.Format("__RequestVerificationToken={0}&CuaHang={1}&SoLuong={2}&NgayGiaoDich={3}&HinhThuc={4}&SJCToken={5}", token, ch, sl, ngaygd, pt, sjctoken);
            //var body = @"__RequestVerificationToken=zuNkz5EJA4iGgrE7SBJOBV3oGPjBs9W4NWnD8zLrklZfpmi83k3X1t53xjbaoJUCh44loXK6RPEaLOyDyi-35cmrUkONw8xIjZxC1dBUTMbDpTAvlOR-evf6I3wuXFNy0&CuaHang=6&SoLuong=1&NgayGiaoDich=2024-07-01&HinhThuc=1";
            request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
            RestResponse response = await client.ExecuteAsync(request);
            if (response != null)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Invoke(new Action(() => row.Cells["Trạng thái"].Value = "Lỗi web SJC!"));
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                {
                    Invoke(new Action(() => row.Cells["Trạng thái"].Value = "Lỗi server, thử lại!"));
                }
                else
                {
                    Result.Root json = JsonConvert.DeserializeObject<Result.Root>(response.Content);
                    Invoke(new Action(() => row.Cells["Trạng thái"].Value = json.StatusText));
                }
            }
            else
            {
                Invoke(new Action(() => row.Cells["Trạng thái"].Value = "Lỗi server, thử lại!"));
            }

        }

        private async Task RunAll(CancellationToken token)
        {
            var dataGridViewData = new List<(string Name, string Cccd, string KhuVuc, string ChiNhanh, string PhuongThuc, DataGridViewRow Row)>();
            foreach (DataGridViewRow row in dgvAccount.Rows)
            {
                if (row.Cells["Name"].Value != null && row.Cells["Phuongthuc"].Value != null && row.Cells["Cccd"].Value != null && row.Cells["Chinhanh"].Value != null && row.Cells["Khuvuc"].Value != null)
                {
                    string name = row.Cells["Name"].Value.ToString();
                    string cccd = row.Cells["Cccd"].Value.ToString();
                    string khuvuc = row.Cells["Khuvuc"].Value.ToString();
                    string chinhanh = row.Cells["Chinhanh"].Value.ToString();
                    string pt = row.Cells["Phuongthuc"].Value.ToString();
                    dataGridViewData.Add((name, cccd, khuvuc, chinhanh, pt, row));
                }
            }
            // Run GetCookie for each row in parallel
            var tasks = new List<Task>();

            borderWidth = 250;
            borderHeight = 400;
            int rowCount = dgvAccount.Rows.Count;
            if (rowCount <= 9)
            {
                scale = 0.9;
            }
            else if (rowCount <= 12)
            {
                scale = 0.7;
            }
            else
            {
                scale = 1;
            }

            int columns = (int)Math.Ceiling(Math.Sqrt(rowCount));
            int rows = (int)Math.Ceiling((double)rowCount / columns);
            int windowWidth = (int)(borderWidth * scale);
            int windowHeight = (int)(borderHeight * scale);

            for (int i = 0; i < rowCount; i++)
            {
                var data = dataGridViewData[i];
                int xPosition = (i % columns) * (windowWidth + borderWidth);
                int yPosition = (i / columns) * (windowHeight);

                tasks.Add(Task.Run(() => GetCookieAsync(windowWidth, windowHeight, xPosition, yPosition, data.Name, data.Cccd, data.KhuVuc, data.ChiNhanh, data.PhuongThuc, data.Row, token), token));
                //Delay giữa các task tránh spam
                if (i < rowCount - 1)
                {
                    await Task.Delay(3000);
                }

            }
        }

        #endregion

        #region Event

        private async void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvAccount.Rows)
            {
                if (row.Cells["Trạng thái"] != null)
                {
                    row.Cells["Trạng thái"].Value = string.Empty;
                }
            }

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            try
            {
                if (cbRepeat.Checked)
                {
                    await RunAll(token);
                    for (int i = 0; i < numRepeat.Value; i++)
                    {
                        int time_sleep = (int)numDelay.Value * 1000;
                        await Task.Delay(time_sleep, token);
                        await RunAll(token);
                    }
                }
                else
                {
                    await RunAll(token);
                }

            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Đã dừng!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = Environment.CurrentDirectory;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPath.Text = theDialog.FileName;
                    LoadDataFromFile(theDialog.FileName);
                    btnOpenAccount.Enabled = true;
                    btnStart.Enabled = true;
                    btnHenGio.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fHuongDan frm = new fHuongDan();
            frm.ShowDialog();
        }

        private void NotepadProcess_Exited(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    LoadDataFromFile(txtPath.Text);
                }));
            }
            else
            {
                LoadDataFromFile(txtPath.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", txtPath.Text);
            Process notepadProcess = new Process();
            notepadProcess.StartInfo.FileName = "notepad.exe";
            notepadProcess.StartInfo.Arguments = txtPath.Text;
            notepadProcess.EnableRaisingEvents = true;
            notepadProcess.Exited += NotepadProcess_Exited;
            notepadProcess.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", "https://www.facebook.com/thanhdinhbao.k20");
        }

        private void btnHenGio_Click(object sender, EventArgs e)
        {
            DateTime targetTime = dtHenGio.Value;
            ScheduleRunAt(targetTime);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }
        }

        private void cbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRepeat.Checked)
            {
                numDelay.Enabled = true;
                numRepeat.Enabled = true;
            }
            else
            {
                numDelay.Enabled = false;
                numRepeat.Enabled = false;
            }

        }

        #endregion
    }
}
