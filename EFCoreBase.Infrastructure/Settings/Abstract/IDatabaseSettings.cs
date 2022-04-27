using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBase.Infrastructure.Settings.Abstract
{
    public interface IDatabaseSettings
    {
         string ProductCollectionName { get; set; }
         string CategoryCollectionName { get; set; }
         string ConnectionString { get; set; }
         string DatabaseName { get; set; }
    }
}
