﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacConstruct
{
    public class IocConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MessageRepository>().As<IMessageRepository>();
            builder.RegisterType<MessageService>();
            return builder.Build();
        }
    }
}
