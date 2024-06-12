using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba13
{
		public class CollectionHandlerEventArgs : EventArgs
		{
			public string ChangeType { get; set; }
			public object ChangedItem { get; set; }

			public CollectionHandlerEventArgs(string changeType, object changedItem)
			{
				ChangeType = changeType;
				ChangedItem = changedItem;
			}

			public override string ToString()
			{
				return $"ChangeType: {ChangeType}, ChangedItem: {ChangedItem}";
			}
		}
	}

