namespace Strategy
{
	public class Encrypt
	{
		public void Encrypt(string file, EncryptStrategy encriptor)
		{
			encriptor.Encrypt(file);
		}
	}


	public class RunEncrypt
	{
		var file500MB = @"d:/somefile.dat";
		var encryptedFile500MB = new Encrypt(file500MB, new InMemoryEncryptor());

		var file20GB = @"d:/someOtherFile.dat";
		var encryptedFile20GB = new Encrypt(file20GB, new CloudEncryptor());
	}
}
