using Lab5.DTO;
using ResearchLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class DTOConverter
    {
        public static ResearchDTO ConvertToResearchDTO(Research research)
        {
            return new ResearchDTO()
            {
                Customer = ConvertToCustomerDTO(research.Customer),
                SigningDate = research.SigningDate,
                Publications = research.Publications.Select(ConvertToPublicationDTO).ToList()
            };
        }

        public static PublicationDTO ConvertToPublicationDTO(Publication publication)
        {
            return new PublicationDTO()
            {
                Student = ConvertToStudentDTO(publication.Student),
                ScientificAchivment = publication.ScientificAchivments
            };
        }

        public static CustomerDTO ConvertToCustomerDTO(Customer customer)
        {
            return new CustomerDTO()
            {
                OrganizationName = customer.OrganizationName,
                ResearchTheme = customer.ResearchTheme,
                Cost = customer.Cost,
            };
        }

        public static StudentDTO ConvertToStudentDTO(Student student)
        {
            return new StudentDTO()
            {
                Name = student.Name,
                Surname = student.Surname,
                EnrollmentYear = student.EnrollmentYear,
            };
        }

        public static Research ConvertToResearch(ResearchDTO research)
        {
            return new Research()
            {
                Customer = ConvertToCustomer(research.Customer),
                SigningDate = research.SigningDate,
                Publications = research.Publications.Select(ConvertToPublication).ToList()
            };
        }

        public static Publication ConvertToPublication(PublicationDTO publication)
        {
            return new Publication()
            {
                Student = ConvertToStudent(publication.Student),
                ScientificAchivments = publication.ScientificAchivment
            };
        }

        public static Customer ConvertToCustomer(CustomerDTO customer)
        {
            return new Customer()
            {
                OrganizationName = customer.OrganizationName,
                ResearchTheme = customer.ResearchTheme,
                Cost = customer.Cost,
            };
        }

        public static Student ConvertToStudent(StudentDTO student)
        {
            return new Student()
            {
                Name = student.Name,
                Surname = student.Surname,
                EnrollmentYear = student.EnrollmentYear,
            };
        }
    }
}
