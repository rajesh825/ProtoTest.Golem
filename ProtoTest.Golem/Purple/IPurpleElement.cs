﻿using System;
using System.Windows.Automation;

namespace Golem.Purple
{
    public interface IPurpleElement
    {
        String ElementName { get; }
        String PurplePath { get; }
        AutomationElement UIAElement { get; }
    }
}