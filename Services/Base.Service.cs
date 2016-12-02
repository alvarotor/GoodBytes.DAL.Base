using GoodBytes.DAL.Base.Interfaces;
using System;

namespace GoodBytes.DAL.Base.Services
{
	public abstract class BaseService : IBaseInterface
	{
		public virtual long ID { get; set; }

		public virtual string IDReturnName { get; set; }

		public virtual string ErrorsBuilder(Exception ex)
		{
			string result = string.Empty;
#if (DEBUG)
			result += ex.GetType().FullName + ": ";
#endif
			result += "Message: " + ex.Message;

			return result;
		}

		public virtual string ErrorsBuilderStack(Exception ex)
		{
			string result = string.Empty;
#if (DEBUG)
			result += "StackTrace: " + ex.StackTrace;
#endif
			return result;
		}

		public virtual string ErrorsBuilderInnerMessage(Exception ex)
		{
			string result = string.Empty;
#if (DEBUG)
			if (ex.InnerException != null)
				result += "InnerException Message: " + ex.InnerException.Message;
#endif
			return result;
		}

		public virtual string ErrorsBuilderInnerStack(Exception ex)
		{
			string result = string.Empty;
#if (DEBUG)
			if (ex.InnerException != null)
				result += "InnerException StackTrace: " + ex.InnerException.StackTrace;
#endif
			return result;
		}

		public virtual void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}