using Bib10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laba13.CollectionHandler;


namespace Laba13
{
	public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);

	public class MyObservableCollection<T> : MyCollection<T> where T : IInit, ICloneable, IComparable, new()
	{
		public event CollectionHandler CollectionCountChanged;
		public event CollectionHandler CollectionReferenceChanged;

		public MyObservableCollection() : base() { }



		public new void Add(T item)
		{
			base.AddToEnd(item);
			NewCollectionCountChanged(new CollectionHandlerEventArgs("Элемент добавлен", item));
		}

		public new bool Remove(T item)
		{
			bool result = base.RemoveItem(item);
			if (result)
			{
				NewCollectionCountChanged(new CollectionHandlerEventArgs("Элемент удален", item));
			}
			return result;
		}

		protected virtual void NewCollectionCountChanged(CollectionHandlerEventArgs e)
		{
			CollectionCountChanged?.Invoke(this, e);
		}

		protected virtual void NewCollectionReferenceChanged(CollectionHandlerEventArgs e)
		{
			CollectionReferenceChanged?.Invoke(this, e);
		}
	}
}
