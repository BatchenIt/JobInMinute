﻿using System.ComponentModel.DataAnnotations;

namespace JobInMinuteServer.Models
{
    public class CandidateJobs
    {
        [Key]
        public int CandidateID { get; set; }
        public Candidate candidate { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
