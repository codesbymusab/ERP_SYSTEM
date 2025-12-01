// File: ERP_System.BL/TransactionBL.cs
using ERP_System.DL;
using ERP_System.DTO;
using System;
using System.Data;

namespace ERP_System.BL
{
    public class TransHistBL
    {
        private readonly TransHistDL dl = new TransHistDL();

       
        public int AddTransaction(TransHistDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));
            return dl.AddTransaction(dto);
        }


        public void RecordTransaction(TransHistDTO dto) => dl.AddTransaction(dto);
        public DataTable GetAllTransactions() => dl.GetAllTransactions();

        
        public DataTable GetTransactionsByType(string transactionType) =>
            dl.GetTransactionsByType(transactionType);


    }
}
