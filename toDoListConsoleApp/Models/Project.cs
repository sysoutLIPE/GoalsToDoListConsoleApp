
//I want to format the dates to yyyy-MM-dd
using System;
using static System.Convert;

namespace toDoListConsoleApp.Models.Project
{
    public class Project
    {
        private string Name { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; } 
        private bool IsCompleted { get; set; }
        private string Description { get; set; }
        private int Productivity { get; set; }
        
        private int ProjectId { get; set; }


        public string GetProjectInfo()
        {
            return $"Project name: {Name}\n" +
                   $"Start date: {StartDate}\n" +
                   $"End date: {EndDate}\n" +
                   $"Is completed: {IsCompleted}\n" +
                   $"Description: {Description}\n" +
                   $"Productivity: {Productivity}\n" +
                   $"Project id: {ProjectId}\n";
        }

        public string getName()
        {
            return Name;
        }
        
        public void setName(string name)
        {
            Name = name;
        }

        public DateTime getStartDate()
        {
            return StartDate;
        }

        public void setStartDate(DateTime startDate)
        {
            StartDate = startDate;
        }

        public DateTime getEndDate()
        {
            return EndDate;
        }

        public void setEndDate(DateTime endDate)
        {
            EndDate = endDate;
        }

        public bool getIsCompleted()
        {
            return IsCompleted;
        }

        public void setIsCompleted(bool isCompleted)
        {
            IsCompleted = isCompleted;
        }


        public string getDescription()
        {
            return Description;
        }

        public void setDescription(string description)
        {
            Description = description;
        }

        public int getProductivity()
        {
            return Productivity;
        }

        public void setProductivity(int productivity)
        {
            Productivity = productivity;
        }


        public int getProjectId()
        {
            return ProjectId;
        }

        public void setProjectId(int projectId)
        {
            ProjectId = projectId;
        }

    }
}