﻿using BoschApp.EntityLayer.Entities.AlanEntity;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.EnjektorAltParcaEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Alan> Alans { get; set; }
        public DbSet<AltParca> AltParcas { get; set; }
        public DbSet<Departman> Departmants { get; set; }
        public DbSet<EnjektorAltParca> EnjektorAltParcas { get; set; }
        public DbSet<Enjektor> Enjektors { get; set; }
        public DbSet<Istasyon> Istasyons { get; set; }
        public DbSet<Kisim> Kisims { get; set; }
        public DbSet<Siparis> Siparises { get; set; }
        public DbSet<StokAlani> StokAlanis { get; set; }
        public DbSet<Uretim> Uretims { get; set; }
    }
}
