using Zad_6.Models;

namespace Zad_6.Configuration
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder) 
        {
            builder.HaskKey(e => e.IdDoctor).HasName("Doctor_PK");
            builder.Property(e => e.IdDoctor).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();

            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).IsUnique();

            var doctors = new List<Doctor>();

            doctors.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Marek",
                LastName = "Lewandowski",
                Email = "mklewan@gmail.com"
            });
            doctors.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Jan",
                LastName = "Nowak",
                Email = "jan_nowak12@gmail.com"
            });

            builder.HasData(doctors);
        }
    }
}
