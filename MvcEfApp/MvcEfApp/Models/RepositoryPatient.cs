using Microsoft.EntityFrameworkCore;

namespace MvcEfApp.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatients()
        {
            HospitalDbContext context = new HospitalDbContext();
            var list = context.Patients.ToList();
            return list;
        }

        public static Patient GetPatientById(int id)
        {
            HospitalDbContext context = new HospitalDbContext();
            var patient = context.Patients.Find(id);
            return (patient);
        }

        public static void AddNewPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Patients.Add(patient);
            ctx.SaveChanges();
        }

        public static void ModifyPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(patient).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void RemovePatient(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Patient patient = ctx.Patients.Find(id);
            ctx.Patients.Remove(patient);
            ctx.SaveChanges();

        }
    }
}
