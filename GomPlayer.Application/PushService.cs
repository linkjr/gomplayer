﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.IApplication;
using GomPlayer.TransferObjects;
using Tang.Infrastructure.Net.Push;

namespace GomPlayer.Application
{
    public class PushService : IPushService
    {
        private readonly IPush push;

        public PushService()
        {
            this.push = new XgPush();
        }

        public void Push(PushTransferObject dataObject)
        {
            if (string.IsNullOrEmpty(dataObject.Token))
            {
                var message = new AllNotification
                {
                    MessageType = MessageTypeOptions.Message,
                    Title = string.Empty,
                    Content = dataObject.WebUrl,
                    Args = new Dictionary<string, object>
                { 
                    {"level" , 2 },
                    {"weburl",  dataObject.WebUrl},
                    {"apkurl", dataObject.ApkUrl}
                }
                };
                var msg = this.push.All(message);
            }
            else
            {
                var message = new Notification
                {
                    Token = dataObject.Token,
                    MessageType = MessageTypeOptions.Message,
                    Title = string.Empty,
                    Content = dataObject.WebUrl,
                    Args = new Dictionary<string, object>
                { 
                    {"level" , 2 },
                    {"weburl",  dataObject.WebUrl},
                    {"apkurl", dataObject.ApkUrl}
                }
                };
                var msg = this.push.Single(message);
            }
        }
    }
}
