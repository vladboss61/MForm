using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp.MatrixLogic {
    public static class MatrixTxT {
        public static void FromMatrixToTxt(Matrix a, string filename = "Matrix") {
            var matrix = a.GetMatrix();
            using ( var fStream = new StreamWriter(Environment.CurrentDirectory + "\\" + filename + ".txt") )
            {
                foreach ( var list in matrix )
                {
                    string str = null;
                    foreach ( var element in list )
                    {
                        str += element + " ";
                    }
                    fStream.WriteLine(str);
                }
            }
        }

        public static Matrix FromTxtToMatrix(string filename = "Matrix") {
            string[] lines = File.ReadAllLines(filename);
            var matrix = new List<List<int>>();

            foreach ( var line in lines )
            {
                var numbers = line.Trim().Split(' ');
                var list = new List<int>();

                foreach ( var number in numbers )
                {
                    list.Add(Int32.Parse(number));
                }
                matrix.Add(list);
            }
            return new Matrix(matrix);
        }
        public static Matrix FromTxtToMatrix(Stream stream) {
            var lines = new List<string>();
            using(var sr = new StreamReader(stream)){
                while(!sr.EndOfStream){
                    lines.Add(sr.ReadLine());
                }
            }
            
            var matrix = new List<List<int>>();        
            foreach ( var line in lines )
            {
                var numbers = line.Trim().Split(' ');
                var list = new List<int>();
                foreach ( var number in numbers )
                {
                    list.Add(Int32.Parse(number));
                }
                matrix.Add(list);
            }
            return new Matrix(matrix);
        }

    }
}
