using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Drawing;
using System.Data;

namespace BLL
{
    public class UserBLL
    {
        private string Encode(String Pass)
        {
            byte[] enData_byte = new byte[Pass.Length];
            enData_byte = Encoding.UTF8.GetBytes(Pass);
            string encodeData = Convert.ToBase64String(enData_byte);
            return encodeData;
        }
        private string Decode(String EncodedPass)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder decoder = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(EncodedPass);
            int charCount = decoder.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] charArray = new char[charCount];
            decoder.GetChars(todecode_byte, 0, todecode_byte.Length, charArray, 0);
            string result = new string(charArray);
            return result;

        }
        UserDAL dal = new UserDAL();
        public string Create(User u, UserGroup ug)
        {
            u.Password = Encode(u.Password);
            return dal.Create(u, ug);
        }
        public DataTable Read()
        {
            return dal.Read();
        }
        public bool IsRegistered()
        {
            return dal.IsRegistered();
        }
        public User Read(int id)
        {
            return dal.Read(id);
        }
        public User ReadU(string s)
        {
            return dal.ReadU(s);
        }
        public User ReadN(string Name)
        {
            return dal.ReadN(Name);
        }
        public List<string> ReadUserNames()
        {
            return dal.ReadUserNames();
        }
        public string Update(User u, int id)
        {
            u.Password = Encode(u.Password);
            return dal.Update(u, id);
        }
        public string Delete(int id)
        {
            return dal.Delete(id);
        }
        public User Login(string u, string p)
        {
            return dal.Login(u, Encode(p));
        }
        public bool Access(User u, string s, int a)
        {
            return dal.Access(u, s, a);
        }
        public List<User> ReadInvoicesList()
        {
            return dal.ReadInvoicesList();
        }
        public List<User> ReadActivity()
        {
            return dal.ReadActivity();
        }
    }
}
