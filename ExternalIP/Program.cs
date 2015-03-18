using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExternalIP
{
	class Program
	{
		static void Main(string[] args)
		{
			string IP_Url = "http://myexternalip.com/raw";
			if(args.Length == 1)
			{
				IP_Url = args[0];
			}
			WebRequest Web_Request = WebRequest.Create(IP_Url);
			Stream Stream_Response = Web_Request.GetResponse().GetResponseStream();
			StreamReader Stream_Reader = new StreamReader(Stream_Response);
			Console.Write(Stream_Reader.ReadToEnd());
		}
	}
}
