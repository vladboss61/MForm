using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp.MatrixLogic {
        public class Matrix {
            private readonly List<List<int>> _matrix; 

            //copy from another matrix
            public Matrix(List<List<int>> matrix) {
                _matrix = new List<List<int>>(matrix);
            }

            //fill new matrix 
            public Matrix(int length, int width, int value = 0) {
                _matrix = new List<List<int>>(length);
                for ( int i = 0; i < length; i++ )
                {
                    _matrix.Add(new List<int>());
                    for ( int j = 0; j < width; j++ )
                    {
                        _matrix[i].Add(value);
                    }
                }
            }

            public Matrix() {
                _matrix = null;
            }

        public List<List<int>> GetMatrix() {

            return _matrix;
        }	
            

            public (int, int) GetSize() {
                return (_matrix.Count, _matrix[0].Count);
            }

            public override string ToString() {    
                string str = "";
                foreach ( var list in _matrix )
                {
                    foreach ( var element in list )
                    {
                        str += element + " ";
                    }
                    str += "\n";
                }
                return str;
            } 
        } 
}
