using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixApp.MatrixLogic {
    public static class MatrixHandler {
        public static bool IsEqualSize(Matrix a, Matrix b) {
            if ( a.GetSize().Equals(b.GetSize()) )
                return true;
            return false;
        }

        public static Matrix Negative(Matrix a) {        
            if ( a == null )
                return null;

            var matrix = a.GetMatrix();
            foreach ( var list in matrix )
            {
                for ( int i = 0; i < list.Count; i++ )
                {
                    list[i] = -list[i];
                }
            }


            return new Matrix(matrix);
        }

        public static Matrix Sum(Matrix a, Matrix b) {
            if ( !IsEqualSize(a, b) )
                throw new Exception("Different sizes of matrixes.");

            var m1 = a.GetMatrix();
            var m2 = b.GetMatrix();
            var matrix = new List<List<int>>();

            for ( int i = 0; i < m1.Count; i++ )
            {
                matrix.Add(new List<int>());
                for ( int j = 0; j < m1[0].Count; j++ )
                {
                    matrix[i].Add(m1[i][j] + m2[i][j]);
                }
            }

            return new Matrix(matrix);
        }

        public static Matrix Sub(Matrix a, Matrix b) {
            if ( !IsEqualSize(a, b) )
                throw new Exception("Different sizes of matrixes.");

            var m1 = a.GetMatrix();
            var m2 = b.GetMatrix();
            var matrix = new List<List<int>>();

            for ( int i = 0; i < m1.Count; i++ )
            {
                matrix.Add(new List<int>());
                for ( int j = 0; j < m1[0].Count; j++ )
                {
                    matrix[i].Add(m1[i][j] - m2[i][j]);
                }
            }
            return new Matrix(matrix);
        }

        public static Matrix Mul(Matrix a,Matrix b) {
            object locker = new object();
            if ( !IsMultiplicationMatrix(a,b) )
                throw new MatrixMultiplicationException("Incorrect size");

            var m1 = a.GetMatrix();
            var m2 = b.GetMatrix();

            var matrix = new List<List<int>>();

            for ( int i = 0; i < m1.Count; i++ )
            {
                matrix.Add(new List<int>());
                for ( int j = 0; j < m2[0].Count; j++ )
                {
                    var result = Task.Run(() => {
							var sumble = 0;
							for ( int k = 0; k < m2[0].Count; k++ )
							{
								var buffer_i = i;
								var buffer_j = j;
								sumble += m1[buffer_i][k] * m2[k][buffer_j];
							}
							return sumble;						
                    });
                    matrix[i].Add(result.Result);
                }
            }
            return new Matrix(matrix);
        }
        private static bool IsMultiplicationMatrix(Matrix l, Matrix r) {
            var hight = l.GetMatrix().Count;

            foreach ( var column in r.GetMatrix() )
            {
                if ( hight != column.Count )
                    return false;
            }
            return true;
        }
    }
}
