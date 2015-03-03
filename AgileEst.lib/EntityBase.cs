using System;

namespace AgileEst.lib
{
	public class EntityBase
	{
		public Guid Id { get; set; }
		public DateTime WhenCreated { get; set; }
		public DateTime WhenModified { get; set; }
	}
}