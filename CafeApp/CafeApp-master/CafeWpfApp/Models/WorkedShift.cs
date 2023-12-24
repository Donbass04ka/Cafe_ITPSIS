using System;
using System.Collections.Generic;

namespace CafeWpfApp
{
    public partial class WorkedShift
    {
        public int Id { get; set; }
        public int? StatusWorkedShiftId { get; set; }
        public int? OrderId { get; set; }

        public virtual Order? Order { get; set; }
        public virtual StatusWorkedShift? StatusWorkedShift { get; set; }
    }
}
