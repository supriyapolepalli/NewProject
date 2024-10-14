using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace REcruitcat.Data
{
    public class REcruitcatContext : DbContext
    {
        public REcruitcatContext(DbContextOptions<REcruitcatContext> options)
            : base(options)
        {

        }
    }
}
