namespace InterfaceSegregationIdentityBefore
{
	using System.Collections.Generic;

	using InterfaceSegregationIdentityBefore.Contracts;

	public class AccountManager : IAccount, IPasswordRequirements
	{
		public int MinRequiredPasswordLength { get; set; }

		public int MaxRequiredPasswordLength { get; set; }

		public void ChangePassword(string oldPass, string newPass)
		{
			// change password
		}
	}
}
