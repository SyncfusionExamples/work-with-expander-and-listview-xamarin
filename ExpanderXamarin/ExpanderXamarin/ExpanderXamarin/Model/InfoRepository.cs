﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ExpanderXamarin.Model
{
    public class InfoRepository
    {
        #region Fields

        private Random random = new Random();

        #endregion

        #region Constructor

        public InfoRepository()
        {

        }

        #endregion

        #region GetEmployeeInfo

        internal ObservableCollection<InboxInfo> GetInboxInfo()
        {
            var inboxInfo = new ObservableCollection<InboxInfo>();
            for (int i = 0; i < Subject.Count(); i++)
            {
                var record = new InboxInfo()
                {
                    Title = Title[i],
                    Subject = Subject[i],
                    Description = Descriptions[i],
                    Date = Month[i] + " " + (i + 8).ToString(),
                };
                inboxInfo.Add(record);
            }
            return inboxInfo;
        }

        internal ObservableCollection<ToDoItem> GetToDoList()
        {
            var todoList = new ObservableCollection<ToDoItem>();
            var random = new Random();

            for (int i = 0; i < toDoLists.Count(); i++)
            {
                var todoItem = new ToDoItem()
                {
                    Name = toDoLists[i],
                };
                todoList.Add(todoItem);
            }
            return todoList;
        }
        #endregion

        #region Inbox Info

        string[] Title = new string[]
     {
            "James Landon",
            "Daniel Caden",
            "Holly Steve",
            "Jacob Oscar",
            "Fiona Michael",
            "Ralph Jennifer",
            "Nicholas Ryan",
            "Liam Connor",
            "Benjamin Alexander",
            "Brenda Kyle",
            "Liz Torrey",
            "Nathan Taylor",
            "Dominic Thomas",
            "Riley Sean",
            "Xavier Bryce"

     };

        string[] Month = new string[]
        {
            "Jan",
            "Jan",
            "Feb",
            "Mar",
            "Mar",
            "Apr",
            "May",
            "May",
            "May",
            "June",
            "July",
            "Aug",
            "Aug",
            "Sep",
            "Sep"
        };

        string[] Subject = new string[] {
            "Happy birthday to an amazing employee!",
            "Like a vintage auto, your value increases...",
            "Happy Anniversary! Happy Anniversary!",
            "We wish you an amazing year with accomplishment...",
            "No one could do a better job than...",
            "GET WELL SOON!!",
            "A cheery Christmas hold lots of happiness for you!",
            //"BOO!!! Happy Halloween! Happy Halloween!",
            //"Happy Turkey Day!!",
            //"Wishing you Happy St Pat's Day!",
            //"Congratulations on the move!",
            //"Enjoy the new greener pastures!",
            //"Happy Thanksgiving Day!",
            //"Never doubt yourself. You’re always...",
            //"The warmest wishes to a great member of our team...",
        };

        string[] Descriptions = new string[] {
            "Wishing you great achievements in this career, And I hope that you have a great day today!",
            "Happy birthday to one of the best and most loyal employees ever!",
            "Congrats! May your life continue to be filled with love, laughter and happiness.",
            "We wish you an amazing year with accomplishment of the great goals that you have set!",
            "No one could do a better job than the job you do. We thank you for sticking with us!",
            "Card messages aren't my thing. Get well soon!",
            "Wishing you a happy Christmas. May it be all that you hope it will be! All the best",
            "Wishing you a killer Halloween, Don't forget to give us treat or else..",
            "Happy Turkey Day!. Don't forget to give thanks for being so blessed.",
            "It's all green which means its all good! HAPPY ST PAT'S",
            "Congratulations! May you find great happiness at your new address.",
            "Good luck with the new job and your career aspirations. All the best",
            "May you enjoy this special day. Happy Thanksgiving to you and your whole family!",
            "Never doubt yourself. You’re always the best! Just continue to be like that!",
            "Warmest wishes! May your special day be full of good emotions, fun and cheer!"
        };

        #endregion

        #region Tasks Info

        string[] toDoLists = new string[]
     {
            "Reserve party venue",
            "Choose party attire",
            "Compile guest list",
            "Choose invitation",
            "Create wedding website",
     };
        #endregion
    }
}
