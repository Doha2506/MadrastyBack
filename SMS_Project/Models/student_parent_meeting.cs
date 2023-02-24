﻿using SMS_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace SMS_Project.Models
{
    public class student_parent_meeting
    {
        [Key]
        public int id { get; set; }
        public string date { get; set; }
        public string level_name { get; set; }
        public int level_id { get; set; }
        public string class_name { get; set; }
        public int class_id { get; set; }
        public int student_id { get; set; }
        public string student_name { get; set; }
        public string reason { get; set; }
        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();
        public int save_in_student_parent_meeting()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_student_parent_meeting]  
         
 '" + date + @"',
 '" + level_name + @"',
 '" + level_id + @"',
 '" + class_name + @"',
 '" + class_id + @"',
 '" + student_id + @"',
 '" + student_name + @"',
 '" + reason + @"'


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
        public DataSet get_student_parent_meeting_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_student_parent_meeting_with_id] '" + id + @"'", con_db.myCN);
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
        public DataSet get_student_parent_meeting()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_student_parent_meeting] ", con_db.myCN);
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
        public int update_student_parent_meeting()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_student_parent_meeting]  
       '" + id + @"',
 '" + date + @"',
 '" + level_name + @"',
 '" + level_id + @"',
 '" + class_name + @"',
 '" + class_id + @"',
 '" + student_id + @"',
 '" + student_name + @"',
 '" + reason + @"'


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
        public int delete_from_student_parent_meeting()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_student_parent_meeting]  
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
