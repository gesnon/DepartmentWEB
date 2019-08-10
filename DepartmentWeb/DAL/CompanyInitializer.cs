using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentWeb.DAL
{
    public class CompanyInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<CompanyContext> //инициализация дазы данных
                                                                                                         // используется для добавления тестовых данных
    {
                       // можно сделать переопределение метода Seed(добавляет данные в базу при инициализации)
    }
}