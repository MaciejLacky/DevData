using DevData.Enitites;
using DevData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevData.Services
{
    public class DataService : IDataService<ModelData>
    {
        private DevDataDbContext _dbContext = new DevDataDbContext();

        public List<ModelData> GetAll()
        {
           
            List<ModelData> models = new List<ModelData>();
            ModelData modelData;
            var tableA = _dbContext.Table_A.ToList();
            var tableB = _dbContext.Table_B.ToList();
            var tableC = _dbContext.Table_C.ToList();
            foreach (var a in tableA)
            {
                modelData = new ModelData();
                modelData.Col_A1 = a.Col_A1;
                foreach (var b in tableB)
                {
                    modelData.Col_B1 = b.Col_B1;
                    modelData.Col_B3 = b.Col_B3;
                    foreach (var c in tableC)
                    {
                        modelData.Col_C3 = c.Col_C3;
                    }
                }  
                models.Add(modelData);
            }
            return models;
        }
    }
}
