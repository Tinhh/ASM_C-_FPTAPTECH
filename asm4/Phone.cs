using System.Globalization;

namespace asm4
{
    public abstract class Phone
    {
        public abstract bool InsertPhone(string name, string phone);
        public abstract bool RemovePhone(string name);
        public abstract bool UpdatePhone(string name, string newphone);
        public abstract PhoneNumber SearchPhone(string name);
    }
    

}