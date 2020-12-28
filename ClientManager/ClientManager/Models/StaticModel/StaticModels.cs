using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using ClientManager.Forms;
using System.Reactive.Subjects;
using System.Reactive;
using ClientManager.Models.AppModel;
using ClientManager.Services;
using System.Threading;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClientManager.Model.StaticModel
{
    static public class StaticModels
    {
        private static LockForm _lockForm;
        private static LoginForm _loginForm;
        private static ChatForm _chatForm;
        private static MenuForm _menuForm;
        private static ChangePasswordForm _changePasswordForm;
        private static TemporaryLockForm _temporaryLockForm;
        private static CategoryOrderForm _categoryOrderForm;

        // Lock form
        public static LockForm LockForm
        {
            get {
                if (StaticModels._lockForm is null)
                {
                    _lockForm = new LockForm(); 
                    return _lockForm; 
                }
                else return StaticModels._lockForm;
            }
            set
            {
                StaticModels._lockForm = value;
            }
        }

        // Login Form
        public static LoginForm LoginForm
        {
            get
            {
                if (StaticModels._loginForm is null)
                {
                    StaticModels._loginForm = new LoginForm(); 
                    return StaticModels._loginForm;
                }
                else return StaticModels._loginForm;
            }
            set
            {
                StaticModels._loginForm = value;
            }
        }

        // Chat form 
        public static ChatForm ChatForm
        {
            get
            {
                if (_chatForm is null)
                {
                    _chatForm = new ChatForm();
                    return _chatForm;
                }
                else
                {
                    return _chatForm;
                }
            }
            set
            {
                _chatForm = value;
            }
        }

        // Change Password Form 
        public static ChangePasswordForm ChangePasswordForm
        {
            get
            {
                if(StaticModels._changePasswordForm is null)
                {
                    StaticModels._changePasswordForm = new ChangePasswordForm();
                    return StaticModels._changePasswordForm;
                }
                else
                {
                    return StaticModels._changePasswordForm;
                }
            }
            set
            {
                StaticModels._changePasswordForm = value;
            }
        }

        // Menu Form 
        public static MenuForm MenuForm
        {
            get { 
                if(StaticModels._menuForm is null)
                {
                    StaticModels._menuForm = new MenuForm();
                    return StaticModels._menuForm;
                }
                else
                {
                    return StaticModels._menuForm;
                }
            }
            set
            {
                StaticModels._menuForm = value;
            }
        }

        // Lock Form ( Khóa tạm thời ) 
        public static TemporaryLockForm TemporaryLockForm
        {
            get
            {
                if(StaticModels._temporaryLockForm is null)
                {
                    StaticModels._temporaryLockForm = new TemporaryLockForm();
                    return StaticModels._temporaryLockForm;
                }
                else
                {
                    return StaticModels._temporaryLockForm; 
                }
            }
            set
            {
                StaticModels._temporaryLockForm = value; 
            }
        }

        // Category order form
        public static CategoryOrderForm CategoryOrderForm
        {
            set
            {
                StaticModels._categoryOrderForm = value;
            }
            get
            {
                if(StaticModels._categoryOrderForm is null)
                {
                    StaticModels._categoryOrderForm = new CategoryOrderForm();
                    return StaticModels._categoryOrderForm;
                }return StaticModels._categoryOrderForm;
            }
        }

        // Biến này lưu subject của LoginForm, lưu một cách toàn cục.
        static public Subject<bool> LoginFormSubject = new Subject<bool>(); 

        // Biến này lưu trạng thái toàn cục là đăng nhập hay đang khóa máy. 
        static public bool isLockWithAccount = false;

        // Biến này lưu người hiện tại đang đăng nhập là ai.
        static public Account CurrentAccount = null;

        // Biến này lưu nhóm máy hiện tại của Client 
        static public GroupClient GroupClient = null;

        // Biến này lưu thông tin về CLient hiện tại;
        static public Client Client = null;

        // Biến này lưu trạng thái của app Client có đang kết nối với máy chủ không. 
        static public bool isConnect = false;

        // Biến này lưu giá trị ClientId (Số máy) 
        static public int ClientId = 1;

        // Biến này để lưu Server IP, khi cài đặt phần mềm lên máy tính thì sẽ ghi vào fileDat.
        static public string ServerIp; 

        // Biến này là tên file chứa client Id, khi cài đặt sẽ đọc ghi file này.
        static public string DatFilePath = "Client.dat";

        // Biến này lưu các loại danh mục 
        static public List<Category> ListCategory;

        // Biến này lưu các item danh mục được trả về. 
        static public List<CategoryItem> ListCategoryItem; 

        // HubConnection chung của toàn bộ app. 
        static public HubConnection HubConnection
        {
            get; set; 
        }

        // Biến này dùng để lưu tổng thời gian. ( Tính bằng phút) 
        static public float TotalTime { get; set; } = 0f;

        // Biến này dùng để lưu thời gian đã trôi qua ( tính bằng phút ) 
        static public float ElapsedTime { get; set; } = 0f;

    }

    public class LoginModel{
        public string Username { get; set; }
        public string Password { get; set; }
    }

    // Cái này lưu vào file Dat.
    [Serializable]
    public class ClientInfoModel
    {
        public int ClientId { get; set; }
        public string ServerIp { get; set; }
    }


    // Class này chứa những method statics. 
    static public class StaticUtility
    {
        static public T Convert<T>(string json) where T: class
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }

    static public class EnpointUrl
    {
        static public string AccountLogin = String.Format("http://{0}/api/authentication/account", StaticModels.ServerIp);
        static public string ClientInfo = String.Format("http://{0}/api/client/", StaticModels.ServerIp);
        static public string GroupClientInfo = String.Format("http://{0}/api/groupclient/", StaticModels.ServerIp);

        // Ping Api ( Check connection ) 
        static public string PingEnpoint = String.Format("http://{0}/api/synctool/ping", StaticModels.ServerIp);

        // Logout Endpoint
        static public string LogoutEnpoint = String.Format("http://{0}/api/authentication/account/logout/", StaticModels.ServerIp);

        // Change pass 
        static public string ChangePasswordEndpoint = String.Format("http://{0}/api/accounts/changepass/", StaticModels.ServerIp);

        // Lấy về các category và categoryItem 
        static public string CategoryEndpoint = String.Format("http://{0}/api/category", StaticModels.ServerIp);
        static public string  CategoryItemEndpoint = String.Format("http://{0}/api/categoryitem", StaticModels.ServerIp);
        static public string CategoryImageEndpoint = String.Format("http://{0}/categoryItemImage/", StaticModels.ServerIp);

        //  SignalR Connect hub
        static public string ClientHubEndpoint = String.Format("http://{0}/client", StaticModels.ServerIp);
    }
}
