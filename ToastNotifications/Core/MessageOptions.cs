﻿using System;

namespace ToastNotifications.Core
{
    public class MessageOptions
    {
        public double? FontSize { get; set; }

        public bool ShowCloseButton { get; set; } = true;

        public object Tag { get; set; }

        public bool FreezeOnMouseEnter { get; set; } = true;

        public Action<NotificationBase> NotificationClickAction { get; set; } = delegate { };

        public Action<NotificationBase> CloseClickAction { get; set; } = delegate { };
        public bool UnfreezeOnMouseLeave { get; set; } = false;
    }
}
