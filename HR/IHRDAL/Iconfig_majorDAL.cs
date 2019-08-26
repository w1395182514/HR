﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRDAL
{
    public interface Iconfig_majorDAL
    {
        int Add(config_majorModel cm);
        int Del(config_majorModel cm);
        int Update(config_majorModel cm);
        List<config_majorModel> Select();
        List<config_majorModel> SelectBy(config_majorModel cm);
    }
}