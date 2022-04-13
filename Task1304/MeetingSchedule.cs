using System;
using System.Collections.Generic;
using System.Text;

namespace Task1304
{
    class MeetingSchedule
    {
        List<Meeting> Meetings = new List<Meeting>();
        public void SetMeeting(string name, DateTime fromDate, DateTime toDate)
        {
            if (Meetings.Exists(d => (d.Name != name) && (d.FromDate < fromDate && d.ToDate < fromDate) || d.FromDate > toDate)) 
            {
                Meeting newMeeting = new Meeting();
                newMeeting.Name = name;
                newMeeting.FromDate = fromDate;
                newMeeting.ToDate = toDate;
                Meetings.Add(newMeeting);
                Console.WriteLine($"Name: {newMeeting.Name}  |  FromDate: {newMeeting.FromDate}  |  ToDate:  {newMeeting.ToDate}");
            }
            else
            {
                throw new ObjectAlreadyExistsException("bele bir gorus artiq movcuddur");
            }
            

        }


        public int FindMeetingsCount(DateTime datetime)
        {              
            return Meetings.FindAll(d => d.FromDate > datetime).Count;           
        }

        public bool IsExistsMeetingByName(string str)
        {
            return Meetings.Exists(d => d.Name == str);
        }

        public List<Meeting> GetExistMeetings(string name)
        {
            return Meetings.FindAll(d=>d.Name.Contains(name));
                
        }

        public void AddMeetings(Meeting meeting)
        {
            Meetings.Add(meeting);
        }

    }

}
