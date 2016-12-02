using System;

namespace GoodBytes.DAL.Base.Interfaces
{
	public interface IBaseInterface
	{
		long ID { get; set; }

		string IDReturnName { get; set; }

		string ErrorsBuilder(Exception ex);
		string ErrorsBuilderStack(Exception ex);
		string ErrorsBuilderInnerMessage(Exception ex);
		string ErrorsBuilderInnerStack(Exception ex);
	}
}