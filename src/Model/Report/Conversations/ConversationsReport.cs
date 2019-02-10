﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpScoutNet.Model.Report.Conversations
{
    public class ConversationsReport
    {
        public List<Tag> FilterTags { get; set; }
        public DayStats BusiestDay { get; set; }
        public int BusyTimeStart { get; set; }
        public int BusyTimeEnd { get; set; }
        public TimeRangeStats Current { get; set; }
        public TimeRangeStats Previous { get; set; }
        public MultipleTimeRangeStats Delta { get; set; }
        public TagStats Tags { get; set; }
        public CustomerStats Customer { get; set; }
        public SavedReplyStats Replies { get; set; }
        public WorkFlowStats WorkFlows { get; set; }

        public class TimeRangeStats
        {
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public int TotalConversations { get; set; }
            public int ConversationsCreated { get; set; }
            public int NewConversations { get; set; }
            public int Customers { get; set; }
            public int ConversationsPerDay { get; set; }
        }
    }

    public class MultipleTimeRangeStats
    {
        public double NewConversations { get; set; }
        public double TotalConversations { get; set; }
        public double Customers { get; set; }
        public double ConversationsCreated { get; set; }
        public double ConversationsPerDay { get; set; }
    }

    public class TagStats
    {
        public int Count { get; set; }
        public List<TagStat> Top { get; set; }
    }

    public class TagStat
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Count { get; set; }
        public int PreviousCount { get; set; }
        public double Percent { get; set; }
        public double PreviousPercent { get; set; }
        public double DeltaPercent { get; set; }
    }

    public class CustomerStats
    {
        public int Count { get; set; }
        public List<CustomerStat> Top { get; set; }
    }

    public class CustomerStat
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public int Count { get; set; }
        public double PreviousCount { get; set; }
        public double Percent { get; set; }
        public double PreviousPercent { get; set; }
        public double DeltaPercent { get; set; }
    }

    public class SavedReplyStats
    {
        public int Count { get; set; }
        public List<SavedReplyStat> replies { get; set; }
    }

    public class SavedReplyStat
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public long MailboxID { get; set; }
        public int Count { get; set; }
        public int PreviousCount { get; set; }
        public double Percent { get; set; }
        public double PreviousPercent { get; set; }
        public double DeltaPercent { get; set; }
    }

    public class WorkFlowStats
    {
        public int Count { get; set; }
        public List<WorkFlowStat> Top { get; set; }
    }

    public class WorkFlowStat
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public int Count { get; set; }
        public int PreviousCount { get; set; }
        public double Percent { get; set; }
        public double PreviousPercent { get; set; }
        public double DeltaPercent { get; set; }
    }
}
