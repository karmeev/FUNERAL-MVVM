﻿using Domain.Complect;
using Infrastructure.Connector;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace Infrastructure.Complect
{
    public class ComplectRepos : GenConnector
    {
        public List<ItemComplectEntity> GetItems()
        {
            Connect("MaterialDB");
            SqlDataAdapter sqlDataAdapter = new("SELECT * FROM Material", _sqlConnection);
            DataSet ds = new();
            sqlDataAdapter.Fill(ds);
            ds.IsInitialized.ToString();
            List<ItemComplectEntity> items = new List<ItemComplectEntity>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                items.Add(new ItemComplectEntity()
                {
                    Id = Convert.ToInt32(dr[0].ToString()),
                    Name = dr[1].ToString(),
                    Money = Convert.ToInt32(dr[2].ToString()),
                });
            }
            return items;
        }
    }
}