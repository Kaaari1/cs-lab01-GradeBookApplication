using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;
using GradeBook.GradeBooks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook (string name, bool IsWeighted) : base(name, IsWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
