using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thuchanh.Entity;

using thuchanh.Utils;

namespace thuchanh.Model
{
    class ModelContact
    {
       
            public bool Insert(Contact contact)
            {
                try
                {
                    using (var stt = UtilsSQL.GetIntances().Connection.Prepare("INSERT INTO Contact (Name, Phone) VALUES (?, ?)"))
                    {
                        stt.Bind(1, contact.Name);
                        stt.Bind(2, contact.Phone);

                        stt.Step();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                return false;
            }

        public Contact Search(string name, string phone)
        {
            try
            {
                var contact = new Contact();
                using (var stt = UtilsSQL.GetIntances().Connection.Prepare("SELECT * from Contact Where Name = ? AND Phone  =?"))
                {
                    stt.Bind(1, name);
                    stt.Bind(1, phone);
                    if (stt.Step() == SQLitePCL.SQLiteResult.ROW)
                    {
                        contact.Name = (string)stt[1];
                        contact.Phone = (string)stt[2];
                    }
                    return contact;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
