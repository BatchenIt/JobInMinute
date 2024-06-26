﻿using JobInMinuteServer.DAL.Interfaces;
using JobInMinuteServer.Models;
using Microsoft.EntityFrameworkCore;

namespace JobInMinuteServer.DAL
{
    public class EmployerRepository : IEmployerRepository
    {
        
        private readonly JobInMinuteDbContext _context;
        public EmployerRepository(JobInMinuteDbContext context)
        {
            _context = context;
        }

        public async Task SaveEmployer(Employer employer)
        {
            if (employer.User.isEmployer == false)
            {
                throw new InvalidOperationException("Employers cannot register as candidates.");
            }
            try
            {
                // Add the new employer to the DbSet
                _context.Employers.Add(employer);

                // Save changes to the database
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the error for debugging
                Console.WriteLine($"An error occurred while saving the employer: {ex.Message}");
                throw;
            }
        }

        public async Task<Employer> GetEmployerById(int employerId)
        {
            try
            {
                var employer = await _context.Employers.FindAsync(employerId);
                if (employer == null)
                {
                    throw new InvalidOperationException("employer not found.");
                }
                return employer;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while retrieving employer with ID {employerId}: {ex.Message}");

                throw;
            }

        }

        public async Task<bool> Exists(int employerId)
        {
            return await _context.Employers.AnyAsync(e => e.EmployerID == employerId);
        }


        public async Task<List<Job>> GetJobsByEmployerId(int employerId)
        {
            var jobsByEmployer = await _context.Jobs
                                        .Where(job => job.EmployerId == employerId)
                                        .ToListAsync();

            return jobsByEmployer ?? new List<Job>();
        }

        
    }
}
