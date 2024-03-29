﻿
//var converter = new ObjectToTextConverter();
//Console.WriteLine(converter.Convert(new House("123 Maple Road", 170.6, 2)));
//class ObjectToTextConverter
//{
//	public string Convert(object obj)
//	{
//		Type type = obj.GetType();
//		var properties = type.GetProperties().Where(p => p.Name != "EqualityContract");

//		return String.Join(", ", properties.Select(property => $"{property.Name} is {property.GetValue(obj)}"));
//	}
//}

//public record Pet(string Name, PetType PetType, float Weight);
//public record House(string Address, double Area, int Floors);
//public enum PetType { Cat, Dog, Fish }


//using System.ComponentModel.DataAnnotations;

//var validPerson = new Person("John", 1981);
//var invalidDog = new Dog("R");
//var validator = new Validator();

//Console.WriteLine(validator.Validate(validPerson) ? "Person is valid" : "Person is invalid");
//Console.WriteLine(validator.Validate(invalidDog) ? "Dog is valid" : "Dog is invalid");
//Console.ReadKey();

//public class Dog
//{
//	[StringLengthValidate(2, 10)]
//	public string Name { get; } // length must be between 2 and 10
//	public Dog(string name) => Name = name;
//}


//public class Person
//{
//	[StringLengthValidate(2, 25)]
//	public string Name { get; } // length must be between 2 and 25
//	public int YearOfBirth { get; }

//	public Person(string name, int yearOfBirth)
//	{
//		Name = name;
//		YearOfBirth = yearOfBirth;
//	}

//	public Person(string name) => Name = name;
//}

//[AttributeUsage(AttributeTargets.Property)]
//class StringLengthValidateAttribute : Attribute
//{
//	public int Min { get; }
//	public int Max { get; }

//	public StringLengthValidateAttribute(int min, int max)
//	{
//		Min = min;
//		Max = max;

//	}
//}

//class Validator
//{
//	public bool Validate(object obj)
//	{
//		var type = obj.GetType();
//		var propertiesToValidate = type.GetProperties().Where(property => Attribute.IsDefined(property, typeof(StringLengthValidateAttribute)));

//		foreach (var property in propertiesToValidate)
//		{
//			object? propertyValue = property.GetValue(obj);
//			if (propertyValue is not string)
//			{
//				throw new InvalidOperationException(
//					$"Attribute {nameof(StringLengthValidateAttribute)}" +
//					$" can only be applied to strings");
//			}

//			var value = (string)propertyValue;
//			var attribute = (StringLengthValidateAttribute)property.GetCustomAttributes(typeof(StringLengthValidateAttribute), true).First();
//			if (value.Length < attribute.Min || value.Length > attribute.Max)
//			{
//				Console.WriteLine($"Property {property.Name} is invalid." + $"Value is {value}");
//				return false;
//			}
//		}
//		return true;
//	}
//}

//[Some(new int[] { 1, 2, 3 })]
//public class SomeClass
//{

//}

//public class SomeAttribute : Attribute
//{
//	public SomeAttribute(int[] numbers)
//	{
//		Numbers = numbers;
//	}

//	public int[] Numbers { get; }
//}

//var point = new Point(1, 3);
//var anotherPoint = point;
//anotherPoint.Y = 100;

//Console.WriteLine("point is: " + point);
//Console.WriteLine("anotherPoint is: " + anotherPoint);

//SomeMethod(5);
//SomeMethod(new Person());

//Point nullPoint = null;
//Person person = new Person();
//var point = new Point();

Console.ReadKey();

//void SomeMethod<T>(T param) where T : class
//{

//}

struct Point
{
	public int X { get; set; }
	public int Y { get; set; }


	public Point(int x, int y)
	{
		X = x;
		Y = y;
	}

	public override string ToString() => $"X: {X}, Y: {Y}";


}



class Person
{
	//private Point _favoritePoint;
	//private Person _favoritePerson;
	public Person ClosestPoint { get; }
	public int Id { get; init; }
	public string Name { get; init; }

	public Person(int id, string name)
	{
		Id = id;
		Name = name;

	}
}