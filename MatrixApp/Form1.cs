using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixApp.MatrixLogic;

namespace MatrixApp {
    public partial class MatrixApplication : Form {
        Matrix matrixFirst = null;
        Matrix matrixSecond = null;

        public MatrixApplication() {
            InitializeComponent();
        }

        //Events
        private void LoadFirstMatrix(object sender, EventArgs e) {
      
            Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog() {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true

            };

            if ( openFileDialog.ShowDialog() == DialogResult.OK ){
                try
				{
                    if ((stream = openFileDialog.OpenFile()) != null )
					{
						using ( stream )
						{
							var matrix = MatrixTxT.FromTxtToMatrix(stream);
							matrixFirst = matrix;
							FillViewMatrix(matrixViewFirst,matrix);
						}
                    }
                } 
				catch ( IOException ex )
				{
                    MessageBox.Show("Error: File Exeption:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
				catch ( Exception ex )
				{
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void LoadSecondMatrix(object sender, EventArgs e) {
            Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog() {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true               
            };

            if ( openFileDialog.ShowDialog() == DialogResult.OK) {
                try{
                    if ( (stream = openFileDialog.OpenFile()) != null ){
                        using ( stream ){
                            var matrix = MatrixTxT.FromTxtToMatrix(stream);
                            matrixSecond = matrix;
                            FillViewMatrix(matrixViewSecond, matrix);
                        }
                    }
                } catch ( IOException ex ){
                    MessageBox.Show("Error: File Exeption:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch ( Exception ex ){
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private  void AddButtonMatrix(object sender, EventArgs e) {
            if ( matrixViewFirst.Rows.Count != 0 && matrixViewSecond.Rows.Count != 0 )
            {
               Resulter(MatrixHandler.Sum, MatrixHandler.Sum);
            }
            else
			{
                    MessageBox.Show("One or two matrix is empty", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }        

        private  void MultiplicationButtomMatrix(object sender, EventArgs e) {
            if ( matrixViewFirst.Rows.Count != 0 && matrixViewSecond.Rows.Count != 0 )
            {
                Resulter(MatrixHandler.Mul, MatrixHandler.Mul);
            } else
            {
                MessageBox.Show("One or two matrix is empty","Sub",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        

        private  void SubButtomMatrix(object sender, EventArgs e) {
            if ( matrixViewFirst.Rows.Count != 0 && matrixViewSecond.Rows.Count != 0 ){
               Resulter(MatrixHandler.Sub, MatrixHandler.Sub);
            } else
			{
                MessageBox.Show("One or two matrix is empty", "Sub", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //===============================================
        //Methods
        private async void Resulter(Func<Matrix, Matrix, Matrix> operationFirst, Func<Matrix,Matrix,Matrix> operationSecond) {            
            if ( resultView == null ){           
                resultView = new DataGridView() {               
                    ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                    Location = new Point(( Width - ( Width / 2 ) ) - 175, ( Height - ( Height / 2 ) )),
                    Name = "matrixViewSecond",
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    Size = new Size(270, 150),
                    TabIndex = 2
                };                
                Controls.Add(resultView);
            }

            var result = await Task.Run(()=> operationFirst(matrixFirst,matrixSecond));
            await Task.Run(() => MatrixTxT.FromMatrixToTxt(operationSecond(matrixFirst,matrixSecond)));
            FillViewMatrix(resultView, result);           
        }

        private void FillViewMatrix(DataGridView view, Matrix matrix){
            if ( view != null && matrix != null ){
                view.RowCount = matrix.GetSize().Item1;
                view.ColumnCount = matrix.GetSize().Item2;
                for ( int i = 0; i < view.RowCount; i++ ){
                    for ( int j = 0; j < view.ColumnCount; j++ ){
                        view[j, i].Value = matrix.GetMatrix()[i][j].ToString();                       
                    }
                }
            } else
                throw new ArgumentNullException("Error: null is view or matrix");
        }
    }
}
