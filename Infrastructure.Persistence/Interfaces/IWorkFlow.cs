using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IWorkFlow
    {
        object StartWorkflow();
        object CheckWorkflowStatus();
    }
}
