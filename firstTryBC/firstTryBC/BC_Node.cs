using System;

namespace firstTryBC
{
	public class BC_Node
	{
		int wallet;
		String id;

		public BC_Node (int defaultWalletSize)
		{
			wallet = defaultWalletSize;
		}

		public String Id { get; set; }

		public void creditWallet(int amount)
		{
			wallet += amount;
		}s

		public bool debitWallet(int amount)
		{
			if (wallet >= amount)
			{
				wallet -= amount;
				return true;
			}
			else
				return false;
		}
	}
}
