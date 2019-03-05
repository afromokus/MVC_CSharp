using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation.Tests
{
    [TestClass()]
    public class NameValidatorTests
    {
        [TestMethod()]
        public void validationTestNameEmty()
        {
            try
            {
                NameValidator nv = new NameValidator("");
                nv.validation();
            }
            catch (Forma1.myexeption.NameNotValidNameIsEmptyException nnvniee)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Üres névre nem jó kivételt dob!");
            }
            Assert.Fail("Üres névre nem dob kivételt!");                            
        }
        [TestMethod()]
        public void validationTestIsNextToFirstLetterIsNotLower()
        {
            try
            {
                NameValidator nv = new NameValidator("NEmecsek");
                nv.validation();
            }
            catch (Forma1.myexeption.NextToFirstLetterIsNotLowerException nflinl)
            {
                return;
            }
            catch (Exception)
            {
                Assert.Fail("Első betű után nagybetűk és nem dob kivételt!");
            }
            Assert.Fail("Első betű után nagybetű, de nem dob kivételt!");

        }

        [TestMethod()]
        public void validationTestNameNotBeginWithUpperCase()
        {
            try
            {
                NameValidator nv = new NameValidator("nemecsek");
                nv.validation();
            }
            catch (Forma1.myexeption.NameNotValidFirstLetterProblemException nnvflpe)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Kisbetűvel kezdődő névre nem jó kivételt dob.");
            }
            Assert.Fail("Kisbetűs névre nem dob kivételt!");
        }
        [TestMethod()]
        public void validationTestNameValid()
        {           
            try
            {
                NameValidator nv = new NameValidator("Nemecsek");
                nv.validation();
            }
            catch (Exception e)
            {
                Assert.Fail("Jó névre kivételt dob.");
            }
        }
    }
}