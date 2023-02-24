﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace SMS_Project.Models
{
    public class teams_and_groups
    {
        [Key]

        public int id { get; set; }
        public int type_id { get; set; }
        public string type_name { get; set; }
        public string name { get; set; }
        public string goals { get; set; }

        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();
        public DataSet get_teams_and_groups()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_teams_and_groups]", con_db.myCN);
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
        public int save_in_teams_and_groups()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_teams_and_groups]  
  
 '" + type_id + @"',
 '" + type_name + @"',
 '" + name + @"',
 '" + goals + @"'


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
        public DataSet get_teams_and_groups_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_teams_and_groups_with_id]'" + id + @"'", con_db.myCN);
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

        public int update_teams_and_groups()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_teams_and_groups] 
 '" + id + @"',
 '" + type_id + @"',
 '" + type_name + @"',
 '" + name + @"',
 '" + goals + @"'

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
        public int delete_from_teams_and_groups()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_teams_and_groups]  
            '" + id + @"'
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