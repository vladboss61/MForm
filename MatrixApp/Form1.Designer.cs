namespace MatrixApp {
    partial class MatrixApplication {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.btnLoadFirstMatrix = new System.Windows.Forms.Button();
            this.matrixViewFirst = new System.Windows.Forms.DataGridView();
            this.matrixViewSecond = new System.Windows.Forms.DataGridView();
            this.btnLoadSecondMatrix = new System.Windows.Forms.Button();
            this.btnAddMatrix = new System.Windows.Forms.Button();
            this.btnMultMatrix = new System.Windows.Forms.Button();
            this.btnSubMatrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrixViewFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixViewSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFirstMatrix
            // 
            this.btnLoadFirstMatrix.Location = new System.Drawing.Point(288, 12);
            this.btnLoadFirstMatrix.Name = "btnLoadFirstMatrix";
            this.btnLoadFirstMatrix.Size = new System.Drawing.Size(60, 23);
            this.btnLoadFirstMatrix.TabIndex = 0;
            this.btnLoadFirstMatrix.Text = "Load";
            this.btnLoadFirstMatrix.UseVisualStyleBackColor = true;
            this.btnLoadFirstMatrix.Click += new System.EventHandler(this.LoadFirstMatrix);
            // 
            // matrixViewFirst
            // 
            this.matrixViewFirst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixViewFirst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixViewFirst.Location = new System.Drawing.Point(12, 12);
            this.matrixViewFirst.Name = "matrixViewFirst";
            this.matrixViewFirst.Size = new System.Drawing.Size(270, 150);
            this.matrixViewFirst.TabIndex = 1;
            // 
            // matrixViewSecond
            // 
            this.matrixViewSecond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixViewSecond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixViewSecond.Location = new System.Drawing.Point(436, 12);
            this.matrixViewSecond.Name = "matrixViewSecond";
            this.matrixViewSecond.Size = new System.Drawing.Size(270, 150);
            this.matrixViewSecond.TabIndex = 2;
            // 
            // btnLoadSecondMatrix
            // 
            this.btnLoadSecondMatrix.Location = new System.Drawing.Point(712, 12);
            this.btnLoadSecondMatrix.Name = "btnLoadSecondMatrix";
            this.btnLoadSecondMatrix.Size = new System.Drawing.Size(60, 23);
            this.btnLoadSecondMatrix.TabIndex = 3;
            this.btnLoadSecondMatrix.Text = "Load";
            this.btnLoadSecondMatrix.UseVisualStyleBackColor = true;
            this.btnLoadSecondMatrix.Click += new System.EventHandler(this.LoadSecondMatrix);
            // 
            // btnAddMatrix
            // 
            this.btnAddMatrix.Location = new System.Drawing.Point(301, 137);
            this.btnAddMatrix.Name = "btnAddMatrix";
            this.btnAddMatrix.Size = new System.Drawing.Size(27, 25);
            this.btnAddMatrix.TabIndex = 4;
            this.btnAddMatrix.Text = "+";
            this.btnAddMatrix.UseVisualStyleBackColor = true;
            this.btnAddMatrix.Click += new System.EventHandler(this.AddButtonMatrix);
            // 
            // btnMultMatrix
            // 
            this.btnMultMatrix.Location = new System.Drawing.Point(344, 137);
            this.btnMultMatrix.Name = "btnMultMatrix";
            this.btnMultMatrix.Size = new System.Drawing.Size(27, 25);
            this.btnMultMatrix.TabIndex = 5;
            this.btnMultMatrix.Text = "*";
            this.btnMultMatrix.UseVisualStyleBackColor = true;
            this.btnMultMatrix.Click += new System.EventHandler(this.MultiplicationButtomMatrix);
            // 
            // btnSubMatrix
            // 
            this.btnSubMatrix.Location = new System.Drawing.Point(386, 137);
            this.btnSubMatrix.Name = "btnSubMatrix";
            this.btnSubMatrix.Size = new System.Drawing.Size(27, 25);
            this.btnSubMatrix.TabIndex = 6;
            this.btnSubMatrix.Text = "-";
            this.btnSubMatrix.UseVisualStyleBackColor = true;
            this.btnSubMatrix.Click += new System.EventHandler(this.SubButtomMatrix);
            // 
            // MatrixApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 371);
            this.Controls.Add(this.btnSubMatrix);
            this.Controls.Add(this.btnMultMatrix);
            this.Controls.Add(this.btnAddMatrix);
            this.Controls.Add(this.btnLoadSecondMatrix);
            this.Controls.Add(this.matrixViewSecond);
            this.Controls.Add(this.matrixViewFirst);
            this.Controls.Add(this.btnLoadFirstMatrix);
            this.Name = "MatrixApplication";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrixViewFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixViewSecond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView matrixViewFirst;
        private System.Windows.Forms.DataGridView matrixViewSecond;
        private System.Windows.Forms.DataGridView resultView;

        private System.Windows.Forms.Button btnLoadFirstMatrix;
        private System.Windows.Forms.Button btnLoadSecondMatrix;
        private System.Windows.Forms.Button btnAddMatrix;
        private System.Windows.Forms.Button btnMultMatrix;
        private System.Windows.Forms.Button btnSubMatrix;
    }
}

