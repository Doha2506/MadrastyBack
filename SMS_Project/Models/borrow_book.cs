﻿using SMS_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SMS_project.Models
{
    public class borrow_book
    {
        [Key]

        public int borr_id { get; set; }
        public string borr_date { get; set; }
        public string lib_book_name { get; set; }
        public string borr_name { get; set; }


        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public int save_in_borrow_book()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_borrow_book]  
         

            '" + borr_date + @"',
            '" + lib_book_name + @"',
   '" + borr_name + @"'


            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;
        }
        public DataSet get_borrow_book_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_borrow_book_with_id] '" + borr_id + @"'", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            con_db.myCN.Close();
            return myDS;

        }
        public DataSet get_borrow_book()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_borrow_book] ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            con_db.myCN.Close();
            return myDS;

        }
        public int delete_from_borrow_book()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_borrow_book]  
            '" + borr_id + @"'
            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;

        }
    }
}
