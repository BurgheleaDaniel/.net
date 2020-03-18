
namespace CarStoreApp.Interfaces
{
	interface IVehicle
	{
		string Make
		{
			get;
			set;
		}

		string Model
		{
			get;
			set;
		}

		int Year
		{
			get;
			set;
		}

		decimal Price
		{
			get;
			set;
		}

		IProducer Producer
		{
			get;
			set;
		}
	}
}
