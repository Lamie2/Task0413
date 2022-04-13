using System;

namespace Task1304
{
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting1 = new Meeting();
            meeting1.Name = "interview1";
            meeting1.FromDate = new DateTime(2022, 01, 13);
            meeting1.ToDate = new DateTime(2022, 01, 14);

            Meeting meeting2 = new Meeting();
            meeting2.Name = "interview2";
            meeting2.FromDate = new DateTime(2022, 02, 13);
            meeting2.ToDate = new DateTime(2022, 02, 14);

            Meeting meeting3 = new Meeting();
            meeting3.Name = "interview3";
            meeting3.FromDate = new DateTime(2022, 03, 13);
            meeting3.ToDate = new DateTime(2022, 03, 14);

            MeetingSchedule meetingSchedule = new MeetingSchedule();
            meetingSchedule.AddMeetings(meeting1);
            meetingSchedule.AddMeetings(meeting2);
            meetingSchedule.AddMeetings(meeting3);


            try
            {
                Console.WriteLine("Meeting yaratmaq ucun ad daxil edin:");
                string name = Console.ReadLine();
                Console.WriteLine("Meetingin baslama tarixini daxil edin: ");
                DateTime fromDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Meetingin bitme tarixini daxil edin: ");
                DateTime toDate = Convert.ToDateTime(Console.ReadLine());

                meetingSchedule.SetMeeting(name, fromDate, toDate);

            }
            catch (ObjectAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Tarix daxil edin");
            DateTime datetime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(meetingSchedule.FindMeetingsCount(datetime)); 


            Console.WriteLine("ad daxil edin:");
            string meetingName = Console.ReadLine();
            foreach (var item in meetingSchedule.GetExistMeetings(meetingName))
            {
                Console.WriteLine($"item: {item.Name}");
            }


            Console.WriteLine("ad daxil edin:");
            string nameStr = Console.ReadLine();
            Console.WriteLine(meetingSchedule.IsExistsMeetingByName(nameStr)); 
        }
    }
}
