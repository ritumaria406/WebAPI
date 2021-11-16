using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class VaccinationContext : DbContext
    {
        public VaccinationContext(DbContextOptions<VaccinationContext> options) :base(options)
        {            
        }
        public DbSet<VaccinationRequest> VaccinationRequest { get; set; }
    }
}
