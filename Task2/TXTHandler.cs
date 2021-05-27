﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class TXTHandler : AbstractHandrler
    {
        string name;
        public TXTHandler()
        {
            name = null;
            Create();
        }
        public TXTHandler(string name)
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
            Console.WriteLine("Вы отредактировали файл {0}.txt", name);
        }
        public override void Create()
        {
            Console.WriteLine("Вы создали файл {0}.txt", name);
        }
        public override void Open()
        {
            Console.WriteLine("Открылся файл {0}.txt", name);
        }
        public override void Save()
        {
            Console.WriteLine("Файл {0}.txt сохранен", name);
        }
    }
}
