using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUD.Models
{
    public class PersonalInfoContext: DbContext
    {
        public PersonalInfoContext(DbContextOptions<PersonalInfoContext> options): base(options)
        {

        }

        public DbSet<PersonalInfo> PersonalInfoList { get; set; }
    }
}
