﻿using KliensSzerverAutoszerelo_Common.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Autoszerelo_Szerver.Repositories
{
    public static class WorkRepository
    {
        public static IList<Work> GetWorks() 
        {
            using (var database = new WorkContext())
            {
                var works = database.Works.ToList();

                return works;
            }
        }

        public static void AddWork(Work work)
        {
            using (var database = new WorkContext())
            {
                database.Works.Add(work);

                database.SaveChanges();
            }
        }
        public static void UpdateWork(Work work) {
            using (var database = new WorkContext()) {
                database.Works.Update(work);

                database.SaveChanges();
            }
        }

        public static void DeleteWork(Work work) {
            using (var database = new WorkContext()) {
                database.Works.Remove(work);

                database.SaveChanges();
            }
        }

    }
}
