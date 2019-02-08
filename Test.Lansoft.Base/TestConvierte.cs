/* -------------------------------------------------------------
	Archivo: TestConvierte.cs
	Modulo: Test.Lansoft.Base
	Autor: LAOS
	Actualizado: 2019/Febrero/06
----------------------------------------------------------------*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lansoft.Base;

namespace Test.Lansoft.Base
{
	[TestClass]
	public class TestConvierte
	{
		[TestMethod]
		public void Convierte_BytesToInt_ArrayByte_ret_int()
		{
			// Prepara
			byte[] bytes = new byte[] { 0, 3, 183, 222 };

			// Ejecuta
			int entero = Convierte.BytesToInt(bytes);

			// Comprueba 
			Assert.AreEqual(243678, entero);
		}

		[TestMethod]
		public void Convierte_IntToBytes_int_ret_ArrayByte()
		{
			// Prepara
			int entero = 243678;

			// Ejecuta
			byte[] bytes = Convierte.IntToBytes(entero);

			// Comprueba 
			byte[] bytesEsperados = new byte[] { 0, 3, 183, 222 };
            Assert.IsTrue(Compara.AreEqual(bytesEsperados, bytes));
        }
    }
}
