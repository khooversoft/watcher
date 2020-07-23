﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WatcherRepository.Models;
using WatcherRepository.Records;

namespace WatcherRepository
{
    public interface IAgentController
    {
        Task<IReadOnlyList<TargetRecord>> GetAssignments(string agentName, CancellationToken token = default);
        Task LoadBalanceAssignments(CancellationToken token = default);
        Task Register(AgentRecord agentRecord, CancellationToken token = default);
        Task<bool> SetState(string agentName, AgentState agentState, CancellationToken token = default);
        Task UnRegister(string agentName, CancellationToken token = default);
    }
}