using System;
using System.Collections.Generic;
using System.Text;

namespace IxMilia.Step.Items
{
    public class StepBoundedSurface : StepSurface
    {
        public StepBoundedSurface(string name) : base(name)
        {
        }
        // TODO implement BoundedSurface
        public override StepItemType ItemType => StepItemType.BoundedSurface;
    }
}
