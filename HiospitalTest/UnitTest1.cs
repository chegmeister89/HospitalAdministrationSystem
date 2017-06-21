using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalAdministration;
namespace HospitalTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            //arrange
            PeopleList p = new PeopleList();  //testing the contents of the patient list



            // act
            string actual = p.AddPatient("Mr", "Joe", "Bloggs", "24/09/89", int.Parse("1213"), "joeb@gmail.com", "0857479345");



            //assert
            string added = "Patient Added";
            Assert.AreEqual(added, actual);

        }

        [TestMethod]

        public void TestMethod2()

        {
            //arrange
            PeopleList s = new PeopleList(); //testing the contents of the staff list


            //act
            string actual = s.AddStaff("Ms", "Mary", "Doyle", "29/07/91", int.Parse("1323"), "mdoyle@gmail.com", "0892342454");

            //assert
            string added = "Staff Added";
            Assert.AreEqual(added, actual);
        }



   







    }


}




            

        


    




