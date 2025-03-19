using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Adapter
{
    public class SessionManager
    {
        private static SessionManager _instance;
        public Model.Account CurrentAccount { get; private set; }

        private SessionManager() { }

        public static SessionManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SessionManager();
                return _instance;
            }
        }

        public void SetCurrentAccount(Model.Account account)
        {
            CurrentAccount = account;
        }

        public void Logout()
        {
            CurrentAccount = null;
        }
    }

}
