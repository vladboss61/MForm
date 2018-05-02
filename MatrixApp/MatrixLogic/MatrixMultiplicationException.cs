using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp.MatrixLogic {
    public class MatrixMultiplicationException : Exception {
        public MatrixMultiplicationException(string msg) : base(msg) {
        }
    }
}
