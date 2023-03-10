// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Microsoft.Extensions.Configuration;
// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;
// using ToDoList.Models;
// using System;

// namespace ToDoList.Tests
// {

//   [TestClass]
//   public class ItemTests : IDisposable
//   {

//     public IConfiguration Configuration { get; set; }

//     public void Dispose()
//     {
//       Item.ClearAll();
//     }
    
//     public ItemTests()
//     {
//       IConfigurationBuilder builder = new ConfigurationBuilder()
//           .AddJsonFile("appsettings.json");
//       Configuration = builder.Build();
//       DBConfiguration.ConnectionString = Configuration["ConnectionStrings:TestConnection"];
//     }

//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Item newItem = new Item("test", 2);
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }

//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       //Arrange
//       string description = "Walk the dog.";

//       //Act
//       Item newItem = new Item(description, 2);
//       string result = newItem.Description;

//       //Assert
//       Assert.AreEqual(description, result);
//     }

//     [TestMethod]
//     public void SetDescription_SetDescription_String()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Item newItem = new Item(description, 2);

//       //Act
//       string updatedDescription = "Do the dishes";
//       newItem.Description = updatedDescription;
//       string result = newItem.Description;

//       //Assert
//       Assert.AreEqual(updatedDescription, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsEmptyList_ItemList()
//     {
//       // Arrange
//       List<Item> newList = new List<Item> { };

//       // Act
//       List<Item> result = Item.GetAll();

//       // Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

// [TestMethod]
//   public void GetAll_ReturnsItems_ItemList()
//   {
//     //Arrange
//     string description01 = "Walk the dog";
//     string description02 = "Wash the dishes";
//     Item newItem1 = new Item(description01, 1);
//     newItem1.Save(); // New code
//     Item newItem2 = new Item(description02, 2);
//     newItem2.Save(); // New code
//     List<Item> newList = new List<Item> { newItem1, newItem2 };

//     //Act
//     List<Item> result = Item.GetAll();

//     //Assert
//     CollectionAssert.AreEqual(newList, result);
//   }

//     [TestMethod]
//     public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Item()
//     {
//       // Arrange, Act
//       Item firstItem = new Item("Mow the lawn", 2);
//       Item secondItem = new Item("Mow the lawn", 2);

//       // Assert
//       Assert.AreEqual(firstItem, secondItem);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsEmptyListFromDatabase_ItemList()
//     {
//       //Arrange
//       List<Item> newList = new List<Item> { };

//       //Act
//       List<Item> result = Item.GetAll();

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void ValueTypes_ReturnsTrueBecauseValuesAreTheSame_Bool()
//     {
//       // Arrange, Act
//       int test1 = 1;
//       int test2 = 1;

//       // Assert
//       Assert.AreEqual(test1, test2);
//     }

//     [TestMethod]
//     public void Save_SavesToDatabase_ItemList()
//     {
//       //Arrange
//       Item testItem = new Item("Mow the lawn", 2);

//       //Act
//       testItem.Save();
//       List<Item> result = Item.GetAll();
//       List<Item> testList = new List<Item>{testItem};

//       //Assert
//       CollectionAssert.AreEqual(testList, result);
//     }

//     [TestMethod]
//     public void Find_ReturnsCorrectItemFromDatabase_Item()
//     {
//       //Arrange
//       Item newItem = new Item("Mow the lawn", 1);
//       newItem.Save();
//       Item newItem2 = new Item("Wash dishes", 1);
//       newItem2.Save();

//       //Act
//       Item foundItem = Item.Find(newItem.Id);
//       //Assert
//       Assert.AreEqual(newItem, foundItem);
//     }
//   }
// }