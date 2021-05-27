using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class XMLHandler : AbstractHandrler
    {
        string name;
        public XMLHandler()
        {
            name = null;
            Create();
        }
        public XMLHandler(string name)
        {
            this.name = name;
            Create();
        }
        public string Name 
        {
            get 
            {
                return name;    
            }
        }
        public override void Chenge()
        {
            Console.WriteLine("Вы отредактировали файл {0}.xml", name);
        }
        public override void Create()
        {
            Console.WriteLine("Вы создали файл {0}.xml", name);
        }
        public override void Open()
        {
            Console.WriteLine("Открылся файл {0}.xml", name);
        }
        public override void Save()
        {
            Console.WriteLine("Файл {0}.xml сохранен", name);
        }
    }
}
