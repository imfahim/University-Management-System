using ProData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProService
{
    public abstract class ServiceFactory
    {
        public static IAdminService GetAdminService()
        {
            return new AdminService(DataAccessFactory.GetAdminDataAccess());
        }
        public static IAttendenceService GetAttendenceService()
        {
            return new AttendenceService(DataAccessFactory.GetAttendenceDataAccess());
        }
        public static ICourseService GetCourseService()
        {
            return new CourseService(DataAccessFactory.GetCourseDataAccess());
        }
        public static IFacultyService GetFacultyService()
        {
            return new FacultyService(DataAccessFactory.GetFacultyDataAccess());
        }
        public static IGradeService GetGradeService()
        {
            return new GradeService(DataAccessFactory.GetGradeDataAccess());
        }
        public static IPreRegistrationService GetPreRegistrationService()
        {
            return new PreRegistrationService(DataAccessFactory.GetPreRegistrationDataAccess());
        }
        public static IReportService GetReportService()
        {
            return new ReportService(DataAccessFactory.GetReportDataAccess());
        }
        public static ISectionService GetSectionService()
        {
            return new SectionService(DataAccessFactory.GetSectionDataAccess());
        }
        public static IStudentService GetStudentService()
        {
            return new StudentService(DataAccessFactory.GetStudentDataAccess());
        }
        public static IStudentSectionService GetStudentSectionService()
        {
            return new StudentSectionService(DataAccessFactory.GetStudentSectionDataAccess());
        }
    }
}
