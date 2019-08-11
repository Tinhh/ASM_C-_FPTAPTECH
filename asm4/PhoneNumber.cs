namespace asm4    
{
    public class PhoneNumber
    {
        public string name;
        public string phone;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }
        public PhoneNumber(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
    }
}