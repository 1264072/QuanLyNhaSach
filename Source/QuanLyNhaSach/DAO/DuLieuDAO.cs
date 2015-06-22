using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DuLieuDAO
    {
        public static int SaoLuu(string path)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                try
                {
                    string dbname = bs.Database.Connection.Database;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("BACKUP DATABASE {0} TO DISK = '{1}' WITH INIT", dbname, path);
                    int i = bs.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sb.ToString());
                    return i;
                }
                catch (SqlException e)
                {
                    if (e.ErrorCode == -2146232060)
                    {
                        return 2;
                    }
                    return 0;
                }
            }
        }

        public static int PhucHoi(string path)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                try
                {
                    string dbname = bs.Database.Connection.Database;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("ALTER DATABASE {0} SET OFFLINE WITH ROLLBACK IMMEDIATE", dbname);
                    sb.AppendLine();
                    sb.AppendFormat("RESTORE DATABASE {0} FROM DISK = '{1}' WITH REPLACE", dbname, path);
                    sb.AppendLine();
                    sb.AppendFormat("ALTER DATABASE {0} SET ONLINE WITH ROLLBACK IMMEDIATE", dbname);
                    int i = bs.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sb.ToString());
                    return i;
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }
    }
}
