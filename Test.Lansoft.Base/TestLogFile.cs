/* -------------------------------------------------------------
	Archivo: TestLogFile.cs
	Modulo: Test.Lansoft.Base
	Autor: LAOS
	Actualizado: 2019/Febrero/08
----------------------------------------------------------------*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lansoft.Base;

namespace Test.Lansoft.Base
{

    [TestClass]
    public class TestLogFile
    {

        [TestMethod]
        public void LogFile_Write_str_ret_str()
        {
            // Prepara
            LogFile logFile = new LogFile("logErrores.txt");

            // Ejecuta
            string mensajeIn = "Este es un mensaje de prueba" + Environment.NewLine + "Con una segunda linea" + Environment.NewLine;
            string codigo = logFile.Write(mensajeIn);

            // Comprueba
            string mensajeOut = logFile.Read(codigo);
            Assert.AreEqual(mensajeOut, mensajeIn);
        }

    }

}
