/* -------------------------------------------------------------
	Archivo: TestCompara.cs
	Modulo: Test.Lansoft.Base
	Autor: LAOS
	Actualizado: 2019/Febrero/07
----------------------------------------------------------------*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lansoft.Base;


namespace Test.Lansoft.Base
{
    [TestClass]
    public class TestCompara
    {
        [TestMethod]
        public void AreEqual ()
        {
            // Prepara
            byte[] byteArray1 = new byte[] { 12, 89, 25, 39, 22 };
            byte[] byteArray2 = new byte[] { 12, 89, 25, 39, 22 };

            // Ejecuta
            bool result = Compara.AreEqual(byteArray1, byteArray2);

            // Comprueba
            Assert.IsTrue(result);
        }
    }
}
