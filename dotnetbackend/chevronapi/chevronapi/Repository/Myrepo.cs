using System;
using chevronapi.Models;
using chevronapi.Services;

namespace chevronapi.Repository
{
	public class Myrepo
	{
        private readonly DataContext _dt;

        public Myrepo(DataContext dt)
		{
            this._dt = dt;
        }

		public void Addperson(Person per)
		{
		
			_dt.mytable.Add(per);
			_dt.SaveChanges();
		}
		public List<Person> getperson()
		{
			return _dt.mytable.ToList();
		}
		public void delete(int id)
		{
			var person = (from x in _dt.mytable select x).Where(c => c.Id == id).FirstOrDefault();
			_dt.Remove(person);
			_dt.SaveChanges();

		}
	}
}

