﻿using System;
using System.Collections.Generic;
using Panteon.Sdk;

namespace Panteon.Host.Interface
{
    public interface IPanteonEngine
    {
        IEnumerable<IPanteonTask> GetTasks();
        void Start();
        void Stop(bool immediate);
        bool StopTask(string name);
        bool StartTask(string name, DateTimeOffset lastKnownEvent=(default(DateTimeOffset)));
        bool UpdateTask(string name, string scheduleExpression);
    }
}