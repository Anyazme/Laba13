using System.Collections.ObjectModel;
using Bib10;

namespace Laba13.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Test1()
		{
			// Arrange
			var journal = new Journal();
			var source = new List<string>(); // источник события
			var args = new CollectionHandlerEventArgs("Add", "NewItem");

			// Act
			journal.AddEntry(source, args);

			// Assert

			var entry = journal.journals[0];
			Assert.AreEqual("List", entry.CollectionName);
			Assert.AreEqual("Add", entry.ChangeType);
			Assert.AreEqual("NewItem", entry.ChangedItemData);
		}

		[TestMethod]
		public void Test2()
		{
			// Arrange
			var journal = new Journal();
			var source = new List<string>(); // источник события
			var args = new CollectionHandlerEventArgs("Add", "NewItem");

			// Act
			journal.AddEntry(source, args);

			// Assert
			Assert.AreEqual("List", journal.journals[0].CollectionName);
			Assert.AreEqual("Add", journal.journals[0].ChangeType);
			Assert.AreEqual("NewItem", journal.journals[0].ChangedItemData);
		}

		[TestMethod]
		public void Test3()
		{
			// Arrange
			var journal = new Journal();
			var source = new Dictionary<int, string>(); // источник события
			var args = new CollectionHandlerEventArgs("Update", "UpdatedItem");

			// Act
			journal.AddEntry(source, args);

			// Assert
			var entry = journal.journals[0];
			Assert.AreEqual("Dictionary", entry.CollectionName);
			Assert.AreEqual("Update", entry.ChangeType);
			Assert.AreEqual("UpdatedItem", entry.ChangedItemData);
		}

		[TestMethod]
		public void Test4()
		{
			// Arrange
			var journal = new Journal();
			var source = new List<string>(); // источник события
			var args = new CollectionHandlerEventArgs("Remove", "Item1");
			var entry = new JournalEntry("List", "Remove", "Item1");
			journal.journals.Add(entry);

			// Act
			journal.RemoveEntry(source, args);

			// Assert
			Assert.IsNotNull(journal.journals);
		}

		[TestMethod]
		public void Test5()
		{
			// Arrange
			var journal = new Journal();
			var source = new List<string>(); // источник события
			var args = new CollectionHandlerEventArgs("Remove", "Item1");
			var nonExistentEntry = new JournalEntry("List", "Remove", "NonExistentItem");
			journal.journals.Add(nonExistentEntry);

			// Act
			journal.RemoveEntry(source, args);

			// Assert
			Assert.AreEqual(nonExistentEntry, journal.journals[0]);
		}

		[TestMethod]
		public void Test6()
		{

		}
	}

		namespace Bib10
	{
		[TestClass]
		public class TestAircraft
		{

			[TestMethod]
			public void Test17()
			{
				// Arrange
				Aircraft aircraft1 = new Aircraft { Year = 2000 };
				Aircraft aircraft2 = new Aircraft { Year = 2000 };

				// Act
				bool result = aircraft1.Equals(aircraft2);

				// Assert
				Assert.IsTrue(result);
			}

			[TestMethod]
			public void Test18()
			{
				// Arrange
				Aircraft aircraft1 = new Aircraft { Year = 2000 };
				Aircraft aircraft2 = new Aircraft { Year = 1995 };

				// Act
				bool result = aircraft1.Equals(aircraft2);

				// Assert
				Assert.IsFalse(result);
			}

			[TestMethod]
			public void Test1()
			{
				//Arrange
				string expectedModel = "Íåò";
				int expectedYear = 0;
				string expectedType = "Íåò";
				int expectedNumber = 0;
				//Act
				Aircraft aircraft1 = new Aircraft(expectedModel, expectedYear, expectedType, expectedNumber);

				//Assert
				Assert.AreEqual(expectedModel, aircraft1.Model); //ñðàâíåíèå çíà÷åíèé íà ðàâåíñòâî
				Assert.AreEqual(expectedYear, aircraft1.Year);
				Assert.AreEqual(expectedType, aircraft1.Type);
				Assert.AreEqual(expectedNumber, aircraft1.Number);
			}


			[TestMethod]
			public void Test2()
			{
				//Arrange
				string expectedModel = "Boeing 737";
				int expectedYear = 2015;
				string expectedType = "GMF-67";
				int expectedNumber = 15;
				//Act
				Aircraft aircraft2 = new Aircraft(expectedModel, expectedYear, expectedType, expectedNumber);

				//Assert
				Assert.AreEqual(expectedModel, aircraft2.Model); //ñðàâíåíèå çíà÷åíèé íà ðàâåíñòâî
				Assert.AreEqual(expectedYear, aircraft2.Year);
				Assert.AreEqual(expectedType, aircraft2.Type);
				Assert.AreEqual(expectedNumber, aircraft2.Number);
			}

			[TestMethod]
			public void Test3()
			{
				//Arrange
				string expectedModel = "Íåò";
				int expectedYear = 0;
				string expectedType = "Íåò";
				int expectedNumber = 0;
				int expectedBladesNumber = 0;

				//Act
				Helicopter helicopter1 = new Helicopter(expectedModel, expectedYear, expectedType, expectedNumber, expectedBladesNumber);

				//Assert
				Assert.AreEqual(expectedModel, helicopter1.Model); //ñðàâíåíèå çíà÷åíèé íà ðàâåíñòâî
				Assert.AreEqual(expectedYear, helicopter1.Year);
				Assert.AreEqual(expectedType, helicopter1.Type);
				Assert.AreEqual(expectedNumber, helicopter1.Number);
				Assert.AreEqual(expectedBladesNumber, helicopter1.BladesNumber);
			}


			[TestMethod]
			public void Test4()
			{
				//Arrange
				string expectedModel = "Ìîäåëü 456";
				int expectedYear = 2001;
				string expectedType = "JUFC - 7";
				int expectedNumber = 15;
				int expectedBladesNumber = 7;

				//Act
				Helicopter helicopter2 = new Helicopter(expectedModel, expectedYear, expectedType, expectedNumber, expectedBladesNumber);

				//Assert
				Assert.AreEqual(expectedModel, helicopter2.Model); //ñðàâíåíèå çíà÷åíèé íà ðàâåíñòâî
				Assert.AreEqual(expectedYear, helicopter2.Year);
				Assert.AreEqual(expectedType, helicopter2.Type);
				Assert.AreEqual(expectedNumber, helicopter2.Number);
				Assert.AreEqual(expectedBladesNumber, helicopter2.BladesNumber);
			}

			[TestMethod]
			public void Test5()
			{
				//Arrange
				string expectedModel = "Íåò";
				int expectedYear = 0;
				string expectedType = "Íåò";
				int expectedNumber = 0;
				int expectedPassengersNumber = 0;
				int expectedRange = 0;


				//Act
				Plane plane1 = new Plane(expectedModel, expectedYear, expectedType, expectedNumber, expectedPassengersNumber, expectedRange);

				//Assert
				Assert.AreEqual(expectedModel, plane1.Model); //ñðàâíåíèå çíà÷åíèé íà ðàâåíñòâî
				Assert.AreEqual(expectedYear, plane1.Year);
				Assert.AreEqual(expectedType, plane1.Type);
				Assert.AreEqual(expectedNumber, plane1.Number);
				Assert.AreEqual(expectedPassengersNumber, plane1.PassengersNumber);
				Assert.AreEqual(expectedRange, plane1.Range);
			}

			[TestMethod]
			public void Test6()
			{
				//Arrange
				string expectedModel = "Boing 666";
				int expectedYear = 2021;
				string expectedType = "ZHFBR - 234";
				int expectedNumber = 9;
				int expectedPassengersNumber = 230;
				int expectedRange = 1500;


				//Act
				Plane plane1 = new Plane(expectedModel, expectedYear, expectedType, expectedNumber, expectedPassengersNumber, expectedRange);

				//Assert
				Assert.AreEqual(expectedModel, plane1.Model); //ñðàâíåíèå çíà÷åíèé íà ðàâåíñòâî
				Assert.AreEqual(expectedYear, plane1.Year);
				Assert.AreEqual(expectedType, plane1.Type);
				Assert.AreEqual(expectedNumber, plane1.Number);
				Assert.AreEqual(expectedPassengersNumber, plane1.PassengersNumber);
				Assert.AreEqual(expectedRange, plane1.Range);
			}

			[TestMethod]
			public void Test7()
			{
				//Arrange
				string expectedModel = "Íåò";
				int expectedYear = 0;
				string expectedType = "Íåò";
				int expectedNumber = 0;
				int expectedPassengersNumber = 0;
				int expectedRange = 0;
				string expectedFighterClass = "Íåò";


				//Act
				Fighter fighter1 = new Fighter(expectedModel, expectedYear, expectedType, expectedNumber, expectedPassengersNumber, expectedRange, expectedFighterClass);

				//Assert
				Assert.AreEqual(expectedModel, fighter1.Model); //ñðàâíåíèå çíà÷åíèé íà ðàâåíñòâî
				Assert.AreEqual(expectedYear, fighter1.Year);
				Assert.AreEqual(expectedType, fighter1.Type);
				Assert.AreEqual(expectedNumber, fighter1.Number);
				Assert.AreEqual(expectedPassengersNumber, fighter1.PassengersNumber);
				Assert.AreEqual(expectedRange, fighter1.Range);
				Assert.AreEqual(expectedFighterClass, fighter1.FighterClass);
			}

			[TestMethod]
			public void Test8()
			{
				//Arrange
				string expectedModel = "Ìîäåëü 595";
				int expectedYear = 1947;
				string expectedType = "Smash";
				int expectedNumber = 3;
				int expectedPassengersNumber = 200;
				int expectedRange = 4000;
				string expectedFighterClass = "Ïåðåõâàò÷èê";


				//Act
				Fighter fighter2 = new Fighter(expectedModel, expectedYear, expectedType, expectedNumber, expectedPassengersNumber, expectedRange, expectedFighterClass);

				//Assert
				Assert.AreEqual(expectedModel, fighter2.Model); //ñðàâíåíèå çíà÷åíèé íà ðàâåíñòâî
				Assert.AreEqual(expectedYear, fighter2.Year);
				Assert.AreEqual(expectedType, fighter2.Type);
				Assert.AreEqual(expectedNumber, fighter2.Number);
				Assert.AreEqual(expectedPassengersNumber, fighter2.PassengersNumber);
				Assert.AreEqual(expectedRange, fighter2.Range);
				Assert.AreEqual(expectedFighterClass, fighter2.FighterClass);

			}

			[TestMethod]
			public void Test9()
			{
				// Arrange (îæèäàåìûå çíà÷åíèÿ çàêðûòûõ àòðèáóòîâ)
				double expectedSpeed1 = 0;
				double expectedDistance1 = 0;

				// Act (ñîçäàíèå íîâîãî îáúåêòà)
				Runner runner1 = new Runner();

				// Assert 
				Assert.AreEqual(expectedSpeed1, runner1.Speed); //ñðàâíåíèå çíà÷åíèé íà ðàâåíñòâî
				Assert.AreEqual(expectedDistance1, runner1.Distance);
			}

			[TestMethod]
			public void Test10()
			{
				//Arrange
				double expectedSpeed = 10;
				double expectedDistance = 10;

				//Act
				Runner runner = new Runner(expectedSpeed, expectedDistance);

				//Assert
				Assert.AreEqual(expectedSpeed, runner.Speed);
				Assert.AreEqual(expectedDistance, runner.Distance);
			}

			[TestMethod]
			public void Test11()
			{
				// Arrange
				int Count = Runner.count;

				// Act
				Runner runner1 = new Runner();
				Runner runner2 = new Runner();
				int newCount = Runner.OutputCount();

				// Assert
				Assert.AreEqual(Count + 2, newCount);
			}

			[TestMethod]
			public void Test12()
			{
				// Arrange
				Aircraft aircraft1 = new Aircraft("Boeing 747", 2000, "Êðóòîé", 5);
				Aircraft aircraft2 = new Aircraft("Boeing 747", 2000, "Êðóòîé", 5);
				Aircraft aircraft3 = new Aircraft("Airbus A380", 2010, "Êðóòîé", 4);

				// Act & Assert
				Assert.IsTrue(aircraft1.Equals(aircraft2));
				Assert.IsFalse(aircraft1.Equals(aircraft3));
			}

			[TestMethod]
			public void Test13()
			{
				// Arrange
				Plane plane1 = new Plane("Boeing 747", 2000, "Ïàññàæèðñêèé", 5, 100, 1000);
				Plane plane2 = new Plane("Boeing 747", 2000, "Ïàññàæèðñêèé", 5, 100, 1000);
				Plane plane3 = new Plane("Airbus A380", 2010, "Ïàññàæèðñêèé", 4, 100, 1000);

				// Act & Assert
				Assert.IsTrue(plane1.Equals(plane2));
				Assert.IsFalse(plane1.Equals(plane3));
			}

			[TestMethod]
			public void Test14()
			{
				// Arrange
				Helicopter helicopter1 = new Helicopter("Boeing 747", 2000, "Áîëüøîé", 5, 6);
				Helicopter helicopter2 = new Helicopter("Boeing 747", 2000, "Áîëüøîé", 5, 6);
				Helicopter helicopter3 = new Helicopter("Boeing 747", 205, "Áîëüøîé", 5, 50);

				// Act & Assert
				Assert.IsTrue(helicopter1.Equals(helicopter2));
				Assert.IsFalse(helicopter1.Equals(helicopter3));
			}

			[TestMethod]
			public void Test15()
			{
				// Arrange
				Fighter fighter1 = new Fighter("Boeing 747", 2000, "Passenger", 5, 100, 1000, "Ïåðåõâàò÷èê");
				Fighter fighter2 = new Fighter("Boeing 747", 2000, "Passenger", 5, 100, 1000, "Ïåðåõâàò÷èê");
				Fighter fighter3 = new Fighter("Boeing 747", 2000, "Passenger", 5, 100, 1000, "Ôðîíòîâîé");

				// Act & Assert
				Assert.IsTrue(fighter1.Equals(fighter2));
				Assert.IsFalse(fighter1.Equals(fighter3));
			}

			[TestMethod]
			public void Test16()
			{
				// Arrange
				Aircraft aircraft = new Aircraft("Boeing 747", 2000, "Ïàññàæèðñêèé", 5);

				// Act
				string result = aircraft.ToString();

				// Assert
				Assert.AreEqual(" Boeing 747, 2000, Ïàññàæèðñêèé, 5", result);
			}

			[TestMethod]
			public void Test28()
			{
				// Arrange
				Helicopter helicopter = new Helicopter("Boeing 747", 2000, "Ïàññàæèðñêèé", 5, 6);
				string expected = "Boeing 747, 2000, Ïàññàæèðñêèé, 5, 6";

				// Act
				string result = helicopter.ToString();

				// Assert
				Assert.AreEqual(expected, result.Trim()); //  ìåòîä Trim() äëÿ óäàëåíèÿ ïðîáåëîâ
			}

			[TestMethod]
			public void Test26()
			{
				// Arrange
				Runner runner = new Runner();

				// Act
				runner.RandomInit();

				// Assert
				Assert.IsTrue(runner.Speed >= 1 && runner.Speed <= 20);
				Assert.IsTrue(runner.Distance >= 1 && runner.Distance <= 100);
			}

			[TestMethod]
			public void Test27()
			{
				// Arrange
				Runner runner = new Runner();

				// Act
				runner.RandomInit();

				// Assert
				Assert.IsTrue(runner.Speed > 0); // Îæèäàåòñÿ, ïîëîæèòåëüíîå ÷èñëî
				Assert.IsTrue(runner.Distance > 0); // Îæèäàåòñÿ, ïîëîæèòåëüíîå ÷èñëî
			}

			[TestMethod]
			public void Test20()
			{
				// Arrange
				Aircraft aircraft1 = new Aircraft("Boeing 747", 2000, "Ïàññàæèðñêèé", 5);
				Aircraft aircraft2 = new Aircraft("Airbus A320", 2005, "Ïàññàæèðñêèé", 6);

				// Act & Assert
				Assert.IsTrue(aircraft1.CompareTo(aircraft2) < 0);
			}

			[TestMethod]
			public void Test29()
			{
				// Arrange
				Plane plane = new Plane();

				// Act
				plane.Range = -100;

				// Assert
				Assert.AreEqual(0, plane.Range);
			}


		}
	}


	namespace Laba12_4
	{
		[TestClass]
		public class Testlaba12_4
		{
			[TestMethod]
			public void Test1()
			{
				// Arrange
				PointCollection<Aircraft> point = new PointCollection<Aircraft>(null);

				// Act
				var result = point.ToString();

				// Assert
				Assert.AreEqual("", result);
			}

			[TestMethod]
			public void Test2()
			{
				MyListCollection<Aircraft> list = new MyListCollection<Aircraft>();

				using (StringWriter sw = new StringWriter())
				{
					Console.SetOut(sw);
					list.PrintList();
					string expected = "The list is empty" + Environment.NewLine;
					Assert.AreEqual(expected, sw.ToString());
				}
			}

			[TestMethod]
			public void Test3()
			{
				Aircraft aircraft = new Aircraft();
				Aircraft aircraft1 = new Aircraft();
				Aircraft[] collection = new Aircraft[] { aircraft, aircraft1 };
				MyListCollection<Aircraft> list = new MyListCollection<Aircraft>(collection);
				Assert.AreEqual(collection.Length, list.Count);
			}

			[TestMethod]
			public void Test4()
			{
				Assert.ThrowsException<Exception>(() => new MyListCollection<Aircraft>(new Aircraft[0]));
			}

			[TestMethod]
			public void Test5()
			{
				MyListCollection<Aircraft> list = new MyListCollection<Aircraft>(3);
				Assert.AreEqual(3, list.Count);
			}


			[TestMethod]
			public void Test6()
			{
				MyListCollection<Aircraft> list = new MyListCollection<Aircraft>();
				Aircraft aircraft = new Aircraft();
				aircraft.RandomInit();
				list.AddToBegin(aircraft);
				Assert.AreEqual(1, list.Count);
			}

			[TestMethod]
			public void Test7()
			{
				MyListCollection<Aircraft> list = new MyListCollection<Aircraft>();
				Aircraft aircraft = new Aircraft();
				aircraft.RandomInit();
				list.AddToEnd(aircraft);
				Assert.AreEqual(1, list.Count);
			}

			[TestMethod]
			public void Test8()
			{
				// Arrange
				PointCollection<Aircraft> point = new PointCollection<Aircraft>();
				point.Data = default(Aircraft);

				// Act
				int hashCode = point.GetHashCode();

				// Assert
				Assert.AreEqual(default(int).GetHashCode(), hashCode);
			}

			[TestMethod]
			public void Test9()
			{
				// Arrange
				PointCollection<Aircraft> point = new PointCollection<Aircraft>();

				// Act

				// Assert
				Assert.AreEqual(default(Aircraft), point.Data);
				Assert.IsNull(point.Pred);
				Assert.IsNull(point.Next);
			}

			[TestMethod]
			public void Test14()
			{
				// Arrange
				MyListCollection<Aircraft> aircraftList = new MyListCollection<Aircraft>();
				Aircraft aircraft1 = new Aircraft();
				Aircraft aircraft2 = new Aircraft();
				aircraftList.AddToEnd(aircraft1);
				aircraftList.AddToEnd(aircraft2);

				// Act
				bool result = aircraftList.RemoveItem(aircraft1);

				// Assert
				Assert.IsTrue(result);
				Assert.AreEqual(1, aircraftList.Count);
			}

			[TestMethod]
			public void Test15()
			{
				// Arrange
				MyListCollection<Aircraft> list = new MyListCollection<Aircraft>();
				Aircraft aircraft = new Aircraft();
				list.AddToEnd(aircraft);

				// Act
				bool result = list.RemoveItem(aircraft);

				// Assert
				Assert.IsTrue(result);
				Assert.AreEqual(0, list.Count);
			}

			[TestMethod]
			public void Test16()
			{
				// Arrange
				MyListCollection<Aircraft> list = new MyListCollection<Aircraft>();
				Aircraft aircraft = new Aircraft("Plane1", 5, "Двигатель1", 7);

				// Act
				list.AddToBegin(aircraft);
				var foundPoint = list.FindItem(aircraft);
				var foundAircraft = foundPoint.Data;

				// Assert
				Assert.AreEqual(1, list.Count);
				Assert.AreEqual(aircraft, foundAircraft);
			}

			[TestMethod]
			public void Test17()
			{
				// Arrange
				MyListCollection<Aircraft> list = new MyListCollection<Aircraft>();

				// Act
				using (StringWriter sw = new StringWriter())
				{
					Console.SetOut(sw);
					list.PrintList();
					string expected = "The list is empty";
					string actual = sw.ToString();

					// Assert
					Assert.AreEqual(expected.Trim(), actual.Trim());
				}
			}


			[TestMethod]
			public void Test18()
			{
				// Arrange
				var list = new MyListCollection<Aircraft>(); // Создание экземпляра вашего класса списка
				var item1 = new Aircraft(); // Создание элемента списка
				var item2 = new Aircraft(); // Создание второго элемента списка

				list.AddToBegin(item1); // Добавление первого элемента в список

				// Act
				list.AddToBegin(item2); // Добавление второго элемента в список

				// Assert
				Assert.AreEqual(item2, list.beg.Data); // Проверка, что новый элемент стал первым в списке
				Assert.AreEqual(item1, list.beg.Next.Data); // Проверка, что старый первый элемент стал вторым
				Assert.AreEqual(null, list.beg.Pred); // Проверка, что у нового первого элемента нет предыдущего элемента
				Assert.AreEqual(list.beg, list.beg.Next.Pred); // Проверка, что у второго элемента указатель на предыдущий элемент указывает на новый первый элемент

			}





			[TestMethod]
			public void Test19()
			{
				// Arrange
				var list = new MyListCollection<Aircraft>(); // Создание экземпляра вашего класса списка
				var itemNotInList = new Aircraft(); // Создание элемента списка, которого нет в списке

				// Act
				var foundItem = list.FindItem(itemNotInList);

				// Assert
				Assert.IsNull(foundItem); // Проверка, что метод возвращает null при поиске элемента, которого нет в списке
			}

			[TestMethod]
			public void Test20()
			{

			}

			[TestMethod]
			public void Test30()
			{
				// Arrange
				PointCollection<Aircraft> instance = new PointCollection<Aircraft>();
				Aircraft aircraft = new Aircraft();
				aircraft.RandomInit();
				instance.Data = aircraft;

				// Act
				int hashCode = instance.GetHashCode();

				// Assert
				Assert.AreEqual(instance.Data.GetHashCode(), hashCode);
			}
		}

	}

}
