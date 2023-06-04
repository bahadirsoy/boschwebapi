﻿using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface IUretimRepository
    {
        bool UretimExist(int uretimId);
        Siparis GetSiparisByUretim(int uretimId);
        AltParca GetAltParcaByUretim(int uretimId);
    }
}
