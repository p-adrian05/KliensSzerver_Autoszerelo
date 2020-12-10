using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkRecorder_Client {
    public class InvalidCarTypeException : Exception {
        public InvalidCarTypeException(string message) : base(message) {
        }
    }
}
