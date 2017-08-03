using System.Collections.Generic;

namespace Job.Models
{
  public class Jobs
  {
    private string _yourName;
    private string _companyName;
    private string _jobTitle;
    private string _startDate;
    private string _endDate;
    private string _jobDescription;
    private List<Jobs> jobList = new List<Jobs> ();


    public Jobs(string yourName)
    {
      _yourName = yourName;
      // _companyName = companyName;
      // _jobTitle = jobTitle;
      // _startDate = startDate;
      // _endDate = endDate;
      // _jobDescription = jobDescription;
      jobList.Add(this);
    }


    public string GetYourName()
    {
      return _yourName;
    }
    public void SetYourName(string yourName)
    {
      _yourName = yourName;
    }
    public string GetCompanyName()
    {
      return _companyName;
    }
    public void SetCompanyName(string companyName)
    {
      _companyName = companyName;
    }
    public string GetJobTitle()
    {
      return _jobTitle;
    }
    private void SetJobTitle(string jobTitle)
    {
      _jobTitle = jobTitle;
    }
    public string GetStartDate()
    {
      return _startDate;
    }
    public void SetStartDate(string startDate)
    {
      _startDate = startDate;
    }
    public string GetEndDate()
    {
      return _endDate;
    }
    public void SetEndDate(string endDate)
    {
      _endDate = endDate;
    }
    public string GetJobDescription()
    {
      return _jobDescription;
    }
    public void SetJobDesription(string jobDescription)
    {
      _jobDescription = jobDescription;
    }
    public List<Jobs> GetAllJobs()
    {
      return jobList;
    }

  }
}


//, string companyName, string jobTitle, string startDate, string endDate, string jobDescription
