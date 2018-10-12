using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GCLesson
{
    public class SomeFilesCreator : IDisposable
    {
        //какие-то методы для работы с файлами

        public void Open()
        {
            //реализация открытия потоков, подключения и т.д.
        }

        public void Close()
        {
            //реализация закрытия потоков, подключения и т.д.
        }

        public void Dispose()
        {
            //очистка неуправляемых ресурсов
        }
    }
}
