using Microsoft.VisualStudio.TestTools.UnitTesting;
using MotoCare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare.Tests
{
    [TestClass()]
    public class EntretienTests
    {
        [TestMethod()]
        public void EntretienTestCtorPremier()
        {
            Entretien entretien = new Entretien("1", "Vidange", "8000", "8000", "", "", "0", "1");

            Assert.AreEqual("1", entretien.IdMaintenance);
            Assert.AreEqual("Vidange", entretien.Description);
            Assert.AreEqual("8000", entretien.FreqKm);
            Assert.AreEqual("8000", entretien.KmPremiereMaintenance);
            Assert.AreEqual("", entretien.KmDerniereMaintenance);
            Assert.AreEqual(new DateTime(), entretien.DateDerniereMaintenance);
            Assert.AreEqual(false, entretien.Fait);
            Assert.AreEqual("1", entretien.IdVehicule);
        }
        [TestMethod()]
        public void EntretienTestCtorRépétition()
        {
            Entretien entretien = new Entretien("1", "Vidange", "8000", "8000", "", "", "0", "1");

            Assert.AreEqual("1", entretien.IdMaintenance);
            Assert.AreEqual("Vidange", entretien.Description);
            Assert.AreEqual("8000", entretien.FreqKm);
            Assert.AreEqual("", entretien.KmPremiereMaintenance);
            Assert.AreEqual("", entretien.KmDerniereMaintenance);
            Assert.AreEqual(new DateTime(), entretien.DateDerniereMaintenance);
            Assert.AreEqual(false, entretien.Fait);
            Assert.AreEqual("1", entretien.IdVehicule);
        }
    }
}