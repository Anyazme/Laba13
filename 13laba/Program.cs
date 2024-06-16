using Bib10;

namespace Laba13
{
	public class Program
	{
		static void Main(string[] args)
		{
			

			MyObservableCollection<Aircraft> c1 = new MyObservableCollection<Aircraft>();
			MyObservableCollection<Aircraft> c2 = new MyObservableCollection<Aircraft>();

			Journal journal = new Journal();
			Journal journal2 = new Journal();

			c1.CollectionCountChanged += journal.AddEntry;
			c2.CollectionCountChanged += journal2.AddEntry;

			c1.CollectionReferenceChanged += journal2.AddEntry;
			c2.CollectionReferenceChanged += journal2.AddEntry;


			var a1 = new Aircraft();
			a1.RandomInit();
			c1.Add(a1);
			journal.Print();

			c1.Remove(a1);
			journal.Print();

			var a2 = new Aircraft();
			a2.RandomInit();
			c2.Add(a2);
			journal2.Print();

			c2.Remove(a2);
			journal2.Print() ;

		}
	}
}