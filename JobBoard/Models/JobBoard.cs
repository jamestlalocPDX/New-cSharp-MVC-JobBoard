using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public Contact ContactInfo { get; set; }

    private static List<JobOpening> _allJobs = new List<JobOpening>() {};

    public JobOpening(string title, string description, Contact contactInfo)
    {
      Title = title;
      Description = description;
      ContactInfo = contactInfo;
      _allJobs.Add(this);
    }

    public static List<JobOpening> GetAll()
    {
      return _allJobs;
    }

  }
}