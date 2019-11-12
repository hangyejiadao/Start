﻿using ChuanGoing.Base.Interface.Event;
using ChuanGoing.Web.API.Events;
using System.Threading;
using System.Threading.Tasks;

namespace ChuanGoing.Web.API.EventHandlers
{
    public class CustomerCreatedEventHandler : IEventHandler<CustomerCreatedEvent>
    {
        public bool CanHandle(IEvent @event)
            => @event.GetType().Equals(typeof(CustomerCreatedEvent));

        public Task<bool> HandleAsync(CustomerCreatedEvent @event, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(true);
        }

        public Task<bool> HandleAsync(IEvent @event, CancellationToken cancellationToken = default(CancellationToken))
            => CanHandle(@event) ? HandleAsync((CustomerCreatedEvent)@event, cancellationToken) : Task.FromResult(false);
    }
}