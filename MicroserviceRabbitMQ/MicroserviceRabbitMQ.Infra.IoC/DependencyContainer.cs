using MicroserviceRabbitMQ.Domain.Core.Bus;
using MicroserviceRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceRabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection servcies)
        {
            servcies.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
