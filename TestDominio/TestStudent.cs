using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;

namespace TestDominio
{
    /// <summary>
    /// Descripción resumida de TestStudent
    /// </summary>
    [TestClass]
    public class TestStudent
    {
        public TestStudent()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        

        [TestMethod]
        public void TestStudentBuilder()
        {
            student testStudentvariable = new student();
            Assert.AreEqual("", testStudentvariable.name);
            Assert.AreEqual("", testStudentvariable.surname);
            Assert.AreEqual(null, testStudentvariable.subjects);
            Assert.AreEqual(0, testStudentvariable.idcard);
            Assert.AreEqual(0, testStudentvariable.number);
            Assert.AreEqual(0, testStudentvariable.x);
            Assert.AreEqual(0, testStudentvariable.y);
            Assert.AreEqual(null, testStudentvariable.payments);
        }

        [TestMethod]
        public void TestStudentBuilderWithParameters()
        {
            student testStudentvariable = new student("name","surname");
            Assert.AreEqual("name", testStudentvariable.name);
            Assert.AreEqual("surname", testStudentvariable.surname);
            Assert.AreEqual(null, testStudentvariable.subjects);
            Assert.AreEqual(0, testStudentvariable.idcard);
            Assert.AreEqual(0, testStudentvariable.number);
            Assert.AreEqual(0, testStudentvariable.x);
            Assert.AreEqual(0, testStudentvariable.y);
            Assert.AreEqual(null, testStudentvariable.payments);
        }


        }
}
