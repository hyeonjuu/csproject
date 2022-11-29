using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCSProject
{
    class DBClass
    {
        private string empno; // 사원 번호
        private string admin; //관리자 여부

        private String ret;
        private String sql;

        private string connectionString;
        private string commandString;

        OracleConnection con;
        OracleDataAdapter da; // Data Provider인 DBAdapter 입니다.
        OracleCommand dcom;
        DataSet ds;// DataSet 객체입니다.
        OracleDataReader dr; //DataReader 객체입니다.
        OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다.
        DataTable phoneTable;// DataTable 객체입니다.

        public String EMPNO { get { return empno; } set { empno = value; } }
        public String ADMIN { get { return admin; } set { admin = value; } }
        public String Ret { get { return ret; } set { ret = value; } }
        public String SQL { get { return sql; } set { sql = value; } }
        public OracleCommand DCom { get { return dcom; } set { dcom = value; } }

        public String CONNECTIONSTRING { get { return connectionString; } set { connectionString = value; } }
        public String COMMANDSTRING { get { return commandString; } set { commandString = value; } }


        public OracleConnection Con { get { return con; } set { con = value; } }
        public OracleDataAdapter DA { get { return da; } set { da = value; } }
        public DataSet DS { get { return ds; } set { ds = value; } }
        public OracleDataReader DR { get { return dr; } set { dr = value; } }
        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }
        public DataTable PhoneTable { get { return phoneTable; } set { phoneTable = value; } }

        public void DB_Open()
        {
            try
            {
                connectionString = "User Id=cshyeonju; Password=dkagh; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                commandString = "select * from emp";

                DA = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DA);

                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_Access()
        {
            try
            {
                string My_con = "User Id=cshyeonju; Password=dkagh; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                Con = new OracleConnection();
                Con.ConnectionString = My_con;
                DCom = new OracleCommand();
                DCom.Connection = Con;
                Con.Open();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_ObjCreate()
        {
            PhoneTable = new DataTable();

        }


        
    }

}
