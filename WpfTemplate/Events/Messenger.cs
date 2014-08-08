using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTemplate.Events
{
	class Messenger
	{
		private static Messenger _instance;
		public static Messenger Instance
		{
			get
			{
				return _instance ?? (_instance = new Messenger());
			}
		}

		public void Post(string msg)
		{
			var h = Received;
			if (h != null) h(this, msg);
		}

		public event EventHandler<string> Received;
	}
}
