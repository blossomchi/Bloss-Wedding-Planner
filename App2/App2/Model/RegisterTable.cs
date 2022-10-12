using SQLite;
using System;
using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;
using System.Text;

namespace App2.Model
{
   public  class RegisterTable
    { 
        [PrimaryKey, AutoIncrement]
        public int CusID { get; set; }
        public string BrideName { get; set; }
        public string BrideGender { get; set; }
        public string GroomName { get; set; }
        public string GroomGender { get; set; }
        public DateTime WeddingDate { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public virtual List<NewFoodTable> NewFoodTable { get; set; }


        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public virtual List<SeatsTable> SeatsTable { get; set; }
    }


    public class NewFoodTable
    {
        [PrimaryKey, AutoIncrement]
        public int FoodID { get; set; }
        public string FoodName { get; set; }

        [ForeignKey(typeof(RegisterTable))]
        public int RegisterCusID { get; set; }

    }

    public class SeatsTable
    {
        [PrimaryKey, AutoIncrement]
        public int SeatID { get; set; }
        public string VenueName { get; set; }
        public string VenuelocationName { get; set; }
        public string ContactName { get; set; }
        public string CostName { get; set; }

        [ForeignKey(typeof(RegisterTable))]
        public int RegisterCusID { get; set; }
     }

    public class BudgetTable
    {
        [PrimaryKey, AutoIncrement]
        public int BudgetID { get; set; }
        public string BudgetName { get; set; }
        public decimal BudgetAmount { get; set; }
       
        [ForeignKey(typeof(RegisterTable))]
        public int RegisterCusID { get; set; }
    }
}
