namespace Classes_Part_2
{
    using Bytes2you.Validation;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int size)
        {
            this.matrix = new T[size, size];
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
