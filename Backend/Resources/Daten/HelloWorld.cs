using System;
using System.Collections.Generic;

namespace Backend
{
	public class HelloWorld
	{
		private List<string> names;

		public HelloWorld ()
		{
			names = new List<string>();
		}

		public List<string> SayHallo (string name)
		{
			names.Add(name);
			return names;
		}
	}
}

