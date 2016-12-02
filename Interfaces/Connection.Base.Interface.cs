namespace GoodBytes.DAL.Base.Interfaces
{
	public interface IConnectionBaseInterface
	{
		object Transaction { get; set; }

		object Connection { get; set; }

		void Connect();

		void Disconnect();

		void TransactionFinish(bool finishedProperly = true);
	}
}