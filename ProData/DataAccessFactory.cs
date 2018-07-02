using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProData
{
    public abstract class DataAccessFactory
    {
        public static IAdminDataAccess GetAdminDataAccess()
        {
            return new AdminDataAccess(new VuesDBContext());
        }
        public static IAttendenceDataAccess GetAttendenceDataAccess()
        {
            return new AttendenceDataAccess(new VuesDBContext());
        }
        public static ICourseDataAccess GetCourseDataAccess()
        {
            return new CourseDataAccess(new VuesDBContext());
        }
        public static IFacultyDataAccess GetFacultyDataAccess()
        {
            return new FacultyDataAccess(new VuesDBContext());
        }
        public static IGradeDataAccess GetGradeDataAccess()
        {
            return new GradeDataAccess(new VuesDBContext());
        }
        public static IPreRegistartionDataAccess GetPreRegistrationDataAccess()
        {
            return new PreRegistrationDataAccess(new VuesDBContext());
        }
        public static IReportDataAccess GetReportDataAccess()
        {
            return new ReportDataAccess(new VuesDBContext());
        }
        public static ISectionDataAccess GetSectionDataAccess()
        {
            return new SectionDataAccess(new VuesDBContext());
        }
        public static IStudentDataAccess GetStudentDataAccess()
        {
            return new StudentDataAccess(new VuesDBContext());
        }
        public static IStudentSectionDataAccess GetStudentSectionDataAccess()
        {
            return new StudentSectionDataAccess(new VuesDBContext());
        }
    }
}
