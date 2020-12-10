using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkRecorder_Client {
    class InvalidLicensePlateException : Exception {
        public InvalidLicensePlateException(string message) : base(message) {
        }
    }
}
