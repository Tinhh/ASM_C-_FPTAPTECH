using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace asm4
{
    public delegate void ChageValue(string s);

    public delegate void RemoveValue(string s);
    public class PhoneBook:Phone
    {
        public event ChageValue PhoneChage ;
        public event RemoveValue PhoneRemove;
        public List<PhoneNumber> PhoneList;

        public override bool InsertPhone(string name, string phone)
        {
            if (PhoneList == null)
            {
                PhoneList = new List<PhoneNumber>();
            }
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    if (!p.Equals(phone))
                    {
                        p.Phone += ":" + phone;
                    }
                    return false;
                }

                PhoneList.Add(new PhoneNumber(name, phone));
            }
            return true;
        }

        public override bool RemovePhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    PhoneList.Remove(p);
                    if (PhoneRemove!=null)
                    {
                        Console.WriteLine("Delete");
                    }
                    
                    return true;
                }
            }

            return false;
        }

        public static void Notify(string s)
        {
            Console.WriteLine(s);
        }
        public override bool UpdatePhone(string name, string newphone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                p.Phone = newphone;
                if (PhoneChage == null)
                {
                    PhoneChage += Notify;
                }
                PhoneChage("Delete "+name );
                return true;
            }

            return false;
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }
            return null;
        }
    }
}