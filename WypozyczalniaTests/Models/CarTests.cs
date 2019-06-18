using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wypozyczalnia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Wypozyczalnia.Models.Tests
{
    [TestClass()]
    public class CarTests
    {

        [TestMethod()]
        public void FillComboBoxes_TestCount()
        {
            Dictionary<string, string[]> dictionary = Car.FillComboBoxes();
            dictionary.Should().HaveCount(4);
        }

        [TestMethod()]
        public void FillComboBoxes_TestKeys()
        {
            Dictionary<string, string[]> dictionary = Car.FillComboBoxes();
            dictionary.Should().ContainKeys("category", "driveType", "engine", "gearbox");
        }

        [TestMethod()]
        public void FillComboBoxes_TestValues()
        {
            string[] categories = { "Hatchback", "Kombi", "Sedan", "Suv" };
            string[] driveTypes = { "AllDrive", "Przedni", "Tylny" };
            string[] engineTypes = { "Benzynowy", "Diesel", "Hybrydowy" };
            string[] gearboxTypes = { "Automatyczna", "Manualna" };

            Dictionary<string, string[]> dictionary = Car.FillComboBoxes();
            dictionary["category"].Should().BeEquivalentTo(categories);
            dictionary["driveType"].Should().BeEquivalentTo(driveTypes);
            dictionary["engine"].Should().BeEquivalentTo(engineTypes);
            dictionary["gearbox"].Should().BeEquivalentTo(gearboxTypes);
        }

        [TestMethod()]
        public void ValidateVINNumber_TestPositive()
        {
            Car car = new Car();
            car.VIN = "1G4PP5SK0E4200085";

            Dictionary<bool, string> dictionary = car.ValidateVINNumber();
            dictionary.Should().ContainKey(true);
            dictionary.Should().ContainValue("");
        }

        [TestMethod()]
        public void ValidateVINNumber_TestNegative_TooShort()
        {
            Car car = new Car();
            car.VIN = "1G4PP5SK0E420008";

            Dictionary<bool, string> dictionary = car.ValidateVINNumber();
            dictionary.Should().ContainKey(false);
            dictionary.Should().ContainValue("Wprowadzony numer VIN samochodu jest nieprawiłowy! (16 znaków zamiast 17)\n");
        }

        [TestMethod()]
        public void ValidateVINNumber_TestNegative_Empty()
        {
            Car car = new Car();
            car.VIN = "";

            Dictionary<bool, string> dictionary = car.ValidateVINNumber();
            dictionary.Should().ContainKey(false);
            dictionary.Should().ContainValue("Numer VIN samochodu nie może zostać pusty!\n");
        }

        [TestMethod()]
        public void ValidateVINNumber_TestNegative_IncorrectSign()
        {
            Car car = new Car();
            car.VIN = "1G4PP5SK0E42000O5" +
                "";

            Dictionary<bool, string> dictionary = car.ValidateVINNumber();
            dictionary.Should().ContainKey(false);
            dictionary.Should().ContainValue("Wprowadzony numer VIN samochodu jest nieprawiłowy! (Numer VIN nie może zawierać liter I, O i Q!\n");
        }

        [TestMethod()]
        public void ValidateLicensePlatenumber_TestPositive()
        {
            Car car = new Car();
            car.LicensePlateNum = "RZE1234";

            Dictionary<bool, string> dictionary = car.ValidateLicensePlatenumber();
            dictionary.Should().ContainKey(true);
            dictionary.Should().ContainValue("");
        }

        [TestMethod()]
        public void ValidateLicensePlatenumber_TestNegative_TooShort()
        {
            Car car = new Car();
            car.LicensePlateNum = "RZE123";

            Dictionary<bool, string> dictionary = car.ValidateLicensePlatenumber();
            dictionary.Should().ContainKey(false);
            dictionary.Should().ContainValue("Wprowadzony numer rejestracyjny samochodu jest nieprawiłowy! (6 znaków zamiast 7)");
        }

        [TestMethod()]
        public void ValidateLicensePlatenumber_TestNegative_Empty()
        {
            Car car = new Car();
            car.LicensePlateNum = "";

            Dictionary<bool, string> dictionary = car.ValidateLicensePlatenumber();
            dictionary.Should().ContainKey(false);
            dictionary.Should().ContainValue("Numer rejestracyjny samochodu nie może zostać pusty!");
        }

        [TestMethod()]
        public void ValidateLicensePlatenumber_TestNegative_IncorrectSignsOrder()
        {
            Car car = new Car();
            car.LicensePlateNum = "1234567";

            Dictionary<bool, string> dictionary = car.ValidateLicensePlatenumber();
            dictionary.Should().ContainKey(false);
            dictionary.Should().ContainValue("Wprowadzony numer rejestracyjny samochodu jest nieprawiłowy! (Co najmniej 2 pierwsze znaki muszą być literami)");
        }

        [TestMethod()]
        public void SimpleValidateCar_TestPositive()
        {
            Car car = new Car();
            car.Category = "Sedan";
            car.Manufacturer = "BMW";
            car.Model = "M3";
            car.Engine = "Benzynowy";
            car.Gearbox = "Automatyczna";
            car.DriveType = "Tylny";
            car.Cost = "200,99";
            car.LicensePlateNum = "RZE1234";
            car.VIN = "1G4PP5SK0E4200085";
            car.ProductionDate = new DateTime(2017, 01, 01);

            Dictionary<bool, string> dictionary = car.SimpleValidateCar();
            dictionary.Should().ContainKey(true);
            dictionary.Should().ContainValue("");
        }

        [TestMethod()]
        public void SimpleValidateCar_TestNegative()
        {
            Car car = new Car();
            car.Category = string.Empty;
            car.Engine = string.Empty;
            car.Gearbox = string.Empty;
            car.DriveType = string.Empty;
            car.ProductionDate = DateTime.MaxValue;

            string errors = string.Empty;
            errors += "Klasa samochodu nie może zostać pusta!\n";
            errors += "Marka samochodu nie może zostać pusta!\n";
            errors += "Model samochodu nie może zostać pusty!\n";
            errors += "Rodzaj napędu nie może zostać pusty!\n";
            errors += "Skrzynia biegów nie może zostać pusta!\n";
            errors += "Data produkcji nie może być większa niż obecna!\n";
            errors += "Silnik nie może zostać pusty!\n";
            errors += "Koszt wynajęcia samochodu nie może zostać pusty!\n";
            errors += "Numer VIN samochodu nie może zostać pusty!\n";
            errors += "Numer rejestracyjny samochodu nie może zostać pusty!";

            Dictionary<bool, string> dictionary = car.SimpleValidateCar();
            dictionary.Should().ContainKey(false);
            dictionary.Should().ContainValue(errors);
        }
    }
}