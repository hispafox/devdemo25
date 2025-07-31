using System;
using System.Collections.Generic;

namespace DevDemoEntities
{
    public class Request
    {
        public int RequestId { get; set; }
        public string? RequestType { get; set; }
        public decimal? RequestAmount { get; set; }
        public string? Description { get; set; }
        public DateTime? RequestDate { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public ICollection<RequestLog> RequestLogs { get; set; }
        public ICollection<RequestStatusLog> RequestStatusLogs { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }

    public class Status
    {
        public int StatusId { get; set; }
        public string? StatusName { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? Description { get; set; }
        public ICollection<Request> Requests { get; set; }
        public ICollection<RequestStatusLog> OldStatusLogs { get; set; }
        public ICollection<RequestStatusLog> NewStatusLogs { get; set; }
    }

    public class RequestLog
    {
        public int RequestLogId { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public DateTime? LogDate { get; set; }
        public string? Details { get; set; }
    }

    public class RequestStatusLog
    {
        public int RequestStatusLogId { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public int OldStatusId { get; set; }
        public Status OldStatus { get; set; }
        public int NewStatusId { get; set; }
        public Status NewStatus { get; set; }
        public string? Reason { get; set; }
    }

    public class TotalBudget
    {
        public int BudgetId { get; set; }
        public int? BudgetYear { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? CurrentAmount { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }

    public class Transaction
    {
        public int TransactionId { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? Amount { get; set; }
        public string? TransactionType { get; set; }
        public string? Description { get; set; }
        public int AssociatedBudgetId { get; set; }
        public TotalBudget AssociatedBudget { get; set; }
        public ICollection<TransactionsHistory> TransactionsHistories { get; set; }
    }

    public class TransactionsHistory
    {
        public int TransactionHistoryId { get; set; }
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public DateTime? LogDate { get; set; }
        public string? ActionType { get; set; }
    }
}
