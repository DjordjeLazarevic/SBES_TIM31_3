using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager;
using System.Security.Cryptography.X509Certificates;
using Common;

namespace Service
{
	public class WCFService : IWCFContract
	{
		public void TestCommunication()
		{
			Console.WriteLine("Communication established.");
		}

    }
}
