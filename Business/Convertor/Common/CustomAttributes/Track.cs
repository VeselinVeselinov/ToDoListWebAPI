using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListWebAPI.Business.Convertor.Common.CustomAttributes
{
	/// <summary>
	/// Used for:
	///		- ignoring a property during a process(with the isIgnored value).
	///		- mapping a property to another property from an other object(with the Src and Destination values)
	/// </summary>
	class Track:Attribute
	{
		private string _src;
		private string _destination;
		private bool _ignored;

		public Track(string src, string destination, bool isIgnored)
		{
			_src = src;
			_destination = destination;
			_ignored = isIgnored;
		}

		public Track(string src, string destination)
		{
			_src = src;
			_destination = destination;
		}

		public Track(bool isIgnored)
		{
			_ignored = isIgnored;
		}

		public virtual string Src
		{
			get { return _src; }
		}

		public virtual bool IsIgnored
		{
			get { return _ignored; }
		}

		public virtual string Destination
		{
			get { return _destination; }
		}
	}
}
