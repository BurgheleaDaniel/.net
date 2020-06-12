namespace InterfaceSegregationIdentityBefore.Contracts
{
	using System.Collections.Generic;

	public interface IAuthCommands : IEmailRequirements, IPasswordRequirements
	{
		bool RequireUniqueEmail { get; set; }

		int MinRequiredPasswordLength { get; set; }

		int MaxRequiredPasswordLength { get; set; }

		void Register(string username, string password);

		void Login(string username, string password);
	}
}
