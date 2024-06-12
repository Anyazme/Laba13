using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba13
{
	public class Journal
	{
		//Инициализация списка объектов JournalEntry
		public List<JournalEntry> journals { get; set; } = new List<JournalEntry>();

		//вывод журналов и объектов
		public void Print()
		{
			//проход по каждой записи в списке
			foreach (var item in journals)
			{
				Console.WriteLine(item);
			}
		}

		//принимает в качестве аргументов объект, который сгенерировал событие и информацию о событии
		public void AddEntry(object source, CollectionHandlerEventArgs args)
		{
			//получение имени объекта
			string collectionName = source.GetType().Name.Split('`')[0];
			//создание нового объекта с именем коллекции и другой инфой и добавления
			journals.Add(new JournalEntry(collectionName, args.ChangeType, args.ChangedItem.ToString()));
		}

		//принимает в качестве аргументов объект, который сгенерировал событие и информацию о событии
		public void RemoveEntry(object source, CollectionHandlerEventArgs args)
		{
			//получение имени 
			string collectionName = source.GetType().Name;
			//создание нового объекта
			var entry = new JournalEntry(collectionName, args.ChangeType, args.ChangedItem.ToString());
			//удаление объекта 
			journals.Remove(entry);
		}
		
	}
}
