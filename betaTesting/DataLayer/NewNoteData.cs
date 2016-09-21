using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using betaTesting.FrameWork;
using System.Data;

using System.ComponentModel;

using System.Windows.Forms;


namespace betaTesting.DataLayer
{
    class NewNoteData
    {
        DataAccess _da = new DataAccess();

        public NewNoteData(string Title,string Description)
        {
            
            string insertCommand = "INSERT INTO noteTitleDescription ( Title,Description) " +
                                      "VALUES ( @Title,@Description)";
            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter nameParameter = new SqlParameter("@Title", SqlDbType.NVarChar);
            nameParameter.Value =Title;

            SqlParameter descriptionParameter = new SqlParameter("@Description", SqlDbType.NVarChar);
            descriptionParameter.Value = Description;

            command.Parameters.Add(nameParameter);
            command.Parameters.Add(descriptionParameter);
            
            _da.Execute(command);
           
        }
    }
}