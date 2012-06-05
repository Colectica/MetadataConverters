using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colectica.BlaiseToDdi.Utility
{
	public static class IdentifierService
	{
		public static Guid GetIdentifier()
		{
			Guid id = Guid.NewGuid();

			// Outrageous code.
			while (Char.IsDigit(id.ToString(), 0))
			{
				id = Guid.NewGuid();
			}

			return id;
		}
	}
}
