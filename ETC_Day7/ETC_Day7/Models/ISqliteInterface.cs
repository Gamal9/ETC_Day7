using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ETC_Day7.Models
{
    public interface ISqliteInterface
    {
        SQLiteAsyncConnection GetConnection();
    }
}
