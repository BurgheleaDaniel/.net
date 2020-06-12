namespace InterfaceSegregationIdentityBefore.Contracts
{
	using System.Collections.Generic;

	public interface IPasswordRequirements
	{
		int MinRequiredPasswordLength { get; set; }

		int MaxRequiredPasswordLength { get; set; }
	}
}
