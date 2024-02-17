using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Refresh1_24.Data;
using Refresh1_24.Model;
using Refresh1_24.Repository;
using Refresh1_24.Simulation;


Farm farm = new Farm();

farm.Start();

farm.DisplayInfo();

