/* -------------------------------------------------------------
	Archivo: SQLiteDB.cs
	Modulo: Lansoft.Base
	Autor: LAOS
	Actualizado: 2019/febrero/08
----------------------------------------------------------------*/

namespace Lansoft.Base
{
    public class SQLiteDB : DataBase
    {
        #region Constructores

        public SQLiteDB() : base(null, "System.Data.SQLite") { } 
        public SQLiteDB(string connectionString) : base(connectionString) { }

        #endregion
    }
}
