using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Human_fileDAO
    {
        private string zfc = "Data Source=.;Initial Catalog=HR_DB;Integrated Security=True";
        public async Task<int> TianAsync(Human_file human)
        {
            using (SqlConnection sqlConnection = new SqlConnection(zfc))
            {
                string sql = $@"insert into [dbo].[human_file](first_kind_id,first_kind_name,second_kind_id,second_kind_name,third_kind_id,third_kind_name,human_major_kind_id,human_major_kind_name
                            ,human_major_id,hunma_major_name,human_pro_designation,human_name,human_sex,human_email,human_telephone,human_qq,human_mobilephone,human_address,human_postcode
                            ,human_nationality,human_birthplace,human_birthday,human_race,human_religion,human_party,human_id_card,human_society_security_id,human_age,human_educated_degree
                            ,human_educated_years,human_educated_major,salary_standard_id,salary_standard_name,human_bank,human_account,register,regist_time,human_speciality,human_hobby
                            ,human_histroy_records,human_family_membership,remark) values('{human.first_kind_id}','{human.first_kind_name}','{human.second_kind_id}','{human.second_kind_name}',
                            '{human.third_kind_id}','{human.third_kind_name}','{human.human_major_kind_id}','{human.human_major_kind_name}'
                            ,'{human.human_major_id}','{human.hunma_major_name}','{human.human_pro_designation}','{human.human_name}','{human.human_sex}','{human.human_email}','{human.human_telephone}','{human.human_qq}'
                            ,'{human.human_mobilephone}','{human.human_address}','{human.human_postcode}'
                            ,'{human.human_nationality}','{human.human_birthplace}','{human.human_birthday}','{human.human_race}','{human.human_religion}','{human.human_party}','{human.human_id_card}','{human.human_society_security_id}','{human.human_age}','{human.human_educated_degree}'
                            ,'{human.human_educated_years}','{human.human_educated_major}','{human.salary_standard_id}','{human.salary_standard_name}','{human.human_bank}','{human.human_account}','{human.register}','{human.regist_time}','{human.human_speciality}','{human.human_hobby}'
                            ,'{human.human_histroy_records}','{human.human_family_membership}','{human.remark}')";
                return await sqlConnection.ExecuteAsync(sql);
            }
        }
    }
}
