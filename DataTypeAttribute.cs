using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    internal class DataTypeAttribute : Attribute
    {
        private DataType date;

        public DataTypeAttribute(DataType date)
        {
            this.date = date;
        }
    }
}