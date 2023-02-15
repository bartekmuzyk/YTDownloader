using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTDownloader
{
    internal class ProgressReportReceiver : IProgress<double>
    {
        private Action<double> callback;

        public ProgressReportReceiver(Action<double> func)
        {
            callback = func;
        }

        public void Report(double value)
        {
            callback.Invoke(value);
        }
    }
}
