namespace InterfaceSegregationIdentityBefore.Contracts
{
	using System.Collections.Generic;

	public interface ISearchUsers
	{
		IEnumerable<IUser> GetAllUsersOnline();

		IEnumerable<IUser> GetAllUsers();

		IUser GetUserByName(string name);
	}
}
