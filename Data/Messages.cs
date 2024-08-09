using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMaui5.Data
{
    public class RefreshMessage : ValueChangedMessage<bool>
    {
        public RefreshMessage(bool value) : base(value)
        {
        }
    }
}
