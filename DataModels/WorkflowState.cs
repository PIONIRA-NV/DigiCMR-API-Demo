//-----------------------------------------------------------------------
// <copyright file="WorkflowState.cs" company="PIONIRA NV">
//     Copyright (c) 2017 PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    public enum WorkflowState
    {
        NotStarted = 0,
        Assigned = 1,
        Started = 2,
        EnteredEmptyContainerNumbers = 5,
        ArrivedAtPickup = 10,
        EnteredFullContainers = 15,
        StartPickup = 20
    }
}
