﻿using System.Collections.Generic;

namespace ChuanGoing.Base.Interface.Domain
{
    /// <summary>
    /// 领域实体对象接口定义
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public interface IDomainEntity<TPrimaryKey> : IAggregateRoot<TPrimaryKey>, IPurgable, IVersionSetter
    {
        IEnumerable<IDomainEvent<TPrimaryKey>> UnCommitEvents { get; }
        void Replay(IEnumerable<IDomainEvent<TPrimaryKey>> events);
        long Version { get; }
    }
}