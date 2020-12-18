using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClientManager.Forms;
using ClientManager.Model.StaticModel;
using ClientManager.Models.AppModel;
using Newtonsoft.Json;

namespace ClientManager.Services
{
    class StaticInitializeService
    {
        public static void StaticItemInitialize()
        {
            // Lấy thông tin client được lưu.
            var clientInfo = LoadFromFile();
            StaticModels.ClientId = clientInfo.ClientId;
            StaticModels.ServerIp = clientInfo.ServerIp;
            GetClientInfo(); 

            // Ở app này, để tránh lỗi về dispose/ null, thì tất cả các form là không thể tắt và là static
            StaticModels.ChatForm = new ChatForm();
            StaticModels.LockForm = new LockForm();
            StaticModels.MenuForm = new MenuForm();
            StaticModels.ChangePasswordForm = new ChangePasswordForm();
            StaticModels.LoginForm = new LoginForm();
            StaticModels.TemporaryLockForm = new TemporaryLockForm();
            StaticModels.CategoryOrderForm = new CategoryOrderForm(); 

            // Trạng thái ban đầu là chưa connect gì hết. 
            StaticModels.isConnect = false;

        }

        // Hàm này lưu client Id vào file dat, hàm này và hàm dưới sẽ được sử dụng để lưu thông tin lúc tạo mới máy trạm
        static public void SaveToFile(ClientInfoModel objectToSerialize)
        {
            Stream stream = File.Open(StaticModels.DatFilePath, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();
        }

        // Hàm này lấy client Id từ file dat
        static public ClientInfoModel LoadFromFile()
        {
            if (!System.IO.File.Exists(AppContext.BaseDirectory + StaticModels.DatFilePath))
                return new ClientInfoModel();

            ClientInfoModel objectToSerialize;
            Stream stream = File.Open(AppContext.BaseDirectory + StaticModels.DatFilePath, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (ClientInfoModel)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }

        // Hàm này chạy tạo task chạy ngầm để xem Có lấy được thông tin về máy không. 
        static public void GetClientInfo()
        {
            // Coi như là, trong phần mềm đã cài sẵn số máy rồi( ClientId)
            // Lấy về thông tin của Client
            new Thread(() => {
                while (StaticModels.Client is null || StaticModels.GroupClient is null)
                {
                    var ClientId = StaticModels.ClientId; // Biến giả, cái này sẽ lưu trong AppSetting hoặc chỗ khác
                    using (ApiService apiService = new ApiService())
                    {
                        // Lấy thông tin client
                        try
                        {
                            Console.WriteLine(EnpointUrl.ClientInfo + ClientId.ToString());
                            var result = apiService.getEntity(EnpointUrl.ClientInfo + ClientId.ToString());
                            if (result != null)
                            {
                                if (result.IsSuccessStatusCode)
                                {
                                    StaticModels.Client = JsonConvert.DeserializeObject<Client>(result.Content.ReadAsStringAsync().Result);
                                    var groupResult = apiService.getEntity(EnpointUrl.GroupClientInfo + StaticModels.Client.ClientGroupId);
                                    if (groupResult.IsSuccessStatusCode)
                                    {
                                        StaticModels.GroupClient = JsonConvert.DeserializeObject<GroupClient>(groupResult.Content.ReadAsStringAsync().Result);
                                        StaticModels.isConnect = true;
                                        StaticModels.LockForm.Invoke((Action)(() => {
                                            StaticModels.LockForm.lbDisconnect.Hide();
                                        }), new object[] { });
                                        // Đoạn này nếu kết nối thành công thì cho chạy thêm task mới là xem kết nối interet có ổn không.
                                        // SỬ dụng biến StaticModels.isConnected

                                        CheckConnectedLoop(); 


                                    }
                                }
                            }
                            else
                            {
                                StaticModels.isConnect = false;
                                StaticModels.LockForm.Invoke((Action)(() => {
                                    StaticModels.LockForm.lbDisconnect.Show();
                                }), new object[] { });
                            }
                        }
                        catch
                        {
                            Console.WriteLine("erro");
                            StaticModels.isConnect = false;
                        }
                    }
                    Thread.Sleep(500);
                    Console.WriteLine(StaticModels.isConnect + StaticModels.ServerIp);
                    Console.WriteLine(EnpointUrl.ClientInfo);
                }

            }).Start();
        }

        // Hàm này gọi 1 lần, để task chạy ngầm liên tục check connect của máy. 
        // 2 phút gọi 1 lần. 
        static public void CheckConnectedLoop()
        {
            new Thread(() => {
                while (true)
                {
                    // Có 1 APi ping đến server. Gọi API này để ping xem có còn kết nối không.
                    using(ApiService apiService = new ApiService())
                    {
                        var pingResult = apiService.getEntity(EnpointUrl.PingEnpoint); 
                        if(pingResult is null)
                        {
                            // Khi ping thất bại, thì lock máy vào. 
                            StaticModels.isConnect = false;
                            StaticModels.LockForm.Invoke((Action)(() => {
                                if (!StaticModels.LockForm.Visible)
                                {
                                    StaticModels.LockForm.Show();
                                    StaticModels.LockForm.TopMost = true; 
                                }
                                StaticModels.LockForm.lbDisconnect.Show(); 
                            }), null);
                        }
                        else
                        {
                            // Nếu ping thành công, thì cho cái chữ mất kết nối không hiển thị ở LockForm nữa.
                            StaticModels.isConnect = true;
                            StaticModels.LockForm.Invoke((Action)(() => {
                                StaticModels.LockForm.lbDisconnect.Hide(); 
                            }), null);
                        }
                        
                    }
                    Thread.Sleep(60000);
                }
            
            }).Start(); 
        }

        // Hàm xử lý thời gian
        static public string MinuteToDate(float minute)
        {
            var timeSpan = TimeSpan.FromMinutes(minute);
            return String.Format("{0:00}:{1:00}", (int)timeSpan.TotalHours, timeSpan.Minutes);
        }

    }
}
