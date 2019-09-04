using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooCoo
{
    public interface IEar
    {
        event CommandRecievedHandler CommandRecieved;
        void StartRecognition();
        void StopRecognition();
    }
}
