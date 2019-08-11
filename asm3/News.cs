using System;

namespace asm3    
{
    public class News : INews
    {
        int id;
        string title;
        string publishDate;
        string author;
        string content;
        float avgRate;
        int[] rateList = new int[3];

        public News()
        {
        }

        public News(int id, string title, string publishDate, string author, string content)
        {
            this.id = id;
            this.title = title;
            this.publishDate = publishDate;
            this.author = author;
            this.content = content;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string PublishDate
        {
            get => publishDate;
            set => publishDate = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public float AvgRate
        {
            get => avgRate;
            set => avgRate = value;
        }

        public int this[int index]
        {
            get => rateList[index]; 
            set
            {
                if (value >= 1 && value <= 5)
                {
                    rateList[index] = value;
                }
                else if(value < 1)
                {
                    rateList[index] = 1;
                }else if (value > 5)
                {
                    rateList[index] = 5;
                }
            }
        }
        
        public void Display()
        {
            Console.WriteLine("id: "+id);
            Console.WriteLine("title: "+title);
            Console.WriteLine("publish Date: "+publishDate);
            Console.WriteLine("author: "+author);
            Console.WriteLine("content: "+content);
            Console.WriteLine("avg rate: "+avgRate);
        }

        public void Calculate()
        {
            int total = 0;
            foreach (int i in rateList)
            {
                total += i;
            }

            avgRate = (float) total / 3;
        }
    }
}