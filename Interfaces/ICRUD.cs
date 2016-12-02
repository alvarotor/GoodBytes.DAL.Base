using System.Collections.Generic;

namespace GoodBytes.DAL.Base.Interfaces
{
	public interface ICRUD<T, B>
		where T : class
		where B : class
	{
		void Add(B model);
		void Delete(long id);
		void Update(T model);
		T Read(long id);
		List<T> All();
	}
}