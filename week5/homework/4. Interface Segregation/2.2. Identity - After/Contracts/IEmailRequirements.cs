namespace InterfaceSegregationIdentityBefore.Contracts
{
	using System.Collections.Generic;

	public interface IEmailRequirements
	{
		bool RequireUniqueEmail { get; set; }
	}
}
