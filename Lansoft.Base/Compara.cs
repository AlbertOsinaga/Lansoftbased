/* -------------------------------------------------------------
	Archivo: Compara.cs
	Modulo: Lansoft.Base
	Autor: LAOS
	Actualizado: 2019/febrero/07
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lansoft.Base
{
    public static class Compara
    {
        public static bool AreEqual(byte[] byteArray1, byte[] byteArray2)
        {
            if (byteArray1 == null || byteArray2 == null)
                return false;
            if (byteArray1.Length != byteArray2.Length)
                return false;

            for (int i = 0; i < byteArray1.Length; i++)
            {
                if (byteArray1[i] != byteArray2[i])
                    return false;
            }

            return true;
        }
    }
}
