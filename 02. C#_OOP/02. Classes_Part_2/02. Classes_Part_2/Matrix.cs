namespace Classes_Part_2
{
    using Bytes2you.Validation;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int r, int c)
        {
            Guard.WhenArgument(r, "Matrix size").IsLessThan(0).Throw();
            Guard.WhenArgument(c, "Matrix size").IsLessThan(0).Throw();

            this.matrix = new T[r, c];
        }

        public int Columns
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public T this[int index1, int index2]
        {
            get
            {
                Guard.WhenArgument(index1, "Index")
                    .IsGreaterThanOrEqual(matrix.GetLength(0))
                    .Throw();
                Guard.WhenArgument(index2, "Index")
                    .IsGreaterThanOrEqual(matrix.GetLength(1))
                    .Throw();

                return this.matrix[index1, index2];
            }
            set
            {
                Guard.WhenArgument(index1, "Index")
                    .IsGreaterThanOrEqual(matrix.GetLength(0))
                    .Throw();
                Guard.WhenArgument(index2, "Index")
                    .IsGreaterThanOrEqual(matrix.GetLength(1))
                    .Throw();
                if (value == null)
                {
                    throw new ArgumentNullException("Value can't be null");
                }

                this.matrix[index1, index2] = value;
            }
        }

        public static Matrix<T> operator+ (Matrix<T> one, Matrix<T> two)
        {
            if (one.Rows != two.Rows && one.Columns != two.Columns)
            {
                throw new ArgumentException("Matrices aren't of the same size");
            }

            Matrix<T> temp = new Matrix<T>(one.Rows, one.Columns);
            
            for (int i = 0; i < temp.Rows; i++)
            {
                for (int j = 0; j < temp.Columns; j++)
                {
                    temp[i, j] = (dynamic)one[i, j] + (dynamic)two[i, j];
                }
            }

            return temp;
        }

        public static Matrix<T> operator -(Matrix<T> one, Matrix<T> two)
        {
            if (one.Rows != two.Rows && one.Columns != two.Columns)
            {
                throw new ArgumentException("Matrices aren't of the same size");
            }

            Matrix<T> temp = new Matrix<T>(one.Rows, one.Columns);

            for (int i = 0; i < temp.Rows; i++)
            {
                for (int j = 0; j < temp.Columns; j++)
                {
                    temp[i, j] = (dynamic)one[i, j] - (dynamic)two[i, j];
                }
            }

            return temp;
        }

        public static Matrix<T> operator *(Matrix<T> one, Matrix<T> two)
        {
            if (one.Rows != two.Rows && one.Columns != two.Columns)
            {
                throw new ArgumentException("Matrices aren't of the same size");
            }

            Matrix<T> temp = new Matrix<T>(one.Rows, one.Columns);

            for (int i = 0; i < temp.Rows; i++)
            {
                for (int j = 0; j < temp.Columns; j++)
                {
                    temp[i, j] = (dynamic)one[i, j] * (dynamic)two[i, j];
                }
            }

            return temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    sb.Append(this.matrix[i, j].ToString().PadLeft(3));
                }
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
